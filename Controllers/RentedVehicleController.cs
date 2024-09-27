using Microsoft.AspNetCore.Mvc;

public class RentedVehicleController : Controller
{
    private readonly CarRentalContext _context;

    public RentedVehicleController(CarRentalContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var rentedVehicles = _context.RentedVehicles
            .Include(r => r.Car)
            .Include(r => r.Customer)
            .ToList();
        return View(rentedVehicles);
    }

    [HttpPost]
    public IActionResult Return(int id)
    {
        var rentedVehicle = _context.RentedVehicles.Find(id);
        if (rentedVehicle != null)
        {
            rentedVehicle.IsReturned = true;
            rentedVehicle.ReturnDate = DateTime.Now;
            _context.SaveChanges();
        }
        return RedirectToAction("Index");
    }
}
