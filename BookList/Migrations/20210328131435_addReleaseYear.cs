using Microsoft.EntityFrameworkCore.Migrations;

namespace BookList.Migrations
{
    public partial class addReleaseYear : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "yearRelease",
                table: "Book",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "yearRelease",
                table: "Book");
        }
    }
}
