using System.ComponentModel.DataAnnotations;


namespace RentalSystem.Models
{
    public class Property
    {
        [Key]
        public int PropertyId { get; set; }

        public string? Name { get; set; }
        
        [Required(ErrorMessage = "Please enter an address")]
        public string Address { get; set; } = string.Empty;

        //Foreign Key Property
        public int LandlordId { get; set; }
        public Landlord Landlord { get; set; } = null!;

        //Property can have multiple units
        public ICollection<Unit> Units { get; set; } = new List<Unit>();
    }
}
