using Microsoft.EntityFrameworkCore.Migrations;

namespace WebResume.MVC.Migrations
{
    public partial class AddedDateItemsToSection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SectionId",
                table: "DateItems",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DateItems_SectionId",
                table: "DateItems",
                column: "SectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_DateItems_Sections_SectionId",
                table: "DateItems",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DateItems_Sections_SectionId",
                table: "DateItems");

            migrationBuilder.DropIndex(
                name: "IX_DateItems_SectionId",
                table: "DateItems");

            migrationBuilder.DropColumn(
                name: "SectionId",
                table: "DateItems");
        }
    }
}
