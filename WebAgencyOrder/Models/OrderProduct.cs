//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAgencyOrder.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderProduct
    {
        public int TotalProductQuantity { get; set; }
        public double TotalProductPrice { get; set; }
        public string OrderID { get; set; }
        public string ItemsID { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual OrderReceipt OrderReceipt { get; set; }
    }
}
