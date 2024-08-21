using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectManagement.Migrations
{
    /// <inheritdoc />
    public partial class TaskChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserTeams_AspNetUsers_UserId",
                table: "UserTeams");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTeams_Teams_TeamId",
                table: "UserTeams");

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

            migrationBuilder.RenameColumn(
                name: "DueDate",
                table: "TasksDefinitions",
                newName: "UpdatedDate");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TasksDefinitions",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "TaskIdentifier",
                table: "TasksDefinitions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Projects",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

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
                    { "41b278a6-aa71-4d6e-b319-ab49b9e40614", null, "User", "USER" },
                    { "4e4b3396-2983-4186-90ba-dc83312f0e5e", null, "Admin", "ADMIN" },
                    { "bc4fc90a-843f-47be-87fd-baac13c863dd", null, "Manager", "MANAGER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f7ec708-e841-4ab2-846f-05c24fa18301",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fdaca31-49f6-4ad3-bea4-c77195fac890", "AQAAAAIAAYagAAAAEHShCCMjSxCR7ucBMDlo0BEcO12Yvcp/Xg1+tyEvTnfJ/vhVtS7TF2ZLoCITcTGd6g==", "c0196821-0b28-455c-9ca2-c8ca3ecf6961" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "318f8ee8-cb12-4d95-9123-1d911a167f3f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "564fdbcb-d9d2-49d5-bc72-55af7f625c0a", "AQAAAAIAAYagAAAAEK77DM90+fxrRQQKXhut6gL6zZta4wf9dIXaLRP1ktTBS8lkYNvnDIXxiubw8VFc1A==", "18e4999f-a27b-44a8-9010-34938773ea1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95fd4abd-0626-49fd-956c-19438402a603",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88f56292-e0ce-49ea-a41d-c3eff3aebe74", "AQAAAAIAAYagAAAAECL0cJCZwipr3IVF3oivNmc9qEKPt2QvOq7CFDiAPpS49GfngdQjLDXkGX5adrFtsQ==", "66ce427c-3319-40e4-af16-7f4fb39e0dbd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97e0ae24-f7e2-4ad5-a1ee-570856fcf874",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7558100-924e-4e30-8c9e-387adb96d87b", "AQAAAAIAAYagAAAAEOJ1VdciGV9knp7U5qoKD01dXaVsGaCap92gVt8deJrgzBxluWs1taQUPKaQALjhHQ==", "dbb95c25-dccd-4be6-b40d-b868a560c8f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c33ee900-c261-4195-b8d6-2ac802657d95",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8447fb37-e758-4c4a-b4b4-d8c8294722fc", "AQAAAAIAAYagAAAAEJo253HUB38HZHLy7vPcQpxfb/La8SBhyNrZ/8aKAtH1cQzhGowFKS6ayQxhVsFN/A==", "88a10e81-2b78-4377-90af-3cc4943affa5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e58ea87d-6a8f-49e0-939c-20d89f995574",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d9c5570-9e47-4835-ad4a-be9965859dff", "AQAAAAIAAYagAAAAEAZebx0XqeJDFx7OrYx6n9I63H/7eGwDgfBH8wAauf55og270g1qdzrZqg6OOfD2IQ==", "4ea9f948-1533-4102-9469-4e178450e954" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8d480c5-ebe1-45e3-a804-a9badf390003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "119687da-c1cb-48b6-98af-b76c69de0293", "AQAAAAIAAYagAAAAEKBcguMB3Fxjymsl2pBKokjnU0sThPsoKOrw+xA2QseYU3hZayNLOseBeyzZZrrzPw==", "951690aa-11dc-43d0-a153-b6589074e123" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bc4fc90a-843f-47be-87fd-baac13c863dd", "1f7ec708-e841-4ab2-846f-05c24fa18301" },
                    { "41b278a6-aa71-4d6e-b319-ab49b9e40614", "318f8ee8-cb12-4d95-9123-1d911a167f3f" },
                    { "bc4fc90a-843f-47be-87fd-baac13c863dd", "95fd4abd-0626-49fd-956c-19438402a603" },
                    { "4e4b3396-2983-4186-90ba-dc83312f0e5e", "97e0ae24-f7e2-4ad5-a1ee-570856fcf874" },
                    { "41b278a6-aa71-4d6e-b319-ab49b9e40614", "c33ee900-c261-4195-b8d6-2ac802657d95" },
                    { "41b278a6-aa71-4d6e-b319-ab49b9e40614", "e58ea87d-6a8f-49e0-939c-20d89f995574" },
                    { "41b278a6-aa71-4d6e-b319-ab49b9e40614", "f8d480c5-ebe1-45e3-a804-a9badf390003" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_UserTeams_AspNetUsers_UserId",
                table: "UserTeams",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTeams_Teams_TeamId",
                table: "UserTeams",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserTeams_AspNetUsers_UserId",
                table: "UserTeams");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTeams_Teams_TeamId",
                table: "UserTeams");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bc4fc90a-843f-47be-87fd-baac13c863dd", "1f7ec708-e841-4ab2-846f-05c24fa18301" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "41b278a6-aa71-4d6e-b319-ab49b9e40614", "318f8ee8-cb12-4d95-9123-1d911a167f3f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bc4fc90a-843f-47be-87fd-baac13c863dd", "95fd4abd-0626-49fd-956c-19438402a603" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4e4b3396-2983-4186-90ba-dc83312f0e5e", "97e0ae24-f7e2-4ad5-a1ee-570856fcf874" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "41b278a6-aa71-4d6e-b319-ab49b9e40614", "c33ee900-c261-4195-b8d6-2ac802657d95" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "41b278a6-aa71-4d6e-b319-ab49b9e40614", "e58ea87d-6a8f-49e0-939c-20d89f995574" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "41b278a6-aa71-4d6e-b319-ab49b9e40614", "f8d480c5-ebe1-45e3-a804-a9badf390003" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41b278a6-aa71-4d6e-b319-ab49b9e40614");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e4b3396-2983-4186-90ba-dc83312f0e5e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc4fc90a-843f-47be-87fd-baac13c863dd");

            migrationBuilder.DropColumn(
                name: "TaskIdentifier",
                table: "TasksDefinitions");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "TasksDefinitions",
                newName: "DueDate");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TasksDefinitions",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Projects",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

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
                name: "FK_UserTeams_AspNetUsers_UserId",
                table: "UserTeams",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserTeams_Teams_TeamId",
                table: "UserTeams",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id");
        }
    }
}
