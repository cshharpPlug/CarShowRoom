using CarShowRoom.Models;
using System.Data.Entity;


namespace CarShowRoom
{
    public class Context : DbContext
    {
        public Context() : base("DBConnection")
        {
        } 

        public DbSet<Car> CarModels { get; set; }
        public DbSet<Log> Logs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<Context>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
