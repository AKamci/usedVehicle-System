namespace usedVehicle.API.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int ProductionYear { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string FuelType { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public int Mileage { get; set; }
        public decimal SalePrice { get; set; }
        public List<string> Equipment { get; set; }
        public List<string> Images { get; set; }
        public bool Approved { get; set; } = false;

    }
}
