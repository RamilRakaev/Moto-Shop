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
            List<Product> motorcycles=new List<Product>();
            string currModel = "";
            if (string.IsNullOrEmpty(model))
            {
                motorcycles = AllProducts.Products.OrderBy(m => m.Id).ToList();
            }
            else
            {
                if (model == "Motorcycle")
                {
                    foreach (Product product in AllProducts.Products)
                    {
                        if (product.IsMoto)
                            motorcycles.Add(product);
                    }
                    currModel = "Мотоциклы";
                }
                else if(model=="Equipment")
                {
                    foreach (Product product in AllProducts.Products)
                    {
                        if (!product.IsMoto)
                            motorcycles.Add(product);
                    }
                    currModel = "Экипировка";
                }
                    
            }

            var motoObj = new ProductListViewModel { AllMoto = motorcycles, CurrModel = currModel };
            ViewBag.Title = "Страница с товарами";

            return View(motoObj);
        }
    }
}
