using Api.Dtos;
using AutoMapper;
using core.Entitys;

namespace Api.Helpers
{
    public class ProductUrlResolver : IValueResolver<Product, ProductToReturnDto, string>
    {
        private readonly IConfiguration _Config;

        public ProductUrlResolver(IConfiguration config)
        {
            _Config = config;
        }

        public string Resolve(Product source, ProductToReturnDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.Image))
            {
                return _Config["ApiUrl"] + source.Image;
            };
            return null;
        }
    }
}
