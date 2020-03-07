using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class IdolCharacterAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IdolCharacters",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NameDefault = table.Column<string>(nullable: true),
                    NameEng = table.Column<string>(nullable: true),
                    NameJp = table.Column<string>(nullable: true),
                    SurnameEng = table.Column<string>(nullable: true),
                    SurnameJp = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: true),
                    Group = table.Column<string>(nullable: true),
                    Subunit = table.Column<string>(nullable: true),
                    YearOfSchoool = table.Column<int>(nullable: true),
                    BustSize = table.Column<int>(nullable: true),
                    WaistSize = table.Column<int>(nullable: true),
                    HipsSize = table.Column<int>(nullable: true),
                    SeiyuuEng = table.Column<string>(nullable: true),
                    SeiyuuJp = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdolCharacters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Values",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Values", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Nico Yazawa" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Maki Nishikino" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Eli Ayase" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Honoka Kosaka" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Kotori Minami" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "Hanayo Koizumi" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Name" },
                values: new object[] { 7, "Umi Sonoda" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Name" },
                values: new object[] { 8, "Rin Hoshizora" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Name" },
                values: new object[] { 9, "Nozomi Tojo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdolCharacters");

            migrationBuilder.DropTable(
                name: "Values");
        }
    }
}
