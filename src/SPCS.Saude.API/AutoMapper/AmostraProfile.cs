using AutoMapper;
using SPCS.ApiModels.Amostra;
using SPCS.Saude.Business.Models;

namespace SPCS.Saude.API.AutoMapper
{
    public class AmostraProfile : Profile
    {
        public AmostraProfile()
        {
            CreateMap<AmostraApiModel, Amostra>().ReverseMap();
            CreateMap<AmostraResponseApiModel, Amostra>().ReverseMap();
            CreateMap<PacienteAmostraResponseApiModel, Amostra>().ReverseMap();
        }
    }
}
