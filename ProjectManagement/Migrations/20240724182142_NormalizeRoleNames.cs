using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectManagement.Migrations
{
    /// <inheritdoc />
    public partial class NormalizeRoleNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5eb4d375-e304-48cf-a550-5dbb01c2d13d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bff947d3-f05f-4e25-aa4e-eed9de3b0e22");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e13bbb73-5d33-4f0d-b0fe-b475f7a6892a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1cea12d0-bfc6-4d81-ac55-d4890f64c316", null, "User", "USER" },
                    { "8e73d9b0-32f1-4868-97f7-717134ed4c7e", null, "Manager", "MANAGER" },
                    { "f8bb2b42-1887-4658-86c8-b06500ee09e7", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1cea12d0-bfc6-4d81-ac55-d4890f64c316");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e73d9b0-32f1-4868-97f7-717134ed4c7e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8bb2b42-1887-4658-86c8-b06500ee09e7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5eb4d375-e304-48cf-a550-5dbb01c2d13d", null, "Manager", "Manager" },
                    { "bff947d3-f05f-4e25-aa4e-eed9de3b0e22", null, "User", "User" },
                    { "e13bbb73-5d33-4f0d-b0fe-b475f7a6892a", null, "Admin", "Admin" }
                });
        }
    }
}
