using Api.Controllers;
using Api.Dtos;
using AutoMapper;
using core.Entitys;
using core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Testing
{
    public class ProductControllerTests
    {
        private readonly Mock<IGenericReposatory<Product>> _mockProductRepo = new Mock<IGenericReposatory<Product>>();
        private readonly Mock<IMapper> _mockMapper = new Mock<IMapper>();

        private readonly ProductController _productController;

        public ProductControllerTests()
        {
            _productController = new ProductController(_mockProductRepo.Object, _mockMapper.Object);
        }

        [Fact]
        public async Task GetAllProduct_ReturnsListOfProducts()
        {
            // Arrange
            var products = ProductDataSet.ProductList();
            var productToReturnDtos = ProductDataSet.ProductDtoList();

            _mockProductRepo.Setup(repo => repo.ListAllAsync()).ReturnsAsync(products);
            _mockMapper.Setup(mapper => mapper.Map<IReadOnlyList<Product>, IReadOnlyList<ProductToReturnDto>>(It.IsAny<IReadOnlyList<Product>>()))
            .Returns(productToReturnDtos);

            // Act
            var result = await _productController.GetAllProduct();

            // Assert
            var okObjectResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnProducts = Assert.IsType<List<ProductToReturnDto>>(okObjectResult.Value);

            Assert.Equal(products.Count, returnProducts.Count);
        }

        [Fact]
        public async Task GetAllProduct_Notcontent()
        {
            // Arrange
            var products = ProductDataSet.ProductList();
            var productToReturnDtos = new List<ProductToReturnDto>();

            _mockProductRepo.Setup(repo => repo.ListAllAsync()).ReturnsAsync(products);
            _mockMapper.Setup(mapper => mapper.Map<IReadOnlyList<Product>, IReadOnlyList<ProductToReturnDto>>(It.IsAny<IReadOnlyList<Product>>()))
            .Returns(productToReturnDtos);

            // Act
            var result = await _productController.GetAllProduct();

            // Assert
            Assert.IsType<NoContentResult>(result.Result);

        }
    }
}