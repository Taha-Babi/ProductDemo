using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductDemo.Migrations
{
    public partial class AddProductID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariants_Products_ProductId",
                table: "ProductVariants");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ProductVariants",
                newName: "ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductVariants_ProductId",
                table: "ProductVariants",
                newName: "IX_ProductVariants_ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariants_Products_ProductID",
                table: "ProductVariants",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariants_Products_ProductID",
                table: "ProductVariants");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "ProductVariants",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductVariants_ProductID",
                table: "ProductVariants",
                newName: "IX_ProductVariants_ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariants_Products_ProductId",
                table: "ProductVariants",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
