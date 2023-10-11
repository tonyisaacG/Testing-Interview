using Api.Dtos;
using core.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public static class ProductDataSet
    {
        public static List<ProductToReturnDto> ProductDtoList()
        {
            var products = new List<ProductToReturnDto>
                {
                    new ProductToReturnDto
                    {
                        Name = "Product 1",
                        Image = "image1.jpg",
                        Category = "Category A",
                        Price = 10.50m,
                        MinQuantity = 5,
                        DiscountRate = 0.1m,
                        ProductCode = "P001"
                    },
                };
            return products;
        }
        public static List<Product> ProductList()
        {
            var products = new List<Product>
                {
                  
                    new Product
                    {
                        Name = "Product 2",
                        Image = "image2.jpg",
                        Category = "Category B",
                        Price = 20.75m,
                        MinQuantity = 10,
                        DiscountRate = 0.15m,
                        ProductCode = "P002"
                    }
                };
            return products;
        }
    }
}
