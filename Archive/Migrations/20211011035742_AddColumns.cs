using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeTestRjnm.Migrations
{
    public partial class AddColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "_id",
                table: "Accounts",
                newName: "id");

            migrationBuilder.AddColumn<string>(
                name: "accountNumber",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "balance",
                table: "Accounts",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "currency",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "firstName",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lastName",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "accountNumber",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "balance",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "currency",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "firstName",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "lastName",
                table: "Accounts");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Accounts",
                newName: "_id");
        }
    }
}
