namespace API.Mediatr_CQRS.Queries.Response;

public class GetAllProductQueryResponse
{
    public Guid ProductId { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public DateTime CreateTime { get; set; }
}