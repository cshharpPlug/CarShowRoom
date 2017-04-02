using CarShowRoom.Models;
using System.Data.Entity;


namespace CarShowRoom
{
    public class Context : DbContext
    { 
        public DbSet<CarModel> CarModels { get; set; }
    }
}
