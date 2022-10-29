using Microsoft.EntityFrameworkCore;

namespace MasterDetails.Models
{
    public class DatabaseCN : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DatabaseCN(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<PurchaseInfo> PurchaseInfos { get; set; }
        public DbSet<PurchaseDetails> PurchaseDetails { get; set; }
    }
}
