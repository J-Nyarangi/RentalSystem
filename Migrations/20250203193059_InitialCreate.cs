using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentalSystem.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Landlord",
                columns: table => new
                {
                    LandlordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Landlord", x => x.LandlordId);
                });

            migrationBuilder.CreateTable(
                name: "Tenant",
                columns: table => new
                {
                    TenantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<int>(type: "int", nullable: false),
                    Emergency_Contact_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Emergency_Contact_Phone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenant", x => x.TenantId);
                });

            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    IsOccupied = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LandlordId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.PropertyId);
                    table.ForeignKey(
                        name: "FK_Property_Landlord_LandlordId",
                        column: x => x.LandlordId,
                        principalTable: "Landlord",
                        principalColumn: "LandlordId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Property_LandlordId",
                table: "Property",
                column: "LandlordId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Property");

            migrationBuilder.DropTable(
                name: "Tenant");

            migrationBuilder.DropTable(
                name: "Landlord");
        }
    }
}
