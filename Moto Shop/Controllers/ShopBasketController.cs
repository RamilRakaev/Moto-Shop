using Microsoft.AspNetCore.Mvc;
using Moto_Shop.Data.Models;
using Moto_Shop.Data.Repository;
using Moto_Shop.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moto_Shop.ViewModels;
using Moto_Shop.Data.Interfaces;

namespace Moto_Shop.Controllers
{
    public class ShopBasketController:Controller
    {
        private IAllProducts MotoRepos;
        private readonly ShopBasket SBasket;

        public ShopBasketController(IAllProducts motoRepos,ShopBasket shopBasket)
        {
            MotoRepos = motoRepos;
            SBasket = shopBasket;
        }
        public ViewResult Index()
        {
            var list = SBasket.GetItems();
            SBasket.ListShopItems=list;

            var obj = new ShopBasketViewModel
            {
                SBask = SBasket
            };
            return View(obj);
        }

        public RedirectToActionResult AddToBasket(int id)
        {
            var item = MotoRepos.Products.FirstOrDefault(m => m.Id == id);
            if (item != null)
            {
                SBasket.AddToMoto(item);
            }
            return RedirectToAction("Index");
        }
    }
}
