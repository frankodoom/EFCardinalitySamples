using EFCardinalityDemo.Context;
using EFCardinalityDemo.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using static EFCardinalityDemo.Models.OneToMany;

namespace EFCardinalityDemo.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ProductViewModel model, IEnumerable<HttpPostedFileBase> files)
        {
            
            using (var _context = new EfDbContext())
            {               
                var product = new Product();
                product.CostPrice = model.CostPrice;
                product.Description = model.Description;
                product.ProductModel = model.ProductModel;
                product.ProductName = model.ProductName;                      
                  
                 foreach (var file in files)
                {
                    string _FileName = Path.GetFileName(file.FileName);
                    string _path = Path.Combine(Server.MapPath("~/Uploads"), _FileName);
                    var productImages = new ProductImages(){
                        ImageUrl = file.FileName,                   
                    };

                    file.SaveAs(_path);
                    _context.ProductImages.Add(productImages);
                   
                }

                 //productImages.Product = product;             
                _context.Products.Add(product);
             ;

                if (await _context.SaveChangesAsync() > 0)
                {
                    ViewBag.Message = "New Product Created Successfully";

                    return View();
                }
            }

            return View();
        }
    }
}