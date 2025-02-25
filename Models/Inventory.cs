namespace UniversityKitchen.Models;

public class Inventory
{
    public int Id { get; set; }
    public string Name { get; set; } // Mahsulot nomi
    public int Quantity { get; set; } // Omborda qancha bor
    public DateTime UpdatedAt { get; set; } // Oxirgi yangilanish vaqti
}
