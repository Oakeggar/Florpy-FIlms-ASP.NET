using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlorpyFIlms.Migrations
{
    /// <inheritdoc />
    public partial class sqlInjectShining : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FIlmCategory",
                table: "Movies",
                newName: "FilmCategory");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FilmCategory",
                table: "Movies",
                newName: "FIlmCategory");
        }
    }
}
