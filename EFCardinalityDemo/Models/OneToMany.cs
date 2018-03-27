using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using static EFCardinalityDemo.Models.OneToMany;

namespace EFCardinalityDemo.Models
{
    public class OneToMany
    {

        public class Product
        {
            [Key]
            public int ProductId { get; set; }
            public decimal CostPrice { get; set; }
            public string ProductName { get; set; }
            public string ProductModel { get; set; }
            public string Description { get; set; }
            public virtual ICollection<ProductImages> ProductImages { get; set; }
        }


        public class ProductImages
        {
            [Key]
            public int ProductImageId { get; set; }
            public string ImageUrl { get; set; }

            [ForeignKey("Product")]
            public int ProductId { get; set; }
            public Product Product { get; set; }
        }
    }
}