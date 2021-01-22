namespace Moto_Shop.Data.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public uint Price { get; set; }
        public virtual Product MotoId { get; set; }
        public virtual Order Order { get; set; }
    }
}