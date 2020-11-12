using Microsoft.EntityFrameworkCore.Migrations;

namespace app02.Migrations
{
    public partial class _11novembro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Multa",
                table: "Indices",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "Juros",
                table: "Indices",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Multa",
                table: "Indices",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "Juros",
                table: "Indices",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
