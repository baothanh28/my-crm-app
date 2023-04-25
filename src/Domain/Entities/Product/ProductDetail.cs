

namespace CRM.Domain.Entities.Product;
public class ProductDetail : BaseAuditableEntity<Guid>
{
    public Guid Id { get; set; }
    public string SKU { get; set; }
    public string ModelNumber { get; set; }
    public string Brand { get; set; }
    public string Color { get; set; }
    public string Size { get; set; }
    public string Material { get; set; }
    public string Weight { get; set; }
    public string Dimensions { get; set; }
    public string Warranty { get; set; }
    public string AdditionalInfo { get; set; }
    public string ImageUrl { get; set; }
    public string VideoUrl { get; set; }
    public string ManualUrl { get; set; }
    public string BrochureUrl { get; set; }
    public DateTime ReleasedDate { get; set; }
    public DateTime LastModifiedDate { get; set; }
    public string Features { get; set; }
    public string Specifications { get; set; }
    public Guid ProductId { get; set; }
    public Product Product { get; set; }
}