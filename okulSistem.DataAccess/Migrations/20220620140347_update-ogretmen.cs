using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace okulSistem.DataAccess.Migrations
{
    public partial class updateogretmen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ogretmenDers",
                table: "Ogretmenler");

            migrationBuilder.AddColumn<int>(
                name: "ogretmenDersdersId",
                table: "Ogretmenler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ogretmenler_ogretmenDersdersId",
                table: "Ogretmenler",
                column: "ogretmenDersdersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogretmenler_Dersler_ogretmenDersdersId",
                table: "Ogretmenler",
                column: "ogretmenDersdersId",
                principalTable: "Dersler",
                principalColumn: "dersId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogretmenler_Dersler_ogretmenDersdersId",
                table: "Ogretmenler");

            migrationBuilder.DropIndex(
                name: "IX_Ogretmenler_ogretmenDersdersId",
                table: "Ogretmenler");

            migrationBuilder.DropColumn(
                name: "ogretmenDersdersId",
                table: "Ogretmenler");

            migrationBuilder.AddColumn<string>(
                name: "ogretmenDers",
                table: "Ogretmenler",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
