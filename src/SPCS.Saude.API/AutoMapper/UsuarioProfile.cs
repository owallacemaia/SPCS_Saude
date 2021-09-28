using AutoMapper;
using SPCS.Saude.API.ViewModels;
using SPCS.Saude.Business.Models;

namespace SPCS.Saude.API.AutoMapper
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<UsuarioViewModel, Usuario>().ReverseMap();
            CreateMap<EnderecoViewModel, Endereco>().ReverseMap();
        }
    }
}
