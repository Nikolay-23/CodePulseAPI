using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodePulseAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationShips : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogPostCategory",
                columns: table => new
                {
                    BlogPostsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostCategory", x => new { x.BlogPostsId, x.CategoriesId });
                    table.ForeignKey(
                        name: "FK_BlogPostCategory_BlogPosts_BlogPostsId",
                        column: x => x.BlogPostsId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogPostCategory_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("061265f3-cdfb-428f-8c8d-08db6cab4598"),
                column: "PublishedDate",
                value: new DateTime(2025, 6, 17, 1, 18, 1, 133, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("7ced7773-a5e1-4eaa-8c8a-08db6cab4598"),
                column: "PublishedDate",
                value: new DateTime(2025, 6, 17, 1, 18, 1, 133, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("81495368-62a1-434c-7268-08db615ccdfb"),
                column: "PublishedDate",
                value: new DateTime(2025, 6, 17, 1, 18, 1, 133, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("908ba10a-f3cd-4918-8c8b-08db6cab4598"),
                column: "PublishedDate",
                value: new DateTime(2025, 6, 17, 1, 18, 1, 133, DateTimeKind.Local).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("9449dc77-3fc4-4b72-8c8c-08db6cab4598"),
                column: "PublishedDate",
                value: new DateTime(2025, 6, 17, 1, 18, 1, 133, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("f02bb5b2-1bb3-44f6-7267-08db615ccdfb"),
                column: "PublishedDate",
                value: new DateTime(2025, 6, 17, 1, 18, 1, 133, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostCategory_CategoriesId",
                table: "BlogPostCategory",
                column: "CategoriesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogPostCategory");

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("061265f3-cdfb-428f-8c8d-08db6cab4598"),
                column: "PublishedDate",
                value: new DateTime(2025, 6, 16, 2, 55, 24, 647, DateTimeKind.Local).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("7ced7773-a5e1-4eaa-8c8a-08db6cab4598"),
                column: "PublishedDate",
                value: new DateTime(2025, 6, 16, 2, 55, 24, 647, DateTimeKind.Local).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("81495368-62a1-434c-7268-08db615ccdfb"),
                column: "PublishedDate",
                value: new DateTime(2025, 6, 16, 2, 55, 24, 647, DateTimeKind.Local).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("908ba10a-f3cd-4918-8c8b-08db6cab4598"),
                column: "PublishedDate",
                value: new DateTime(2025, 6, 16, 2, 55, 24, 647, DateTimeKind.Local).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("9449dc77-3fc4-4b72-8c8c-08db6cab4598"),
                column: "PublishedDate",
                value: new DateTime(2025, 6, 16, 2, 55, 24, 647, DateTimeKind.Local).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("f02bb5b2-1bb3-44f6-7267-08db615ccdfb"),
                column: "PublishedDate",
                value: new DateTime(2025, 6, 16, 2, 55, 24, 647, DateTimeKind.Local).AddTicks(3082));
        }
    }
}
