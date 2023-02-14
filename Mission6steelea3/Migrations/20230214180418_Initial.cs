using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6steelea3.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    FormId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    Rating = table.Column<string>(nullable: true),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.FormId);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "FormId", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Christopher Nolan", false, "", "", "PG-13", "Inception", 2010 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "FormId", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Taika Waititi", false, "", "", "R", "Eagle vs Shark", 2007 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "FormId", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Tyler Nilson, Michael Schwartz", false, "", "", "PG-13", "The Peanut Butter Falcon", 2019 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
