
namespace CRM.Domain.Entities;

public class BranchDetail : BaseAuditableEntity<int>
{
    public int Id { get; set; }
    public string Description { get; set; }
    public string ManagerName { get; set; }
    public string ManagerPhoneNumber { get; set; }
    public string ManagerEmail { get; set; }
    public int TotalEmployees { get; set; }
    public int TotalCustomers { get; set; }
    public string Website { get; set; }
    public string LogoUrl { get; set; }
    public string FacebookUrl { get; set; }
    public string TwitterUrl { get; set; }
    public string InstagramUrl { get; set; }
    public string YoutubeUrl { get; set; }
    //public Branch Branch { get; set; }
}
