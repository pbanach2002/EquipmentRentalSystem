namespace EquipmentRentalSystem.Models;

public abstract class User
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public abstract int MaxRentals { get; }
}