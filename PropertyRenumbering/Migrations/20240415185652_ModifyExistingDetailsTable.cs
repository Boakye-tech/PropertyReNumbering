using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertyRenumbering.Migrations
{
    /// <inheritdoc />
    public partial class ModifyExistingDetailsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocalityId",
                table: "ExistingDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocalityId",
                table: "ExistingDetails");
        }
    }
}
