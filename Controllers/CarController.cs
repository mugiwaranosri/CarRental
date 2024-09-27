using CarRental.Areas.Identity.Data;
using Microsoft.AspNetCore.Mvc;

public class CarController : Controller
{
    private readonly ApplicationDbContext _context;

    public CarController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var cars = _context.Cars.ToList();
        return View(cars);
    }

    // Create, Edit, Delete methods
}