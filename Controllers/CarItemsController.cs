using CarsProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarsProject.Controllers
{
    public class CarItemsController : Controller
    {
        private readonly CarsContext _context;
        private readonly UserManager<User> _userManager;

        public CarItemsController(CarsContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // index
        public async Task<IActionResult> Index(string searchString, string category, string sortBy, int page = 1)
        {
            int pageSize = 6;
            var carsQuery = _context.Cars.Include(c => c.Category).AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                carsQuery = carsQuery.Where(c => c.Name.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(category))
            {
                carsQuery = carsQuery.Where(c => c.Category.Name == category);
            }

            // Sort
            carsQuery = sortBy switch
            {
                "price_asc" => carsQuery.OrderBy(c => c.Price),
                "price_desc" => carsQuery.OrderByDescending(c => c.Price),
                "name" => carsQuery.OrderBy(c => c.Name),
                _ => carsQuery.OrderByDescending(c => c.Id),
            };

            var totalCars = await carsQuery.CountAsync();
            var cars = await carsQuery
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            
            ViewBag.Categories = await _context.Categories.Select(c => c.Name).ToListAsync();
            ViewBag.CurrentSearch = searchString;
            ViewBag.CurrentCategory = category;
            ViewBag.CurrentSort = sortBy;
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling((double)totalCars / pageSize);
            ViewBag.HasPreviousPage = page > 1;
            ViewBag.HasNextPage = page < ViewBag.TotalPages;

            return View(cars);
        }

        // details
        public async Task<IActionResult> Details(int id)
        {
            var car = await _context.Cars
                .Include(c => c.Category)
                .Include(c => c.Reviews)
                    .ThenInclude(r => r.User)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (car == null) return NotFound();

            ViewBag.AverageRating = car.Reviews?.Any() == true ? car.Reviews.Average(r => r.Rating) : 0;
            ViewBag.TotalReviews = car.Reviews?.Count ?? 0;

            return View(car);
        }

        // add to cart
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddToCart(int carId, int quantity)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return RedirectToAction("Login", "Account");

            var car = await _context.Cars.FindAsync(carId);
            if (car == null || car.Status != "Available")
            {
                TempData["Error"] = "Car is not available.";
                return RedirectToAction("Details", new { id = carId });
            }

            var cartItem = await _context.CartItems
                .FirstOrDefaultAsync(ci => ci.CarId == carId && ci.UserId == user.Id);

            if (cartItem != null)
            {
                cartItem.Quantity += quantity;
            }
            else
            {
                cartItem = new CartItem
                {
                    CarId = carId,
                    Quantity = quantity,
                    UserId = user.Id
                };
                _context.CartItems.Add(cartItem);
            }

            await _context.SaveChangesAsync();
            TempData["Success"] = "Car added to cart!";
            return RedirectToAction("Index", "Cart");
        }

        // add reviews
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddReview(int carId, int rating, string content)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return RedirectToAction("Login", "Account");

            if (rating < 1 || rating > 5 || string.IsNullOrWhiteSpace(content))
            {
                TempData["Error"] = "Invalid review data.";
                return RedirectToAction("Details", new { id = carId });
            }

            var review = new Review
            {
                CarId = carId,
                Rating = rating,
                Content = content,
                UserId = user.Id
            };

            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();

            TempData["Success"] = "Thanks for your review!";
            return RedirectToAction("Details", new { id = carId });
        }
    }
}
