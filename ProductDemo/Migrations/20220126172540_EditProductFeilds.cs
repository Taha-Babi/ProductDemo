using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductDemo.Migrations
{
    public partial class EditProductFeilds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VariantNameAr",
                table: "ProductVariants");

            migrationBuilder.DropColumn(
                name: "VariantNameEn",
                table: "ProductVariants");

            migrationBuilder.DropColumn(
                name: "VariantNameFr",
                table: "ProductVariants");

            migrationBuilder.AddColumn<string>(
                name: "VariantNameAr",
                table: "Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VariantNameEn",
                table: "Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VariantNameFr",
                table: "Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VariantNameAr",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "VariantNameEn",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "VariantNameFr",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "VariantNameAr",
                table: "ProductVariants",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VariantNameEn",
                table: "ProductVariants",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VariantNameFr",
                table: "ProductVariants",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
