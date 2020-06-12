using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksLookup.Migrations
{
    public partial class InitialSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1,
                columns: new[] { "Hours", "PhotoUrl" },
                values: new object[] { "24/7", "https://www.nationalgeographic.com/content/dam/expeditions/destinations/north-america/private/Yosemite/Hero-Yosemite.ngsversion.1524840074980.adapt.1900.1.jpg" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Classification", "Hours", "Name", "PhotoUrl", "State" },
                values: new object[] { 2, "State", "25/8 (if you can find it)", "Gravity Falls", "https://vignette.wikia.nocookie.net/gravityfalls/images/2/22/Opening_Bigfoot.png/revision/latest?cb=20160119145704", "Oregon" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Classification", "Hours", "Name", "PhotoUrl", "State" },
                values: new object[] { 3, "National", "24/7", "Zion", "https://www.nps.gov/npgallery/GetAsset/988A495E-155D-451F-67EE640C7B3812F6/proxy/hires?", "Utah" });

            migrationBuilder.InsertData(
                table: "Landmark",
                columns: new[] { "LandmarkId", "Name", "ParkId" },
                values: new object[,]
                {
                    { 4, "Mystery Shack", 2 },
                    { 5, "Gravity Falls Forest", 2 },
                    { 6, "Lake Gravity falls", 2 },
                    { 7, "The Narrows", 3 },
                    { 8, "Angels Landing", 3 },
                    { 9, "Emerald Pools Trail", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Landmark",
                keyColumn: "LandmarkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Landmark",
                keyColumn: "LandmarkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Landmark",
                keyColumn: "LandmarkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Landmark",
                keyColumn: "LandmarkId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Landmark",
                keyColumn: "LandmarkId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Landmark",
                keyColumn: "LandmarkId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1,
                columns: new[] { "Hours", "PhotoUrl" },
                values: new object[] { "27/7", "www.sample.com" });
        }
    }
}
