using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFCardinalityDemo.ViewModel
{
    public class ProductViewModel
    {
        public decimal CostPrice { get; set; }
        public string ProductName { get; set; }
        public string ProductModel { get; set; }
        public string Description { get; set; }
    }
}