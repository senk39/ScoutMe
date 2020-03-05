using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class IdolCharactersV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "WaistSize",
                table: "IdolCharacters",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<byte>(
                name: "HipsSize",
                table: "IdolCharacters",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<byte>(
                name: "BustSize",
                table: "IdolCharacters",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "IdolCharacters",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "Group",
                table: "IdolCharacters",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SchoolClass",
                table: "IdolCharacters",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Subunit",
                table: "IdolCharacters",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Group",
                table: "IdolCharacters");

            migrationBuilder.DropColumn(
                name: "SchoolClass",
                table: "IdolCharacters");

            migrationBuilder.DropColumn(
                name: "Subunit",
                table: "IdolCharacters");

            migrationBuilder.AlterColumn<byte>(
                name: "WaistSize",
                table: "IdolCharacters",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(byte),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "HipsSize",
                table: "IdolCharacters",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(byte),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "BustSize",
                table: "IdolCharacters",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(byte),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "IdolCharacters",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }
}
