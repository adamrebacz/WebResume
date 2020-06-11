using Microsoft.EntityFrameworkCore.Migrations;

namespace WebResume.MVC.Migrations
{
    public partial class AddedStringItemsToSection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SectionId",
                table: "StringItems",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StringItems_SectionId",
                table: "StringItems",
                column: "SectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_StringItems_Sections_SectionId",
                table: "StringItems",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StringItems_Sections_SectionId",
                table: "StringItems");

            migrationBuilder.DropIndex(
                name: "IX_StringItems_SectionId",
                table: "StringItems");

            migrationBuilder.DropColumn(
                name: "SectionId",
                table: "StringItems");
        }
    }
}
