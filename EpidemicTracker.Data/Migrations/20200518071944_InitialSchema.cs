using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EpidemicTracker.Data.Migrations
{
    public partial class InitialSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddressType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserCreated = table.Column<string>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    UserModified = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OccupationType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserCreated = table.Column<string>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    UserModified = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OccupationType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    EmailId = table.Column<string>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserCreated = table.Column<string>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    UserModified = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    PhoneNo = table.Column<string>(nullable: false),
                    GovernmentIdNo = table.Column<string>(nullable: false),
                    OccupationTypeId = table.Column<int>(nullable: false),
                    OccCompanyName = table.Column<string>(nullable: true),
                    OccupationPhoneNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.EmailId);
                    table.ForeignKey(
                        name: "FK_User_OccupationType_OccupationTypeId",
                        column: x => x.OccupationTypeId,
                        principalTable: "OccupationType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserCreated = table.Column<string>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    UserModified = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    HouseNo = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    Locality = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    EmailId = table.Column<string>(nullable: true),
                    AddressTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_AddressType_AddressTypeId",
                        column: x => x.AddressTypeId,
                        principalTable: "AddressType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Address_User_EmailId",
                        column: x => x.EmailId,
                        principalTable: "User",
                        principalColumn: "EmailId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_AddressTypeId",
                table: "Address",
                column: "AddressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_EmailId",
                table: "Address",
                column: "EmailId");

            migrationBuilder.CreateIndex(
                name: "IX_User_OccupationTypeId",
                table: "User",
                column: "OccupationTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "AddressType");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "OccupationType");
        }
    }
}
