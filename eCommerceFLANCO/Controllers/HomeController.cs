using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerceFLANCO.Models;

namespace eCommerceFLANCO.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [Route("Default")]
        public ActionResult Index()
        {
            
            return View();
        }

        [HttpGet]
        public ActionResult GetNavigation()
        {
            var categories = db.Categories.Include(c => c.Parent).ToList();
            return PartialView(@"~/Views/Shared/_navigation.cshtml",categories);
        }

        [HttpGet]
        public ActionResult GetCategoriesWidget()
        {
            var categories = db.Categories.Include(c => c.Parent).ToList();
            return PartialView(@"~/Views/Home/Widgets/categories.cshtml", categories);
        }

        [HttpGet]
        public ActionResult GetBrandsWidget()
        {
            var brands = db.Brands.Take(8).ToList();
            return PartialView(@"~/Views/Home/Widgets/brands.cshtml", brands);
        }

        [HttpGet]
        public ActionResult GetProducts()
        {
            var products = db.Products
                .Take(10)
                .Include(c => c.Category)
                .ToList();
            return PartialView(@"~/Views/Home/Widgets/main.cshtml", products);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}