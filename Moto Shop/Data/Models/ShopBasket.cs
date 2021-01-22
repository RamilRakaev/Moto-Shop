using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moto_Shop.Data.Models
{
    public class ShopBasket
    {
        private readonly MotoDBContext motoDB;
        public ShopBasket(MotoDBContext motoDBContext)
        {
            this.motoDB = motoDBContext;
            //this.ListShopItems = motoDB.MotoShopItems.ToList();
        }
        public string ShopBasketId { get; set; }
        public List<MotoShopItem> ListShopItems { get; set; }

        public static ShopBasket GetBasket(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = service.GetService<MotoDBContext>();
            string shopBasketId = session.GetString("MotoId") ?? Guid.NewGuid().ToString();
            session.SetString("MotoId", shopBasketId);

            return new ShopBasket(context) { ShopBasketId = shopBasketId };
        }

        public void AddToMoto(Product moto)
        {
            this.motoDB.MotoShopItems.Add(new MotoShopItem()
            {
                ShopBasketId = this.ShopBasketId,
                MotoId = moto.Id,
                Moto=moto,
                Price = moto.Price
            });
            motoDB.SaveChanges();
        }

        public List<MotoShopItem> GetItems()
        {
            var items= motoDB.MotoShopItems.Where(m => m.ShopBasketId == this.ShopBasketId)
                .ToList();
            foreach(MotoShopItem item in items)
            {
                item.Moto = motoDB.Moto.Where(m => m.Id == item.MotoId).FirstOrDefault();
            }
            return items;
        }
    }
}
