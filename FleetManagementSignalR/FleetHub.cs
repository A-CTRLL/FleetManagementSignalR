using Microsoft.AspNetCore.SignalR;

namespace FleetManagementSignalR
{
    //FLeetHub inheritended From base Hub in SignalR
    public  sealed  class FleetHub : Hub
    {
        public async Task DriveVehicle(int vehicleId)
        {
            // Implement logic to start driving the vehicle
            await Clients.All.SendAsync("VehicleDriven",$"{Context.ConnectionId} is moving");
        }

        public async Task StopVehicle(int vehicleId)
        {
            // Implement logic to stop the vehicle
            await Clients.All.SendAsync("VehicleStopped", vehicleId);
        }
         
        public async Task ReverseVehicle(int vehicleId)
        {
            // Implement logic to put the vehicle in reverse
            await Clients.All.SendAsync("VehicleReversed", vehicleId);
        }
    }
}
