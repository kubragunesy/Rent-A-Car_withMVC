using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "brands",
                columns: table => new
                {
                    brandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brandName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brands", x => x.brandId);
                });

            migrationBuilder.CreateTable(
                name: "colors",
                columns: table => new
                {
                    colorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    colorName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_colors", x => x.colorId);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    customerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    password = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    eMail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    birthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    adress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.customerId);
                });

            migrationBuilder.CreateTable(
                name: "paymentMethods",
                columns: table => new
                {
                    paymentMethodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    paymentMethodName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paymentMethods", x => x.paymentMethodId);
                });

            migrationBuilder.CreateTable(
                name: "cars",
                columns: table => new
                {
                    carId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    carName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    carModelYear = table.Column<int>(type: "int", nullable: false),
                    carDailyPrice = table.Column<float>(type: "real", nullable: false),
                    carDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    brandId = table.Column<int>(type: "int", nullable: false),
                    colorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cars", x => x.carId);
                    table.ForeignKey(
                        name: "FK_cars_brands_brandId",
                        column: x => x.brandId,
                        principalTable: "brands",
                        principalColumn: "brandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cars_colors_colorId",
                        column: x => x.colorId,
                        principalTable: "colors",
                        principalColumn: "colorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rentals",
                columns: table => new
                {
                    rentalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rentalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    rentalReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    paymentMethodId = table.Column<int>(type: "int", nullable: false),
                    customerId = table.Column<int>(type: "int", nullable: false),
                    carId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rentals", x => x.rentalId);
                    table.ForeignKey(
                        name: "FK_rentals_cars_carId",
                        column: x => x.carId,
                        principalTable: "cars",
                        principalColumn: "carId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rentals_customers_customerId",
                        column: x => x.customerId,
                        principalTable: "customers",
                        principalColumn: "customerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rentals_paymentMethods_paymentMethodId",
                        column: x => x.paymentMethodId,
                        principalTable: "paymentMethods",
                        principalColumn: "paymentMethodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cars_brandId",
                table: "cars",
                column: "brandId");

            migrationBuilder.CreateIndex(
                name: "IX_cars_colorId",
                table: "cars",
                column: "colorId");

            migrationBuilder.CreateIndex(
                name: "IX_rentals_carId",
                table: "rentals",
                column: "carId");

            migrationBuilder.CreateIndex(
                name: "IX_rentals_customerId",
                table: "rentals",
                column: "customerId");

            migrationBuilder.CreateIndex(
                name: "IX_rentals_paymentMethodId",
                table: "rentals",
                column: "paymentMethodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "rentals");

            migrationBuilder.DropTable(
                name: "cars");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "paymentMethods");

            migrationBuilder.DropTable(
                name: "brands");

            migrationBuilder.DropTable(
                name: "colors");
        }
    }
}
