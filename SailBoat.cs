namespace Better_OOP_Inheritence
{
    public class SailBoat : IRental
    {
        public int RentalId { get; set; }
        public string CurrentRenter { get; set; }
        public decimal PricePerDay { get; set; }
    }
}
