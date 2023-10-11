using Api.Dtos;
using AutoMapper;
using core.Entitys;
using core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IGenericReposatory<Product> _productRepo;
        private readonly IMapper _mapper;

        public ProductController(IGenericReposatory<Product> productRepo, IMapper mapper)
        {
            _productRepo = productRepo;
            _mapper = mapper;
        }



        //[HttpPost]

        //public async Task<IActionResult> CreateProduct(ProductToReturnDto Dto)
        //{
        //    //var product = new Product
        //    //{
        //    //    Name = Dto.Name,
        //    //    Price = Dto.Price,
        //    //    Image = Dto.Image,
        //    //    MinQuantity = Dto.MinQuantity,
        //    //    DiscountRate = Dto.DiscountRate,
        //    //    ProductCode = Dto.ProductCode,
        //    //};
        //    //await _context.Products.AddAsync(product);
        //    //    _context.SaveChangesAsync();
        //    //return Ok(product);
        //}

        [HttpGet]

        public async Task<ActionResult<List<ProductToReturnDto>>> GetAllProduct()
        {
            var products = await _productRepo.ListAllAsync();
            return Ok(_mapper.Map<IReadOnlyList<Product>, IReadOnlyList<ProductToReturnDto>>(products));


        }
    }
}


