using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moto_Shop.Data.Models;
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
        public DbSet<Motorcycle> Moto { get; set; }
        public DbSet<ModelMotorcycle> MotoModel { get; set; }
        public DbSet<MotoShopItem> MotoShopItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrdersDetails { get; set; }
    
    }
}
