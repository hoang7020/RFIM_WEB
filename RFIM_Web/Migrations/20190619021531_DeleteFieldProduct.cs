using Microsoft.EntityFrameworkCore.Migrations;

namespace RFIM_Web.Migrations
{
    public partial class DeleteFieldProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BoxHeight",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "BoxLength",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "BoxWidth",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "QuantityPerPackage",
                table: "Product");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "BoxHeight",
                table: "Product",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "BoxLength",
                table: "Product",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "BoxWidth",
                table: "Product",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "QuantityPerPackage",
                table: "Product",
                nullable: false,
                defaultValue: 0);
        }
    }
}
