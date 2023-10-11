using Api.Dtos;
using AutoMapper;
using core.Entitys;

namespace Api.Helpers
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
               
                .ForMember(d => d.Image, o => o.MapFrom<ProductUrlResolver>()
                );
            
        }
    }
}
