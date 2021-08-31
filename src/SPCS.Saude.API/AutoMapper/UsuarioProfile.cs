using AutoMapper;
using SPCS.Saude.API.ViewModels;
using SPCS.Saude.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPCS.Saude.API.AutoMapper
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<UsuarioViewModel, Usuario>().ReverseMap();
        }
    }
}
