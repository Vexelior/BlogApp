using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 27, 19, 6, 7, 988, DateTimeKind.Local).AddTicks(2215), new DateTime(2023, 4, 27, 19, 6, 7, 988, DateTimeKind.Local).AddTicks(2259) });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "CreatedAt", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 2, "This is my second post.", new DateTime(2023, 4, 27, 19, 6, 7, 988, DateTimeKind.Local).AddTicks(2271), "Second Post", new DateTime(2023, 4, 27, 19, 6, 7, 988, DateTimeKind.Local).AddTicks(2274) },
                    { 3, "This is my third post.", new DateTime(2023, 4, 27, 19, 6, 7, 988, DateTimeKind.Local).AddTicks(2279), "Third Post", new DateTime(2023, 4, 27, 19, 6, 7, 988, DateTimeKind.Local).AddTicks(2282) },
                    { 4, "This is my fourth post.", new DateTime(2023, 4, 27, 19, 6, 7, 988, DateTimeKind.Local).AddTicks(2285), "Fourth Post", new DateTime(2023, 4, 27, 19, 6, 7, 988, DateTimeKind.Local).AddTicks(2288) },
                    { 5, "This is my fifth post.", new DateTime(2023, 4, 27, 19, 6, 7, 988, DateTimeKind.Local).AddTicks(2292), "Fifth Post", new DateTime(2023, 4, 27, 19, 6, 7, 988, DateTimeKind.Local).AddTicks(2295) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
