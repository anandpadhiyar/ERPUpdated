using Enterprise.Domains.Domains.CustomerEntities;
using Enterprise.Domains.Domains.Generic;

namespace Enterprise.Domains.Domains.ShopEntities;

public sealed class Shop
{
    private Shop(int shopId, string shopName, Address primaryAddress, List<Address> addresses, List<Customer> customers)
    {
        ShopId = shopId;
        ShopName = shopName;
        PrimaryAddress = primaryAddress;
        Addresses = addresses;
        Customers = customers;
    }
    public int ShopId { get; }
    public string ShopName { get; }
    public Address PrimaryAddress { get; }
    public List<Address> Addresses { get; }
    public List<Customer> Customers { get; }

    public static Shop Create(int shopId, string shopName, Address primaryAddress, List<Address> addresses, List<Customer> customers)
    {
        return new Shop(shopId, shopName, primaryAddress, addresses, customers);
    }
}