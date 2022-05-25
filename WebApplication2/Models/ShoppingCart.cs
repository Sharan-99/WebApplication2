using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class ShoppingCart
    {
        public String CartId { get; set; }
        public String ItemName { get; set; }
        public int Price { get; set; }
        public string ItemType { get; set; }

        public ShoppingCart(String cartId, String itemName, int price, String itemType)
        {
            this.ItemName = itemName;
            this.CartId = cartId;
            this.Price = price;
            this.ItemType = itemType;
        }
    }
}