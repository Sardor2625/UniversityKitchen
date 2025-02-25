namespace UniversityKitchen.Models;

public class Payment
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public Order Order { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public decimal Amount { get; set; }
    public PaymentStatus PaymentStatus { get; set; } // Enum ishlatilmoqda
    public DateTime CreatedAt { get; set; }
}
