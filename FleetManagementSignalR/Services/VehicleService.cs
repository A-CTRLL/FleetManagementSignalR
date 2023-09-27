using FleetManagementSignalR.Data;
using FleetManagementSignalR.Models;

namespace FleetManagementSignalR.Services
{
    public class VehicleService 
    {
        private readonly FleetManagementSignalRContext _context;

        public VehicleService(FleetManagementSignalRContext context)
        {
            _context = context;
        }

        // Implement CRUD operations for Makes, Models, and Vehicles
        // ...

        public double CalculateKilometersDriven(Vehicle vehicle, int hoursInDriveMode)
        {
            double averageSpeed = vehicle.AverageSpeed;
            return averageSpeed * hoursInDriveMode;
        }

        public double CalculateKilometersReversed(Vehicle vehicle, int hoursInReverseMode)
        {
            double averageSpeed = vehicle.AverageSpeed;
            double reverseSpeed = averageSpeed * 0.1; // 10% of average speed while reversing
            return reverseSpeed * hoursInReverseMode;
        }
    }
}
