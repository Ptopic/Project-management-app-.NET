using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectManagement.Migrations
{
    /// <inheritdoc />
    public partial class TestTeams : Migration
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
                keyValues: new object[] { "5becc065-53fc-41fd-8e25-8f9c719cd316", "1f7ec708-e841-4ab2-846f-05c24fa18301" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c09571c8-140e-4607-b63e-2324332563a5", "318f8ee8-cb12-4d95-9123-1d911a167f3f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5becc065-53fc-41fd-8e25-8f9c719cd316", "95fd4abd-0626-49fd-956c-19438402a603" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "10f9e4ff-a93d-428d-be13-9e5014f08b55", "97e0ae24-f7e2-4ad5-a1ee-570856fcf874" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c09571c8-140e-4607-b63e-2324332563a5", "c33ee900-c261-4195-b8d6-2ac802657d95" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c09571c8-140e-4607-b63e-2324332563a5", "e58ea87d-6a8f-49e0-939c-20d89f995574" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c09571c8-140e-4607-b63e-2324332563a5", "f8d480c5-ebe1-45e3-a804-a9badf390003" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10f9e4ff-a93d-428d-be13-9e5014f08b55");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5becc065-53fc-41fd-8e25-8f9c719cd316");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c09571c8-140e-4607-b63e-2324332563a5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7d856cfd-72f1-4146-840a-7e459df65890", null, "Manager", "MANAGER" },
                    { "aa097ec7-7811-459c-9509-34b14c555775", null, "Admin", "ADMIN" },
                    { "ead4feb7-cf8f-4d92-985b-22d9d0a9a7aa", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f7ec708-e841-4ab2-846f-05c24fa18301",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "caa8ab00-2a7f-4a90-8fe3-20008e61b164", "AQAAAAIAAYagAAAAEIzRqHiFNB2VulEuLi8kLGLmqJsvXQnQL3ApzXTv9iGpywHXVaCmWALQIVBmcpb2rQ==", "b5a7518c-d89a-4710-b1d2-2366199a9a13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "318f8ee8-cb12-4d95-9123-1d911a167f3f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e67c607-8eaf-449c-8bea-0a0c21d49b90", "AQAAAAIAAYagAAAAEHs7nIcGupM2RZkzl/NxfgU4obURQf4mXMatX6FaWdurujFZdoAvtDM6YnfU5tBGMg==", "6a1a5e03-5fb4-493d-8fcd-c347e6a31214" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95fd4abd-0626-49fd-956c-19438402a603",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f3edbd5-d5b8-40f2-96eb-5e42bf7f7ea3", "AQAAAAIAAYagAAAAEOum8XZi0YyxP3q7kkzyqGk/b1eEBQzHKMtNcwJzXUVqAISQP06ULTVTfUtNPtbXNQ==", "17b209ea-996d-464e-9335-ce134e0ec7a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97e0ae24-f7e2-4ad5-a1ee-570856fcf874",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d04a081b-d181-4914-8c12-253f310d3279", "AQAAAAIAAYagAAAAEEL/FVOZxVi7i503mRP80d3VNozYYR5CUJ1Beqnsk7fPL/INDbF3G0Ntl5GBm2r+6w==", "57373b30-8f80-4fbc-9725-9436656c41fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c33ee900-c261-4195-b8d6-2ac802657d95",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1028a2d7-cb0f-4f52-bd40-0951ba5f1f71", "AQAAAAIAAYagAAAAEJir3uYIuTcrkgc5+4u3IvkjP3QE8jBcVkqqVoUlDbve3aT4l4RYN4i3oGx1YSu0gg==", "afc2e8c8-f2ea-428c-83a8-f6797837bfe8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e58ea87d-6a8f-49e0-939c-20d89f995574",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa0e4abf-f02c-475c-b6ca-9ca2cadc3575", "AQAAAAIAAYagAAAAECeYnNYLTr7hTVbo0D9xm0wlLFys954lgq5h7XnstX79L+uAsOOLNT9c08tWdA1mzQ==", "cd24f2f6-cd09-483c-96dc-702a2fbde0f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8d480c5-ebe1-45e3-a804-a9badf390003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86bc10e1-f6df-432e-a61e-8570cd9af764", "AQAAAAIAAYagAAAAEJF0FWeYwhXymkyjxIYGd5g4tLamz2WVK41mHvSuvX3HjIbcv42DAaLIkQsKAgY1aw==", "1b3e5096-269a-4f6e-b53c-fd0644bb3ca0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7d856cfd-72f1-4146-840a-7e459df65890", "1f7ec708-e841-4ab2-846f-05c24fa18301" },
                    { "ead4feb7-cf8f-4d92-985b-22d9d0a9a7aa", "318f8ee8-cb12-4d95-9123-1d911a167f3f" },
                    { "7d856cfd-72f1-4146-840a-7e459df65890", "95fd4abd-0626-49fd-956c-19438402a603" },
                    { "aa097ec7-7811-459c-9509-34b14c555775", "97e0ae24-f7e2-4ad5-a1ee-570856fcf874" },
                    { "ead4feb7-cf8f-4d92-985b-22d9d0a9a7aa", "c33ee900-c261-4195-b8d6-2ac802657d95" },
                    { "ead4feb7-cf8f-4d92-985b-22d9d0a9a7aa", "e58ea87d-6a8f-49e0-939c-20d89f995574" },
                    { "ead4feb7-cf8f-4d92-985b-22d9d0a9a7aa", "f8d480c5-ebe1-45e3-a804-a9badf390003" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_UserTeams_AspNetUsers_UserId",
                table: "UserTeams",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTeams_Teams_TeamId",
                table: "UserTeams",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
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
                keyValues: new object[] { "7d856cfd-72f1-4146-840a-7e459df65890", "1f7ec708-e841-4ab2-846f-05c24fa18301" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ead4feb7-cf8f-4d92-985b-22d9d0a9a7aa", "318f8ee8-cb12-4d95-9123-1d911a167f3f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7d856cfd-72f1-4146-840a-7e459df65890", "95fd4abd-0626-49fd-956c-19438402a603" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aa097ec7-7811-459c-9509-34b14c555775", "97e0ae24-f7e2-4ad5-a1ee-570856fcf874" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ead4feb7-cf8f-4d92-985b-22d9d0a9a7aa", "c33ee900-c261-4195-b8d6-2ac802657d95" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ead4feb7-cf8f-4d92-985b-22d9d0a9a7aa", "e58ea87d-6a8f-49e0-939c-20d89f995574" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ead4feb7-cf8f-4d92-985b-22d9d0a9a7aa", "f8d480c5-ebe1-45e3-a804-a9badf390003" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d856cfd-72f1-4146-840a-7e459df65890");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa097ec7-7811-459c-9509-34b14c555775");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ead4feb7-cf8f-4d92-985b-22d9d0a9a7aa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "10f9e4ff-a93d-428d-be13-9e5014f08b55", null, "Admin", "ADMIN" },
                    { "5becc065-53fc-41fd-8e25-8f9c719cd316", null, "Manager", "MANAGER" },
                    { "c09571c8-140e-4607-b63e-2324332563a5", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f7ec708-e841-4ab2-846f-05c24fa18301",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "671dce9a-0319-4982-a06e-1a294aa0d5dd", "AQAAAAIAAYagAAAAELXYm+6ve8LBdMym2vOoFaw0JdrkP9CQJeqgu8sS7Q+CyXVwdsHVeG2HFZ9VS5gwTg==", "5d301250-7d3c-4dc9-85c4-70f61dbcedec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "318f8ee8-cb12-4d95-9123-1d911a167f3f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b9ef53f-d1d9-4e41-85ea-e589d10da6d4", "AQAAAAIAAYagAAAAEEmZE1I3ubwezWRqkDpoEbM9D+grvDbtVtuNf8n9Ye4QxhnVECxmKIFCrTwJga8buQ==", "0f9824e0-9893-4b40-b64e-72fdd825ed66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95fd4abd-0626-49fd-956c-19438402a603",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8b4426f-c5e6-4203-985a-08ad7555ab59", "AQAAAAIAAYagAAAAEOhvwUdZSzs7OU1121QPTrxNAd1Sudfd1RiyMkbJT3r6TdCjkC7Jtq1buaUlGeam4Q==", "a89cc3b0-1162-4b7e-a797-34d4a779c8e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97e0ae24-f7e2-4ad5-a1ee-570856fcf874",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "493ce2f7-b204-4f76-9674-7cd4998f4029", "AQAAAAIAAYagAAAAEKRpTyw9yvnwjNVpVN1gfYo/kuETMmkeyNmALNLYyPuMmUSahtWB4TTgTlmaYzgWPw==", "048c9ade-622f-493c-b7eb-9ccd6745566b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c33ee900-c261-4195-b8d6-2ac802657d95",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c52d492a-1ad9-41f9-b0d7-d7b682689d23", "AQAAAAIAAYagAAAAEIaYX4WhzSuboruv9T/r1jr9K0ygpqI3xzYouRWJulbcV0WJm9132gJVzfvC8a36aQ==", "1c46f7a4-be47-4c6e-ac35-d13b7257584e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e58ea87d-6a8f-49e0-939c-20d89f995574",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a7fc064-0096-4d80-8946-0485fbefe071", "AQAAAAIAAYagAAAAEGPCIeMmh4SpWHTgHZUwxSsscFpxWasdxrWITnkXHPA9oVm+ir6rRbRK5kj3qSe5bg==", "c20e1fcc-50ff-4787-9bf7-dfc09568eefa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8d480c5-ebe1-45e3-a804-a9badf390003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b4eaad2-43c3-403e-89eb-5dc96374b3fb", "AQAAAAIAAYagAAAAEKCp6gRijlSelJ+Ne/NDTjTpZbZnxkClxwp4V0Ih7O4BAKiOB7NG4mSk0KT0pELYjg==", "88550273-fb35-4cb2-934a-7b45d22bac4d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5becc065-53fc-41fd-8e25-8f9c719cd316", "1f7ec708-e841-4ab2-846f-05c24fa18301" },
                    { "c09571c8-140e-4607-b63e-2324332563a5", "318f8ee8-cb12-4d95-9123-1d911a167f3f" },
                    { "5becc065-53fc-41fd-8e25-8f9c719cd316", "95fd4abd-0626-49fd-956c-19438402a603" },
                    { "10f9e4ff-a93d-428d-be13-9e5014f08b55", "97e0ae24-f7e2-4ad5-a1ee-570856fcf874" },
                    { "c09571c8-140e-4607-b63e-2324332563a5", "c33ee900-c261-4195-b8d6-2ac802657d95" },
                    { "c09571c8-140e-4607-b63e-2324332563a5", "e58ea87d-6a8f-49e0-939c-20d89f995574" },
                    { "c09571c8-140e-4607-b63e-2324332563a5", "f8d480c5-ebe1-45e3-a804-a9badf390003" }
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
    }
}
