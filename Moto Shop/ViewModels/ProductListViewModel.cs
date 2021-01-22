using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moto_Shop.Data.Models;

namespace Moto_Shop.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> AllMoto { get; set; }

        public string CurrModel {get; set;}
    }
}
