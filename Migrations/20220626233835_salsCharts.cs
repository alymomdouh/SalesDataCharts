using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesDataCharts.Migrations
{
    public partial class salsCharts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "salesEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonthName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalSales = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salesEntities", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "salesEntities");
        }
    }
}
