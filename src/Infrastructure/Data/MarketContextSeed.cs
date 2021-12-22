using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class MarketContextSeed
    {
        public async Task SeedAsync(MarketContext db)
        {
            var phone = new Category() { Name = "Phone" };
            var monitor = new Category() { Name = "Monitor" };
            var tablet = new Category() { Name = "Tablet" };
            db.AddRange(phone, monitor, tablet);
            await db.SaveChangesAsync();

            var lg = new Brand() { Name = "LG" };
            var samsung = new Brand() { Name = "Samsung" };
            var apple = new Brand() { Name = "Apple" };
            var huawei = new Brand() { Name = "Huawie" };
            db.AddRange(lg, samsung, apple, huawei);
            await db.SaveChangesAsync();

            Product[] products =
            {

             new Product() { Name = "", Price = 0m, PictureUri = "1.jpg", Brand = lg, Category = tablet },
             new Product() { Name = "", Price = 0m, PictureUri = "2.jpg", Brand = lg, Category = tablet },
             new Product() { Name = "", Price = 0m, PictureUri = "3.jpg", Brand = lg, Category = tablet },
             new Product() { Name = "", Price = 0m, PictureUri = "4.jpg", Brand = lg, Category = tablet },
             new Product() { Name = "", Price = 0m, PictureUri = "5.jpg", Brand = lg, Category = tablet },
             new Product() { Name = "", Price = 0m, PictureUri = "6.jpg", Brand = lg, Category = tablet },
             new Product() { Name = "", Price = 0m, PictureUri = "7.jpg", Brand = lg, Category = tablet },
             new Product() { Name = "", Price = 0m, PictureUri = "8.jpg", Brand = lg, Category = tablet },
             new Product() { Name = "", Price = 0m, PictureUri = "9.jpg", Brand = lg, Category = tablet },
             new Product() { Name = "", Price = 0m, PictureUri = "10.jpg", Brand = lg, Category = tablet },
             new Product() { Name = "", Price = 0m, PictureUri = "11.jpg", Brand = lg, Category = tablet },
             new Product() { Name = "", Price = 0m, PictureUri = "12.jpg", Brand = lg, Category = tablet },
 
            };

            db.AddRange(products);
            await db.SaveChangesAsync();

        }
    }
}
