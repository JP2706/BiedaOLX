using Microsoft.EntityFrameworkCore.Migrations;

namespace BiedaOLX.Data.Migrations
{
    public partial class NotOrUseds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NotOrUsedId",
                table: "Announcements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "Announcements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "NotOrUseds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotOrUseds", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_NotOrUsedId",
                table: "Announcements",
                column: "NotOrUsedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Announcements_NotOrUseds_NotOrUsedId",
                table: "Announcements",
                column: "NotOrUsedId",
                principalTable: "NotOrUseds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Announcements_NotOrUseds_NotOrUsedId",
                table: "Announcements");

            migrationBuilder.DropTable(
                name: "NotOrUseds");

            migrationBuilder.DropIndex(
                name: "IX_Announcements_NotOrUsedId",
                table: "Announcements");

            migrationBuilder.DropColumn(
                name: "NotOrUsedId",
                table: "Announcements");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Announcements");
        }
    }
}
