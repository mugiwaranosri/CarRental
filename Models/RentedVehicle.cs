public class RentedVehicle
{
    public int Id { get; set; }
    public int CarId { get; set; }
    public int CustomerId { get; set; }
    public DateTime RentedDate { get; set; }
    public DateTime ReturnDate { get; set; }
    public decimal Fee { get; set; }
}
