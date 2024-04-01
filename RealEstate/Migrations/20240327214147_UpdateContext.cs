using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstate.Migrations
{
    /// <inheritdoc />
    public partial class UpdateContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Estates",
                columns: new[] { "Estate_Id", "Address", "Description", "Name" },
                values: new object[] { 1, "Apple Street", "Very nice house", "Home sweet home" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "Estate_Id",
                keyValue: 1);
        }
    }
}
