using Microsoft.AspNetCore.Mvc;
using Task_Lg.Models;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Task_Lg.Controllers
{
    public class ProductBaseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductBaseController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            ViewBag.CategoryTypes = Enum.GetValues(typeof(CategoryType)).Cast<CategoryType>().ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductViewModel model)
        {
            if (model.ProductBase.CategoryType == CategoryType.Labtop)
            {
                
                
                    var labtop = new LabtopProduct
                    {
                        Name = model.ProductBase.Name,
                        Model = model.LabtopProduct.Model,
                        Type = model.LabtopProduct.Type,
                        Ram = model.LabtopProduct.Ram,
                        Prossecor = model.LabtopProduct.Prossecor,

                        CategoryType = CategoryType.Labtop,
                    };
                    _context.Products.Add(labtop);
                
            }
            else if (model.ProductBase.CategoryType == CategoryType.Printer)
            {
                var printer = new PrinterProduct
                {
                    Name = model.ProductBase.Name,
                    Brand = model.PrinterProduct.Brand,
                    Model = model.PrinterProduct.Model,
                    ip = model.PrinterProduct.ip,
                    CategoryType = CategoryType.Printer

                };
                _context.Products.Add(printer);
            }
            else if (model.ProductBase.CategoryType == CategoryType.Router)
            {
                var router = new RouterProduct
                {
                    Name = model.ProductBase.Name,
                    Speed = model.RouterProduct.Speed,
                    Model = model.RouterProduct.Model,
                    ip = model.RouterProduct.ip,
                    NumberOfPorts = model.RouterProduct.NumberOfPorts,

                    CategoryType = CategoryType.Router

                };
                _context.Products.Add(router);
            }
            else if (model.ProductBase.CategoryType == CategoryType.Screen)
            {
                var screen = new ScreenProduct
                {
                    Name = model.ProductBase.Name,
                    Color = model.ScreenProduct.Color,
                    Size = model.ScreenProduct.Size,
                    Quality = model.ScreenProduct.Quality,

                    CategoryType = CategoryType.Screen

                };
                _context.Products.Add(screen);
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }
       

        public IActionResult GetCategoryFields(CategoryType categoryType)
        {
            if (categoryType == CategoryType.Labtop)
            {
                return PartialView("_LabtopFields");
            }
            else if (categoryType == CategoryType.Printer)
            {
                return PartialView("_PrinterFields");
            }
            else if (categoryType == CategoryType.Screen)
            {
                return PartialView("_ScreenFields");
            }
            else if (categoryType == CategoryType.Router)
            {
                return PartialView("_RouterFields");
            }

            return BadRequest();
        }
    }
}
