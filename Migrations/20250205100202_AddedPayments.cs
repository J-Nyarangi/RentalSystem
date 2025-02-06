using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentalSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddedPayments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lease_Tenant_TenantId",
                table: "Lease");

            migrationBuilder.DropForeignKey(
                name: "FK_Lease_Unit_UnitId",
                table: "Lease");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Landlord_LandlordId",
                table: "Property");

            migrationBuilder.DropForeignKey(
                name: "FK_Unit_Property_PropertyId",
                table: "Unit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Unit",
                table: "Unit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tenant",
                table: "Tenant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Property",
                table: "Property");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lease",
                table: "Lease");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Landlord",
                table: "Landlord");

            migrationBuilder.RenameTable(
                name: "Unit",
                newName: "Units");

            migrationBuilder.RenameTable(
                name: "Tenant",
                newName: "Tenants");

            migrationBuilder.RenameTable(
                name: "Property",
                newName: "Properties");

            migrationBuilder.RenameTable(
                name: "Lease",
                newName: "Leases");

            migrationBuilder.RenameTable(
                name: "Landlord",
                newName: "Landlords");

            migrationBuilder.RenameIndex(
                name: "IX_Unit_PropertyId",
                table: "Units",
                newName: "IX_Units_PropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_LandlordId",
                table: "Properties",
                newName: "IX_Properties_LandlordId");

            migrationBuilder.RenameIndex(
                name: "IX_Lease_UnitId",
                table: "Leases",
                newName: "IX_Leases_UnitId");

            migrationBuilder.RenameIndex(
                name: "IX_Lease_TenantId",
                table: "Leases",
                newName: "IX_Leases_TenantId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Units",
                table: "Units",
                column: "UnitId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tenants",
                table: "Tenants",
                column: "TenantId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Properties",
                table: "Properties",
                column: "PropertyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Leases",
                table: "Leases",
                column: "LeaseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Landlords",
                table: "Landlords",
                column: "LandlordId");

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    DatePaid = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeaseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payments_Leases_LeaseId",
                        column: x => x.LeaseId,
                        principalTable: "Leases",
                        principalColumn: "LeaseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_LeaseId",
                table: "Payments",
                column: "LeaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Leases_Tenants_TenantId",
                table: "Leases",
                column: "TenantId",
                principalTable: "Tenants",
                principalColumn: "TenantId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Leases_Units_UnitId",
                table: "Leases",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "UnitId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Landlords_LandlordId",
                table: "Properties",
                column: "LandlordId",
                principalTable: "Landlords",
                principalColumn: "LandlordId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Units_Properties_PropertyId",
                table: "Units",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "PropertyId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leases_Tenants_TenantId",
                table: "Leases");

            migrationBuilder.DropForeignKey(
                name: "FK_Leases_Units_UnitId",
                table: "Leases");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Landlords_LandlordId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Units_Properties_PropertyId",
                table: "Units");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Units",
                table: "Units");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tenants",
                table: "Tenants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Properties",
                table: "Properties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Leases",
                table: "Leases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Landlords",
                table: "Landlords");

            migrationBuilder.RenameTable(
                name: "Units",
                newName: "Unit");

            migrationBuilder.RenameTable(
                name: "Tenants",
                newName: "Tenant");

            migrationBuilder.RenameTable(
                name: "Properties",
                newName: "Property");

            migrationBuilder.RenameTable(
                name: "Leases",
                newName: "Lease");

            migrationBuilder.RenameTable(
                name: "Landlords",
                newName: "Landlord");

            migrationBuilder.RenameIndex(
                name: "IX_Units_PropertyId",
                table: "Unit",
                newName: "IX_Unit_PropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_LandlordId",
                table: "Property",
                newName: "IX_Property_LandlordId");

            migrationBuilder.RenameIndex(
                name: "IX_Leases_UnitId",
                table: "Lease",
                newName: "IX_Lease_UnitId");

            migrationBuilder.RenameIndex(
                name: "IX_Leases_TenantId",
                table: "Lease",
                newName: "IX_Lease_TenantId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Unit",
                table: "Unit",
                column: "UnitId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tenant",
                table: "Tenant",
                column: "TenantId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Property",
                table: "Property",
                column: "PropertyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lease",
                table: "Lease",
                column: "LeaseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Landlord",
                table: "Landlord",
                column: "LandlordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lease_Tenant_TenantId",
                table: "Lease",
                column: "TenantId",
                principalTable: "Tenant",
                principalColumn: "TenantId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lease_Unit_UnitId",
                table: "Lease",
                column: "UnitId",
                principalTable: "Unit",
                principalColumn: "UnitId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Landlord_LandlordId",
                table: "Property",
                column: "LandlordId",
                principalTable: "Landlord",
                principalColumn: "LandlordId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Unit_Property_PropertyId",
                table: "Unit",
                column: "PropertyId",
                principalTable: "Property",
                principalColumn: "PropertyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
