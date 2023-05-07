using System.Reflection.Emit;
using CRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.Infrastructure.Persistence.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(t => t.Name)
            .HasMaxLength(200)
            .IsRequired();
        builder.HasOne(cd => cd.ProductDetail)
           .WithOne()
           .HasForeignKey<ProductDetail>(cd => cd.Id);
    }
}
public class ProductDetailConfiguration : IEntityTypeConfiguration<ProductDetail>
{
    public void Configure(EntityTypeBuilder<ProductDetail> builder)
    {
        builder.Property(t => t.ModelNumber)
            .HasMaxLength(200)
            .IsRequired();
     
    }
}
