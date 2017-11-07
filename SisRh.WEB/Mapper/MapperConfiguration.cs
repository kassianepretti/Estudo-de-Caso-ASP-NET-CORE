using AutoMapper;
using SisRh.Domain.Entities;
using SisRh.WEB.Models.ViewModels;

namespace SisRh.WEB.Mapper
{
    public class MapperConfiguration : Profile
    {
        public MapperConfiguration()
        {
            CreateMap<Empregado, EmpregadoViewModel>().ReverseMap();
            CreateMap<Setor, SetorViewModel>().ReverseMap();
        }
    }
}
