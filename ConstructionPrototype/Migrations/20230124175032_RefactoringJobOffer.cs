using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConstructionPrototype.Migrations
{
    /// <inheritdoc />
    public partial class RefactoringJobOffer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "JobType",
                table: "JobOffers",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "JobName",
                table: "JobOffers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "JobLocation",
                table: "JobOffers",
                newName: "Location");

            migrationBuilder.RenameColumn(
                name: "JobId",
                table: "JobOffers",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "JobOffers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "JobOffers");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "JobOffers",
                newName: "JobType");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "JobOffers",
                newName: "JobName");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "JobOffers",
                newName: "JobLocation");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "JobOffers",
                newName: "JobId");
        }
    }
}
