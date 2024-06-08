using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FinanseaAPI.Model;

namespace FinanseaAPI.Configuration
{
    public class DonationConfiguration : IEntityTypeConfiguration<Donation>
    {
        public void Configure(EntityTypeBuilder<Donation> builder)
        {
            builder.ToTable("DONATION");

            builder.HasKey(x => x.id);
            builder.Property(x => x.id).HasColumnName("ID_DONATION");
            builder.Property(x => x.amounth).HasColumnName("AMOUNTH_DONATION").IsRequired();
            builder.Property(x => x.date).HasColumnName("DATE_DONATION").IsRequired();
            builder.Property(x => x.project).HasColumnName("PROJECT_DONATION").IsRequired();
            builder.Property(x => x.financier).HasColumnName("FINANCIER").IsRequired();
        }
    }
}
