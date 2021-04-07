using Microsoft.EntityFrameworkCore.Migrations;

namespace BookList.Migrations
{
    public partial class addFamousQuote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "famousQuote",
                table: "Book",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "famousQuote",
                table: "Book");
        }
    }
}
