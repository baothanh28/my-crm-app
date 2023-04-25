

namespace CRM.Domain.Entities;
public class CategoryDetail : BaseAuditableEntity<Guid>
{
    public Guid Id { get; set; }
    public int CategoryId { get; set; }
    public string Title { get; set; }
    public string Keywords { get; set; }
    public string MetaDescription { get; set; }
    public string Body { get; set; }
    public bool IsActive { get; set; }
    public string Icon { get; set; }
    public int Rating { get; set; }
    public bool IsTrending { get; set; }
    public bool IsTopSelling { get; set; }
    public bool IsNewArrival { get; set; }
    public string BannerImageUrl { get; set; }
    public string ThumbnailImageUrl { get; set; }
    public string MobileImageUrl { get; set; }
    public string AdditionalImages { get; set; }
    public string Videos { get; set; }

    // Navigation property
    public virtual Category Category { get; set; }
}