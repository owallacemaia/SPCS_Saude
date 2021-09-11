using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SPCS.Saude.API.ViewModels;
using SPCS.Saude.Business.Interfaces;
using SPCS.Saude.Business.Models;
using SPCS.Saude.Core.Identidade;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SPCS.Saude.API.Controllers
{
    [Route("api/usuario")]
    public class UsuarioController : MainController
    {
        private readonly IPacienteService _pacienteService;
        private readonly IUsuarioService _usuarioService;
        private readonly IMedicoService _medicoService;
        private readonly IEnfermeiroService _enfermeiroService;
        public readonly SignInManager<IdentityUser> SignInManager;
        public readonly UserManager<IdentityUser> UserManager;

        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;

        public UsuarioController(IPacienteService pacienteService, IUsuarioService usuarioService, IMedicoService medicoService, IEnfermeiroService enfermeiroService, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _pacienteService = pacienteService;
            _usuarioService = usuarioService;
            _medicoService = medicoService;
            _enfermeiroService = enfermeiroService;
            SignInManager = signInManager;
            UserManager = userManager;
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }

        [HttpGet("obter-usuarios")]
        public async Task<ActionResult<IEnumerable<UsuarioViewModel>>> TodosUsuarios()
        {
            var usuarios = _mapper.Map<IEnumerable<UsuarioViewModel>>(await _usuarioRepository.ObterTodos());

            return CustomResponse(usuarios);
        }

        [HttpGet("buscar/{id:guid}")]
        public async Task<ActionResult<UsuarioViewModel>> ObterPorId(Guid id)
        {
            var usuario = await _usuarioRepository.ObterPorId(id);

            if(usuario == null && usuario.Id !=  id)
            {
                AdicionarErroProcessamento("Usuário não encontrado! Confirme o ID informado.");
                return CustomResponse();
            }

            return CustomResponse(_mapper.Map<UsuarioViewModel>(usuario));
        }

        [HttpGet("buscar/{cpf}")]
        public async Task<ActionResult<UsuarioViewModel>> ObterPorCpf(string cpf)
        {
            var usuario = await _usuarioRepository.ObterPorCpf(cpf);

            if (usuario == null || usuario.Cpf != cpf)
            {
                AdicionarErroProcessamento("Usuário não encontrado! Confirme o ID informado.");
                return CustomResponse();
            }

            return CustomResponse(_mapper.Map<UsuarioViewModel>(usuario));
        }

        [HttpPost("novo/paciente")]
        public async Task<ActionResult<UsuarioViewModel>> Cadastrar(PacienteViewModel model)
        {
            if (!ModelState.IsValid)
                return CustomResponse(model);

            var usuarioRegistrado = await Registrar(model);

            if (!OperacaoValida())
                return CustomResponse();

            var paciente = new Paciente(Guid.Parse(usuarioRegistrado.Id));

            var addPaciente = await _pacienteService.Adicionar(paciente);
            
            if(!addPaciente.IsValid)
            {
                await UserManager.DeleteAsync(usuarioRegistrado);
                _usuarioRepository.Remover(Guid.Parse(usuarioRegistrado.Id));
            }

            return CustomResponse("Usuario cadastrado");
        }

        [HttpPost("novo/medico")]
        public async Task<ActionResult<UsuarioViewModel>> Cadastrar(MedicoViewModel model)
        {
            if (!ModelState.IsValid)
                return CustomResponse(model);

            var usuarioRegistrado = await Registrar(model);

            if (!OperacaoValida())
                return CustomResponse();

            var medico = new Medico(Guid.Parse(usuarioRegistrado.Id), model.Crm);

            var addMedico = await _medicoService.Adicionar(medico);

            if (!addMedico.IsValid)
            {
                await UserManager.DeleteAsync(usuarioRegistrado);
                _usuarioRepository.Remover(Guid.Parse(usuarioRegistrado.Id));
            }

            return CustomResponse("Usuario Cadastrado");
        }

        [HttpPost("novo/enfermeiro")]
        public async Task<ActionResult<UsuarioViewModel>> Cadastrar(EnfermeiroViewModel model)
        {
            if (!ModelState.IsValid)
                return CustomResponse(model);

            var usuarioRegistrado = await Registrar(model);

            if (!OperacaoValida())
                return CustomResponse();

            var enfermeiro = new Enfermeiro(Guid.Parse(usuarioRegistrado.Id), model.Coren);

            var addEnfermeiro = await _enfermeiroService.Adicionar(enfermeiro);

            if (!addEnfermeiro.IsValid)
            {
                await UserManager.DeleteAsync(usuarioRegistrado);
                _usuarioRepository.Remover(Guid.Parse(usuarioRegistrado.Id));
            }

            return CustomResponse("Usuario Cadastrado");
        }

        private async Task<IdentityUser> Registrar(UsuarioViewModel usuarioRegistro)
        {
            var user = new IdentityUser
            {
                UserName = usuarioRegistro.Email,
                Email = usuarioRegistro.Email,
                EmailConfirmed = true
            };

            var result = await UserManager.CreateAsync(user, usuarioRegistro.Senha);
            if (result.Succeeded)
            {
                var usuario = new Usuario(Guid.Parse(user.Id), usuarioRegistro.Nome, usuarioRegistro.Email, usuarioRegistro.Cpf, usuarioRegistro.TipoUsuario.Id);

                var addUsuario = await _usuarioService.Adicionar(usuario);

                if (!addUsuario.IsValid)
                    await UserManager.DeleteAsync(user);
                else
                    return user;
            }
            
            foreach (var error in result.Errors)
            {
                AdicionarErroProcessamento(error.Description);
            }

            return null;
        }

    }
}
