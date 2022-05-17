using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jokes.Data.Migrations
{
    public partial class language : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Joke",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Language",
                table: "Joke");
        }
    }
}
