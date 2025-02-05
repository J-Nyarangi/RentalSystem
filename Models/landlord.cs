using System.ComponentModel.DataAnnotations;

namespace RentalSystem.Models
{
    public class Landlord
    {
        [Key]
        public int LandlordId {  get; set; }
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public List<Property> Properties { get; set; } = new();
    }
}
