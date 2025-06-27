using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CarsProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CarsProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CarsContext _context;

        public HomeController(ILogger<HomeController> logger, CarsContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var featuredCars = _context.Cars
                .Include(c => c.Category)
                .Where(c => c.Status == "Available")
                .GroupBy(c => c.Name)
                .Select(g => g.First())
                .OrderBy(c => Guid.NewGuid())
                .Take(6)
                .ToList();


            ViewBag.TotalCars = _context.Cars.Count(c => c.Status == "Available");
            ViewBag.TotalCategories = _context.Categories.Count();
            ViewBag.HappyCustomers = _context.Users.Count();

            return View(featuredCars);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
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