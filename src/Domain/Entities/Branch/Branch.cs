

namespace CRM.Domain.Entities;
public class Branch : BaseAuditableEntity<Guid>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string ManagerName { get; set; }
    public bool IsActive { get; set; }
    public int MaxCapacity { get; set; }

    public virtual BranchDetail BranchDetail { get; set; }
}
