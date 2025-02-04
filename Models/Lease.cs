using System.ComponentModel.DataAnnotations;

namespace RentalSystem.Models
{
    public class Lease
    {
        [Key]
        public int LeaseId { get; set; }
        
        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public int Rent {  get; set; }

        [Required]
        public int Deposit { get; set; }
        
        [Required]
        public DateTime PaymentDueDay { get; set; }
        
        [Required]
        public bool IsActive { get; set; }

        //Foreign Key Properties
        public int PropertyId { get; set; }

        public int TenantId {  get; set; }

        //Navigation Properties
        public Property Property { get; set; } = null!;
        public Tenant Tenant { get; set; } = null!;
    }
}
