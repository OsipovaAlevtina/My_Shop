using Microsoft.AspNetCore.Mvc;
using MyShop.Data.Interfaces;
using MyShop.Data.Models;
using MyShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Controllers
{
    public class LampsController : Controller
    {
        private readonly IAllLamps _allLamps;
        private readonly ILampsCategory _allCategories;

        public LampsController(IAllLamps iAllLamps, ILampsCategory iLampsCat)
        {
            _allLamps = iAllLamps;
            _allCategories = iLampsCat;
        }

        [Route("Lamps/List")]
        [Route("Lamps/List/{category}")]

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Lamp> Lamps = null;
            string LampCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                Lamps = _allLamps.Lamps.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("figure", category, StringComparison.OrdinalIgnoreCase))
                {
                    Lamps = _allLamps.Lamps.Where(i => i.Category.CategoryName.Equals("Фигурные")).OrderBy(i => i.Id);
                    LampCategory = "Фигурные";
                }
                else if (string.Equals("signage", category, StringComparison.OrdinalIgnoreCase))
                {
                    Lamps = _allLamps.Lamps.Where(i => i.Category.CategoryName.Equals("Вывески")).OrderBy(i => i.Id);
                    LampCategory = "Вывески";
                }

                
            }
            var lampObj = new LampsListViewModel
            {
                AllLamps = Lamps,
                LampCategory = LampCategory
            };

            ViewBag.Title = "Neon";

            return View(lampObj);
        }
    }
}
