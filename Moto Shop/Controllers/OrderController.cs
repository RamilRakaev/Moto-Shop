using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Moto_Shop.Data.Interfaces;
using Moto_Shop.Data.Models;

namespace Moto_Shop.Controllers
{
    public class OrderController:Controller
    {
        private readonly IAllOrders AllOrders;
        private readonly ShopBasket SBas;

        public OrderController(IAllOrders motoRepos, ShopBasket shopBasket)
        {
            AllOrders = motoRepos;
            SBas = shopBasket;
        }

        [HttpGet]
        public IActionResult RegOrder()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegOrder(Order order)
        {
            SBas.ListShopItems = SBas.GetItems();

            if (SBas.ListShopItems.Count == 0)
            {
                ModelState.AddModelError("","Корзина пуста!");
            }
            else if (ModelState.IsValid){

                AllOrders.CreateOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }
        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ выполнен";
            return View();
        }

        
    }
}
