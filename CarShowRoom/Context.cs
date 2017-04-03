using CarShowRoom.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CarShowRoom
{
    public class Context : DbContext
    {
        public Context() : base("DBConnection")
        {
            
        } 

        public DbSet<Cars> CarModels { get; set; }
        public DbSet<Logs> LogsTable { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<Context>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
