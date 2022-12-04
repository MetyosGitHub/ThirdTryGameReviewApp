using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThirdTryGameReviewApp.Data.Migrations
{
    public partial class ReviewTry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Description", "GameId", "Score", "Title" },
                values: new object[] { 1, "I expected great action from God of War, and it delivers that handily. But I didn’t expect it to be a thrilling journey in which every aspect of it complements the others to form what is nothing short of a masterpiece. It’s a game in which Kratos, a previously one-note character, becomes a complex father, warrior, and monster, embattled both on the field and within his own heart about how to treat his son; one in which the world opens up and shifts, offering rewards in both gameplay and knowledge of its lore that I treasured with each accomplishment. The obvious care that went into crafting its world, characters, and gameplay delivers by far the most stirring and memorable game in the series.", 1, 10m, "God of War a true masterpiece" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
