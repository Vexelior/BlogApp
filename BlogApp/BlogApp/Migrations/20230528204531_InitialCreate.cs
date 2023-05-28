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
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", maxLength: 100000, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "CreatedAt", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Content for post 1", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6265), "Post 1", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6305) },
                    { 2, "Content for post 2", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6318), "Post 2", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6322) },
                    { 3, "Content for post 3", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6328), "Post 3", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6331) },
                    { 4, "Content for post 4", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6336), "Post 4", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6339) },
                    { 5, "Content for post 5", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6345), "Post 5", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6348) },
                    { 6, "Content for post 6", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6357), "Post 6", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6361) },
                    { 7, "Content for post 7", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6367), "Post 7", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6370) },
                    { 8, "Content for post 8", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6375), "Post 8", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6378) },
                    { 9, "Content for post 9", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6383), "Post 9", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6386) },
                    { 10, "Content for post 10", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6395), "Post 10", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6399) },
                    { 11, "Content for post 11", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6405), "Post 11", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6408) },
                    { 12, "Content for post 12", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6414), "Post 12", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6417) },
                    { 13, "Content for post 13", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6423), "Post 13", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6426) },
                    { 14, "Content for post 14", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6431), "Post 14", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6434) },
                    { 15, "Content for post 15", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6440), "Post 15", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6443) },
                    { 16, "Content for post 16", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6449), "Post 16", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6452) },
                    { 17, "Content for post 17", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6457), "Post 17", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6460) },
                    { 18, "Content for post 18", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6469), "Post 18", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6473) },
                    { 19, "Content for post 19", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6479), "Post 19", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6482) },
                    { 20, "Content for post 20", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6488), "Post 20", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6491) },
                    { 21, "Content for post 21", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6497), "Post 21", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6500) },
                    { 22, "Content for post 22", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6506), "Post 22", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6509) },
                    { 23, "Content for post 23", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6514), "Post 23", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6517) },
                    { 24, "Content for post 24", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6523), "Post 24", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6526) },
                    { 25, "Content for post 25", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6532), "Post 25", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6535) },
                    { 26, "Content for post 26", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6540), "Post 26", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6543) },
                    { 27, "Content for post 27", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6549), "Post 27", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6552) },
                    { 28, "Content for post 28", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6557), "Post 28", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6560) },
                    { 29, "Content for post 29", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6566), "Post 29", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6569) },
                    { 30, "Content for post 30", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6574), "Post 30", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6577) },
                    { 31, "Content for post 31", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6583), "Post 31", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6586) },
                    { 32, "Content for post 32", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6591), "Post 32", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6594) },
                    { 33, "Content for post 33", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6722), "Post 33", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6728) },
                    { 34, "Content for post 34", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6740), "Post 34", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6744) },
                    { 35, "Content for post 35", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6749), "Post 35", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6752) },
                    { 36, "Content for post 36", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6758), "Post 36", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6761) },
                    { 37, "Content for post 37", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6766), "Post 37", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6769) },
                    { 38, "Content for post 38", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6775), "Post 38", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6778) },
                    { 39, "Content for post 39", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6783), "Post 39", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6786) },
                    { 40, "Content for post 40", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6792), "Post 40", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6795) },
                    { 41, "Content for post 41", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6800), "Post 41", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6803) },
                    { 42, "Content for post 42", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6808), "Post 42", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6811) },
                    { 43, "Content for post 43", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6817), "Post 43", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6820) },
                    { 44, "Content for post 44", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6825), "Post 44", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6828) },
                    { 45, "Content for post 45", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6833), "Post 45", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6836) },
                    { 46, "Content for post 46", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6841), "Post 46", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6844) },
                    { 47, "Content for post 47", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6849), "Post 47", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6852) },
                    { 48, "Content for post 48", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6857), "Post 48", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6860) },
                    { 49, "Content for post 49", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6866), "Post 49", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6868) },
                    { 50, "Content for post 50", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6874), "Post 50", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6876) },
                    { 51, "Content for post 51", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6882), "Post 51", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6885) },
                    { 52, "Content for post 52", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6890), "Post 52", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6893) },
                    { 53, "Content for post 53", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6898), "Post 53", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6901) },
                    { 54, "Content for post 54", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6906), "Post 54", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6909) },
                    { 55, "Content for post 55", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6914), "Post 55", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6917) },
                    { 56, "Content for post 56", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6923), "Post 56", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6926) },
                    { 57, "Content for post 57", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6931), "Post 57", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6934) },
                    { 58, "Content for post 58", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6939), "Post 58", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6942) },
                    { 59, "Content for post 59", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6947), "Post 59", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6950) },
                    { 60, "Content for post 60", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6955), "Post 60", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6958) },
                    { 61, "Content for post 61", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6963), "Post 61", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6966) },
                    { 62, "Content for post 62", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6971), "Post 62", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6974) },
                    { 63, "Content for post 63", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6979), "Post 63", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6982) },
                    { 64, "Content for post 64", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6988), "Post 64", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6990) },
                    { 65, "Content for post 65", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6996), "Post 65", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(6999) },
                    { 66, "Content for post 66", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7007), "Post 66", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7011) },
                    { 67, "Content for post 67", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7016), "Post 67", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7019) },
                    { 68, "Content for post 68", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7025), "Post 68", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7028) },
                    { 69, "Content for post 69", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7033), "Post 69", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7036) },
                    { 70, "Content for post 70", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7041), "Post 70", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7044) },
                    { 71, "Content for post 71", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7049), "Post 71", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7052) },
                    { 72, "Content for post 72", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7057), "Post 72", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7060) },
                    { 73, "Content for post 73", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7065), "Post 73", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7068) },
                    { 74, "Content for post 74", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7120), "Post 74", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7125) },
                    { 75, "Content for post 75", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7132), "Post 75", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7135) },
                    { 76, "Content for post 76", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7141), "Post 76", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7145) },
                    { 77, "Content for post 77", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7151), "Post 77", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7154) },
                    { 78, "Content for post 78", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7159), "Post 78", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7162) },
                    { 79, "Content for post 79", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7168), "Post 79", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7171) },
                    { 80, "Content for post 80", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7176), "Post 80", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7179) },
                    { 81, "Content for post 81", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7185), "Post 81", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7188) },
                    { 82, "Content for post 82", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7193), "Post 82", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7196) },
                    { 83, "Content for post 83", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7202), "Post 83", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7205) },
                    { 84, "Content for post 84", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7210), "Post 84", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7213) },
                    { 85, "Content for post 85", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7219), "Post 85", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7222) },
                    { 86, "Content for post 86", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7227), "Post 86", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7230) },
                    { 87, "Content for post 87", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7236), "Post 87", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7239) },
                    { 88, "Content for post 88", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7245), "Post 88", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7248) },
                    { 89, "Content for post 89", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7253), "Post 89", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7256) },
                    { 90, "Content for post 90", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7262), "Post 90", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7265) },
                    { 91, "Content for post 91", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7270), "Post 91", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7273) },
                    { 92, "Content for post 92", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7279), "Post 92", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7282) },
                    { 93, "Content for post 93", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7287), "Post 93", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7290) },
                    { 94, "Content for post 94", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7296), "Post 94", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7299) },
                    { 95, "Content for post 95", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7304), "Post 95", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7307) },
                    { 96, "Content for post 96", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7313), "Post 96", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7316) },
                    { 97, "Content for post 97", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7321), "Post 97", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7324) },
                    { 98, "Content for post 98", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7330), "Post 98", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7333) },
                    { 99, "Content for post 99", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7338), "Post 99", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7341) },
                    { 100, "Content for post 100", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7347), "Post 100", new DateTime(2023, 5, 28, 13, 45, 31, 570, DateTimeKind.Local).AddTicks(7350) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
