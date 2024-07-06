namespace NET1814_MilkShop.Repositories.Models.OrderModels;

public class OrderHistoryModel
{
    public Guid OrderId { get; set; }
    public int TotalAmount { get; set; }

    public string? PaymentMethod { get; set; }
    public string? OrderStatus { get; set; }
    public DateTime CreatedAt { get; set; }
    public object? ProductList { get; set; }
}