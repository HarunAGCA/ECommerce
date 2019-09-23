using Microsoft.EntityFrameworkCore.Migrations;

namespace Agca.ECommerce.CoreMvcWebUI.Migrations
{
    public partial class customerId_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "AspNetUsers");
        }
    }
}
