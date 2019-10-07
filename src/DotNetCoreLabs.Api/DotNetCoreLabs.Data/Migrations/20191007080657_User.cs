using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreLabs.Data.Migrations
{
    public partial class User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Username = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Firstname = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Email", "Firstname", "Lastname", "Username" },
                values: new object[] { 1, new DateTime(1994, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "luka.vavetic@gmail.com", "Luka", "Vavetić", "Lukaku" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Email", "Firstname", "Lastname", "Username" },
                values: new object[] { 2, new DateTime(1989, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "frano.sasavi@gmail.com", "Frano", "Sasvari", "Fusari" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
