using Microsoft.EntityFrameworkCore.Migrations;

namespace HotDeskApp.Migrations
{
    public partial class changeDeskDeviceIdToNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Desks_Devices_DeviceId",
                table: "Desks");

            migrationBuilder.AlterColumn<int>(
                name: "DeviceId",
                table: "Desks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Desks_Devices_DeviceId",
                table: "Desks",
                column: "DeviceId",
                principalTable: "Devices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Desks_Devices_DeviceId",
                table: "Desks");

            migrationBuilder.AlterColumn<int>(
                name: "DeviceId",
                table: "Desks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Desks_Devices_DeviceId",
                table: "Desks",
                column: "DeviceId",
                principalTable: "Devices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
