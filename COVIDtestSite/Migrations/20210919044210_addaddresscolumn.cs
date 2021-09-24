using Microsoft.EntityFrameworkCore.Migrations;

namespace COVIDtestSite.Migrations
{
    public partial class addaddresscolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "TestingSite",
                type: "nvarchar(max)",
                nullable: true);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "Address",
                table: "TestingSite");

   

          
        }
    }
}
