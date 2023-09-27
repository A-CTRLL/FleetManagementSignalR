namespace FleetManagementSignalR.Models
{
    public class Car : Vehicle
    {
        public string AdditionalProperty1 { get; set; }
        public string AdditionalProperty2 { get; set; }

        // Foreign keys
        public int MakeId { get; set; }
        public int ModelId { get; set; }

        // Navigation properties
        public Make Make { get; set; }
        public Model Model { get; set; }
    }
}
