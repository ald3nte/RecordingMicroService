using Microsoft.EntityFrameworkCore.Migrations;

namespace RecordingMicroService.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Recordings",
                columns: new[] { "Id", "Name", "RecordingPath" },
                values: new object[] { 1, "hard guitar", "/recordings/hard_guitar.wav" });

            migrationBuilder.InsertData(
                table: "Recordings",
                columns: new[] { "Id", "Name", "RecordingPath" },
                values: new object[] { 2, "riif guitar", "/recordings/riff_guitar.wav" });

            migrationBuilder.InsertData(
                table: "Recordings",
                columns: new[] { "Id", "Name", "RecordingPath" },
                values: new object[] { 3, "soft guitar", "/recordings/soft_guitar.mp3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recordings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recordings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recordings",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
