namespace usedVehicle.API.Models
{
    public class Advert
    {
        public int Id { get; set; }
        public Vehicle Vehicle { get; set; }
        public User User { get; set; }
        public DateTime DateAdded { get; set; }

    }
}
