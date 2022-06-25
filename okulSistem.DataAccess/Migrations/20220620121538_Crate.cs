using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace okulSistem.DataAccess.Migrations
{
    public partial class Crate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ogrenciler",
                columns: table => new
                {
                    ogrenciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ogrenciAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ogreniciSoyadi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ogreniciNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ogreniciDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenciler", x => x.ogrenciId);
                });

            migrationBuilder.CreateTable(
                name: "Ogretmenler",
                columns: table => new
                {
                    ogretmenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ogretmenAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ogretmenSoyadi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ogretmenDers = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ogretmenDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogretmenler", x => x.ogretmenId);
                });

            migrationBuilder.CreateTable(
                name: "Dersler",
                columns: table => new
                {
                    dersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dersAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    dersAciklama = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    dersDurum = table.Column<bool>(type: "bit", nullable: false),
                    ogrenciId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dersler", x => x.dersId);
                    table.ForeignKey(
                        name: "FK_Dersler_Ogrenciler_ogrenciId",
                        column: x => x.ogrenciId,
                        principalTable: "Ogrenciler",
                        principalColumn: "ogrenciId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dersler_ogrenciId",
                table: "Dersler",
                column: "ogrenciId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dersler");

            migrationBuilder.DropTable(
                name: "Ogretmenler");

            migrationBuilder.DropTable(
                name: "Ogrenciler");
        }
    }
}
