using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerceProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewController_Stores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatePublished = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OwnerUsername = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Domain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultCurrencySymbol = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FileStorageDomain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stores_Currencies_DefaultCurrencySymbol",
                        column: x => x.DefaultCurrencySymbol,
                        principalTable: "Currencies",
                        principalColumn: "Symbol");
                    table.ForeignKey(
                        name: "FK_Stores_Users_OwnerUsername",
                        column: x => x.OwnerUsername,
                        principalTable: "Users",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stores_DefaultCurrencySymbol",
                table: "Stores",
                column: "DefaultCurrencySymbol");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_OwnerUsername",
                table: "Stores",
                column: "OwnerUsername");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stores");
        }
    }
}
