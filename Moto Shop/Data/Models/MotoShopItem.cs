using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Moto_Shop.Data.Models
{
    public class MotoShopItem
    {
        public int Id { get; set; }
        public int MotoId { get; set; }

        [NotMapped]
        public Motorcycle Moto { get; set; }
        public int Price { get; set; }

        public string ShopBasketId { get; set; }
    }
}
