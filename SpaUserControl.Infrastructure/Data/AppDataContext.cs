using SpaUserControl.Domain.Entities;
using SpaUserControl.Infrastructure.Data.Mappings;
using System.Data.Entity;

namespace SpaUserControl.Infrastructure.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext() : base("ConnectionString")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
