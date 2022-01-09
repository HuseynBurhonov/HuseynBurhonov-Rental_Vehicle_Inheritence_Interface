namespace Better_OOP_Inheritence
{
    public class Car : LandVehicle, IRental
    {
        public CarType Style { get; set; }
        public int RentalId { get; set; }
        public string CurrentRenter { get; set; }
        public decimal PricePerDay { get; set; }

    }
}
