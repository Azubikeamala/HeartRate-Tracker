using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AlbumApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedMoreAlbums : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "Artist", "Rating", "Songs", "Title" },
                values: new object[,]
                {
                    { 5, "Olamide", 8.8m, "Loading, Infinity, Triumphant", "Carpe Diem" },
                    { 6, "Kizz Daniel", 9.1m, "One Ticket, Madu, Bad", "No Bad Songz" },
                    { 7, "Fireboy DML", 8.7m, "Champion, Tattoo, Remember Me", "Apollo" },
                    { 8, "Adekunle Gold", 8.9m, "Something Different, Pretty Girl", "Afro Pop Vol. 1" },
                    { 9, "Rema", 9.2m, "Soundgasm, Calm Down, FYN", "Rave & Roses" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
