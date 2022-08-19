using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramwork.net5.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Departments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Departments",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
