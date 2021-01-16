using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moto_Shop.Data.Models;

namespace Moto_Shop.Data.Interfaces
{
    public interface IAllProducts
    {
        IEnumerable<Motorcycle> Products { get;  }
        IEnumerable<Motorcycle> GetFavoriteMoto { get;}
        Motorcycle GetMoto(int Id);
    }
}
