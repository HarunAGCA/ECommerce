using Microsoft.EntityFrameworkCore.Migrations;

namespace Agca.ECommerce.DataAccess.Migrations
{
    public partial class was_editted_some_tables2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShippingDetails_Orders_OrderId",
                table: "ShippingDetails");

            migrationBuilder.DropIndex(
                name: "IX_ShippingDetails_OrderId",
                table: "ShippingDetails");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "ShippingDetails");

            migrationBuilder.AddColumn<int>(
                name: "ShippingDetailsId",
                table: "Orders",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShippingDetailsId",
                table: "Orders",
                column: "ShippingDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_ShippingDetails_ShippingDetailsId",
                table: "Orders",
                column: "ShippingDetailsId",
                principalTable: "ShippingDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_ShippingDetails_ShippingDetailsId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ShippingDetailsId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShippingDetailsId",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "ShippingDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ShippingDetails_OrderId",
                table: "ShippingDetails",
                column: "OrderId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ShippingDetails_Orders_OrderId",
                table: "ShippingDetails",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
