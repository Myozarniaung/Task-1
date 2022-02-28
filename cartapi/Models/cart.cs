using System;
namespace cartapi.Models
{
    public class cart
    {
        public int cartId { get; set; }
        public int productId { get; set; }
        public double price { get; set; }
        public int total { get; set; }
        public string orderId { get; set; }
        public string Status { get; set; }
    }
}
