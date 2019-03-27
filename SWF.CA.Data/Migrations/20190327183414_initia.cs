using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SWF.CA.Data.Migrations
{
    public partial class initia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InsuranceOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    MinSquareMeter = table.Column<int>(nullable: false),
                    MaxSquareMeter = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceOptions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "InsuranceOptions",
                columns: new[] { "Id", "MaxSquareMeter", "MinSquareMeter", "Name" },
                values: new object[] { new Guid("c91dd9e9-7af5-4aa8-87ea-dca5d869af3b"), 50, 0, "LowCostOption" });

            migrationBuilder.InsertData(
                table: "InsuranceOptions",
                columns: new[] { "Id", "MaxSquareMeter", "MinSquareMeter", "Name" },
                values: new object[] { new Guid("9b9fe51d-8c9f-4b0f-b2ca-b1293aea5c67"), 100, 51, "MediumCostOption" });

            migrationBuilder.InsertData(
                table: "InsuranceOptions",
                columns: new[] { "Id", "MaxSquareMeter", "MinSquareMeter", "Name" },
                values: new object[] { new Guid("5e65ea0b-e2d6-423d-ae72-fd1b74bd4430"), 10000, 101, "HighCostOption" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InsuranceOptions");
        }
    }
}
