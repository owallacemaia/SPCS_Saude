using AutoMapper;
using SPCS.Saude.API.ViewModels;
using SPCS.Saude.Business.Models;

namespace SPCS.Saude.API.AutoMapper
{
    public class FichaProfile : Profile
    {
        public FichaProfile()
        {
            CreateMap<Ficha, FichaViewModel>().ReverseMap();
        }
    }
}
