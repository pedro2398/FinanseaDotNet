using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FinanseaAPI.Model;

namespace FinanseaAPI.Configuration
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("PROJECT");

            builder.HasKey(x => x.id);
            builder.Property(x => x.id).HasColumnName("ID_PROJECT");
            builder.Property(x => x.name).HasColumnName("NM_PROJECT").IsRequired();
            builder.Property(x => x.address).HasColumnName("ADDRESS_PROJECT").IsRequired();
            builder.Property(x => x.description).HasColumnName("DESC_PROJECT").IsRequired();
            builder.Property(x => x.goal).HasColumnName("GOAL_PROJECT").IsRequired();
            builder.Property(x => x.status).HasColumnName("STATUS_PROJECT").IsRequired();
            builder.Property(x => x.proofOfTheProject).HasColumnName("PROOF_PROJECT").IsRequired();
            builder.Property(x => x.accumulated).HasColumnName("ACCUMULATED_PROJECT").IsRequired();
            builder.Property(x => x.ong).HasColumnName("ONG").IsRequired();
        }
    }
}
