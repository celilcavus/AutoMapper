using AutoMapper;
using AutoMapperMvc.Dto;
using AutoMapperMvc.Entites;

namespace AutoMapperMvc.Mapping
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}