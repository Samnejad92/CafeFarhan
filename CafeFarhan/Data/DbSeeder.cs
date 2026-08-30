using CafeFarhan.Models;

namespace CafeFarhan.Data
{
    public static class DbSeeder
    {
        public static void Seed(CafeDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Categories.Any())
                return;

            var coffee = new Category
            {
                Name = "قهوه",
                DisplayOrder = 1
            };

            var coldDrinks = new Category
            {
                Name = "نوشیدنی سرد",
                DisplayOrder = 2
            };

            var desserts = new Category
            {
                Name = "دسر و کیک",
                DisplayOrder = 3
            };

            var breakfast = new Category
            {
                Name = "صبحانه",
                DisplayOrder = 4
            };

            context.Categories.AddRange(
                coffee,
                coldDrinks,
                desserts,
                breakfast
            );

            context.SaveChanges();

            var products = new List<Product>
            {
                new Product
{
    Name = "اسپرسو",

    Description =
        "یک شات اسپرسوی تازه و خوش‌عطر",

    Ingredients =
        "قهوه اسپرسو",

    Price = 85000,

    ImageUrl =
        "/images/products/espresso.jpg",

    CategoryId = coffee.Id,

    IsAvailable = true
},

                new Product
{
    Name = "کاپوچینو",

    Description =
        "قهوه‌ای خوش‌عطر با بافتی نرم و خامه‌ای",

    Ingredients =
        "اسپرسو, شیر, فوم شیر",

    Price = 120000,

    ImageUrl =
        "/images/products/cappuccino.jpg",

    CategoryId = coffee.Id,

    IsAvailable = true
},

                new Product
                {
                    Name = "کافه لاته",
                    Description = "اسپرسو با شیر گرم و فوم نرم",
                    Price = 125000,
                    CategoryId = coffee.Id,
                    IsAvailable = true
                },

                new Product
                {
                    Name = "آیس کافی",
                    Description = "قهوه سرد با یخ",
                    Price = 135000,
                    CategoryId = coldDrinks.Id,
                    IsAvailable = true
                },

                new Product
                {
                    Name = "موهیتو",
                    Description = "نوشیدنی خنک با نعناع و لیمو",
                    Price = 140000,
                    CategoryId = coldDrinks.Id,
                    IsAvailable = true
                },

                new Product
{
    Name = "چیزکیک",

    Description =
        "چیزکیک مخصوص کافه فرهان",

    Ingredients =
        "پنیر خامه‌ای, بیسکویت, خامه, شکر",

    Price = 150000,

    ImageUrl =
        "/images/products/cheesecake.jpg",

    CategoryId = desserts.Id,

    IsAvailable = true
},

                new Product
                {
                    Name = "کیک شکلاتی",
                    Description = "کیک شکلاتی تازه",
                    Price = 130000,
                    CategoryId = desserts.Id,
                    IsAvailable = true
                },

                new Product
                {
                    Name = "صبحانه مخصوص",
                    Description = "صبحانه کامل کافه فرهان",
                    Price = 250000,
                    CategoryId = breakfast.Id,
                    IsAvailable = true
                }
            };

            context.Products.AddRange(products);

            context.SaveChanges();
        }
    }
}