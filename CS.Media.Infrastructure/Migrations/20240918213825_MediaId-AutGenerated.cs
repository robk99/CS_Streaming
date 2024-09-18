using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CS.Media.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MediaIdAutGenerated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MediaTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "EPG");

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 2,
                column: "LengthInSeconds",
                value: 13344);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 3,
                column: "LengthInSeconds",
                value: 1730);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 4,
                column: "LengthInSeconds",
                value: 2278);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 5,
                column: "LengthInSeconds",
                value: 6352);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 6,
                column: "LengthInSeconds",
                value: 7452);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 7,
                column: "LengthInSeconds",
                value: 11410);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 8,
                column: "LengthInSeconds",
                value: 3350);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 9,
                column: "LengthInSeconds",
                value: 5321);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 10,
                column: "LengthInSeconds",
                value: 10345);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 11,
                column: "LengthInSeconds",
                value: 3887);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 12,
                column: "LengthInSeconds",
                value: 1121);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 13,
                column: "LengthInSeconds",
                value: 193);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 14,
                column: "LengthInSeconds",
                value: 339);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 15,
                column: "LengthInSeconds",
                value: 1169);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 16,
                column: "LengthInSeconds",
                value: 3208);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 17,
                column: "LengthInSeconds",
                value: 2137);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 18,
                column: "LengthInSeconds",
                value: 1808);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 19,
                column: "LengthInSeconds",
                value: 3189);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 20,
                column: "LengthInSeconds",
                value: 1797);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 21,
                column: "LengthInSeconds",
                value: 424);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 22,
                column: "LengthInSeconds",
                value: 1676);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MediaTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "EPG-1");

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 2,
                column: "LengthInSeconds",
                value: 9219);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 3,
                column: "LengthInSeconds",
                value: 13918);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 4,
                column: "LengthInSeconds",
                value: 5999);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 5,
                column: "LengthInSeconds",
                value: 1825);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 6,
                column: "LengthInSeconds",
                value: 9976);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 7,
                column: "LengthInSeconds",
                value: 14020);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 8,
                column: "LengthInSeconds",
                value: 746);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 9,
                column: "LengthInSeconds",
                value: 7687);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 10,
                column: "LengthInSeconds",
                value: 12280);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 11,
                column: "LengthInSeconds",
                value: 11209);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 12,
                column: "LengthInSeconds",
                value: 927);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 13,
                column: "LengthInSeconds",
                value: 268);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 14,
                column: "LengthInSeconds",
                value: 88);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 15,
                column: "LengthInSeconds",
                value: 3396);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 16,
                column: "LengthInSeconds",
                value: 1960);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 17,
                column: "LengthInSeconds",
                value: 2847);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 18,
                column: "LengthInSeconds",
                value: 3456);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 19,
                column: "LengthInSeconds",
                value: 1726);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 20,
                column: "LengthInSeconds",
                value: 1854);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 21,
                column: "LengthInSeconds",
                value: 2353);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 22,
                column: "LengthInSeconds",
                value: 249);
        }
    }
}
