using Microsoft.EntityFrameworkCore.Migrations;

namespace HotDeskApp.Migrations
{
    public partial class createManyToManyDeskDevice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
