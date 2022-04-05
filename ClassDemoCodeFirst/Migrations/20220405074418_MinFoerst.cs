using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassDemoCodeFirst.Migrations
{
    public partial class MinFoerst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Adr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ancinitet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personer", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personer");
        }
    }
}
