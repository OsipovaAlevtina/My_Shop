using MyShop.Data.Interfaces;
using MyShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Data.Info
{
    public class InfoCategory : ILampsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {CategoryName = "Фигурные", Desc = "Декоративные неоновые фигуры" },
                    new Category {CategoryName = "Вывески", Desc = "Неоновые настенные вывески"}
                };
            }
        }
    }
}
