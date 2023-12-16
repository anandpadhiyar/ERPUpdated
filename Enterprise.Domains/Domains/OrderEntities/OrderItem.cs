using Enterprise.Domains.Domains.ProductEntities;

namespace Enterprise.Domains.Domains.OrderEntities;

public class OrderItem
{
    public OrderItem(int orderItemId, Product product, int quantity)
    {
        OrderItemId = orderItemId;
        Product = product;
        Quantity = quantity;
    }

    public int OrderItemId { get; }
    public Product Product { get; }
    public int Quantity { get; }

    public static OrderItem Create(int orderItemId, Product product, int quantity)
    {
        return new OrderItem(orderItemId, product, quantity);
    }
}