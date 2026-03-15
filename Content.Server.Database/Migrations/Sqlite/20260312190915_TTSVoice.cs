using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Content.Server.Database.Migrations.Sqlite
{
    /// <inheritdoc />
    public partial class TTSVoice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "voice",
                table: "job");

            migrationBuilder.AddColumn<string>(
                name: "voice",
                table: "profile",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "voice",
                table: "profile");

            migrationBuilder.AddColumn<string>(
                name: "voice",
                table: "job",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
