using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SPCS.ApiModels.Usuario;
using SPCS.Saude.API.Data;
using SPCS.Saude.Business.Interfaces;
using SPCS.Saude.Business.Models;
using SPCS.Saude.Core.Identidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SPCS.Saude.API.Controllers
{
    [Authorize]
    [Route("api/usuario")]
    public class UsuarioController : MainController
    {
        private const string TipoAuthozire = "Usuarios";
        private const string Permissoes = "Criar Enfermeiro, Criar Paciente, Criar Medico, Visualizar, Alterar, Desativar";
        private readonly IPacienteService _pacienteService;
        private readonly IUsuarioService _usuarioService;
        public readonly SignInManager<IdentityUser> SignInManager;
        public readonly UserManager<IdentityUser> UserManager;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IPacienteRepository _pacienteRepository;
        private readonly IMapper _mapper;

        public UsuarioController(IPacienteService pacienteService, IUsuarioService usuarioService, SignInManager<IdentityUser> signInManager,
                                 UserManager<IdentityUser> userManager, IUsuarioRepository usuarioRepository, IPacienteRepository pacienteRepository, IMapper mapper)
        {
            _pacienteService = pacienteService;
            _usuarioService = usuarioService;
            SignInManager = signInManager;
            UserManager = userManager;
            _usuarioRepository = usuarioRepository;
            _pacienteRepository = pacienteRepository;
            _mapper = mapper;
        }

        [ClaimsAuthorize(TipoAuthozire, Permissoes)]
        [HttpGet("{tipoUsuarioId:guid}/{id:guid}")]
        public async Task<ActionResult<dynamic>> ObterPorId(Guid tipoUsuarioId, Guid id)
        {
            if (tipoUsuarioId == TipoUsuario.Enfermeiro.Id)
            {
                var enfermeiro = await _usuarioRepository.ObterPorId(id);

                if (enfermeiro == null || enfermeiro.Id != id)
                {
                    AdicionarErroProcessamento("Não foi encontrado o enfermeiro com o ID informado!");
                    return CustomResponse(enfermeiro);
                }

                return CustomResponse(_mapper.Map<UsuarioResponseApiModel>(enfermeiro));
            }
            else if (tipoUsuarioId == TipoUsuario.Medico.Id)
            {
                var medico = await _usuarioRepository.ObterPorId(id);

                if (medico == null || medico.Id != id)
                {
                    AdicionarErroProcessamento("Não foi encontrado o medico com o ID informado!");
                    return CustomResponse(medico);
                }

                return CustomResponse(_mapper.Map<UsuarioResponseApiModel>(medico));
            }
            else
            {
                var paciente = await _pacienteRepository.ObterPorId(id);

                if (paciente == null || paciente.Id != id)
                {
                    AdicionarErroProcessamento("Não foi encontrado o medico com o ID informado!");
                    return CustomResponse(paciente);
                }

                return CustomResponse(_mapper.Map<PacienteResponseApiModel>(paciente));
            }
        }

        [ClaimsAuthorize(TipoAuthozire, Permissoes)]
        [HttpGet("listar/todos/{tipoUsuarioId:guid}")]
        public async Task<ActionResult<IEnumerable<dynamic>>> ListarTodos(Guid tipoUsuarioId)
        {
            if (tipoUsuarioId == TipoUsuario.Enfermeiro.Id)
                return CustomResponse(_mapper.Map<IEnumerable<UsuarioResponseApiModel>>(await _usuarioRepository.ObterEnfermeiros()));
            else if (tipoUsuarioId == TipoUsuario.Medico.Id)
                return CustomResponse(_mapper.Map<IEnumerable<UsuarioResponseApiModel>>(await _usuarioRepository.ObterMedicos()));
            else
                return CustomResponse(_mapper.Map<IEnumerable<PacienteResponseApiModel>>(await _pacienteRepository.ObterTodos()));
        }

        [ClaimsAuthorize(TipoAuthozire, Permissoes)]
        [HttpGet("{tipoUsuarioId:guid}/{cpf}")]
        public async Task<ActionResult<PacienteResponseApiModel>> ObterPacientePorCpf(Guid tipoUsuarioId, string cpf)
        {
            if (tipoUsuarioId == TipoUsuario.Enfermeiro.Id)
            {
                var enfermeiro = await _usuarioRepository.ObterPorCpf(cpf);

                if (enfermeiro == null || enfermeiro.Cpf != cpf)
                {
                    AdicionarErroProcessamento("Não foi encontrado o enfermeiro com o cpf informado!");
                    return CustomResponse(enfermeiro);
                }

                return CustomResponse(_mapper.Map<UsuarioResponseApiModel>(enfermeiro));
            }
            else if (tipoUsuarioId == TipoUsuario.Medico.Id)
            {
                var medico = await _usuarioRepository.ObterPorCpf(cpf);

                if (medico == null || medico.Cpf != cpf)
                {
                    AdicionarErroProcessamento("Não foi encontrado o medico com o cpf informado!");
                    return CustomResponse(medico);
                }

                return CustomResponse(_mapper.Map<UsuarioResponseApiModel>(medico));
            }
            else
            {
                var paciente = await _pacienteRepository.ObterPorCpf(cpf);

                if (paciente == null || paciente.Cpf != cpf)
                {
                    AdicionarErroProcessamento("Não foi encontrado o medico com o ID informado!");
                    return CustomResponse(paciente);
                }

                return CustomResponse(_mapper.Map<PacienteResponseApiModel>(paciente));
            }
        }

        [ClaimsAuthorize(TipoAuthozire, Permissoes)]
        [HttpPost("novo/paciente")]
        public async Task<ActionResult<UsuarioResponseApiModel>> CadastrarPaciente(CadastrarPacienteRequestApiModel usuarioRegistro)
        {
            if (!ModelState.IsValid)
                return CustomResponse(usuarioRegistro);

            var endereco = _mapper.Map<Endereco>(usuarioRegistro.Endereco);

            var paciente = new Paciente(usuarioRegistro.Nome, usuarioRegistro.Cpf,
                                          usuarioRegistro.Imagem, usuarioRegistro.Sexo, usuarioRegistro.DataNascimento, usuarioRegistro.Telefone,
                                          usuarioRegistro.Escolaridade, endereco);

            var cadastro = await _pacienteService.Adicionar(paciente);

            if (!cadastro.IsValid)
            {
                return CustomResponse(cadastro);
            }

            return CustomResponse(_mapper.Map<PacienteResponseApiModel>(paciente));
        }

        [ClaimsAuthorize(TipoAuthozire, Permissoes)]
        [HttpPost("novo/medico")]
        public async Task<ActionResult<UsuarioResponseApiModel>> CadastrarMedico(CadastrarUsuarioRequestApiModel model)
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
                var medicouser = new Usuario(Guid.Parse(user.Id), model.Nome, model.Email, model.Cpf,
                                                        model.Sexo, model.DataNascimento, model.Telefone, model.TipoUsuarioId);

                var registroMedico = await _usuarioService.Adicionar(medicouser);

                if (!registroMedico.IsValid)
                {
                    await UserManager.DeleteAsync(user);
                    return CustomResponse();
                }

                await AdicionarPermissoes(user, model.TipoUsuarioId);

                return CustomResponse(_mapper.Map<UsuarioResponseApiModel>(medicouser));
            }

            foreach (var error in result.Errors)
            {
                AdicionarErroProcessamento(error.Description);
            }

            return CustomResponse();
        }

        [ClaimsAuthorize(TipoAuthozire, Permissoes)]
        [HttpPost("novo/enfermeiro")]
        public async Task<ActionResult<UsuarioResponseApiModel>> CadastrarEnfermeiro(CadastrarUsuarioRequestApiModel model)
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
                var enfermeirouser = new Usuario(Guid.Parse(user.Id), model.Nome, model.Email, model.Cpf,
                                                 model.Sexo, model.DataNascimento, model.Telefone, model.TipoUsuarioId);

                var registroEnfermeiro = await _usuarioService.Adicionar(enfermeirouser);

                if (!registroEnfermeiro.IsValid)
                {
                    await UserManager.DeleteAsync(user);
                    return CustomResponse(registroEnfermeiro);
                }

                await AdicionarPermissoes(user, model.TipoUsuarioId);

                return CustomResponse(_mapper.Map<UsuarioResponseApiModel>(enfermeirouser));
            }

            foreach (var error in result.Errors)
            {
                AdicionarErroProcessamento(error.Description);
            }

            return CustomResponse();
        }

        [ClaimsAuthorize(TipoAuthozire, Permissoes)]
        [HttpPut("atualizar/desativar/{id:guid}")]
        public async Task<IActionResult> AtualizarUsuario(Guid id)
        {
            var usuario = await _usuarioRepository.ObterPorId(id);

            if (usuario == null || usuario.Id != id)
            {
                AdicionarErroProcessamento("Não foi possível encontrar o usuário com o ID informado!");
                return CustomResponse(usuario);
            }

            usuario.Ativo = false;

            await _usuarioService.Atualizar(usuario);

            return CustomResponse();
        }

        private async Task AdicionarPermissoes(IdentityUser user, TipoUsuario tipoUsuario)
        {
            switch (tipoUsuario.Descricao)
            {
                
                case "Medico":
                    {
                        var tipoPermissao = "Usuarios";
                        var permissoes = "Criar Enfermeiro, Criar Paciente, Criar Medico, Visualizar, Alterar, Desativar";

                        await UserManager.AddClaimAsync(user, new Claim(tipoPermissao, permissoes));

                        tipoPermissao = "Agrotoxicos";
                        permissoes = "Criar, Visualizar, Alterar, Excluir";

                        await UserManager.AddClaimAsync(user, new Claim(tipoPermissao, permissoes));

                        tipoPermissao = "Fichas";
                        permissoes = "Criar, Visualizar, Alterar";

                        await UserManager.AddClaimAsync(user, new Claim(tipoPermissao, permissoes));
                        break;
                    }
                case "Enfermeiro":
                    {
                        var tipoPermissao = "Usuarios";
                        var permissoes = "Criar Paciente, Visualizar, Alterar, Desativar";

                        await UserManager.AddClaimAsync(user, new Claim(tipoPermissao, permissoes));

                        tipoPermissao = "Agrotoxicos";
                        permissoes = "Criar, Visualizar, Alterar, Desativar";

                        await UserManager.AddClaimAsync(user, new Claim(tipoPermissao, permissoes));

                        tipoPermissao = "Fichas";
                        permissoes = "Criar, Visualizar, Alterar";

                        await UserManager.AddClaimAsync(user, new Claim(tipoPermissao, permissoes));
                        break;
                    }
            }
        }
    }
}
