using CarShowRoom.Models;
using System.Data.Entity;


namespace CarShowRoom
{
    public class Context : DbContext
    {
        public Context() : base("DBConnection")
        {
        } 

        public DbSet<CarModel> CarModels { get; set; }
    }
}
