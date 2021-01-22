using Moto_Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moto_Shop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> FavMoto { get; set; }
    }
}
