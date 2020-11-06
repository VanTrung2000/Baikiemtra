using Microsoft.EntityFrameworkCore.Migrations;

namespace BaiKiemTra.Migrations
{
    public partial class ew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TagsId",
                table: "Posts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_TagsId",
                table: "Posts",
                column: "TagsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Tags_TagsId",
                table: "Posts",
                column: "TagsId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Tags_TagsId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_TagsId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "TagsId",
                table: "Posts");
        }
    }
}
