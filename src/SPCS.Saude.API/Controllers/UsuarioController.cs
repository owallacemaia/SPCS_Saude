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

        [HttpGet("listar")]
        public async Task<ActionResult<IEnumerable<UsuarioResponseApiModel>>> TodosUsuarios()
        {
            var usuarios = _mapper.Map<IEnumerable<UsuarioResponseApiModel>>(await _usuarioRepository.ObterTodos());

            return CustomResponse(usuarios);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<UsuarioResponseApiModel>> ObterPorId(Guid id)
        {
            var usuario = await _usuarioRepository.ObterPorId(id);

            if (usuario == null || usuario.Id != id)
            {
                AdicionarErroProcessamento("Usuário não encontrado! Confirme o ID informado.");
                return CustomResponse();
            }

            dynamic response = null;

            if(usuario.TipoUsuario.Id == TipoUsuario.Enfermeiro.Id)
            {
                var enfermeiro = await _enfermeiroRepository.ObterPorId(usuario.Id);
                response = _mapper.Map<EnfermeiroResponseApiModel>(usuario);
                _mapper.Map(enfermeiro, response);
            }
            else if(usuario.TipoUsuario.Id == TipoUsuario.Medico.Id)
            {
                var medico = await _medicoRepository.ObterPorId(usuario.Id);
                response = _mapper.Map<MedicoResponseApiModel>(usuario);
                _mapper.Map(medico, response);
            }
            else if (usuario.TipoUsuario.Id == TipoUsuario.Paciente.Id)
            {
                var paciente = await _pacienteRepository.ObterPorId(usuario.Id);
                response = _mapper.Map<PacienteResponseApiModel>(usuario);
                _mapper.Map(paciente, response);
            }

            return CustomResponse(response);
        }

        [HttpGet("listar/pacientes")]
        public async Task<IEnumerable<PacienteResponseApiModel>> ObterTodosPacientes()
        {
            var pacientes = await _pacienteRepository.ObterTodos();

            var usuario = (await _usuarioRepository.ObterTodos()).Where(a => a.TipoUsuario.Id == TipoUsuario.Paciente.Id);

            var response = pacientes.Select(item =>
            {
                var paciente = _mapper.Map<PacienteResponseApiModel>(item);
                _mapper.Map(usuario.FirstOrDefault(a => a.Id == item.UsuarioId), paciente);
                return paciente;
            });

            return (response);
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
        public async Task<ActionResult<UsuarioResponseApiModel>> Cadastrar(CadastrarPacienteRequestApiModel usuarioRegistro)
        {
            if (!ModelState.IsValid)
                return CustomResponse(usuarioRegistro);

            var usuario = new Usuario(Guid.NewGuid(), usuarioRegistro.Nome, usuarioRegistro.Email, usuarioRegistro.Cpf,
                                          usuarioRegistro.Imagem, usuarioRegistro.Sexo, usuarioRegistro.DataNascimento, usuarioRegistro.Telefone,
                                          usuarioRegistro.Escolaridade, usuarioRegistro.TipoUsuarioId);

            var addUsuario = await _usuarioService.Adicionar(usuario);

            if (!addUsuario.IsValid)
            {
                AdicionarErroProcessamento("Houve um erro ao tentar cadastrar o paciente");
                return CustomResponse();
            }

            var endereco = _mapper.Map<Endereco>(usuarioRegistro.Endereco);
            var paciente = new Paciente(usuario.Id, endereco);

            var addPaciente = await _pacienteService.Adicionar(paciente);

            if (!addPaciente.IsValid)
            {
                AdicionarErroProcessamento("Houve um erro ao tentar cadastrar o paciente!");
                return CustomResponse();
            }

            return CustomResponse("Usuario cadastrado");
        }

        [HttpPost("novo/medico")]
        public async Task<IActionResult> Cadastrar(CadastrarMedicoRequestApiModel model)
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

            await AdicionarPermissoes(usuarioRegistrado, model.TipoUsuarioId);

            return CustomResponse("Usuario Cadastrado");
        }

        [HttpPost("novo/enfermeiro")]
        public async Task<IActionResult> Cadastrar(CadastrarEnfermeiroRequestApiModel model)
        {
            if (!ModelState.IsValid)
                return CustomResponse(model);

            var usuarioRegistrado = await Registrar(model);

            if (!OperacaoValida() || usuarioRegistrado == null)
                return CustomResponse();

            var enfermeiro = new Enfermeiro(Guid.Parse(usuarioRegistrado.Id), model.Coren);

            var addEnfermeiro = await _enfermeiroService.Adicionar(enfermeiro);

            if (!addEnfermeiro.IsValid)
            {
                await UserManager.DeleteAsync(usuarioRegistrado);
                _usuarioRepository.Remover(Guid.Parse(usuarioRegistrado.Id));
            }

            await AdicionarPermissoes(usuarioRegistrado, model.TipoUsuarioId);

            return CustomResponse("Usuario Cadastrado");
        }

        private async Task<IdentityUser> Registrar(CadastrarUsuarioRequestApiModel usuarioRegistro)
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
                var usuario = new Usuario(Guid.Parse(user.Id), usuarioRegistro.Nome, usuarioRegistro.Email, usuarioRegistro.Cpf,
                                          usuarioRegistro.Imagem, usuarioRegistro.Sexo, usuarioRegistro.DataNascimento, usuarioRegistro.Telefone,
                                          usuarioRegistro.Escolaridade, usuarioRegistro.TipoUsuarioId);

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
