namespace Enterprise.Domains;

public class Shop
{
    public int ShopId { get; set; }
    public string? ShopName { get; set; }
    public string? ShopAddressLine1 { get; set; }
    public string? ShopAddressLine2 { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }

    public Shop(string? shopName, string? shopAddressLine1, string? shopAddressLine2)
    {
        ShopName = shopName;
        ShopAddressLine1 = shopAddressLine1;
        ShopAddressLine2 = shopAddressLine2;
    }
}
