using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocalGovts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalGovts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mechants",
                columns: table => new
                {
                    MerchantId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactPersonFirstname = table.Column<string>(maxLength: 100, nullable: true),
                    ContactPersonLastname = table.Column<string>(maxLength: 100, nullable: true),
                    EmailAddress = table.Column<string>(maxLength: 150, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 20, nullable: true),
                    Website = table.Column<string>(maxLength: 250, nullable: true),
                    Location = table.Column<string>(maxLength: 100, nullable: true),
                    Profession = table.Column<string>(maxLength: 150, nullable: true),
                    ProfessionId = table.Column<long>(nullable: false),
                    Services = table.Column<long>(nullable: false),
                    ImageName = table.Column<string>(maxLength: 250, nullable: true),
                    Address = table.Column<string>(maxLength: 250, nullable: true),
                    City = table.Column<string>(maxLength: 150, nullable: true),
                    State = table.Column<string>(maxLength: 100, nullable: true),
                    StateId = table.Column<long>(nullable: false),
                    LocalGovt = table.Column<string>(maxLength: 150, nullable: true),
                    LocalGovtId = table.Column<long>(nullable: false),
                    EnrollerName = table.Column<string>(maxLength: 150, nullable: true),
                    EnrollerUserId = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    DateRegistered = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mechants", x => x.MerchantId);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MerchantId = table.Column<long>(nullable: false),
                    ServiceId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceSetups",
                columns: table => new
                {
                    ServiceId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(maxLength: 250, nullable: true),
                    DateEntered = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceSetups", x => x.ServiceId);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VerifiedInfos",
                columns: table => new
                {
                    VerifyId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MerchantId = table.Column<long>(nullable: false),
                    EmailAddress = table.Column<bool>(nullable: false),
                    PhoneNumber = table.Column<bool>(nullable: false),
                    Address = table.Column<bool>(nullable: false),
                    BusinessName = table.Column<bool>(nullable: false),
                    VerifierName = table.Column<string>(maxLength: 150, nullable: true),
                    DateVerified = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VerifiedInfos", x => x.VerifyId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalGovts");

            migrationBuilder.DropTable(
                name: "Mechants");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "ServiceSetups");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "VerifiedInfos");
        }
    }
}
