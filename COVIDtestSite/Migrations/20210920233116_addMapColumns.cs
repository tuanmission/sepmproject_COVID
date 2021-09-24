using Microsoft.EntityFrameworkCore.Migrations;

namespace COVIDtestSite.Migrations
{
    public partial class addMapColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.AddColumn<decimal>(
                name: "latitude",
                table: "TestingSite",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "longitude",
                table: "TestingSite",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

        
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.DropColumn(
                name: "latitude",
                table: "TestingSite");

            migrationBuilder.DropColumn(
                name: "longitude",
                table: "TestingSite");

        }
    }
}
