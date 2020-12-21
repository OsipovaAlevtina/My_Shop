using Microsoft.AspNetCore.Mvc;
using MyShop.Data.Interfaces;
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

        public ViewResult List()
        {
            ViewBag.Title = "Neon";
            LampsListViewModel obj = new LampsListViewModel();
            obj.AllLamps = _allLamps.Lamps;
            obj.LampCategory = "Светильники";

            return View(obj);
           
        }

    }
}
