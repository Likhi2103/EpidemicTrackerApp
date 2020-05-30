using Microsoft.EntityFrameworkCore.Migrations;

namespace EpidemicTracker.Data.Migrations
{
    public partial class UpdatedHospitalStaff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "HospitalStaff",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine",
                table: "HospitalStaff",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "HospitalStaff",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "HospitalStaff",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "HospitalStaff",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "HospitalStaff",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailId",
                table: "HospitalStaff",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "HospitalStaff",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "HospitalStaff",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GovernmentIdNo",
                table: "HospitalStaff",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "HospitalStaff",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNo",
                table: "HospitalStaff",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Pincode",
                table: "HospitalStaff",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "HospitalStaff",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressLine",
                table: "HospitalStaff");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "HospitalStaff");

            migrationBuilder.DropColumn(
                name: "Area",
                table: "HospitalStaff");

            migrationBuilder.DropColumn(
                name: "City",
                table: "HospitalStaff");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "HospitalStaff");

            migrationBuilder.DropColumn(
                name: "EmailId",
                table: "HospitalStaff");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "HospitalStaff");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "HospitalStaff");

            migrationBuilder.DropColumn(
                name: "GovernmentIdNo",
                table: "HospitalStaff");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "HospitalStaff");

            migrationBuilder.DropColumn(
                name: "PhoneNo",
                table: "HospitalStaff");

            migrationBuilder.DropColumn(
                name: "Pincode",
                table: "HospitalStaff");

            migrationBuilder.DropColumn(
                name: "State",
                table: "HospitalStaff");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "HospitalStaff",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
