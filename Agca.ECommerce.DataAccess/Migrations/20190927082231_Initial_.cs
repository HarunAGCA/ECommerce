using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Agca.ECommerce.DataAccess.Migrations
{
    public partial class Initial_ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfPayment",
                table: "Payments",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 27, 11, 22, 31, 55, DateTimeKind.Local).AddTicks(4096),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 27, 11, 7, 38, 681, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 27, 11, 22, 31, 53, DateTimeKind.Local).AddTicks(5871),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 27, 11, 7, 38, 680, DateTimeKind.Local).AddTicks(2702));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfPayment",
                table: "Payments",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 27, 11, 7, 38, 681, DateTimeKind.Local).AddTicks(8709),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 27, 11, 22, 31, 55, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 27, 11, 7, 38, 680, DateTimeKind.Local).AddTicks(2702),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 27, 11, 22, 31, 53, DateTimeKind.Local).AddTicks(5871));
        }
    }
}
