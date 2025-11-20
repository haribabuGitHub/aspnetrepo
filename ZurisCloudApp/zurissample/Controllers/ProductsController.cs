using Microsoft.AspNetCore.Mvc;
using zurissample.Models;

namespace zurissample.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        // GET: /Products
        public IActionResult Index()
        {
            // Return a static list of products as the model for the view
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Price = 9.99m },
                new Product { Id = 2, Name = "Product 2", Price = 19.99m },
                new Product { Id = 3, Name = "Product 3", Price = 29.99m }
            };

            return View(products);
        }

        // GET: /Products/Details/5
        public IActionResult Details(int id)
        {
            ViewData["ProductId"] = id;
            return View();
        }
    }
}