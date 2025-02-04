using System.ComponentModel.DataAnnotations;


namespace RentalSystem.Models
{
    public class Property
    {
        [Key]
        public int PropertyId { get; set; }
        
        [Required(ErrorMessage = "Please enter an address")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter the unit type")]
        public string Unit_type { get; set; } = string.Empty;

        [Required]
        public int Amount {  get; set; }

        [Required]
        public bool IsOccupied {  get; set; }

        public string Description { get; set; } = string.Empty;

        //Foreign Key Property
        public int LandlordId { get; set; }

        //Navigation Property
        public Landlord Landlord { get; set; } = null!;
    }
}
