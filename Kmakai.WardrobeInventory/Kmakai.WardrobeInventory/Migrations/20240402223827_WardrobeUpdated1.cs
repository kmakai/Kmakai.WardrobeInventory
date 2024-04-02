using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kmakai.WardrobeInventory.Migrations
{
    /// <inheritdoc />
    public partial class WardrobeUpdated1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WardrobeItems_wardrobes_WardrobeId",
                table: "WardrobeItems");

            migrationBuilder.DropIndex(
                name: "IX_WardrobeItems_WardrobeId",
                table: "WardrobeItems");

            migrationBuilder.DropColumn(
                name: "WardrobeId",
                table: "WardrobeItems");

            migrationBuilder.AddColumn<int>(
                name: "BottomId",
                table: "wardrobes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FootwearId",
                table: "wardrobes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TopId",
                table: "wardrobes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_wardrobes_BottomId",
                table: "wardrobes",
                column: "BottomId");

            migrationBuilder.CreateIndex(
                name: "IX_wardrobes_FootwearId",
                table: "wardrobes",
                column: "FootwearId");

            migrationBuilder.CreateIndex(
                name: "IX_wardrobes_TopId",
                table: "wardrobes",
                column: "TopId");

            migrationBuilder.AddForeignKey(
                name: "FK_wardrobes_WardrobeItems_BottomId",
                table: "wardrobes",
                column: "BottomId",
                principalTable: "WardrobeItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_wardrobes_WardrobeItems_FootwearId",
                table: "wardrobes",
                column: "FootwearId",
                principalTable: "WardrobeItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_wardrobes_WardrobeItems_TopId",
                table: "wardrobes",
                column: "TopId",
                principalTable: "WardrobeItems",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_wardrobes_WardrobeItems_BottomId",
                table: "wardrobes");

            migrationBuilder.DropForeignKey(
                name: "FK_wardrobes_WardrobeItems_FootwearId",
                table: "wardrobes");

            migrationBuilder.DropForeignKey(
                name: "FK_wardrobes_WardrobeItems_TopId",
                table: "wardrobes");

            migrationBuilder.DropIndex(
                name: "IX_wardrobes_BottomId",
                table: "wardrobes");

            migrationBuilder.DropIndex(
                name: "IX_wardrobes_FootwearId",
                table: "wardrobes");

            migrationBuilder.DropIndex(
                name: "IX_wardrobes_TopId",
                table: "wardrobes");

            migrationBuilder.DropColumn(
                name: "BottomId",
                table: "wardrobes");

            migrationBuilder.DropColumn(
                name: "FootwearId",
                table: "wardrobes");

            migrationBuilder.DropColumn(
                name: "TopId",
                table: "wardrobes");

            migrationBuilder.AddColumn<int>(
                name: "WardrobeId",
                table: "WardrobeItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WardrobeItems_WardrobeId",
                table: "WardrobeItems",
                column: "WardrobeId");

            migrationBuilder.AddForeignKey(
                name: "FK_WardrobeItems_wardrobes_WardrobeId",
                table: "WardrobeItems",
                column: "WardrobeId",
                principalTable: "wardrobes",
                principalColumn: "Id");
        }
    }
}
