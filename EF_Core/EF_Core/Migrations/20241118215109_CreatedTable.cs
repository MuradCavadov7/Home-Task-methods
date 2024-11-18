using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core.Migrations
{
    /// <inheritdoc />
    public partial class CreatedTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Products_ProductsId",
                table: "Baskets");

            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Users_UsersId",
                table: "Baskets");

            migrationBuilder.DropIndex(
                name: "IX_Baskets_ProductsId",
                table: "Baskets");

            migrationBuilder.DropIndex(
                name: "IX_Baskets_UsersId",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "ProductsId",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Baskets");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductsId",
                table: "Baskets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "Baskets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_ProductsId",
                table: "Baskets",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_UsersId",
                table: "Baskets",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Products_ProductsId",
                table: "Baskets",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Users_UsersId",
                table: "Baskets",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
