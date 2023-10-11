using core.Entitys;
using infrastructure.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context)
        {
            if (!context.Products.Any())

            {
                var productsData = File.ReadAllText("../infrastructure/Data/SeedData/products.json");
                var products = JsonSerializer.Deserialize<List<Product>>(productsData);
                context.Products.AddRange(products);
            }
            //if (!context.users.Any())
            //{
            //    var typesData = File.ReadAllText("../infrastructure/Data/SeedData/types.json");
            //    var users = JsonSerializer.Deserialize<List<User>>(typesData);
            //    context.users.AddRange(users);
            //}
           



            if (context.ChangeTracker.HasChanges()) await context.SaveChangesAsync();
        }
    }
}
