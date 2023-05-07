using System.Reflection.Emit;
using CRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.Infrastructure.Persistence.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.Property(t => t.Name)
            .HasMaxLength(200)
            .IsRequired();
        builder.HasOne(cd => cd.CategoryDetail)
          .WithOne(c => c.Category)
          .HasForeignKey<Category>(cd => cd.Id);

    }
}
public class CategoryDetailConfiguration : IEntityTypeConfiguration<CategoryDetail>
{
    public void Configure(EntityTypeBuilder<CategoryDetail> builder)
    {
        builder.Property(t => t.Title)
            .HasMaxLength(200)
            .IsRequired();
     
    }
}
