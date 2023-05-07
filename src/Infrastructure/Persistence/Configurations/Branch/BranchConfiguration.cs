using System.Reflection.Emit;
using CRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.Infrastructure.Persistence.Configurations;

public class BranchConfiguration : IEntityTypeConfiguration<Branch>
{
    public void Configure(EntityTypeBuilder<Branch> builder)
    {
        builder.Property(t => t.Name)
            .HasMaxLength(200)
            .IsRequired();

        builder.HasOne(cd => cd.BranchDetail)
           .WithOne(c => c.Branch)
           .HasForeignKey<BranchDetail>(cd => cd.Id);

    }
}
public class BranchDetailConfiguration : IEntityTypeConfiguration<BranchDetail>
{
    public void Configure(EntityTypeBuilder<BranchDetail> builder)
    {
        builder.Property(t => t.ManagerName)
            .HasMaxLength(200)
            .IsRequired();
     
    }
}
