

namespace CRM.Domain.Entities;
public class Category : BaseAuditableEntity<int>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsActive { get; set; }
    public decimal Discount { get; set; }
    public bool IsFeatured { get; set; }
    public int SortOrder { get; set; }
    public string ImageUrl { get; set; }
    public int BranchId { get; set; }
    public virtual Branch Branch { get; set; }
    public virtual CategoryDetail CategoryDetail { get; set; }
    public virtual List<Product>  Products { get; set; }
}