using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Agca.ECommerce.DataAccess.Migrations
{
    public partial class photo_feature_test_ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoView",
                table: "Photo");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Photo",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "Photo");

            migrationBuilder.AddColumn<byte[]>(
                name: "PhotoView",
                table: "Photo",
                nullable: true);
        }
    }
}
