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

            var shake = new Category
            {
                Name = "شیک ها",
                DisplayOrder = 5
            };

            var smoke = new Category
            {
                Name = "قلیان",
                DisplayOrder = 6
            };

            context.Categories.AddRange(
                fastfood,
                burger,
                hotDrinks,
                coldDrinks,
                shake,
                smoke
            );

            context.SaveChanges();

            var products = new List<Product>
            {
                #region fastfoods
                // fastfoods
                new Product
                {
                    Name = "پیتزا میتی مخصوص",
                    Description =
                        "",
                    Ingredients =
                        "قارچ ,ژامبودن ",
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
                        "",
                    Ingredients =
                        "قارچ ,مرغ ",
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
                        "",
                    Ingredients =
                        "قارچ ,گوشت ",
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
                        "",
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
                        "",
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
                        "",
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
                        "",
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
                        "",
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
                        "",
                    Ingredients =
                        "پپرونی  ",
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
                        "",
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
                        "",
                    Ingredients =
                        "مرغ  ",
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
                        "",
                    Ingredients =
                        "گوشت  ",
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
                        "",
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
                        "",
                    Ingredients =
                        "پپرونی  ",
                    Price = 810000,
                    ImageUrl =
                        "/images/products/pizza.jpg",
                    CategoryId = fastfood.Id,
                    IsAvailable = true
                },
                #endregion

                #region burgers
                // burgers
                new Product
                {
                    Name = "بمب برگر",
                    Description =
                        "",
                    Ingredients =
                        "همبر",
                    Price = 810000,
                    ImageUrl =
                        "/images/burgers/burger.jpg",
                    CategoryId = burger.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "همبرگر",
                    Description =
                        "",
                    Ingredients =
                        "همبر",
                    Price = 810000,
                    ImageUrl =
                        "/images/burgers/burger.jpg",
                    CategoryId = burger.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "چیز برگر",
                    Description =
                        "",
                    Ingredients =
                        "همبر",
                    Price = 810000,
                    ImageUrl =
                        "/images/burgers/burger.jpg",
                    CategoryId = burger.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "دوبل برگر",
                    Description =
                        "",
                    Ingredients =
                        "همبر",
                    Price = 810000,
                    ImageUrl =
                        "/images/burgers/burger.jpg",
                    CategoryId = burger.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "رویال برگر",
                    Description =
                        "",
                    Ingredients =
                        "همبر",
                    Price = 90000,
                    ImageUrl =
                        "/images/burgers/burger.jpg",
                    CategoryId = burger.Id,
                    IsAvailable = true
                },
                #endregion

                #region hot drinks
                // hot drinks
                new Product
                {
                    Name = "اسپرسو",
                    Description =
                        "",
                    Ingredients =
                        "قهوه ",
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
                        "",
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
                        "",
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
                    Description = "",
                    Ingredients =
                        "اسپرسو, شیر, فوم شیر",
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
                        "",
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
                        "",
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
                        "",
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
                        "",
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
                        "",
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
                        "",
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
                        "",
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
                        "",
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
                        "",
                    Ingredients =
                        "دمنوش",
                    Price = 170000,
                    ImageUrl =
                        "/images/products/espresso.jpg",
                    CategoryId = hotDrinks.Id,
                    IsAvailable = true
                },
                #endregion

                #region cold drinks
                new Product
                {
                    Name = "ایلتوبریز(مخصوص فرهان)",
                    Description = "",
                    Ingredients =
                        "مخصوص",
                    Price = 310000,
                    CategoryId = coldDrinks.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "موهیتو",
                    Description = "",
                    Ingredients =
                        "موهیتو",
                    Price = 175000,
                    CategoryId = coldDrinks.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "ایس تی هلو",
                    Description = "",
                    Ingredients =
                        "ایس تی هلو",
                    Price = 110000,
                    CategoryId = coldDrinks.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "بلادی",
                    Description = "",
                    Ingredients =
                        "بلادی",
                    Price = 240000,
                    CategoryId = coldDrinks.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "دراگون",
                    Description = "",
                    Ingredients =
                        "دراگون",
                    Price = 200000,
                    CategoryId = coldDrinks.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "دتاکس سودا",
                    Description = "",
                    Ingredients =
                        "دتاکس",
                    Price = 120000,
                    CategoryId = coldDrinks.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "معجون ترش",
                    Description = "",
                    Ingredients =
                        "معجون ترش",
                    Price = 260000,
                    CategoryId = coldDrinks.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "استوایی در بم",
                    Description = "",
                    Ingredients =
                        "استوایی ",
                    Price = 260000,
                    CategoryId = coldDrinks.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "کوکو در بم",
                    Description = "",
                    Ingredients =
                        "کوکو ",
                    Price = 175000,
                    CategoryId = coldDrinks.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "سامرتایم",
                    Description = "",
                    Ingredients =
                        "سامر",
                    Price = 280000,
                    CategoryId = coldDrinks.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "شاتوت البالو",
                    Description = "",
                    Ingredients =
                        "شاتوت ,البالو",
                    Price = 195000,
                    CategoryId = coldDrinks.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "آفوکانو",
                    Description = "",
                    Ingredients =
                        "آفوکانو",
                    Price = 120000,
                    CategoryId = coldDrinks.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "آیس لاته",
                    Description = "",
                    Ingredients =
                        "آیس لاته",
                    Price = 190000,
                    CategoryId = coldDrinks.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "آیس امریکانو",
                    Description = "",
                    Ingredients =
                        "امریکانو",
                    Price = 150000,
                    CategoryId = coldDrinks.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "آیس موکا",
                    Description = "",
                    Ingredients =
                        "آیس موکا",
                    Price = 230000,
                    CategoryId = coldDrinks.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "آیس ماکیاتو",
                    Description = "",
                    Ingredients =
                        "آیس ماکیاتو",
                    Price = 260000,
                    CategoryId = coldDrinks.Id,
                    IsAvailable = true
                },

                #endregion

                #region shakes
                new Product
                {
                    Name = "شیک شکلات",
                    Description =
                        "",
                    Ingredients =
                        "شکلات",
                    Price = 220000,
                    ImageUrl =
                        "/images/products/cheesecake.jpg",
                    CategoryId = shake.Id,
                    IsAvailable = true
                },

                new Product
                {
                    Name = "شیک موز شکلات",
                    Description = "",
                    Ingredients =
                        "موز,شکلات",
                    Price = 280000,
                    CategoryId = shake.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "شیک توت فرنگی",
                    Description = "",
                    Ingredients =
                        "توت فرنگی",
                    Price = 220000,
                    CategoryId = shake.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "شیک بادام زمینی",
                    Description = "",
                    Ingredients =
                        "بادام زمینی,",
                    Price = 300000,
                    CategoryId = shake.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "شیک موز ",
                    Description = "",
                    Ingredients =
                        "موز,",
                    Price = 240000,
                    CategoryId = shake.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "شیک لوتوس",
                    Description = "",
                    Ingredients =
                        "شیک",
                    Price = 300000,
                    CategoryId = shake.Id,
                    IsAvailable = true
                },
                #endregion

                #region smokes
                new Product
                {
                    Name = "قلیان نعنا",
                    Description = "",
                    Ingredients =
                        "نعنا",
                    Price = 250000,
                    ImageUrl =
                        "/images/smokes/قلیان.jpg",
                    CategoryId = smoke.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "قلیان نعنا ادامس",
                    Description = "",
                    Ingredients =
                        "نعنا ادامس",
                    Price = 250000,
                    ImageUrl =
                        "/images/smokes/قلیان.jpg",
                    CategoryId = smoke.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "قلیان نعنا لیمو",
                    Description = "",
                    Ingredients =
                        "نعنا لیمو",
                    Price = 250000,
                    ImageUrl =
                        "/images/smokes/قلیان.jpg",
                    CategoryId = smoke.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "نعنا یخقلیان ",
                    Description = "",
                    Ingredients =
                        "نعنا یخ",
                    Price = 250000,
                    ImageUrl =
                        "/images/smokes/قلیان.jpg",
                    CategoryId = smoke.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "قلیان نعنا پرتقال",
                    Description = "",
                    Ingredients =
                        "نعنا پرتقال",
                    Price = 250000,
                    ImageUrl =
                        "/images/smokes/قلیان.jpg",
                    CategoryId = smoke.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "قلیان پرتقال",
                    Description = "",
                    Ingredients =
                        "پرتقال",
                    Price = 250000,
                    ImageUrl =
                        "/images/smokes/قلیان.jpg",
                    CategoryId = smoke.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "قلیان پرتقال خامه",
                    Description = "",
                    Ingredients =
                        "پرتقال خامه",
                    Price = 250000,
                    ImageUrl =
                        "/images/smokes/قلیان.jpg",
                    CategoryId = smoke.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "قلیان شلیل",
                    Description = "",
                    Ingredients =
                        "شلیل",
                    Price = 250000,
                    ImageUrl =
                        "/images/smokes/قلیان.jpg",
                    CategoryId = smoke.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "قلیان شلیل البالو",
                    Description = "",
                    Ingredients =
                        "شلیل البالو",
                    Price = 250000,
                    ImageUrl =
                        "/images/smokes/قلیان.jpg",
                    CategoryId = smoke.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "قلیان دوسیب",
                    Description = "",
                    Ingredients =
                        "دوسیب",
                    Price = 250000,
                    ImageUrl =
                        "/images/smokes/قلیان.jpg",
                    CategoryId = smoke.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "دوسیب البالوقلیان ",
                    Description = "",
                    Ingredients =
                        "دوسیب البالو",
                    Price = 250000,
                    ImageUrl =
                        "/images/smokes/قلیان.jpg",
                    CategoryId = smoke.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "قلیان لاو",
                    Description = "",
                    Ingredients =
                        "لاو",
                    Price = 250000,
                    ImageUrl =
                        "/images/smokes/قلیان.jpg",
                    CategoryId = smoke.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "شب های مسکوقلیان ",
                    Description = "",
                    Ingredients =
                        "شب های مسکو",
                    Price = 250000,
                    ImageUrl =
                        "/images/smokes/قلیان.jpg",
                    CategoryId = smoke.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "قلیان بلوبری",
                    Description = "",
                    Ingredients =
                        "بلوبری",
                    Price = 250000,
                    ImageUrl =
                        "/images/smokes/قلیان.jpg",
                    CategoryId = smoke.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "قلیان یخ شراب",
                    Description = "",
                    Ingredients =
                        "یخ شراب",
                    Price = 250000,
                    ImageUrl =
                        "/images/smokes/قلیان.jpg",
                    CategoryId = smoke.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "انارقلیان ",
                    Description = "",
                    Ingredients =
                        "انار",
                    Price = 250000,
                    ImageUrl =
                        "/images/smokes/قلیان.jpg",
                    CategoryId = smoke.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "قلیان انبه",
                    Description = "",
                    Ingredients =
                        "انبه",
                    Price = 250000,
                    ImageUrl =
                        "/images/smokes/قلیان.jpg",
                    CategoryId = smoke.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "قلیان لبمو ترش",
                    Description = "",
                    Ingredients =
                        "لیموترش",
                    Price = 250000,
                    ImageUrl =
                        "/images/smokes/قلیان.jpg",
                    CategoryId = smoke.Id,
                    IsAvailable = true
                },
                new Product
                {
                    Name = "تعویض سر قلیان",
                    Description = "",
                    Ingredients =
                        "تعویض سر",
                    Price = 100000,
                    ImageUrl =
                        "/images/smokes/قلیان.jpg",
                    CategoryId = smoke.Id,
                    IsAvailable = true
                },
                #endregion
            };

            context.Products.AddRange(products);

            context.SaveChanges();
        }
    }
}