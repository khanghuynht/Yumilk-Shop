namespace NET1814_MilkShop.Repositories.Models.OrderModels;

public class OrderDetailModel
{
    public string? RecieverName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public string? Note { get; set; }
    public List<CheckoutOrderDetailModel> OrderDetail { get; set; } = [];
    public int TotalPrice { get; set; }
    public int ShippingFee { get; set; }
    public int TotalAmount { get; set; }
    public string? PaymentMethod { get; set; }

    public string? OrderStatus { get; set; }
    public DateTime CreatedAt { get; set; }

    public object? PaymentData { get; set; }
}