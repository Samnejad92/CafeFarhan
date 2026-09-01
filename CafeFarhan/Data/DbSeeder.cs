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

            var fastfood = new Category
            {
                Name = "فست فود",
                DisplayOrder = 1
            };

            var burger = new Category
            {
                Name = "برگر",
                DisplayOrder = 2
            };

            var hotDrinks = new Category
            {
                Name = "نوشیدنی گرم",
                DisplayOrder = 3
            };

            var coldDrinks = new Category
            {
                Name = "نوشیدنی سرد",
                DisplayOrder = 4
            };

            var desserts = new Category
            {
                Name = "دسر و کیک",
                DisplayOrder = 5
            };

            var breakfast = new Category
            {
                Name = "صبحانه",
                DisplayOrder = 6
            };

            context.Categories.AddRange(
                fastfood,
                burger,
                hotDrinks,
                coldDrinks,
                desserts,
                breakfast
            );

            context.SaveChanges();

            var products = new List<Product>
            {
                // fastfoods
                new Product
                {
                    Name = "پیتزا میتی مخصوص",
                    Description =
                        "پیتزا",
                    Ingredients =
                        "قارچ ژامبودن ",
                    Price = 270000,
                    ImageUrl =
                        "/images/products/pizza.jpg",
                    CategoryId = fastfood.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "پیتزا مینی مرغ",
                    Description =
                        "پیتزا",
                    Ingredients =
                        "قارچ مرغ ",
                    Price = 365000,
                    ImageUrl =
                        "/images/products/pizza.jpg",
                    CategoryId = fastfood.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "پیتزا مینی رست بیف",
                    Description =
                        "پیتزا",
                    Ingredients =
                        "قارچ مرغ ",
                    Price = 400000,
                    ImageUrl =
                        "/images/products/pizza.jpg",
                    CategoryId = fastfood.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "پیتزا مخصوص",
                    Description =
                        "پیتزا",
                    Ingredients =
                        "قارچ  ",
                    Price = 450000,
                    ImageUrl =
                        "/images/products/pizza.jpg",
                    CategoryId = fastfood.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "پیتزا قارچ و مرغ",
                    Description =
                        "پیتزا",
                    Ingredients =
                        "قارچ  ",
                    Price = 500000,
                    ImageUrl =
                        "/images/products/pizza.jpg",
                    CategoryId = fastfood.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "پیتزا سبزیجات",
                    Description =
                        "پیتزا",
                    Ingredients =
                        "قارچ  ",
                    Price = 400000,
                    ImageUrl =
                        "/images/products/pizza.jpg",
                    CategoryId = fastfood.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "پیتزا رست بیف",
                    Description =
                        "پیتزا",
                    Ingredients =
                        "قارچ  ",
                    Price = 630000,
                    ImageUrl =
                        "/images/products/pizza.jpg",
                    CategoryId = fastfood.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "پیتزا سراشپز",
                    Description =
                        "پیتزا",
                    Ingredients =
                        "قارچ  ",
                    Price = 590000,
                    ImageUrl =
                        "/images/products/pizza.jpg",
                    CategoryId = fastfood.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "پیتزا پپرونی",
                    Description =
                        "پیتزا",
                    Ingredients =
                        "قارچ  ",
                    Price = 480000,
                    ImageUrl =
                        "/images/products/pizza.jpg",
                    CategoryId = fastfood.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "پیتزا خانواده مخصوص",
                    Description =
                        "پیتزا",
                    Ingredients =
                        "قارچ  ",
                    Price = 790000,
                    ImageUrl =
                        "/images/products/pizza.jpg",
                    CategoryId = fastfood.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "پیتزا مرغ خانواده",
                    Description =
                        "پیتزا",
                    Ingredients =
                        "قارچ  ",
                    Price = 900000,
                    ImageUrl =
                        "/images/products/pizza.jpg",
                    CategoryId = fastfood.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "پیتزا رست بیف خانواده",
                    Description =
                        "پیتزا",
                    Ingredients =
                        "قارچ  ",
                    Price = 1200000,
                    ImageUrl =
                        "/images/products/pizza.jpg",
                    CategoryId = fastfood.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "پیتزا سراشپز خانواده",
                    Description =
                        "پیتزا",
                    Ingredients =
                        "قارچ  ",
                    Price = 990000,
                    ImageUrl =
                        "/images/products/pizza.jpg",
                    CategoryId = fastfood.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "پیتزا خانواده پپرونی",
                    Description =
                        "پیتزا",
                    Ingredients =
                        "قارچ  ",
                    Price = 810000,
                    ImageUrl =
                        "/images/products/pizza.jpg",
                    CategoryId = fastfood.Id,
                    IsAvailable = true
                },
                // coffe
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
                    CategoryId = hotDrinks.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "امریکانو",
                    Description =
                        "یک فنجان",
                    Ingredients =
                        "قهوه",
                    Price = 140000,
                    ImageUrl =
                        "/images/products/espresso.jpg",
                    CategoryId = hotDrinks.Id,
                    IsAvailable = true
                },
                              new Product
                {
                    Name = "کاپوچینو",
                    Description =
                        "قهوه‌ای خوش‌عطر با بافتی نرم و خامه‌ای",
                    Ingredients =
                        "اسپرسو, شیر, فوم شیر",
                    Price = 95000,
                    ImageUrl =
                        "/images/products/cappuccino.jpg",
                    CategoryId = hotDrinks.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "کافه لاته",
                    Description = "اسپرسو با شیر گرم و فوم نرم",
                    Price = 160000,
                    ImageUrl =
                        "/images/products/espresso.jpg",
                    CategoryId = hotDrinks.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "موکا",
                    Description =
                        "یک فنجان",
                    Ingredients =
                        "قهوه",
                    Price = 190000,
                    ImageUrl =
                        "/images/products/espresso.jpg",
                    CategoryId = hotDrinks.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "ماکیاتو",
                    Description =
                        "یک فنجان",
                    Ingredients =
                        "قهوه",
                    Price = 200000,
                    ImageUrl =
                        "/images/products/espresso.jpg",
                    CategoryId = hotDrinks.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "چای",
                    Description =
                        "یک ",
                    Ingredients =
                        "چای",
                    Price = 85000,
                    ImageUrl =
                        "/images/products/espresso.jpg",
                    CategoryId = hotDrinks.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "چای سبز",
                    Description =
                        "یک ",
                    Ingredients =
                        "چای",
                    Price = 100000,
                    ImageUrl =
                        "/images/products/espresso.jpg",
                    CategoryId = hotDrinks.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "چای ماسالا",
                    Description =
                        "یک ",
                    Ingredients =
                        "چای ماسالا",
                    Price = 130000,
                    ImageUrl =
                        "/images/products/espresso.jpg",
                    CategoryId = hotDrinks.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "چای کرک",
                    Description =
                        "یک ",
                    Ingredients =
                        "چای کرک",
                    Price = 170000,
                    ImageUrl =
                        "/images/products/espresso.jpg",
                    CategoryId = hotDrinks.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "دمنوش به لیمو",
                    Description =
                        "یک ",
                    Ingredients =
                        "دمنوش",
                    Price = 60000,
                    ImageUrl =
                        "/images/products/espresso.jpg",
                    CategoryId = hotDrinks.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "دمنوش گل گاوزبان",
                    Description =
                        "یک ",
                    Ingredients =
                        "دمنوش",
                    Price = 60000,
                    ImageUrl =
                        "/images/products/espresso.jpg",
                    CategoryId = hotDrinks.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "دمنوش بابونه",
                    Description =
                        "یک ",
                    Ingredients =
                        "دمنوش",
                    Price = 170000,
                    ImageUrl =
                        "/images/products/espresso.jpg",
                    CategoryId = hotDrinks.Id,
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

                    CategoryId = hotDrinks.Id,

                    IsAvailable = true
                },

                new Product
                {
                    Name = "کافه لاته",
                    Description = "اسپرسو با شیر گرم و فوم نرم",
                    Price = 125000,
                    CategoryId = hotDrinks.Id,
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