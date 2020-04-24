using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ProNCat.Models;
using Microsoft.EntityFrameworkCore;

namespace ProNCat.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        public HomeController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            // List<Product> getAll = _context.Products.Include( p => p.Categories )
            //                                         .ThenInclude( a => a.Category )
            //                                         .ToList();
            ViewBag.AllProducts = _context.Products.ToList();
            return View();
        }
        [HttpPost("create/product")]
        public IActionResult Product(Product newProduct)
        {
            if(ModelState.IsValid)
            {
                _context.Products.Add(newProduct);
                _context.SaveChanges();
                return Redirect("/");
            }
            else
            {
                return Redirect("/");
            }
        }

        [HttpGet("categories")]
        public IActionResult Category()
        {
            ViewBag.AllCategories = _context.Categories.ToList();
            return View("Category");
        }
        [HttpPost("create/category")]
        public IActionResult Category(Category newCategory)
        {
            if(ModelState.IsValid)
            {
                _context.Categories.Add(newCategory);
                _context.SaveChanges();
                return Redirect("/categories");
            }
            else
            {
                return Redirect("/categories");
            }
        }

        [HttpGet("product/{ID}")]
        public IActionResult DisplayProduct(int ID)
        {
            Product getOne = _context.Products.Include( p => p.Categories)
                                              .ThenInclude( a => a.Category)
                                              .FirstOrDefault(p => p.ProductId == ID);
            ViewBag.AllCategories = _context.Categories.Include( c => c.Products)
                                                       .ThenInclude( a => a.Product)
                                                       .ToList();
            return View(getOne);
        }

        [HttpGet("category/{ID}")]
        public IActionResult DisplayCategory(int ID)
        {
            Category getOne = _context.Categories.Include(c => c.Products)
                                                 .ThenInclude(a => a.Product)
                                                 .FirstOrDefault(p => p.CategoryId == ID);
            ViewBag.AllProducts = _context.Products.Include( p => p.Categories)
                                                   .ThenInclude( a => a.Category)
                                                   .ToList();
            return View(getOne);
        }

        [HttpPost("product/{proID}/category")]
        public IActionResult AddCategory(int proID, int catID)
        {
            Association productCat = new Association();
            productCat.ProductId = proID;
            productCat.CategoryId = catID;
            _context.Associations.Add(productCat);
            _context.SaveChanges();
            return Redirect($"/product/{proID}");
        }
        [HttpPost("category/{catID}/product")]
        public IActionResult AddProduct(int catID, int proID)
        {
            Association categoryPro = new Association();
            categoryPro.CategoryId = catID;
            categoryPro.ProductId = proID;
            _context.Associations.Add(categoryPro);
            _context.SaveChanges();
            return Redirect($"/category/{catID}");
        }











        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
