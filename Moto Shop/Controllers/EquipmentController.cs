using Microsoft.AspNetCore.Mvc;
using Moto_Shop.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moto_Shop.Controllers
{
    public class EquipmentController : Controller
    {
        private readonly IAllProducts AllProducts;

        public EquipmentController()
        {
                
        }

        public ViewResult ReturnEquipment()
        {
            return View();
        }
    }
}
