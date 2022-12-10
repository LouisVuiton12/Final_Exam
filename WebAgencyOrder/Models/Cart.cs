using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAgencyOrder.Models
{
    public class Cart
    {
        private object value;

        public Item Product { get; set; }
        public int Quantity { get; set; }

        public Cart(Item product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public Cart(object value)
        {
            this.value = value;
        }
    }
}