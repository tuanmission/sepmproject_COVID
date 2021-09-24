using Microsoft.EntityFrameworkCore.Migrations;

namespace COVIDtestSite.Migrations
{
    public partial class addcoordinatesprecision : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "longitude",
                table: "TestingSite",
                type: "decimal(12,9)",
                precision: 12,
                scale: 9,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "latitude",
                table: "TestingSite",
                type: "decimal(12,9)",
                precision: 12,
                scale: 9,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "longitude",
                table: "TestingSite",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,9)",
                oldPrecision: 12,
                oldScale: 9);

            migrationBuilder.AlterColumn<decimal>(
                name: "latitude",
                table: "TestingSite",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,9)",
                oldPrecision: 12,
                oldScale: 9);
        }
    }
}
