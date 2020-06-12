using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksLookup.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Classification = table.Column<string>(maxLength: 10, nullable: false),
                    State = table.Column<string>(maxLength: 15, nullable: false),
                    Hours = table.Column<string>(nullable: true),
                    PhotoUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                });

            migrationBuilder.CreateTable(
                name: "Landmark",
                columns: table => new
                {
                    LandmarkId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParkId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Landmark", x => x.LandmarkId);
                    table.ForeignKey(
                        name: "FK_Landmark_Parks_ParkId",
                        column: x => x.ParkId,
                        principalTable: "Parks",
                        principalColumn: "ParkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Classification", "Hours", "Name", "PhotoUrl", "State" },
                values: new object[] { 1, "National", "27/7", "Yosemite", "www.sample.com", "California" });

            migrationBuilder.InsertData(
                table: "Landmark",
                columns: new[] { "LandmarkId", "Name", "ParkId" },
                values: new object[] { 1, "Yosemite Valley", 1 });

            migrationBuilder.InsertData(
                table: "Landmark",
                columns: new[] { "LandmarkId", "Name", "ParkId" },
                values: new object[] { 2, "Half Dome", 1 });

            migrationBuilder.InsertData(
                table: "Landmark",
                columns: new[] { "LandmarkId", "Name", "ParkId" },
                values: new object[] { 3, "YosemiteFalls", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Landmark_ParkId",
                table: "Landmark",
                column: "ParkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Landmark");

            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
