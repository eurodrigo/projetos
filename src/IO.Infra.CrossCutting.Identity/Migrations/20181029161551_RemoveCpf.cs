using Microsoft.EntityFrameworkCore.Migrations;

namespace IO.Infra.CrossCutting.Identity.Migrations
{
    public partial class RemoveCpf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPF",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "AspNetUsers",
                nullable: true);
        }
    }
}
