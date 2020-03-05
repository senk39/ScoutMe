using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class IdolCharactersAdded2 : Migration
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
                    Birthday = table.Column<DateTime>(nullable: false),
                    BustSize = table.Column<byte>(nullable: false),
                    WaistSize = table.Column<byte>(nullable: false),
                    HipsSize = table.Column<byte>(nullable: false),
                    SeiyuuEng = table.Column<string>(nullable: true),
                    SeiyuuJp = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdolCharacters", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdolCharacters");
        }
    }
}
