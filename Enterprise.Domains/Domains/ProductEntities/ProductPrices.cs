namespace Enterprise.Domains.Domains.ProductEntities;

public class ProductPrices
{
    private ProductPrices(int productPriceVersionId, DateTime startedOn, DateTime? endOn, bool flagLatest, Product product)
    {
        ProductPriceVersionId = productPriceVersionId;
        StartedOn = startedOn;
        EndOn = endOn;
        FlagLatest = flagLatest;
        Product = product;
    }
    public int ProductPriceVersionId { get; }
    public DateTime StartedOn { get; }
    public DateTime? EndOn { get; }
    public bool FlagLatest { get; }
    public Product Product { get; set; }

    public static ProductPrices Create(int productPriceVersionId, DateTime startedOn, DateTime? endOn, bool flagLatest, Product product)
    {
        return new ProductPrices(productPriceVersionId, startedOn, endOn, flagLatest, product);
    }
}