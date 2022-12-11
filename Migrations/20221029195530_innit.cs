using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp2.Migrations
{
    public partial class innit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    author_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    author_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    author_age = table.Column<int>(type: "int", nullable: false),
                    author_password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    author_username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    author_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    author_isBlocked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.author_id);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    owner_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    owner_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    owner_password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    owner_age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.owner_id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    blog_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    blog_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    blog_desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ownerid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.blog_id);
                    table.ForeignKey(
                        name: "FK_Blogs_Owners_ownerid",
                        column: x => x.ownerid,
                        principalTable: "Owners",
                        principalColumn: "owner_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    post_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    post_title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    post_brief = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    post_desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    post_media = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    post_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    blog_id1 = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    blog_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.post_id);
                    table.ForeignKey(
                        name: "FK_Posts_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "author_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Blogs_blog_id1",
                        column: x => x.blog_id1,
                        principalTable: "Blogs",
                        principalColumn: "blog_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_ownerid",
                table: "Blogs",
                column: "ownerid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_AuthorId",
                table: "Posts",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_blog_id1",
                table: "Posts",
                column: "blog_id1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Owners");
        }
    }
}
