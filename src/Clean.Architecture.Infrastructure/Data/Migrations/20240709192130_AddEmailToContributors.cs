using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clean.Architecture.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddEmailToContributors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Contributors",
                type: "TEXT",
                nullable: false,
                maxLength: 255,
                defaultValue:"example@example.com",
                comment: "Email address of the contributor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Contributors");
        }
    }
}
