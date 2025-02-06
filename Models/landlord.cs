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

        //Landlord can have many properties
        public ICollection<Property> Properties { get; set; } = new List<Property>();   
    }
}
