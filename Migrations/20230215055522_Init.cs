using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoDealer.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandNameId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerRecords",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddressLineOne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLineTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerRecords", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "ExteriorColors",
                columns: table => new
                {
                    ExteriorColorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExteriorColorName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExteriorColors", x => x.ExteriorColorId);
                });

            migrationBuilder.CreateTable(
                name: "InteriorColors",
                columns: table => new
                {
                    InteriorColorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InteriorColorName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InteriorColors", x => x.InteriorColorId);
                });

            migrationBuilder.CreateTable(
                name: "Specials",
                columns: table => new
                {
                    SpecialId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpecialName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecialDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specials", x => x.SpecialId);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    ModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.ModelId);
                    table.ForeignKey(
                        name: "FK_Models_Brands_BrandNameId",
                        column: x => x.BrandNameId,
                        principalTable: "Brands",
                        principalColumn: "BrandNameId");
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleVIN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Transmission = table.Column<int>(type: "int", nullable: true),
                    InteriorColorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExteriorColorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BodyStyle = table.Column<int>(type: "int", nullable: false),
                    ModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Mileage = table.Column<decimal>(type: "decimal(6,0)", nullable: false),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalListPrice = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    CurrentListPrice = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    MRSP = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false),
                    IsSold = table.Column<bool>(type: "bit", nullable: false),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false),
                    ImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleVIN);
                    table.ForeignKey(
                        name: "FK_Vehicles_ExteriorColors_ExteriorColorId",
                        column: x => x.ExteriorColorId,
                        principalTable: "ExteriorColors",
                        principalColumn: "ExteriorColorId");
                    table.ForeignKey(
                        name: "FK_Vehicles_InteriorColors_InteriorColorId",
                        column: x => x.InteriorColorId,
                        principalTable: "InteriorColors",
                        principalColumn: "InteriorColorId");
                    table.ForeignKey(
                        name: "FK_Vehicles_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "ModelId");
                });

            migrationBuilder.CreateTable(
                name: "ContactRequests",
                columns: table => new
                {
                    ContactRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContactFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateContactRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VehicleRequestedVehicleVIN = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactRequests", x => x.ContactRequestId);
                    table.ForeignKey(
                        name: "FK_ContactRequests_Vehicles_VehicleRequestedVehicleVIN",
                        column: x => x.VehicleRequestedVehicleVIN,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleVIN");
                });

            migrationBuilder.CreateTable(
                name: "PurchaseRecords",
                columns: table => new
                {
                    PurchaseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypeOfPurchase = table.Column<int>(type: "int", nullable: false),
                    PurchasedVehicleRecordVehicleVIN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PurchasingCustomerCustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PurchasePrice = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    SalesRepresentative = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseRecords", x => x.PurchaseId);
                    table.ForeignKey(
                        name: "FK_PurchaseRecords_CustomerRecords_PurchasingCustomerCustomerId",
                        column: x => x.PurchasingCustomerCustomerId,
                        principalTable: "CustomerRecords",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseRecords_Vehicles_PurchasedVehicleRecordVehicleVIN",
                        column: x => x.PurchasedVehicleRecordVehicleVIN,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleVIN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactRequests_VehicleRequestedVehicleVIN",
                table: "ContactRequests",
                column: "VehicleRequestedVehicleVIN");

            migrationBuilder.CreateIndex(
                name: "IX_Models_BrandNameId",
                table: "Models",
                column: "BrandNameId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseRecords_PurchasedVehicleRecordVehicleVIN",
                table: "PurchaseRecords",
                column: "PurchasedVehicleRecordVehicleVIN");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseRecords_PurchasingCustomerCustomerId",
                table: "PurchaseRecords",
                column: "PurchasingCustomerCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_ExteriorColorId",
                table: "Vehicles",
                column: "ExteriorColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_InteriorColorId",
                table: "Vehicles",
                column: "InteriorColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_ModelId",
                table: "Vehicles",
                column: "ModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactRequests");

            migrationBuilder.DropTable(
                name: "PurchaseRecords");

            migrationBuilder.DropTable(
                name: "Specials");

            migrationBuilder.DropTable(
                name: "CustomerRecords");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "ExteriorColors");

            migrationBuilder.DropTable(
                name: "InteriorColors");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
