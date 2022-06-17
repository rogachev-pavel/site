using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoGlassMarket.Migrations
{
    public partial class dbnew : Migration
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

            migrationBuilder.CreateTable(
                name: "allGlassesRP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    typeGlass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    img = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_allGlassesRP", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "allCarsRP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    carModel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    cartype = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    bodytype = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    carReleaseDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    size = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    price = table.Column<long>(type: "bigint", maxLength: 50, nullable: false),
                    fullinfo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    GlassesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_allCarsRP", x => x.Id);
                    table.ForeignKey(
                        name: "FK_allCarsRP_allGlassesRP_GlassesId",
                        column: x => x.GlassesId,
                        principalTable: "allGlassesRP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_allCarsRP_GlassesId",
                table: "allCarsRP",
                column: "GlassesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "allBuyersRP");

            migrationBuilder.DropTable(
                name: "allCarsRP");

            migrationBuilder.DropTable(
                name: "allGlassesRP");
        }
    }
}
