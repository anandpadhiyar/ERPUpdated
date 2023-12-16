namespace Enterprise.Domains.Domains.OrderEntities;

public class CustomerOrder
{
    private CustomerOrder(int customerOrderId, DateTime orderDate, decimal orderAmount, List<OrderItem> orderItems)
    {
        CustomerOrderId = customerOrderId;
        OrderDate = orderDate;
        OrderAmount = orderAmount;
        OrderItems = orderItems;
    }
    public int CustomerOrderId { get; }
    public DateTime OrderDate { get; }
    public decimal OrderAmount { get; }
    public IReadOnlyCollection<OrderItem> OrderItems { get; }

    public static CustomerOrder Create(int customerOrderId, DateTime orderDate, decimal orderAmount, List<OrderItem> orderItems)
    {
        return new CustomerOrder(customerOrderId, orderDate, orderAmount, orderItems);
    }
}