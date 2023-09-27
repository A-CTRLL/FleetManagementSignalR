namespace FleetManagementSignalR.Models
{
    public class Truck : Vehicle
    {
        public string AdditionalProperty1 { get; set; }
        public string AdditionalProperty2 { get; set; }

        // Additional properties specific to trucks
        public string TruckProperty1 { get; set; }
        public string TruckProperty2 { get; set; }

        public int MakeId { get; set; }
        public int ModelId { get; set; }
        public Make Make { get; set; }
        public Model Model { get; set; }
    }
}
