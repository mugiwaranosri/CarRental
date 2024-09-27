using CarRental.Areas.Identity.Data;
using Microsoft.AspNetCore.Mvc;

public class CustomerController : Controller
{
    private readonly ApplicationDbContext _context;

    public CustomerController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var customers = _context.Customers.ToList();
        return View(customers);
    }

    // Add, Edit, Delete methods
}
