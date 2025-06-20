using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodePulseAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddingBlogImageDomainModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileExtension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogImages", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("061265f3-cdfb-428f-8c8d-08db6cab4598"),
                column: "PublishedDate",
                value: new DateTime(2025, 6, 19, 16, 35, 7, 353, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("7ced7773-a5e1-4eaa-8c8a-08db6cab4598"),
                column: "PublishedDate",
                value: new DateTime(2025, 6, 19, 16, 35, 7, 353, DateTimeKind.Local).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("81495368-62a1-434c-7268-08db615ccdfb"),
                column: "PublishedDate",
                value: new DateTime(2025, 6, 19, 16, 35, 7, 353, DateTimeKind.Local).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("908ba10a-f3cd-4918-8c8b-08db6cab4598"),
                column: "PublishedDate",
                value: new DateTime(2025, 6, 19, 16, 35, 7, 353, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("9449dc77-3fc4-4b72-8c8c-08db6cab4598"),
                column: "PublishedDate",
                value: new DateTime(2025, 6, 19, 16, 35, 7, 353, DateTimeKind.Local).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("f02bb5b2-1bb3-44f6-7267-08db615ccdfb"),
                column: "PublishedDate",
                value: new DateTime(2025, 6, 19, 16, 35, 7, 353, DateTimeKind.Local).AddTicks(6228));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogImages");

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
        }
    }
}
