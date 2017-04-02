using CarShowRoom.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowRoom
{
    public class Context : DbContext
    { 
        public DbSet<CarModel> CarModels { get; set; }
    }
}
