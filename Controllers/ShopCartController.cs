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
    public class ShopCartController : Controller
    {
        private IAllLamps _lampRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllLamps lampRep, ShopCart shopCart)
        {
            _lampRep = lampRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.GetShopItems();
            _shopCart.ListShopItems = items;

            var obj = new ShopCartViewModel
            {
                ShopCart = _shopCart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _lampRep.Lamps.FirstOrDefault(i => i.Id == id);
            if(item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }

    }
}
