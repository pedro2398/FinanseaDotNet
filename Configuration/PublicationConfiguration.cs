using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FinanseaAPI.Model;

namespace FinanseaAPI.Configuration
{
    public class PublicationConfiguration : IEntityTypeConfiguration<Publication>
    {
        public void Configure(EntityTypeBuilder<Publication> builder)
        {
            builder.ToTable("PUBLICATION");

            builder.HasKey(x => x.id);
            builder.Property(x => x.id).HasColumnName("ID_PUB");
            builder.Property(x => x.description).HasColumnName("DESC_PUB").IsRequired();
            builder.Property(x => x.date).HasColumnName("DT_PUB").IsRequired();
            builder.Property(x => x.ong).HasColumnName("ONG").IsRequired();
        }
    }
}
