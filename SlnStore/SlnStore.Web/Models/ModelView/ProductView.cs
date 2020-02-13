using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlnStore.Web.Models.ModelView
{
    public class ProductView
    {
        public string NameProduct { get; set; }
        public decimal PriceUnit { get; set; }
        public int Stock { get; set; }
        public System.DateTime ExpirationDate { get; set; }
    }
}