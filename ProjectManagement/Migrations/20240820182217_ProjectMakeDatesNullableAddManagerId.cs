using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectManagement.Migrations
{
    /// <inheritdoc />
    public partial class ProjectMakeDatesNullableAddManagerId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_AspNetUsers_ManagerId",
                table: "Projects");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8bad4a17-7657-45ca-941a-eb47b611b5a4", "1f7ec708-e841-4ab2-846f-05c24fa18301" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a3182515-a66b-4e8c-8349-ff0fe944146b", "318f8ee8-cb12-4d95-9123-1d911a167f3f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8bad4a17-7657-45ca-941a-eb47b611b5a4", "95fd4abd-0626-49fd-956c-19438402a603" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ae1141df-e49c-4d54-a2fa-1e3ca8f4fa27", "97e0ae24-f7e2-4ad5-a1ee-570856fcf874" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a3182515-a66b-4e8c-8349-ff0fe944146b", "c33ee900-c261-4195-b8d6-2ac802657d95" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a3182515-a66b-4e8c-8349-ff0fe944146b", "e58ea87d-6a8f-49e0-939c-20d89f995574" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a3182515-a66b-4e8c-8349-ff0fe944146b", "f8d480c5-ebe1-45e3-a804-a9badf390003" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8bad4a17-7657-45ca-941a-eb47b611b5a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3182515-a66b-4e8c-8349-ff0fe944146b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae1141df-e49c-4d54-a2fa-1e3ca8f4fa27");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Projects",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ManagerId",
                table: "Projects",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Projects",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "360b7646-204c-4bb1-8cf7-555420c3c581", null, "Admin", "ADMIN" },
                    { "a625f37d-b755-4112-9f7f-74f02c9d7fa1", null, "User", "USER" },
                    { "bbb9ab3e-736a-4fd0-984d-56b9f28f7788", null, "Manager", "MANAGER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f7ec708-e841-4ab2-846f-05c24fa18301",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ddc0a29-e8da-479e-a540-f08aff8e1318", "AQAAAAIAAYagAAAAEK7p+8fI04hgdo432zbuOyY5SejMJD7FZi569NtwuLbolZ0waUFjczacLVDhvN22HA==", "27547c20-462d-4ca4-a3cb-d83ca5d244f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "318f8ee8-cb12-4d95-9123-1d911a167f3f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33967d1c-788c-4753-82d8-3e4b92e3353e", "AQAAAAIAAYagAAAAEPKZ5bEYao49KmVV6EYZ18aOWlf02kbpMvZqDQMS8oaaEg855yiFDG7XnzUG7of8Vg==", "1761de33-8800-484c-a3fb-023c23234a00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95fd4abd-0626-49fd-956c-19438402a603",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab050238-cee1-40c0-b653-c8f5e4b48861", "AQAAAAIAAYagAAAAEL6Mo6CKWcVqMrXKglXemBW5AuhREBx/Z6d4h2FiUQ+JBfZ1dtx1LxLEnoPRefLfLw==", "d883ee28-be2d-4f1e-985c-23c9a75113ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97e0ae24-f7e2-4ad5-a1ee-570856fcf874",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0361ee62-174a-4931-b17f-3a8a2d579b8c", "AQAAAAIAAYagAAAAELupAxwK1rIVj+Dgc6L7ozxQXh5qyzVuSlrW2FS1/pUutTo4T3bYcZYIr9ZY3j8mgw==", "a5f96e2d-1186-42dc-99e6-94ea7ec1d7b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c33ee900-c261-4195-b8d6-2ac802657d95",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f2e7e41-1489-46fe-a2a7-e1435d9c2c84", "AQAAAAIAAYagAAAAEAhrVXZ/omyqphUomHfaM6iHHmfH1xpmH20HIpLB9DWYcPv4oSqk4ZZyMxj0BwmHow==", "8bb97498-d1a1-40c9-88cb-03e507dcb75b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e58ea87d-6a8f-49e0-939c-20d89f995574",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5745281c-863d-44ce-8160-7cd7b3e4d54f", "AQAAAAIAAYagAAAAENbXprny4Xs7QZaLkpn1UH7Y0Uu6180+ip160vElYHz2WkO2+xxaoIUq8IfpTLQH7w==", "991b26e1-4de4-429c-8638-089ca18f4b85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8d480c5-ebe1-45e3-a804-a9badf390003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed056d70-ff5e-4596-92f4-f04df3246a38", "AQAAAAIAAYagAAAAEJRAGDOEsxOg9guLTdUo9vVRoQiKzPWDss7fMUonXlRMBLtKS88c9aZoHJa5a4D2Cg==", "c1ea6e9d-e0a7-4f23-9642-2b69e2baa7d2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bbb9ab3e-736a-4fd0-984d-56b9f28f7788", "1f7ec708-e841-4ab2-846f-05c24fa18301" },
                    { "a625f37d-b755-4112-9f7f-74f02c9d7fa1", "318f8ee8-cb12-4d95-9123-1d911a167f3f" },
                    { "bbb9ab3e-736a-4fd0-984d-56b9f28f7788", "95fd4abd-0626-49fd-956c-19438402a603" },
                    { "360b7646-204c-4bb1-8cf7-555420c3c581", "97e0ae24-f7e2-4ad5-a1ee-570856fcf874" },
                    { "a625f37d-b755-4112-9f7f-74f02c9d7fa1", "c33ee900-c261-4195-b8d6-2ac802657d95" },
                    { "a625f37d-b755-4112-9f7f-74f02c9d7fa1", "e58ea87d-6a8f-49e0-939c-20d89f995574" },
                    { "a625f37d-b755-4112-9f7f-74f02c9d7fa1", "f8d480c5-ebe1-45e3-a804-a9badf390003" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_AspNetUsers_ManagerId",
                table: "Projects",
                column: "ManagerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_AspNetUsers_ManagerId",
                table: "Projects");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bbb9ab3e-736a-4fd0-984d-56b9f28f7788", "1f7ec708-e841-4ab2-846f-05c24fa18301" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a625f37d-b755-4112-9f7f-74f02c9d7fa1", "318f8ee8-cb12-4d95-9123-1d911a167f3f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bbb9ab3e-736a-4fd0-984d-56b9f28f7788", "95fd4abd-0626-49fd-956c-19438402a603" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "360b7646-204c-4bb1-8cf7-555420c3c581", "97e0ae24-f7e2-4ad5-a1ee-570856fcf874" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a625f37d-b755-4112-9f7f-74f02c9d7fa1", "c33ee900-c261-4195-b8d6-2ac802657d95" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a625f37d-b755-4112-9f7f-74f02c9d7fa1", "e58ea87d-6a8f-49e0-939c-20d89f995574" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a625f37d-b755-4112-9f7f-74f02c9d7fa1", "f8d480c5-ebe1-45e3-a804-a9badf390003" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "360b7646-204c-4bb1-8cf7-555420c3c581");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a625f37d-b755-4112-9f7f-74f02c9d7fa1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bbb9ab3e-736a-4fd0-984d-56b9f28f7788");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Projects",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ManagerId",
                table: "Projects",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Projects",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8bad4a17-7657-45ca-941a-eb47b611b5a4", null, "Manager", "MANAGER" },
                    { "a3182515-a66b-4e8c-8349-ff0fe944146b", null, "User", "USER" },
                    { "ae1141df-e49c-4d54-a2fa-1e3ca8f4fa27", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f7ec708-e841-4ab2-846f-05c24fa18301",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3189690a-343c-4d59-9b77-ee320f38918a", "AQAAAAIAAYagAAAAEB7+8yHcPGmb/J1s0VZenyLDWDpxaJUGpY/JWxzERwVi+XuZojlF+2niVvXBetaO+A==", "adc79e4b-2f31-494c-9c68-2c5cea30bdac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "318f8ee8-cb12-4d95-9123-1d911a167f3f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7bef2f40-c0c8-43cb-ad18-0101e4bb03d9", "AQAAAAIAAYagAAAAEOt7lmulMsOu7UeyPHOM4kaTIFOv5pWWoTA7XThzPl0bBd3ATJXbWL3xe0YuRNZZag==", "b0a9dee8-cbbe-4d70-b236-ee4003cff89a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95fd4abd-0626-49fd-956c-19438402a603",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd59cea0-3592-41c3-9d3f-023881e16115", "AQAAAAIAAYagAAAAEPU5uC4w4CVRHTy7ckfMYHjqUYHXgrQLeY6AH2dUCMLGnZIlqYlNz0b7IAW5H0ULsQ==", "f677d692-2e92-415a-8578-12124a9d0206" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97e0ae24-f7e2-4ad5-a1ee-570856fcf874",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6373a55-6488-49ba-a537-1919e5fe182c", "AQAAAAIAAYagAAAAENAvBqoFjwLJ/WqrV23+DmVlBU1DHCaLVGZVtwe8A0XyGwAGlp2PscJXXPSOluuSLg==", "49768335-3ed2-462a-8ac3-33f82313c778" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c33ee900-c261-4195-b8d6-2ac802657d95",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "685ff9e2-4e99-4b8c-aab7-0fd442002d01", "AQAAAAIAAYagAAAAEAUrV/+rLe41VL6tbI4d+aHjMMWP0rNqVhoFGmnxUqKi1cWbEDpCMRpg8TehEeRkOA==", "7bc8e8c8-9c48-49e1-b4cf-73cb4cb58d51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e58ea87d-6a8f-49e0-939c-20d89f995574",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9bb54814-4954-4258-b224-13cdd08e4dd5", "AQAAAAIAAYagAAAAEMxjcHrk8DvomcpF15nAInByqYIwPyPMTlxEJGg9tEHCO2OglBAAMR3ke28d7PApgg==", "cbfe4609-3a58-4acd-8f85-6776f67f3a57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8d480c5-ebe1-45e3-a804-a9badf390003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d51160d2-e8dc-4a2c-a215-264919cde822", "AQAAAAIAAYagAAAAEF9sV2KyG/G46rnZEvDrc0bAgyRosRjqkaxHW40GXzt6TcDyahGoiC5JjjnFDHK3iw==", "c0f02f0a-f33d-4c5c-94c0-b686e6321d3c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8bad4a17-7657-45ca-941a-eb47b611b5a4", "1f7ec708-e841-4ab2-846f-05c24fa18301" },
                    { "a3182515-a66b-4e8c-8349-ff0fe944146b", "318f8ee8-cb12-4d95-9123-1d911a167f3f" },
                    { "8bad4a17-7657-45ca-941a-eb47b611b5a4", "95fd4abd-0626-49fd-956c-19438402a603" },
                    { "ae1141df-e49c-4d54-a2fa-1e3ca8f4fa27", "97e0ae24-f7e2-4ad5-a1ee-570856fcf874" },
                    { "a3182515-a66b-4e8c-8349-ff0fe944146b", "c33ee900-c261-4195-b8d6-2ac802657d95" },
                    { "a3182515-a66b-4e8c-8349-ff0fe944146b", "e58ea87d-6a8f-49e0-939c-20d89f995574" },
                    { "a3182515-a66b-4e8c-8349-ff0fe944146b", "f8d480c5-ebe1-45e3-a804-a9badf390003" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_AspNetUsers_ManagerId",
                table: "Projects",
                column: "ManagerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
