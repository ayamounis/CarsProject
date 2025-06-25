using CarsProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CarsProject.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DashboardController : Controller
    {
        private readonly CarsContext context;

        public DashboardController(CarsContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            ViewBag.TotalUsers = context.Users.Count();
            ViewBag.TotalCars = context.Cars.Count();
            ViewBag.TotalOrders = context.Orders.Count();
            ViewBag.TotalReviews = context.Reviews.Count();

            var cars = context.Cars.Include(c => c.Category).ToList();
            return View("Dashboard", cars);
        }



        // Car Controller Actions

        // ================ ADD ACTIONS ================

        [HttpGet]
        public IActionResult Add()
        {
            LoadCategories();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Car car)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    context.Cars.Add(car);
                    context.SaveChanges();
                    TempData["SuccessMessage"] = "Car added successfully!";
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "An error occurred while saving the car. Please try again.");
                    // Log the exception here if you have logging configured
                }
            }

            // إعادة تحميل الكاتيجوري في حالة الخطأ
            LoadCategories();
            return View(car);
        }

        // ================ EDIT ACTIONS ================

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var car = context.Cars.FirstOrDefault(c => c.Id == id);

            if (car == null)
            {
                TempData["ErrorMessage"] = "Car not found!";
                return RedirectToAction("Index");
            }

            LoadCategories();
            return View(car);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Car car)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // التأكد من وجود السيارة
                    var existingCar = context.Cars.FirstOrDefault(c => c.Id == car.Id);
                    if (existingCar == null)
                    {
                        TempData["ErrorMessage"] = "Car not found!";
                        return RedirectToAction("Index");
                    }

                    // تحديث البيانات
                    existingCar.Name = car.Name;
                    existingCar.Description = car.Description;
                    existingCar.ImageUrl = car.ImageUrl;
                    existingCar.Price = car.Price;
                    existingCar.Condition = car.Condition;
                    existingCar.Status = car.Status;
                    existingCar.Color = car.Color;
                    existingCar.Transmission = car.Transmission;
                    existingCar.CategoryId = car.CategoryId;

                    context.SaveChanges();
                    TempData["SuccessMessage"] = "Car updated successfully!";
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "An error occurred while updating the car. Please try again.");
                    // Log the exception here if you have logging configured
                }
            }

            // إعادة تحميل الكاتيجوري في حالة الخطأ
            LoadCategories();
            return View(car);
        }

        // ================ HELPER METHOD ================

        private void LoadCategories()
        {
            var categories = new List<SelectListItem>
    {
        new SelectListItem { Value = "", Text = "-- Select Category --", Disabled = true }
    };

            categories.AddRange(context.Categories
                .OrderBy(c => c.Name)
                .Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                }));

            ViewBag.Categories = categories;
        }

        // ================ ADDITIONAL HELPER METHODS ================

        // للحصول على خيارات Status
        private void LoadStatusOptions()
        {
            ViewBag.StatusOptions = new List<SelectListItem>
    {
        new SelectListItem { Value = "", Text = "-- Select Status --", Disabled = true },
        new SelectListItem { Value = "Available", Text = "Available" },
        new SelectListItem { Value = "Sold", Text = "Sold" }
    };
        }

        // للحصول على خيارات Condition
        private void LoadConditionOptions()
        {
            ViewBag.ConditionOptions = new List<SelectListItem>
    {
        new SelectListItem { Value = "", Text = "-- Select Condition --", Disabled = true },
        new SelectListItem { Value = "New", Text = "New" },
        new SelectListItem { Value = "Used", Text = "Used" }
    };
        }

        // للحصول على خيارات Transmission
        private void LoadTransmissionOptions()
        {
            ViewBag.TransmissionOptions = new List<SelectListItem>
    {
        new SelectListItem { Value = "", Text = "-- Select Transmission --", Disabled = true },
        new SelectListItem { Value = "Automatic", Text = "Automatic" },
        new SelectListItem { Value = "Manual", Text = "Manual" }
    };
        }

        // استخدم هذا المتهود لتحميل كل الخيارات مرة واحدة
        private void LoadAllOptions()
        {
            LoadCategories();
            LoadStatusOptions();
            LoadConditionOptions();
            LoadTransmissionOptions();
        }
        // ================ DELETE ACTIONS ================

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var car = context.Cars
                .Include(c => c.Category) // عشان نعرض اسم الكاتيجوري
                .FirstOrDefault(c => c.Id == id);

            if (car == null)
            {
                TempData["ErrorMessage"] = "Car not found!";
                return RedirectToAction("Index");
            }

            return View("Delete", car);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            try
            {
                var car = context.Cars.FirstOrDefault(c => c.Id == id);

                if (car == null)
                {
                    TempData["ErrorMessage"] = "Car not found!";
                    return RedirectToAction("Index");
                }

                // التحقق من وجود علاقات قبل الحذف (اختياري)
                var hasReviews = context.Set<Review>().Any(r => r.CarId == id);
                var hasCartItems = context.Set<CartItem>().Any(ci => ci.CarId == id);
                var hasOrderItems = context.Set<OrderItem>().Any(oi => oi.CarId == id);

                if (hasReviews || hasCartItems || hasOrderItems)
                {
                    TempData["ErrorMessage"] = "Cannot delete this car because it has related records (reviews, cart items, or orders).";
                    return RedirectToAction("Index");
                }

                context.Cars.Remove(car);
                context.SaveChanges();

                TempData["SuccessMessage"] = $"Car '{car.Name}' has been deleted successfully!";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "An error occurred while deleting the car. Please try again.";
                // Log the exception here if you have logging configured
                return RedirectToAction("Index");
            }
        }

    }
 }
