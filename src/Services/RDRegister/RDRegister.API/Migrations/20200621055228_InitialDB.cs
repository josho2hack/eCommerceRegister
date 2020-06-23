using Microsoft.EntityFrameworkCore.Migrations;

namespace RDRegister.API.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RDTraineds",
                columns: table => new
                {
                    OfficerId = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RDTraineds", x => x.OfficerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RDTraineds");
        }
    }
}
