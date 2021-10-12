using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SPCS.ApiModels.Usuario;
using SPCS.Saude.API.Data;
using SPCS.Saude.Business.Interfaces;
using SPCS.Saude.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
        private readonly IPacienteRepository _pacienteRepository;
        private readonly IMedicoRepository _medicoRepository;
        private readonly IEnfermeiroRepository _enfermeiroRepository;
        private readonly IMapper _mapper;

        public UsuarioController(IPacienteService pacienteService, IUsuarioService usuarioService, IMedicoService medicoService, IEnfermeiroService enfermeiroService, 
                                 SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, IUsuarioRepository usuarioRepository, IPacienteRepository pacienteRepository, 
                                 IMedicoRepository medicoRepository, IEnfermeiroRepository enfermeiroRepository, IMapper mapper)
        {
            _pacienteService = pacienteService;
            _usuarioService = usuarioService;
            _medicoService = medicoService;
            _enfermeiroService = enfermeiroService;
            SignInManager = signInManager;
            UserManager = userManager;
            _usuarioRepository = usuarioRepository;
            _pacienteRepository = pacienteRepository;
            _medicoRepository = medicoRepository;
            _enfermeiroRepository = enfermeiroRepository;
            _mapper = mapper;
        }

        [HttpGet("{tipoUsuarioId:guid}/{id:guid}")]
        public async Task<ActionResult<dynamic>> ObterPorId(Guid tipoUsuarioId, Guid id)
        {
            if (tipoUsuarioId == TipoUsuario.Enfermeiro.Id)
            {
                var enfermeiro = await _enfermeiroRepository.ObterPorId(id);

                if(enfermeiro == null || enfermeiro.Id != id)
                {
                    AdicionarErroProcessamento("Não foi encontrado o enfermeiro com o ID informado!");
                    return CustomResponse(enfermeiro);
                }

                return CustomResponse(_mapper.Map<EnfermeiroResponseApiModel>(enfermeiro));
            }
            else if (tipoUsuarioId == TipoUsuario.Medico.Id)
            {
                var medico = await _medicoRepository.ObterPorId(id);

                if (medico == null || medico.Id != id)
                {
                    AdicionarErroProcessamento("Não foi encontrado o medico com o ID informado!");
                    return CustomResponse(medico);
                }

                return CustomResponse(_mapper.Map<MedicoResponseApiModel>(medico));
            }
            else if (tipoUsuarioId == TipoUsuario.Paciente.Id)
            {

                var paciente = await _pacienteRepository.ObterPorId(id);

                if (paciente == null || paciente.Id != id)
                {
                    AdicionarErroProcessamento("Não foi encontrado o medico com o ID informado!");
                    return CustomResponse(paciente);
                }

                return CustomResponse(_mapper.Map<PacienteResponseApiModel>(paciente));
            }

            AdicionarErroProcessamento("Não foi encontrado o tipo de usuario informado");

            return CustomResponse();
        }

        [HttpGet("listar/todos/{tipoUsuarioId:guid}")]
        public async Task<ActionResult<IEnumerable<dynamic>>> ListarTodos(Guid tipoUsuarioId)
        {
            if (tipoUsuarioId == TipoUsuario.Enfermeiro.Id)
                return CustomResponse(_mapper.Map<IEnumerable<EnfermeiroResponseApiModel>>(await _enfermeiroRepository.ObterTodos()));
            else if (tipoUsuarioId == TipoUsuario.Medico.Id)
                return CustomResponse(_mapper.Map<IEnumerable<MedicoResponseApiModel>>(await _medicoRepository.ObterTodos()));
            else if (tipoUsuarioId == TipoUsuario.Paciente.Id)
                return CustomResponse(_mapper.Map<IEnumerable<PacienteResponseApiModel>>(await _pacienteRepository.ObterTodos()));

            AdicionarErroProcessamento("Não foi encontrado o tipo de usuario informado");

            return CustomResponse();
        }

        [HttpGet("buscar/{cpf}")]
        public async Task<ActionResult<UsuarioResponseApiModel>> ObterPorCpf(string cpf)
        {
            var usuario = await _usuarioRepository.ObterPorCpf(cpf);

            if (usuario == null || usuario.Cpf != cpf)
            {
                AdicionarErroProcessamento("Usuário não encontrado! Confirme o ID informado.");
                return CustomResponse();
            }

            return CustomResponse(_mapper.Map<UsuarioResponseApiModel>(usuario));
        }

        [HttpPost("novo/paciente")]
        public async Task<ActionResult<PacienteResponseApiModel>> Cadastrar(CadastrarPacienteRequestApiModel usuarioRegistro)
        {
            if (!ModelState.IsValid)
                return CustomResponse(usuarioRegistro);

            var endereco = _mapper.Map<Endereco>(usuarioRegistro.Endereco);

            var paciente = new Paciente(usuarioRegistro.Nome, usuarioRegistro.Cpf,
                                          usuarioRegistro.Imagem, usuarioRegistro.Sexo, usuarioRegistro.DataNascimento, usuarioRegistro.Telefone,
                                          usuarioRegistro.Escolaridade, endereco, usuarioRegistro.TipoUsuarioId);

            await _pacienteService.Adicionar(paciente);

            if (!OperacaoValida())
            {
                AdicionarErroProcessamento("Houve um erro ao tentar cadastrar o paciente");
                return CustomResponse();
            }

            return CustomResponse(_mapper.Map<PacienteResponseApiModel>(paciente));
        }

        [HttpPost("novo/medico")]
        public async Task<ActionResult<MedicoResponseApiModel>> Cadastrar(CadastrarMedicoRequestApiModel model)
        {
            if (!ModelState.IsValid)
                return CustomResponse(model);

            var user = new IdentityUser
            {
                UserName = model.Email,
                Email = model.Email,
                EmailConfirmed = true
            };

            var result = await UserManager.CreateAsync(user, model.Senha);
            if (result.Succeeded)
            {
                var medicouser = new Medico(Guid.Parse(user.Id), model.Nome, model.Email, model.Cpf,
                                          model.Imagem, model.Sexo, model.DataNascimento, model.Telefone,
                                          model.Crm, model.TipoUsuarioId);

                var registroMedico = await _medicoService.Adicionar(medicouser);

                if (!registroMedico.IsValid)
                {
                    await UserManager.DeleteAsync(user);
                    return CustomResponse();
                }
                    
                await AdicionarPermissoes(user, model.TipoUsuarioId);

                return CustomResponse(_mapper.Map<MedicoResponseApiModel>(medicouser));
            }

            foreach (var error in result.Errors)
            {
                AdicionarErroProcessamento(error.Description);
            }

            return CustomResponse();
        }

        [HttpPost("novo/enfermeiro")]
        public async Task<ActionResult<EnfermeiroResponseApiModel>> Cadastrar(CadastrarEnfermeiroRequestApiModel model)
        {
            if (!ModelState.IsValid)
                return CustomResponse(model);

            var user = new IdentityUser
            {
                UserName = model.Email,
                Email = model.Email,
                EmailConfirmed = true
            };

            var result = await UserManager.CreateAsync(user, model.Senha);
            if (result.Succeeded)
            {
                var enfermeirouser = new Enfermeiro(Guid.Parse(user.Id), model.Nome, model.Email, model.Cpf,
                                          model.Imagem, model.Sexo, model.DataNascimento, model.Telefone,
                                          model.Coren, model.TipoUsuarioId);

                var registroEnfermeiro = await _enfermeiroService.Adicionar(enfermeirouser);

                if (!registroEnfermeiro.IsValid)
                {
                    await UserManager.DeleteAsync(user);
                    return CustomResponse(registroEnfermeiro);
                }

                await AdicionarPermissoes(user, model.TipoUsuarioId);

                return CustomResponse(_mapper.Map<EnfermeiroResponseApiModel>(enfermeirouser));
            }

            foreach (var error in result.Errors)
            {
                AdicionarErroProcessamento(error.Description);
            }

            return CustomResponse();
        }

        private async Task AdicionarPermissoes(IdentityUser user, TipoUsuario tipoUsuario)
        {
            string permissoes = null;
            switch (tipoUsuario.Descricao)
            {
                case "Medico":
                    {
                        permissoes = "Criar, Visualizar, Alterar, Excluir";
                        break;
                    }
                case "Enfermeiro":
                    {
                        permissoes = "Criar, Visualizar, Alterar";
                        break;
                    }
            }

            await UserManager.AddClaimAsync(user, new Claim(tipoUsuario.Descricao, permissoes));
        }
    }
}
