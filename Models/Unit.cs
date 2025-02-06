using System.ComponentModel.DataAnnotations;

namespace RentalSystem.Models
{
    public class Unit
    {
        [Key]
        public int UnitId { get; set; }

        public string UnitNumber { get; set; } = string.Empty; // e.g. Shop 1, Shop 2

        public int PropertyId { get; set; }
        public Property Property { get; set; } = null!;

        //Unit should have one lease
        public Lease Lease { get; set; } = null!;

        public bool IsAvailable()
        {
            return Lease == null || !Lease.IsActive;
        }

        public bool HasActiveLease()
        {
            return Lease != null && Lease.IsActive;
        }

    }
}
