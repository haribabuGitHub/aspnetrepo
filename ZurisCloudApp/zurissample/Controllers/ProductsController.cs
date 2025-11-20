using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
            return View();
        }

        // GET: /Products/Details/5
        public IActionResult Details(int id)
        {
            ViewData["ProductId"] = id;
            return View();
        }
    }
}