

namespace CRM.Domain.Entities;
public class Branch : BaseAuditableEntity<int>
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string ManagerName { get; set; }
    public bool IsActive { get; set; }
    public int MaxCapacity { get; set; }
    public BranchDetail BranchDetail { get; set; }
    public virtual IList<Category> CategoryList { get; set; }
}
