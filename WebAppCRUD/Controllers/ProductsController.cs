using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.ModelBinding;
using System.Web.Mvc;
using WebAppCRUD.Models;
using WebAppCRUD.Models.ViewModels;

namespace WebAppCRUD.Controllers
{
    public class ProductsController : Controller
    {
      
        ProductContext _productContext;
        public ProductsController()
        {
            _productContext = new ProductContext();
        }
        public ActionResult Error(ErrorViewModel errorViewModel)
        {
            return View(errorViewModel);
        }
        // GET: Products
        public ActionResult Index()
        {
            var model = _productContext.GetProducts();
            return View(model);
        }


        public ActionResult Test() 
        {
                try
                {
                    throw new Exception("Operation n'est pas permise");

                }
                catch (Exception ex)
                {
                    ErrorViewModel errorViewModel = new ErrorViewModel
                    {
                        Message = ex.Message,
                        Time = DateTime.Now,
                        Severity = Severity.FatalError
                    };
                
                    //Ecrire ici un code alternatif
                    return View("Error", errorViewModel);
                }
        }
        


        //GET  localhost:port/Products/Create
        public ActionResult Create()
        {
            return View();
        }


        //[HttpPost] //C'est la où l'operation d'ajout dans la base va être faite
        //public ActionResult Create([Bind(Include = "Id,Label,Category,Price")] Product product)  // <= Il faut passer les paramètres dans méthode create
        //{
        //    if(ModelState.IsValid)
        //    {
        //        _productContext.Add(product);
        //    }
        //    return View();
        //}

        //// GET localhost:port/Edit/1
        //public ActionResult Edit(int? id)
        //{
        //    Product product = _productContext.GetProduct(id??-9999); 
        //    if(id==null ||product==null)
        //    {
        //        RedirectToAction("Error");
        //    }
        //    ProductViewModel model = new ProductViewModel
        //    {
        //        Id = product.Id,
        //        Label = product.Label,
        //        Category = product.Category,
        //        Price = product.Price,
        //    }; 

        //   return View(model);
        //}

        //[HttpPost] //C'est la où l'operation d'ajout dans la base va être faite
        //public ActionResult Create(ProductViewModel productVM)  // <= Il faut passer les paramètres dans méthode create
        //{
        //    Product product;
        //    if (ModelState.IsValid)
        //    {
        //        product = new Product
        //        {
        //            Id = productVM.Id,
        //            Label = productVM.Label,
        //            CategoryId = _productContext.products
        //            .SingleOrDefault(p => p.Label == productVM.Category).Id,
        //            Price = productVM.Price,
        //        };
        //        _productContext.Add(product);
        //    }
        //    return View(productVM);
        //}

        //[HttpPost]
        //public ActionResult Edit([Bind(Include = "Id,Label,Category,Price")] Product product)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _productContext.Update(product.Id, product);
        //    }
        //    return View(product);
        //}

        [HttpPost]
        public ActionResult Edit(ProductViewModel productVM)
        {
            Product product = new Product();
           

            if (ModelState.IsValid)
            {
                product.Id = productVM.Id;
                product.Label = productVM.Label;
                //product.CategoryId = _productContext.categroies
                //    .SingleOrDefault(c=>c.Label == productVM.Label).Id;
                product.Category = productVM.Category;
                product.Price = productVM.Price;
                
                _productContext.Update(product.Id, product);
            }
            return View(productVM);
        }

        // GET localhost:port/Details/1
        public ActionResult Details(int? id)
        {
            Product product = _productContext.GetProduct(id ?? -9999);
            if (id == null || product == null)
            {
                RedirectToAction("Error");
            }
            return View(product);
        }

        //GET localhost:port/Delete/3
        public ActionResult Delete(int? id)
        {
            Product product = _productContext.GetProduct(id ?? -9999);
            if(id==null ||product==null)
            {
                RedirectToAction("Error");
            }
            _productContext.Delete(product.Id);
            return View();
        }
 
      
    }
}