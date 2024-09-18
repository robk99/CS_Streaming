using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CS.User.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, "john-1.doe-1@fakemail12.com", "John-1", "Doe-1" },
                    { 2, "john-2.doe-2@fakemail12.com", "John-2", "Doe-2" },
                    { 3, "john-3.doe-3@fakemail12.com", "John-3", "Doe-3" },
                    { 4, "john-4.doe-4@fakemail12.com", "John-4", "Doe-4" },
                    { 5, "john-5.doe-5@fakemail12.com", "John-5", "Doe-5" },
                    { 6, "john-6.doe-6@fakemail12.com", "John-6", "Doe-6" },
                    { 7, "john-7.doe-7@fakemail12.com", "John-7", "Doe-7" },
                    { 8, "john-8.doe-8@fakemail12.com", "John-8", "Doe-8" },
                    { 9, "john-9.doe-9@fakemail12.com", "John-9", "Doe-9" },
                    { 10, "john-10.doe-10@fakemail12.com", "John-10", "Doe-10" }
                });

            migrationBuilder.Sql(@"
                CREATE PROCEDURE Users_Create
                    @Name NVARCHAR(100),
                    @Surname NVARCHAR(100),
                    @Email NVARCHAR(100)
                AS
                BEGIN
                    INSERT INTO Users (Name, Surname, Email)
                    VALUES (@Name, @Surname, @Email);
                    SELECT SCOPE_IDENTITY() AS NewUserId;
                END;
                GO
            ");

            migrationBuilder.Sql(@"
                CREATE PROCEDURE Users_GetById
                    @Id INT
                AS
                BEGIN
                    SELECT * FROM Users WHERE Id = @Id;
                END;
                GO
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS Users_Create;");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS Users_GetById;");
        }
    }
}
