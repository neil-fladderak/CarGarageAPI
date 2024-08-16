namespace CarGarageApi.Models
{
    public class Vehicle
    {
        private static int Number { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string SubModel { get; set; }
        public string ProductionYear { get; set; }
        public int Mileage { get; set; }
        public string VehicleType { get; set; }
        public string GarageName { get; set; } 
        public int Id => Number;

        public Vehicle (string make, string model, string subModel, string productionYear, int mileage, string vehicletype, string garageName)
        {
            Make = make;
            Model = model;
            SubModel = subModel;
            ProductionYear = productionYear;
            VehicleType = vehicletype;
            GarageName = garageName;
            Number = Number++;
        }
    }
}
