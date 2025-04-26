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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");
            builder.Property(p => p.CustomerCodeId).IsRequired().HasMaxLength(10);
            builder.Property(p => p.CustomerName).IsRequired().HasMaxLength(200);
            builder.Property(p => p.CustommerAddress).IsRequired().HasMaxLength(200);
            builder.Property(p => p.CustomerEmail).IsRequired().HasMaxLength(200);
            builder.Property(p => p.CustomerPhone).IsRequired().HasMaxLength(20);
            builder.Property(p => p.CustomerCity).IsRequired().HasMaxLength(200);
            builder.Property(p => p.CustomerState).IsRequired().HasMaxLength(2);
            builder.Property(p => p.CustomerCountry).IsRequired().HasMaxLength(2);

        }
    }
}
