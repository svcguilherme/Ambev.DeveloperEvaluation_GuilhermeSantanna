using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.ORM.Mapping
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");
            builder.Property(p => p.Description).IsRequired().HasMaxLength(100);
            builder.Property(p => p.CodeBar).IsRequired().HasMaxLength(100);
            builder.Property(p => p.ProductName).IsRequired().HasMaxLength(250);
            builder.Property(p => p.Price).IsRequired().HasColumnType("Decimal(18,2)");
            
        }
    }
}
