using Microsoft.EntityFrameworkCore.Migrations;

namespace app02.Migrations
{
    public partial class _2011202000 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Passwordconfirme",
                table: "Usuario",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Passwordconfirme",
                table: "Usuario");
        }
    }
}
