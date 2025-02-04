using System.ComponentModel.DataAnnotations;

namespace RentalSystem.Models
{
    public class Tenant
    {
        [Key]
        public int TenantId { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email {  get; set; } = string.Empty;
        [Required]
        public int Phone { get; set; }

        public string Emergency_Contact_Name { get; set; } = string.Empty;

        public int Emergency_Contact_Phone { get; set; }


    }
}
