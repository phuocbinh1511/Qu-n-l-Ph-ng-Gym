using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quản_lý_Phòng_Gym.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GoiTaps",
                columns: table => new
                {
                    MaGoi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenGoi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaTien = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoiTaps", x => x.MaGoi);
                });

            migrationBuilder.CreateTable(
                name: "HoiViens",
                columns: table => new
                {
                    MaHoiVien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaGoi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoiViens", x => x.MaHoiVien);
                    table.ForeignKey(
                        name: "FK_HoiViens_GoiTaps_MaGoi",
                        column: x => x.MaGoi,
                        principalTable: "GoiTaps",
                        principalColumn: "MaGoi",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoiViens_MaGoi",
                table: "HoiViens",
                column: "MaGoi");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoiViens");

            migrationBuilder.DropTable(
                name: "GoiTaps");
        }
    }
}
