using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerceProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewColumn_Users_PreferredCurrencyId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PreferredCurrencySymbol",
                table: "Users",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_PreferredCurrencySymbol",
                table: "Users",
                column: "PreferredCurrencySymbol");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Currencies_PreferredCurrencySymbol",
                table: "Users",
                column: "PreferredCurrencySymbol",
                principalTable: "Currencies",
                principalColumn: "Symbol");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Currencies_PreferredCurrencySymbol",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PreferredCurrencySymbol",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PreferredCurrencySymbol",
                table: "Users");
        }
    }
}
