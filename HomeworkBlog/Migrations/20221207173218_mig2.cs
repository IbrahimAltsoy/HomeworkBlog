using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeworkBlog.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedTime", "Email", "IsActive", "IsAdmin", "Name", "Password", "Surname" },
                values: new object[] { 1, new DateTime(2022, 12, 7, 20, 32, 18, 778, DateTimeKind.Local).AddTicks(7776), "a@gmail.com", true, true, "Admin", "123", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
