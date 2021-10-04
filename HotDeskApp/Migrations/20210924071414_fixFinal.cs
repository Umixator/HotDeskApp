using Microsoft.EntityFrameworkCore.Migrations;

namespace HotDeskApp.Migrations
{
    public partial class fixFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Desks_DeskId",
                table: "Devices");

            migrationBuilder.DropIndex(
                name: "IX_Devices_DeskId",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "DeskId",
                table: "Devices");

            migrationBuilder.CreateTable(
                name: "DeskDevice",
                columns: table => new
                {
                    DesksId = table.Column<int>(type: "int", nullable: false),
                    DevicesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeskDevice", x => new { x.DesksId, x.DevicesId });
                    table.ForeignKey(
                        name: "FK_DeskDevice_Desks_DesksId",
                        column: x => x.DesksId,
                        principalTable: "Desks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeskDevice_Devices_DevicesId",
                        column: x => x.DevicesId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeskDevice_DevicesId",
                table: "DeskDevice",
                column: "DevicesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeskDevice");

            migrationBuilder.AddColumn<int>(
                name: "DeskId",
                table: "Devices",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Devices_DeskId",
                table: "Devices",
                column: "DeskId");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Desks_DeskId",
                table: "Devices",
                column: "DeskId",
                principalTable: "Desks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
