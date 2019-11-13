using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TLC_WebApp.Data.Migrations
{
    public partial class GameBoards : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GameBoard",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TopLeft = table.Column<string>(nullable: true),
                    TopMiddle = table.Column<string>(nullable: true),
                    TopRight = table.Column<string>(nullable: true),
                    MiddleLeft = table.Column<string>(nullable: true),
                    MiddleMiddle = table.Column<string>(nullable: true),
                    MiddleRight = table.Column<string>(nullable: true),
                    BottomLeft = table.Column<string>(nullable: true),
                    BottomMiddle = table.Column<string>(nullable: true),
                    BottomRight = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameBoard", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameBoard");
        }
    }
}
