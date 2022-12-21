using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeworkBlog.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedTime",
                table: "Categories",
                newName: "CreateDate");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 12, 21, 22, 52, 16, 480, DateTimeKind.Local).AddTicks(8268));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Categories",
                newName: "CreatedTime");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2022, 12, 7, 20, 32, 18, 778, DateTimeKind.Local).AddTicks(7776));
        }
    }
}
