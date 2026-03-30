using EquipmentRentalSystem.Models;
using EquipmentRentalSystem.Services;

var service = new RentalService();

var student = new Student
{
    FirstName = "Patryk",
    LastName = "Banach"
};

var laptop = new Laptop
{
    Name = "Dell Precision 5560",
    Ram = 32,
    Processor = "i7"
};

Console.WriteLine("=== RENT ===");
service.RentEquipment(student, laptop);

Console.WriteLine("=== BAD TRY ===");
try
{
    service.RentEquipment(student, laptop);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("=== RETURN ===");
var rental = service.GetActiveRentals(student).FirstOrDefault();

if (rental == null)
{
    Console.WriteLine("No active rental");
    return;
}
service.ReturnEquipment(rental);
