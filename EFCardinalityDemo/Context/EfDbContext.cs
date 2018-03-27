using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using static EFCardinalityDemo.Models.OneToMany;

namespace EFCardinalityDemo.Context
{
    public class EfDbContext: DbContext
    {

        public EfDbContext() : base("name=EfConn")
        {

        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductImages> ProductImages { get; set; }
    }
}