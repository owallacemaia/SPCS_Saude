using AutoMapper;
using SPCS.ApiModels.Ficha;
using SPCS.ApiModels.Usuario;
using SPCS.Saude.Business.Models;

namespace SPCS.Saude.API.AutoMapper
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            //Usuario
            CreateMap<CadastrarUsuarioRequestApiModel, Usuario>().ReverseMap();
            CreateMap<CadastrarEnderecoRequestApiModel, Endereco>().ReverseMap();
            CreateMap<UsuarioResponseApiModel, Usuario>().ReverseMap();
            
            //Paciente
            CreateMap<PacienteResponseApiModel, Paciente>().ReverseMap();
            CreateMap<PacienteResponseApiModel, Usuario>().ReverseMap();
            CreateMap<EnderecoResponseApiModel, Endereco>().ReverseMap();
            CreateMap<UsuarioFichaRequestApiModel, Paciente>().ReverseMap();
        }
    }
}
