using Moto_Shop.Data.Models.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moto_Shop.Data.Interfaces
{
    interface IMotoClothing
    {
        IEnumerable<Clothing> AllClothing { get; }
    }
}
