using Project.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL
{
    public class NewContext : DbContext
    {
        public DbSet<VehicleMakeEntity> VehicleMakes { get; set; }
        public DbSet<VehicleModelEntity> VehicleModels { get; set; }
    }
}
