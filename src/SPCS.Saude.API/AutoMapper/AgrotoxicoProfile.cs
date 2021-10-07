using AutoMapper;
using SPCS.ApiModels.Agrotoxico;
using SPCS.Saude.Business.Models;

namespace SPCS.Saude.API.AutoMapper
{
    public class AgrotoxicoProfile : Profile
    {
        public AgrotoxicoProfile()
        {
            CreateMap<CadastrarAgrotoxicoRequestApiModel, Agrotoxico>().ReverseMap();
            CreateMap<AgrotoxicoResponseApiModel, Agrotoxico>().ReverseMap();
        }
    }
}
