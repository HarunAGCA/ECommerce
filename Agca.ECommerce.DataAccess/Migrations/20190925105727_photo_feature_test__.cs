using Microsoft.EntityFrameworkCore.Migrations;

namespace Agca.ECommerce.DataAccess.Migrations
{
    public partial class photo_feature_test__ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMain",
                table: "Photo",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMain",
                table: "Photo");
        }
    }
}
