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
    public class PurchaseItemConfiguration : IEntityTypeConfiguration<PurchaseItem>
    {
        public void Configure(EntityTypeBuilder<PurchaseItem> builder)
        {
            builder.ToTable("PurchaseItems");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");
            builder.Property(p => p.Quantity).HasColumnType("FLOAT").IsRequired();
            builder.Property(p => p.UnitPrice).HasColumnType("Decimal(18,2)").IsRequired();
            builder.Property(p => p.TotalPrice).HasColumnType("Decimal(18,2)").IsRequired();
            builder.Property(p => p.TotalDiscount).HasColumnType("Decimal(18,2)").IsRequired();

        }
    }
}
