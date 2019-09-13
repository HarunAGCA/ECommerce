using Microsoft.EntityFrameworkCore.Migrations;

namespace Agca.ECommerce.DataAccess.Migrations
{
    public partial class Added_EMail_Column_to_ShippingDetails_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EMail",
                table: "ShippingDetails",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EMail",
                table: "ShippingDetails");
        }
    }
}
