using Microsoft.AspNetCore.Mvc;
using MyShop.Data.Interfaces;
using MyShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Controllers
{
    public class HomeController : Controller
    {
        private IAllLamps _lampRep;

        public HomeController (IAllLamps lampRep)
        {
            _lampRep = lampRep;
        }

        public ViewResult Index()
        {
            var homeLamps = new HomeViewModel
            {
                FavLamps = _lampRep.GetFavLamp
            };
            return View(homeLamps);
        }
    }
}
