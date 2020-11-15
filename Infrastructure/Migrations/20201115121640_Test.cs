using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sachs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSach = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TheLoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TacGia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NhaXuatBan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaBia = table.Column<int>(type: "int", nullable: false),
                    ViTri = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sachs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sachs");
        }
    }
}
