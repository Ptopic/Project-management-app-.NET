using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectManagement.Migrations
{
    /// <inheritdoc />
    public partial class FixRoleNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5481dc9-1306-43d3-95f7-98c43192b60a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb1901c7-4018-4be1-986a-aca8d7677a25");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7e3387f-e1be-49a9-b789-906fc77b898f");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "b5481dc9-1306-43d3-95f7-98c43192b60a", null, "user", "user" },
                    { "bb1901c7-4018-4be1-986a-aca8d7677a25", null, "manager", "manager" },
                    { "e7e3387f-e1be-49a9-b789-906fc77b898f", null, "admin", "admin" }
                });
        }
    }
}
