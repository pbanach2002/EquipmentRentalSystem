using EquipmentRentalSystem.Models;
namespace EquipmentRentalSystem.Services;

public class RentalService
{
    private List<Rental> rentals = new();

    public void RentEquipment(User user, Equipment equipment)
    {
        if(!equipment.IsAvailable)
            throw new ArgumentException("Equipment is not available");
        var activeRentals = rentals.Count(r => r.User == user && r.ReturnDate == null);
        if (activeRentals >= user.MaxRentals)
            throw new ArgumentException("Rental is full");
        var rental = new Rental
        {
            User = user,
            Equipment = equipment,
            RentDate = DateTime.Now,
            ReturnDate = DateTime.Now.AddDays(7)
        };
        rentals.Add(rental);
        equipment.IsAvailable = false;
    }
}