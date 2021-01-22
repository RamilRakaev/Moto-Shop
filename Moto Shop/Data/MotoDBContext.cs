using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moto_Shop.Data.Models;
using Moto_Shop.Data.Models.Equipment;

namespace Moto_Shop.Data
{
    public class MotoDBContext : DbContext
    {
        public MotoDBContext
            (DbContextOptions<MotoDBContext> options)
            :base(options)
        {

        }
        public MotoDBContext()
        {

        }
        public DbSet<Product> Moto { get; set; }
        public DbSet<ModelMotorcycle> MotoModels { get; set; }
        public DbSet<Clothing> Clothings { get; set; }
        public DbSet<MotoShopItem> MotoShopItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrdersDetails { get; set; }
    
    }
}
