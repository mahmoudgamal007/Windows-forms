using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp2.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Blogs_blog_id1",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "blog_id",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "blog_id1",
                table: "Posts",
                newName: "BlogId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_blog_id1",
                table: "Posts",
                newName: "IX_Posts_BlogId");

            migrationBuilder.RenameColumn(
                name: "blog_id",
                table: "Blogs",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Blogs_BlogId",
                table: "Posts",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Blogs_BlogId",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "BlogId",
                table: "Posts",
                newName: "blog_id1");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_BlogId",
                table: "Posts",
                newName: "IX_Posts_blog_id1");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Blogs",
                newName: "blog_id");

            migrationBuilder.AddColumn<int>(
                name: "blog_id",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Blogs_blog_id1",
                table: "Posts",
                column: "blog_id1",
                principalTable: "Blogs",
                principalColumn: "blog_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
