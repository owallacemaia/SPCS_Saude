using AutoMapper;
using SPCS.ApiModels.Usuario;
using SPCS.Saude.Business.Models;

namespace SPCS.Saude.API.AutoMapper
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CadastrarUsuarioRequestApiModel, Usuario>().ReverseMap();
            CreateMap<CadastrarEnderecoRequestApiModel, Endereco>().ReverseMap();
            CreateMap<UsuarioResponseApiModel, Usuario>().ReverseMap();
            CreateMap<PacienteResponseApiModel, Paciente>().ReverseMap();
            CreateMap<PacienteResponseApiModel, Usuario>().ReverseMap();
            CreateMap<EnderecoResponseApiModel, Endereco>().ReverseMap();
        }
    }
}
