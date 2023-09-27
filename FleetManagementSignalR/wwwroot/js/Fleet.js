namespace FleetManagementSignalR.wwwroot.js
{
    // Add this script to your VehicleControlCentre.cshtml
    
        const connection = new signalR.HubConnectionBuilder()
        .withUrl("/FleetHub")
        .build();

        connection.start().then(function () {
            // Hub connection is established
        }).catch(function (err) {
            console.error(err)
    });

        // Handle button clicks and invoke hub methods
        $("#drive-btn").click(function () {
            connection.invoke("Drive", vehicleId)
    });

        $("#stop-btn").click(function () {
            connection.invoke("Stop", vehicleId)
    });

        $("#reverse-btn").click(function () {
            connection.invoke("Reverse", vehicleId)
    });

        // Implement handling of hub messages (e.g., vehicle movements)

        connection.on("VehicleDriving", function (vehicleId) {
            // Handle vehicle driving event
        });

        connection.on("VehicleStopped", function (vehicleId) {
            // Handle vehicle stopped event
        });

        connection.on("VehicleReversing", function (vehicleId) {
            // Handle vehicle reversing event
        });
 

}
