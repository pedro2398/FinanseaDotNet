using FinanseaAPI.Configuration;
using FinanseaAPI.Model;
using Microsoft.EntityFrameworkCore;
namespace FinanseaAPI.Context
{
    public class FinanseaContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public FinanseaContext(DbContextOptions<FinanseaContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        public DbSet<Donation> Donation { get; set; }
        public DbSet<Ong> Ong { get; set; }
        public DbSet<Financier> Financier { get; set; }
        public DbSet<BankAccount> BankAccount { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Publication> Publication { get; set; }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new OngConfiguration());
        modelBuilder.ApplyConfiguration(new BankAccountConfiguration());
        modelBuilder.ApplyConfiguration(new DonationConfiguration());
        modelBuilder.ApplyConfiguration(new FinancierConfiguration());
        modelBuilder.ApplyConfiguration(new ProjectConfiguration());
        modelBuilder.ApplyConfiguration(new PublicationConfiguration());
        
        base.OnModelCreating(modelBuilder);
    }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseOracle(_configuration.GetConnectionString("OracleConnection"));
            }
        }
    }
}