using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FinanseaAPI.Model;

namespace FinanseaAPI.Configuration
{
    public class BankAccountConfiguration : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            builder.ToTable("BANK_ACCOUNT");

            builder.HasKey(x => x.id);
            builder.Property(x => x.id).HasColumnName("ID_BANK_ACCOUNT");
            builder.Property(x => x.accountNumber).HasColumnName("NUMBER_BANCK_ACCOUNT").IsRequired();
            builder.Property(x => x.agency).HasColumnName("AGENCY_BANCK_ACCOUNT").IsRequired();
            builder.Property(x => x.password).HasColumnName("PWD_BANCK_ACCOUNT").IsRequired();
        }
    }
}
