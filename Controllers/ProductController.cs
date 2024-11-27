using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StoreApp.Models;

namespace StoreApp.Controllers
{
    
   
    public class ProductController : Controller
    {
        private readonly RepositoryContext  _context;

        public ProductController(RepositoryContext context)
        {
            _context = context;
        }

    //     public IEnumerable<Product> Index(){
    //     // var context = new RepositoryContext(
    //     //     new DbContextOptionsBuilder<RepositoryContext>()
    //     //     .UseSqlite("Data Source = C:\\sqlitedbs\\ProductDb.db")
    //     //     .Options
    //     // );

    //      return _context.Products;

    //    }
       public IActionResult Index(){
        var model = _context.Products.ToList();
        return View(model);
       }

       public IActionResult Get(int id){
         var product = _context.Products.FirstOrDefault(p => p.ProductId == id);
    if (product == null)
    {
        return NotFound("The requested product was not found.");
    }

    return View(product);
       }


        

    
    }
}