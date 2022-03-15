using AutoMapper;
using Hamazon_DataAccess;
using Hamazon_Models;

namespace Hamazon_Business.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Person, PersonDTO>().ReverseMap(); // .ReverseMap() is the same as -> CreateMap<PersonDTO, Person>();
        }
    }
}
