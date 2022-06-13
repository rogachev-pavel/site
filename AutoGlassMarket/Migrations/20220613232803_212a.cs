using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoGlassMarket.Migrations
{
    public partial class _212a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "allBuyersRP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    UserNumber = table.Column<long>(type: "bigint", nullable: false),
                    ProductInformation = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_allBuyersRP", x => x.Id);
                });

        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "allBuyersRP");

        }
    }
}
