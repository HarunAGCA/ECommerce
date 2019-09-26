using Microsoft.EntityFrameworkCore.Migrations;

namespace Agca.ECommerce.DataAccess.Migrations
{
    public partial class photo_feature_test_____ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId1",
                table: "Photos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Photos_ProductId1",
                table: "Photos",
                column: "ProductId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Products_ProductId1",
                table: "Photos",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Products_ProductId1",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_ProductId1",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "Photos");
        }
    }
}
