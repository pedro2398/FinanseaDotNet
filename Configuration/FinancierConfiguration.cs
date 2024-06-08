using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FinanseaAPI.Model;

namespace FinanseaAPI.Configuration
{
    public class FinancierConfiguration : IEntityTypeConfiguration<Financier>
    {
        public void Configure(EntityTypeBuilder<Financier> builder)
        {
            builder.ToTable("FINANCIER");

            builder.HasKey(x => x.id);
            builder.Property(x => x.id).HasColumnName("ID_FINANCIER");
            builder.Property(x => x.document).HasColumnName("DOC_FINANCIER").IsRequired();
            builder.Property(x => x.name).HasColumnName("NM_FINANCIER").IsRequired();
            builder.Property(x => x.email).HasColumnName("EMAIL_FINANCIER").IsRequired();
            builder.Property(x => x.password).HasColumnName("PWD_FINANCIER").IsRequired();
            builder.Property(x => x.address).HasColumnName("ADDRESS_FINANCIER").IsRequired();
            builder.Property(x => x.telephone).HasColumnName("PHONE_FINANCIER").IsRequired();
            builder.Property(x => x.bankAccount).HasColumnName("BANK_ACCOUNT").IsRequired();
        }
    }
}
