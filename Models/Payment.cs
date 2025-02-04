using System.ComponentModel.DataAnnotations;

namespace RentalSystem.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId {  get; set; }

        public int Amount { get; set; }

        public DateTime DatePaid { get; set; }

        public string PaymentMethod { get; set; } = string.Empty;

        public string PaymentStatus { get; set; } = string.Empty;

        //Foreign Key Property
        public int LeaseId {  get; set; }

        //Navigation Property
        public Lease Lease { get; set; } = null!;

    }
}
