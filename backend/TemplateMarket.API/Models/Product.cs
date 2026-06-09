namespace TemplateMarket.API.Models;

public class Product
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public string ImageUrl { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }

    public int SellerId { get; set; }

    public User? Seller { get; set; }
}