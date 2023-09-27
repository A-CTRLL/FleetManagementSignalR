using FleetManagementSignalR.Models;

namespace FleetManagementSignalR.Services
{
    public interface IVehicleService
    {
        
            // CRUD operations for Makes
            IEnumerable<Make> GetAllMakes();
            Make GetMakeById(int id);
            void AddMake(Make make);
            void UpdateMake(Make make);
            void DeleteMake(int id);

            // CRUD operations for Models
            IEnumerable<Model> GetAllModels();
            Model GetModelById(int id);
            void AddModel(Model model);
            void UpdateModel(Model model);
            void DeleteModel(int id);

            // CRUD operations for Vehicles
            IEnumerable<Vehicle> GetAllVehicles();
            Vehicle GetVehicleById(int id);
            void AddVehicle(Vehicle vehicle);
            void UpdateVehicle(Vehicle vehicle);
            void DeleteVehicle(int id);

            // Logic to calculate kilometers driven and reversed
            double CalculateKilometersDriven(Vehicle vehicle, int hoursInDriveMode);
            double CalculateKilometersReversed(Vehicle vehicle, int hoursInReverseMode);
        }

    }

