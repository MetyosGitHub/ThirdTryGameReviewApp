using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThirdTryGameReviewApp.Data.Migrations
{
    public partial class GameOneSeedTry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "GenreId", "Name", "PictureURL", "PublisherId", "YearOfCreation" },
                values: new object[] { 1, "After destroying the Greek Pantheon Kratos is trying to teach his son how to not make the same mistakes again.", 1, "God Of War", null, 1, 2018 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
