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
    public class MotoController:Controller
    {
        private readonly IAllProducts AllProducts;
        private readonly IMotoModel MotoModel;

        public MotoController(IAllProducts allProducts, IMotoModel motoModel)
        {
            AllProducts = allProducts;
            MotoModel = motoModel;
        }

        [Route("Moto/ListProducts")]
        [Route("Moto/ListProducts/{model}")]
        public ViewResult ListProducts(string model)
        {
            string _model = model;
            IEnumerable<Motorcycle> motorcycles=null;
            string currModel = "";
            if (string.IsNullOrEmpty(model))
            {
                motorcycles = AllProducts.Products.OrderBy(m => m.Id);
            }
            else
            {
                if (string.Equals("Enduro", model, StringComparison.OrdinalIgnoreCase))
                {
                    motorcycles = AllProducts.Products.Where(m => m.Model.ModelName.Equals("Эндуро")).OrderBy(m => m.Id);
                    currModel = "Эндуро";
                }
                else if (string.Equals("Classic", model, StringComparison.OrdinalIgnoreCase))
                {
                    motorcycles = AllProducts.Products.Where(m => m.Model.ModelName.Equals("Классический")).OrderBy(m => m.Id);
                    currModel = "Классический";
                }
                else if (string.Equals("Chopper", model, StringComparison.OrdinalIgnoreCase))
                {
                    motorcycles = AllProducts.Products.Where(m => m.Model.ModelName.Equals("Чоппер")).OrderBy(m => m.Id);
                    currModel = "Чоппер";
                }
                else if (string.Equals("Sport", model, StringComparison.OrdinalIgnoreCase))
                {
                    motorcycles = AllProducts.Products.Where(m => m.Model.ModelName.Equals("Спортивный")).OrderBy(m => m.Id);
                    currModel = "Спортивный";
                }
                
            }

            var motoObj = new MotoListViewModel { AllMoto = motorcycles, CurrModel = currModel };
            ViewBag.Title = "Страница с мотоциклами";

            return View(motoObj);
        }
    }
}
