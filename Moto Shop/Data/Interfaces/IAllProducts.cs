using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moto_Shop.Data.Models;

namespace Moto_Shop.Data.Interfaces
{
    public interface IAllProducts
    {
        IEnumerable<Product> Products { get;  }
        IEnumerable<Product> GetFavoriteMoto { get;}
        Product GetMoto(int Id);
    }
}
