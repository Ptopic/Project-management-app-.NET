using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectManagement.Migrations
{
    /// <inheritdoc />
    public partial class FixRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02e1ae04-e50d-4d94-a01f-85a36959ccc0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23718d45-afca-4bbc-9cd8-14f6fca96e96");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "407a1a67-6bcf-4c31-8a30-f370f1284c8e");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "02e1ae04-e50d-4d94-a01f-85a36959ccc0", null, "user", null },
                    { "23718d45-afca-4bbc-9cd8-14f6fca96e96", null, "manager", null },
                    { "407a1a67-6bcf-4c31-8a30-f370f1284c8e", null, "admin", "user" }
                });
        }
    }
}
