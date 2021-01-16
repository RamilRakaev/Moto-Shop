using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moto_Shop.Data.Interfaces;
using Moto_Shop.Data.Models;
using Moto_Shop.ViewModels;

namespace Moto_Shop.Controllers
{
    public class HomeController:Controller
    {
        private readonly IAllProducts MRep;

        public HomeController(IAllProducts motoRepos, ShopBasket shopBasket)
        {
            MRep = motoRepos;
        }

        public ViewResult Index()
        {
            var homeMoto = new HomeViewModel
            {
                FavMoto = MRep.GetFavoriteMoto
            };
            return View(homeMoto);
        }
    }
}
