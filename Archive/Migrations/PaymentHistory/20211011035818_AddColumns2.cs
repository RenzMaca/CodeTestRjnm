using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeTestRjnm.Migrations.PaymentHistory
{
    public partial class AddColumns2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "_id",
                table: "Payments",
                newName: "id");

            migrationBuilder.AddColumn<string>(
                name: "accountNumber",
                table: "Payments",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "amount",
                table: "Payments",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "remarks",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "accountNumber",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "amount",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "date",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "remarks",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Payments");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Payments",
                newName: "_id");
        }
    }
}
