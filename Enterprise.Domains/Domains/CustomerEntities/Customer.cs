using Enterprise.Domains.Domains.Generic;
using Enterprise.Domains.Domains.OrderEntities;

namespace Enterprise.Domains.Domains.CustomerEntities;

public class Customer
{
    private Customer(int customerId, string customerName, Address address, decimal pendingAmount, List<CustomerOrder> customerOrders)
    {
        CustomerId = customerId;
        CustomerName = customerName;
        Address = address;
        PendingAmount = pendingAmount;
        CustomerOrders = customerOrders;
    }
    public int CustomerId { get; }
    public string CustomerName { get; }
    public Address Address { get; }
    public decimal PendingAmount { get; }
    public IReadOnlyCollection<CustomerOrder> CustomerOrders { get; }

    public static Customer Create(int customerId, string customerName, Address address, decimal pendingAmount, List<CustomerOrder> customerOrders)
    {
        return new Customer(customerId, customerName, address, pendingAmount, customerOrders);
    }
}