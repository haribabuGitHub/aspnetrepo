using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using zurissample.Models;

namespace zurissample.Controllers
{
    /// <summary>
    /// Handles HTTP requests for the home page and error handling.
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="logger">The logger instance for this controller.</param>
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Displays the home page.
        /// </summary>
        /// <returns>The Index view.</returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Displays the privacy policy page.
        /// </summary>
        /// <returns>The Privacy view.</returns>
        public IActionResult Privacy()
        {
            return View();
        }

        /// <summary>
        /// Handles application errors and displays the error page.
        /// </summary>
        /// <returns>The Error view with the current request identifier.</returns>
        /// <remarks>
        /// This action disables response caching to ensure error pages are not cached.
        /// </remarks>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
