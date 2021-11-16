using AutoMapper;
using SPCS.ApiModels.Ficha;
using SPCS.Saude.Business.Models;

namespace SPCS.Saude.API.AutoMapper
{
    public class FichaProfile : Profile
    {
        public FichaProfile()
        {
            CreateMap<CadastrarFichaRequestApiModel, Ficha>().ReverseMap();
            CreateMap<FichaResponseApiModel, Ficha>().ReverseMap();
            CreateMap<FichaAgro, FichaAgroApiModel>().ReverseMap();
            CreateMap<Paciente, UsuarioFichaRequestApiModel>().ReverseMap();
            CreateMap<Ficha, FichasUsuarioApiModel>().ReverseMap();
        }
    }
}
