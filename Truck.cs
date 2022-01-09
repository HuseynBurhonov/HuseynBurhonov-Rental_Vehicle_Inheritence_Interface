namespace Better_OOP_Inheritence
{
    public class Truck : LandVehicle, IRental
    {
        public TruckType Style { get; set; }
        public int RentalId { get; set; }
        public string CurrentRenter { get; set; }
        public decimal PricePerDay { get; set; }
    }
}
