using Microsoft.EntityFrameworkCore.Migrations;

namespace WebResume.MVC.Migrations
{
    public partial class AddedSectionDescriptionToSection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "sectionDescriptionId",
                table: "Sections",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sections_sectionDescriptionId",
                table: "Sections",
                column: "sectionDescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_SectionDescriptions_sectionDescriptionId",
                table: "Sections",
                column: "sectionDescriptionId",
                principalTable: "SectionDescriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sections_SectionDescriptions_sectionDescriptionId",
                table: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Sections_sectionDescriptionId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "sectionDescriptionId",
                table: "Sections");
        }
    }
}
