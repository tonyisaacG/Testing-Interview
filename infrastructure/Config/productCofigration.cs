using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using core.Entitys;

namespace infrastructure.Config
{
    public class productCofigration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.id).IsRequired();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Price).HasColumnType("decimal");
            builder.Property(p => p.Image).IsRequired();
            builder.Property(p => p.Category).IsRequired();
            builder.Property(p => p.MinQuantity).IsRequired();
            builder.Property(p => p.DiscountRate).IsRequired();
            builder.HasIndex(p => p.ProductCode).IsUnique();
        }
    
    }
}
