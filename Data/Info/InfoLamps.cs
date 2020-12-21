using MyShop.Data.Interfaces;
using MyShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Data.Info
{
    public class InfoLamps : IAllLamps
    {
        private readonly ILampsCategory _categoryLamps = new InfoCategory();

        public IEnumerable<Lamp> Lamps 
        {
            get
            {
                return new List<Lamp>
                {
                    new Lamp
                    {
                        Name = "Flamingo",
                        ShortDesc = "Настольный светильник",
                        LongDesc = "Яркий декоративный светильник с подставкой. Цвет: розовый. Высота: 45см.",
                        Img = "/Img/flamingo.jpg",
                        Price = 2500,
                        IfFavourite = true,
                        Available = false,
                        Category = _categoryLamps.AllCategories.First()
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
                        Category = _categoryLamps.AllCategories.First()
                    },
                    new Lamp 
                    {
                        Name = "Bird",
                        ShortDesc = "Настенный светильник",
                        LongDesc = "Яркий настенный светильник. Цвет: синий. Высота: 35см.",
                        Img = "/Img/bird.jpg",
                        Price = 2100,
                        IfFavourite = false,
                        Available = true,
                        Category = _categoryLamps.AllCategories.First()
                    },
                    new Lamp 
                    {
                        Name = "Hello",
                        ShortDesc = "Декоративная вывеска",
                        LongDesc = "Украшение для стен комнаты. Цвет: розовый. Размер: 30х70см.",
                        Img = "/Img/hello.jpg",
                        Price = 2700,
                        IfFavourite = false,
                        Available = true,
                        Category = _categoryLamps.AllCategories.Last()
                    },
                    new Lamp 
                    {
                        Name = "Smile",
                        ShortDesc = "Декоративная вывеска",
                        LongDesc = "Атмосферная вывеска для крупных пемещений. Цвет: красно-оранжевый. Размер: 50х150см.",
                        Img = "/Img/smile.jpg",
                        Price = 3600,
                        IfFavourite = false,
                        Available = true,
                        Category = _categoryLamps.AllCategories.Last()
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
                        Category = _categoryLamps.AllCategories.Last()
                    }
                    
                };
            }
        }
        public IEnumerable<Lamp> GetFavLamp { get ; set; }

        public Lamp GetObjectLamp(int lampId)
        {
            throw new NotImplementedException();
        }
    }
}
