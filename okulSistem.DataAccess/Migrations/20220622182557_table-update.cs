using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace okulSistem.DataAccess.Migrations
{
    public partial class tableupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dersler_Ogrenciler_ogrenciId",
                table: "Dersler");

            migrationBuilder.DropIndex(
                name: "IX_Dersler_ogrenciId",
                table: "Dersler");

            migrationBuilder.DropColumn(
                name: "ogrenciId",
                table: "Dersler");

            migrationBuilder.AddColumn<string>(
                name: "ogreniDersler",
                table: "Ogrenciler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ogreniDersler",
                table: "Ogrenciler");

            migrationBuilder.AddColumn<int>(
                name: "ogrenciId",
                table: "Dersler",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dersler_ogrenciId",
                table: "Dersler",
                column: "ogrenciId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dersler_Ogrenciler_ogrenciId",
                table: "Dersler",
                column: "ogrenciId",
                principalTable: "Ogrenciler",
                principalColumn: "ogrenciId");
        }
    }
}
