using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FleetManagementSignalR.Models;

namespace FleetManagementSignalR.Data
{
    public class FleetManagementSignalRContext : DbContext
    {
        public FleetManagementSignalRContext (DbContextOptions<FleetManagementSignalRContext> options)
            : base(options)
        {
        }

        public DbSet<FleetManagementSignalR.Models.Car> Car { get; set; } = default!;

        public DbSet<FleetManagementSignalR.Models.Make> Make { get; set; } = default!;

        public DbSet<FleetManagementSignalR.Models.Model> Model { get; set; } = default!;

        public DbSet<FleetManagementSignalR.Models.Model> Truck { get; set; } = default!;


        public DbSet<FleetManagementSignalR.Models.Vehicle> Vehicle { get; set; } = default!;


        public DbSet<FleetManagementSignalR.Models.Truck> Truck_1 { get; set; } = default!;
    }
}
