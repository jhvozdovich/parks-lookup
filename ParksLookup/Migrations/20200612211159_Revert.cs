using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksLookup.Migrations
{
    public partial class Revert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Landmark_Parks_ParkId",
                table: "Landmark");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Landmark",
                table: "Landmark");

            migrationBuilder.RenameTable(
                name: "Landmark",
                newName: "Landmarks");

            migrationBuilder.RenameIndex(
                name: "IX_Landmark_ParkId",
                table: "Landmarks",
                newName: "IX_Landmarks_ParkId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Landmarks",
                table: "Landmarks",
                column: "LandmarkId");

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Classification", "Hours", "Name", "PhotoUrl", "State" },
                values: new object[] { 4, "National", "24/7", "Everglades", "https://www.nps.gov/common/uploads/banner_image/akr/homepage/510DA558-1DD8-B71B-0BF2DBBE49B06F9F.jpg", "Florida" });

            migrationBuilder.AddForeignKey(
                name: "FK_Landmarks_Parks_ParkId",
                table: "Landmarks",
                column: "ParkId",
                principalTable: "Parks",
                principalColumn: "ParkId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Landmarks_Parks_ParkId",
                table: "Landmarks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Landmarks",
                table: "Landmarks");

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.RenameTable(
                name: "Landmarks",
                newName: "Landmark");

            migrationBuilder.RenameIndex(
                name: "IX_Landmarks_ParkId",
                table: "Landmark",
                newName: "IX_Landmark_ParkId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Landmark",
                table: "Landmark",
                column: "LandmarkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Landmark_Parks_ParkId",
                table: "Landmark",
                column: "ParkId",
                principalTable: "Parks",
                principalColumn: "ParkId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
