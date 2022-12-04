using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThirdTryGameReviewApp.Data.Migrations
{
    public partial class GamesSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "GenreId", "Name", "PictureURL", "PublisherId", "YearOfCreation" },
                values: new object[,]
                {
                    { 2, "Play as one of Earth's most famous leaders on their quest to build the greatest country there is and will be.", 2, "Civilization 6", null, 2, 2016 },
                    { 3, "A team-based competitive game mode based on strategy and outplaying opponents. Players work with their team to break the enemy Nexus before the enemy team breaks theirs.", 3, "League Of Legends", null, 3, 2009 },
                    { 4, "A sequel to the 2019 reboot, and serves as the nineteenth installment in the overall Call of Duty series.", 4, "Call Of Duty Modern Warfare 2", null, 4, 2022 },
                    { 5, "A mobile game where you play as a detective who investigates the death of his cat in order to go back in time and prevent it from happening.", 5, "Time Enigma", null, 5, 2020 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
