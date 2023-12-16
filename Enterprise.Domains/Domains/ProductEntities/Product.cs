namespace Enterprise.Domains.Domains.ProductEntities;

public class Product
{
    public Product(int productId, string productName, decimal currentPrice)
    {
        ProductId = productId;
        ProductName = productName;
        CurrentPrice = currentPrice;
    }
    public int ProductId { get; }
    public string ProductName { get; }
    public decimal CurrentPrice { get; }

    public static Product Create(int productId, string productName, decimal currentPrice)
    {
        return new Product(productId, productName, currentPrice);
    }
}