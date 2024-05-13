using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertyRenumbering.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedExistingDetailsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerCode",
                table: "ExistingDetails",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerCode",
                table: "ExistingDetails");
        }
    }
}
