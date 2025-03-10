using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class AppUserUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyKnownAs",
                table: "Users",
                newName: "KnownAs");

            migrationBuilder.RenameColumn(
                name: "MyCreated",
                table: "Users",
                newName: "Created");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KnownAs",
                table: "Users",
                newName: "MyKnownAs");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Users",
                newName: "MyCreated");
        }
    }
}
