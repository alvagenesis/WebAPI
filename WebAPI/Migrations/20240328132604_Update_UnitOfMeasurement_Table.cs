using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Update_UnitOfMeasurement_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsSmallestUnit",
                table: "UnitOfMeasurements",
                type: "bit",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,4)");

            migrationBuilder.AddColumn<decimal>(
                name: "ConversionToSmallestUnit",
                table: "UnitOfMeasurements",
                type: "decimal(10,4)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConversionToSmallestUnit",
                table: "UnitOfMeasurements");

            migrationBuilder.AlterColumn<decimal>(
                name: "IsSmallestUnit",
                table: "UnitOfMeasurements",
                type: "decimal(10,4)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
