using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsDeliveryNote
{
    public class OrderProduct
    {
        public int OrderID { get; set; }
        public string ItemsID { get; set; }
        public double TotalProductPrice { get; set; }
        public int TotalProductQuantity { get; set; }
    }
}
