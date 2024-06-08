using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FinanseaAPI.Model;

namespace FinanseaAPI.Configuration 
{
    public class OngConfiguration : IEntityTypeConfiguration<Ong> 
    {
        public void Configure(EntityTypeBuilder<Ong> builder) 
        {

            builder.ToTable("ONG");

            builder.HasKey(x => x.id);
            builder.Property(x => x.id).HasColumnName("ID_ONG");
            builder.Property(x => x.document).HasColumnName("DOC_ONG").IsRequired();
            builder.Property(x => x.name).HasColumnName("NM_ONG").IsRequired();
            builder.Property(x => x.email).HasColumnName("EMAIL_ONG").IsRequired();
            builder.Property(x => x.password).HasColumnName("PWD_ONG").IsRequired();
            builder.Property(x => x.address).HasColumnName("ADDRESS_ONG").IsRequired();
            builder.Property(x => x.telephone).HasColumnName("PHONE_ONG").IsRequired();
            builder.Property(x => x.bankAccount).HasColumnName("BANK_ACCOUNT").IsRequired();
        }
     }
 }