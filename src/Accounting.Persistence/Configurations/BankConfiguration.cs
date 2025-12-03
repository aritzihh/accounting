using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Accounting.Persistence.Configurations
{
    public class BankConfiguration : IEntityTypeConfiguration<Bank>
    {

        public void Configure(EntityTypeBuilder<Bank> builder)
        {
            builder.ToTable("banks", "dbo");

            builder.HasKey(e => e.BankId);

            builder.Property(e => e.BankId)
                .HasColumnName("bank_id")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasMaxLength(150);

            builder.Property(e => e.BankCode)
                .HasColumnName("bank_code")
                .HasMaxLength(40);

            builder.Property(e => e.CreatedAt)
                .IsRequired()
                .HasColumnName("created_at")
                .HasDefaultValueSql("dateadd(hour, -6, GETUTCDATE())")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.UpdatedAt)
                .HasColumnName("updated_at");

            builder.Property(e => e.IsActive)
                .IsRequired()
                .HasColumnName("is_active")
                .HasDefaultValue(true);

            builder.HasIndex(e => e.Name)
                .HasDatabaseName("IX_bank_name");

            builder.HasIndex(e => e.BankCode)
                .HasDatabaseName("IX_bank_bank_code");

            builder.HasIndex(e => e.IsActive)
                .HasDatabaseName("IX_bank_is_active");

            builder.HasIndex(e => new { e.IsActive, e.Name })
                .HasDatabaseName("IX_bank_is_active_name");
        }

    }
}
