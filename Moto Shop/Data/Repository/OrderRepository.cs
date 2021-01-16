using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moto_Shop.Data.Interfaces;
using Moto_Shop.Data.Models;

namespace Moto_Shop.Data.Repository
{
    public class OrderRepository : IAllOrders
    {
        private readonly MotoDBContext MotoDB;
        private readonly ShopBasket Basket;

        public OrderRepository(MotoDBContext motoDBContext, ShopBasket shopBasket)
        {
            this.MotoDB = motoDBContext;
            this.Basket = shopBasket;
        }

        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            MotoDB.Orders.Add(order);

            var items = Basket.ListShopItems;
            foreach(var el in items)
            {
                var orderDetails = new OrderDetails()
                {
                    ProductId = el.Moto.Id,
                    OrderId = order.Id,
                    Price = el.Moto.Price
                };
                MotoDB.OrdersDetails.Add(orderDetails);

            }
            MotoDB.SaveChanges();
        }
    }
}
