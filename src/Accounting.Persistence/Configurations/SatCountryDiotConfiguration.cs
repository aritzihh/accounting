using Accounting.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Accounting.Persistence.Configurations
{
    public class SatCountryDiotConfiguration : IEntityTypeConfiguration<SatCountryDiot>
    {

        public void Configure(EntityTypeBuilder<SatCountryDiot> builder)
        {

            builder.ToTable("sat_country_diot");         

            builder.HasKey(e => e.SatCountryId);

            builder.Property(e => e.SatCountryId)
                .HasColumnName("sat_country_id")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.KeyCountry)
                .IsRequired()
                .HasColumnName("key_country")
                .HasMaxLength(10);

            builder.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("description")
                .HasMaxLength(250);

            builder.Property(e => e.IsActive)
                .IsRequired()
                .HasColumnName("is_active")
                .HasDefaultValue(true);

            builder.HasIndex(e => e.KeyCountry)
                .IsUnique()
                .HasDatabaseName("IX_sat_country_diot_key_country");

            builder.HasIndex(e => e.IsActive)
                .HasDatabaseName("IX_sat_country_diot_is_active");

        }

    }
}
