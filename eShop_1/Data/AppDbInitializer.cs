using eShop_1.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace eShop_1.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBilder)
        {
            using (var serviceScope = applicationBilder.ApplicationServices.CreateScope())
            {
                var contex = serviceScope.ServiceProvider.GetService<AppDbContext>();

                contex.Database.EnsureCreated();

                //ProductCategory
                if(!contex.ProductCategories.Any())
                {
                    contex.ProductCategories.AddRange(new List<ProductCategory>()
                    {
                        new ProductCategory()
                        {
                            Name = "smartphone",
                            ImagURL ="https://avatars.mds.yandex.net/get-mpic/4397006/img_id3884474343356692179.jpeg/orig"
                        }
                    });
                    contex.SaveChanges();
                }
                //Brands
                if (!contex.Brands.Any())
                {
                    contex.Brands.AddRange(new List<Brand>() { 
                        new Brand()
                        {
                            Name = "Apple",
                            OffcialURL = "https://www.apple.com",
                            ImagURL = "https://upload.wikimedia.org/wikipedia/commons/f/fa/Apple_logo_black.svg",
                            Bio = "Apple — американская корпорация, производитель персональных и планшетных компьютеров, аудиоплееров, смартфонов, программного обеспечения. " +
                            "Один из пионеров в области персональных компьютеров и современных многозадачных операционных систем с графическим интерфейсом. " +
                            "Штаб-квартира — в Купертино, штат Калифорния."
                        }
                    });
                    contex.SaveChanges();

                }
                //Products
                if (!contex.Products.Any())
                {
                    contex.Products.AddRange(new List<Product>
                    {
                        new Product() 
                        { 
                          Name = "Ihpone 11",
                          RAM =   4.0,
                          ROM = 64.0,
                          Description = "Функциональный и стильный смартфон Apple iPhone 11" +
                          " в металлическом корпусе способен обеспечить не только повседневное " +
                          "общение и развлечения, но и продуктивную работу. Для этого он оснащен" +
                          " мощным процессором Apple A13 Bionic из 6 ядер, поддерживающим слаженную работу" +
                          " всех комплектующих, а также модулем ОЗУ объемом в 4 ГБ, что предусматривает быстрое" +
                          " переключение между открытыми приложениями и возможность играть в игры. Основная (12;12 Мп)" +
                          " и фронтальная (12 Мп) камеры позволят создавать фотошедевры. Изображение на экране" +
                          " смартфона Apple iPhone 11 диагональю 6.1 дюйма обладает поразительной" +
                          " детализацией и цветопередачей. Олеофобное покрытие исключает сильное" +
                          " загрязнение экрана. Корпус смартфона имеет высокую степень пылевлагозащиты (IP68)," +
                          " благодаря чему обеспечивается эффективная и длительная работа устройства. " +
                          "Несъемный аккумулятор емкостью 3110 мА·ч " +
                          "поддерживает беспроводную зарядку, что сделает " +
                          "данный процесс более легким и быстрым.",
                          Price = 50990.0,
                          Colour = "Green",
                          ImagURL = "https://avatars.mds.yandex.net/get-mpic/4509881/img_id1153621322038257362.jpeg/orig",
                          InStok = true,
                          Brand = contex.Brands.Where(b => b.Name == "Apple").FirstOrDefault(),
                          BrandId =contex.Brands.Where(b => b.Name == "Apple").FirstOrDefault().Id,
                          Category = contex.ProductCategories.Where(c => c.Name =="smartphone").FirstOrDefault(),
                          CategoryId = contex.ProductCategories.Where(c => c.Name =="smartphone").FirstOrDefault().Id
                        }
                    });
                    contex.SaveChanges();
                }
                //Users
                if (!contex.Users.Any())
                {
                    contex.AddRange(new List<User>
                    {
                        new User()
                        {
                            Name = "Tim",
                            Email = "tima@mail.com",
                            Login = "tima99",
                            PassWord ="12345678",
                            PhoneNumber = "+71234565432",
                        }
                    });
                    contex.SaveChanges();
                }
            }
        }
    }
}
