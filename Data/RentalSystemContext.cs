using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RentalSystem.Models;

namespace RentalSystem.Data
{
    public class RentalSystemContext : DbContext
    {
        public RentalSystemContext (DbContextOptions<RentalSystemContext> options)
            : base(options)
        {
        }

        public DbSet<RentalSystem.Models.Tenant> Tenants { get; set; } = default!;
        public DbSet<RentalSystem.Models.Property> Properties { get; set; } = default!;
        public DbSet<RentalSystem.Models.Lease> Leases { get; set; } = default!;
        public DbSet<RentalSystem.Models.Payment> Payments { get; set; } = default!;
        public DbSet<RentalSystem.Models.Unit> Units { get; set; } = default!;
        public DbSet<RentalSystem.Models.Landlord> Landlords { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Landlord>()
                .HasMany(l => l.Properties)
                .WithOne(p => p.Landlord)
                .HasForeignKey(p => p.LandlordId);

            modelBuilder.Entity<Property>()
                .HasMany(p => p.Units)
                .WithOne(u => u.Property)
                .HasForeignKey(u => u.PropertyId);

            modelBuilder.Entity<Unit>()
                .HasOne(u => u.Lease)
                .WithOne(l => l.Unit)
                .HasForeignKey<Lease>(l => l.UnitId);

            modelBuilder.Entity<Tenant>()
                .HasMany(t => t.Leases)
                .WithOne(l => l.Tenant)
                .HasForeignKey(l => l.TenantId);
        }
    }
}
