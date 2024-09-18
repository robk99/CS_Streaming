using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CS.Session.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedSessionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MediaId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "EndTime", "MediaId", "StartTime", "State", "UserId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 9, 18, 8, 55, 11, 517, DateTimeKind.Local).AddTicks(3813), 2, new DateTime(2024, 9, 18, 7, 33, 11, 517, DateTimeKind.Local).AddTicks(3813), 5, 8 },
                    { 2L, new DateTime(2024, 9, 18, 8, 22, 11, 517, DateTimeKind.Local).AddTicks(3947), 1, new DateTime(2024, 9, 18, 7, 52, 11, 517, DateTimeKind.Local).AddTicks(3947), 5, 4 },
                    { 3L, new DateTime(2024, 9, 18, 8, 14, 11, 517, DateTimeKind.Local).AddTicks(3964), 3, new DateTime(2024, 9, 18, 7, 49, 11, 517, DateTimeKind.Local).AddTicks(3964), 5, 6 },
                    { 4L, new DateTime(2024, 9, 18, 11, 42, 11, 517, DateTimeKind.Local).AddTicks(3977), 3, new DateTime(2024, 9, 18, 8, 24, 11, 517, DateTimeKind.Local).AddTicks(3977), 5, 10 },
                    { 5L, new DateTime(2024, 9, 18, 9, 41, 11, 517, DateTimeKind.Local).AddTicks(3992), 3, new DateTime(2024, 9, 18, 8, 0, 11, 517, DateTimeKind.Local).AddTicks(3992), 5, 10 },
                    { 6L, new DateTime(2024, 9, 18, 9, 49, 11, 517, DateTimeKind.Local).AddTicks(4008), 2, new DateTime(2024, 9, 18, 7, 47, 11, 517, DateTimeKind.Local).AddTicks(4008), 5, 2 },
                    { 7L, new DateTime(2024, 9, 18, 8, 21, 11, 517, DateTimeKind.Local).AddTicks(4022), 2, new DateTime(2024, 9, 18, 7, 25, 11, 517, DateTimeKind.Local).AddTicks(4022), 5, 8 },
                    { 8L, new DateTime(2024, 9, 18, 9, 19, 11, 517, DateTimeKind.Local).AddTicks(4034), 3, new DateTime(2024, 9, 18, 8, 32, 11, 517, DateTimeKind.Local).AddTicks(4034), 5, 7 },
                    { 9L, new DateTime(2024, 9, 18, 8, 38, 11, 517, DateTimeKind.Local).AddTicks(4047), 1, new DateTime(2024, 9, 18, 8, 7, 11, 517, DateTimeKind.Local).AddTicks(4047), 5, 9 },
                    { 10L, new DateTime(2024, 9, 18, 9, 5, 11, 517, DateTimeKind.Local).AddTicks(4060), 2, new DateTime(2024, 9, 18, 7, 43, 11, 517, DateTimeKind.Local).AddTicks(4060), 5, 4 },
                    { 11L, new DateTime(2024, 9, 18, 11, 50, 11, 517, DateTimeKind.Local).AddTicks(4073), 1, new DateTime(2024, 9, 18, 8, 36, 11, 517, DateTimeKind.Local).AddTicks(4073), 5, 5 },
                    { 12L, new DateTime(2024, 9, 18, 8, 43, 11, 517, DateTimeKind.Local).AddTicks(4086), 1, new DateTime(2024, 9, 18, 7, 59, 11, 517, DateTimeKind.Local).AddTicks(4086), 5, 2 },
                    { 13L, new DateTime(2024, 9, 18, 10, 40, 11, 517, DateTimeKind.Local).AddTicks(4100), 3, new DateTime(2024, 9, 18, 8, 6, 11, 517, DateTimeKind.Local).AddTicks(4100), 5, 4 },
                    { 14L, new DateTime(2024, 9, 18, 9, 38, 11, 517, DateTimeKind.Local).AddTicks(4115), 3, new DateTime(2024, 9, 18, 8, 23, 11, 517, DateTimeKind.Local).AddTicks(4115), 5, 9 },
                    { 15L, new DateTime(2024, 9, 18, 8, 5, 11, 517, DateTimeKind.Local).AddTicks(4190), 2, new DateTime(2024, 9, 18, 7, 46, 11, 517, DateTimeKind.Local).AddTicks(4190), 5, 8 },
                    { 16L, new DateTime(2024, 9, 18, 11, 29, 11, 517, DateTimeKind.Local).AddTicks(4205), 3, new DateTime(2024, 9, 18, 8, 20, 11, 517, DateTimeKind.Local).AddTicks(4205), 5, 9 },
                    { 17L, new DateTime(2024, 9, 18, 10, 36, 11, 517, DateTimeKind.Local).AddTicks(4218), 3, new DateTime(2024, 9, 18, 7, 42, 11, 517, DateTimeKind.Local).AddTicks(4218), 5, 6 },
                    { 18L, new DateTime(2024, 9, 18, 9, 20, 11, 517, DateTimeKind.Local).AddTicks(4232), 1, new DateTime(2024, 9, 18, 8, 25, 11, 517, DateTimeKind.Local).AddTicks(4232), 5, 5 },
                    { 19L, new DateTime(2024, 9, 18, 8, 35, 11, 517, DateTimeKind.Local).AddTicks(4245), 2, new DateTime(2024, 9, 18, 8, 10, 11, 517, DateTimeKind.Local).AddTicks(4245), 5, 8 },
                    { 20L, new DateTime(2024, 9, 18, 10, 16, 11, 517, DateTimeKind.Local).AddTicks(4258), 3, new DateTime(2024, 9, 18, 7, 39, 11, 517, DateTimeKind.Local).AddTicks(4258), 5, 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sessions");
        }
    }
}
