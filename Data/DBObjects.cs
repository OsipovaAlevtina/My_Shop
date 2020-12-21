using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MyShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if(!content.Lamp.Any())
            {
                content.AddRange(
                     new Lamp
                     {
                         Name = "Flamingo",
                         ShortDesc = "Настольный светильник",
                         LongDesc = "Яркий декоративный светильник с подставкой. Цвет: розовый. Высота: 45см.",
                         Img = "/Img/flamingo.jpg",
                         Price = 2500,
                         IfFavourite = true,
                         Available = false,
                         Category = Categories["Фигурные"]
                     },
                    new Lamp
                    {
                        Name = "Tree leaf",
                        ShortDesc = "Настенный светильник",
                        LongDesc = "Яркий настенный светильник. Цвет: зеленый. Высота: 40см.",
                        Img = "/Img/list.jpg",
                        Price = 2000,
                        IfFavourite = true,
                        Available = true,
                        Category = Categories["Фигурные"]
                    },
                    new Lamp
                    {
                        Name = "Bird",
                        ShortDesc = "Настенный светильник",
                        LongDesc = "Яркий настенный светильник. Цвет: синий. Высота: 35см.",
                        Img = "/Img/bird.jpg",
                        Price = 2100,
                        IfFavourite = true,
                        Available = true,
                        Category = Categories["Фигурные"]
                    },
                    new Lamp
                    {
                        Name = "Hello",
                        ShortDesc = "Декоративная вывеска",
                        LongDesc = "Украшение для стен комнаты. Цвет: розовый. Размер: 30х70см.",
                        Img = "/Img/hello.jpg",
                        Price = 2700,
                        IfFavourite = true,
                        Available = true,
                        Category = Categories["Вывески"]
                    },
                    new Lamp
                    {
                        Name = "Smile",
                        ShortDesc = "Декоративная вывеска",
                        LongDesc = "Атмосферная вывеска для крупных пемещений. Цвет: красно-оранжевый. Размер: 50х150см.",
                        Img = "/Img/smile.jpg",
                        Price = 3600,
                        IfFavourite = true,
                        Available = true,
                        Category = Categories["Вывески"]
                    },
                    new Lamp
                    {
                        Name = "Open",
                        ShortDesc = "Декоративная вывеска",
                        LongDesc = "Яркая неоновая вывеска для магазинов и кафе. Цвет: розово-синий. Размер: 45х110см.",
                        Img = "/Img/open.jpg",
                        Price = 3600,
                        IfFavourite = true,
                        Available = true,
                        Category = Categories["Вывески"]
                    }
                    );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            { 
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category {CategoryName = "Фигурные", Desc = "Декоративные неоновые фигуры" },
                        new Category {CategoryName = "Вывески", Desc = "Неоновые настенные вывески"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.CategoryName, el);
                }

                return category;
            }
        }

    }
}
