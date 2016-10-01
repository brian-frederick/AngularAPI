using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularAPI.Models
{
    public class ProductModel
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public object Image { get; set; }
        public List<Review> Reviews { get; set; }
        public bool CanPurchase { get; set; }
        public bool SoldOut { get; set; }
    }
}