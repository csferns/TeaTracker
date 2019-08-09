using Microsoft.EntityFrameworkCore.Migrations;

namespace TeaTracker.Data.Migrations
{
    public partial class Unit_Change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "CupSize",
                schema: "core",
                table: "History",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "VolumeUnit",
                schema: "core",
                table: "History",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VolumeUnit",
                schema: "core",
                table: "History");

            migrationBuilder.AlterColumn<int>(
                name: "CupSize",
                schema: "core",
                table: "History",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
