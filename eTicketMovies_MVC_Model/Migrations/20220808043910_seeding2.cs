using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTicketMovies_MVC_Model.Migrations
{
    public partial class seeding2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CinemaId", "Description", "EndDate", "ImageUrl", "MovieCategory", "Name", "Price", "ProducerId", "StartDate" },
                values: new object[,]
                {
                    { 1, 3, "This is the Life movie description", new DateTime(2022, 8, 18, 0, 39, 10, 524, DateTimeKind.Local).AddTicks(7493), "http://dotnethow.net/images/movies/movie-3.jpeg", 4, "Life", 39.5, 3, new DateTime(2022, 7, 29, 0, 39, 10, 524, DateTimeKind.Local).AddTicks(7464) },
                    { 2, 1, "This is the Shawshank Redemption description", new DateTime(2022, 8, 11, 0, 39, 10, 524, DateTimeKind.Local).AddTicks(7498), "http://dotnethow.net/images/movies/movie-1.jpeg", 1, "The Shawshank Redemption", 29.5, 1, new DateTime(2022, 8, 8, 0, 39, 10, 524, DateTimeKind.Local).AddTicks(7497) },
                    { 3, 4, "This is the Ghost movie description", new DateTime(2022, 8, 15, 0, 39, 10, 524, DateTimeKind.Local).AddTicks(7502), "http://dotnethow.net/images/movies/movie-4.jpeg", 5, "Ghost", 39.5, 4, new DateTime(2022, 8, 8, 0, 39, 10, 524, DateTimeKind.Local).AddTicks(7500) },
                    { 4, 1, "This is the Race movie description", new DateTime(2022, 8, 3, 0, 39, 10, 524, DateTimeKind.Local).AddTicks(7505), "http://dotnethow.net/images/movies/movie-6.jpeg", 4, "Race", 39.5, 2, new DateTime(2022, 7, 29, 0, 39, 10, 524, DateTimeKind.Local).AddTicks(7504) },
                    { 5, 1, "This is the Scoob movie description", new DateTime(2022, 8, 6, 0, 39, 10, 524, DateTimeKind.Local).AddTicks(7509), "http://dotnethow.net/images/movies/movie-7.jpeg", 6, "Scoob", 39.5, 3, new DateTime(2022, 7, 29, 0, 39, 10, 524, DateTimeKind.Local).AddTicks(7507) },
                    { 6, 1, "This is the Cold Soles movie description", new DateTime(2022, 8, 28, 0, 39, 10, 524, DateTimeKind.Local).AddTicks(7513), "http://dotnethow.net/images/movies/movie-8.jpeg", 3, "Cold Soles", 39.5, 5, new DateTime(2022, 8, 11, 0, 39, 10, 524, DateTimeKind.Local).AddTicks(7511) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
