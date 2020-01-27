using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.api.Migrations
{
    public partial class fixedlookingforcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LookinFor",
                table: "Users",
                newName: "LookingFor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LookingFor",
                table: "Users",
                newName: "LookinFor");
        }
    }
}
