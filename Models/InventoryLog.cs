namespace UniversityKitchen.Models // Loyihangiz nomi bo‘yicha to‘g‘rilang
{
    public class InventoryLog
    {
        public int Id { get; set; }
        public int InventoryId { get; set; }
        public Inventory Inventory { get; set; } // Inventory ishlaydi
        public InventoryChangeType ChangeType { get; set; }
        public int Quantity { get; set; }
        public DateTime ChangedAt { get; set; }
    }
}
