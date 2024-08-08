using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddOwnerToTeam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9829c5c5-b566-4688-a554-f34203a9eabc", "1f7ec708-e841-4ab2-846f-05c24fa18301" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "84a12d64-7281-48dd-a626-544f6726de28", "318f8ee8-cb12-4d95-9123-1d911a167f3f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9829c5c5-b566-4688-a554-f34203a9eabc", "95fd4abd-0626-49fd-956c-19438402a603" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "26a8fecd-8ec7-4306-b084-aefb1c433dd4", "97e0ae24-f7e2-4ad5-a1ee-570856fcf874" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "84a12d64-7281-48dd-a626-544f6726de28", "c33ee900-c261-4195-b8d6-2ac802657d95" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "84a12d64-7281-48dd-a626-544f6726de28", "e58ea87d-6a8f-49e0-939c-20d89f995574" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "84a12d64-7281-48dd-a626-544f6726de28", "f8d480c5-ebe1-45e3-a804-a9badf390003" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26a8fecd-8ec7-4306-b084-aefb1c433dd4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84a12d64-7281-48dd-a626-544f6726de28");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9829c5c5-b566-4688-a554-f34203a9eabc");

            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "Teams",
                type: "text",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("241347d2-44a4-420c-8e0f-b27e8fdb8c1a"),
                column: "OwnerId",
                value: "1f7ec708-e841-4ab2-846f-05c24fa18301");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("26f7c123-0749-4f53-892f-055d8e1fbcf0"),
                column: "OwnerId",
                value: "95fd4abd-0626-49fd-956c-19438402a603");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("297f0f61-1ac0-4652-9423-4fb558209d6e"),
                column: "OwnerId",
                value: "95fd4abd-0626-49fd-956c-19438402a603");

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

            migrationBuilder.CreateIndex(
                name: "IX_Teams_OwnerId",
                table: "Teams",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_AspNetUsers_OwnerId",
                table: "Teams",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_AspNetUsers_OwnerId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_OwnerId",
                table: "Teams");

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

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Teams");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "26a8fecd-8ec7-4306-b084-aefb1c433dd4", null, "Admin", "ADMIN" },
                    { "84a12d64-7281-48dd-a626-544f6726de28", null, "User", "USER" },
                    { "9829c5c5-b566-4688-a554-f34203a9eabc", null, "Manager", "MANAGER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f7ec708-e841-4ab2-846f-05c24fa18301",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7caffe59-31a8-442e-99ca-86f4a39e12c4", "AQAAAAIAAYagAAAAEHXIbfRhCvKl6UcyTd/0PXOSqJgJnLAm6UABxNUDYXRJEf4RoWfS0h4uHa1lLduUHw==", "55a95ff4-57bf-4c5c-a8f1-e595175772fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "318f8ee8-cb12-4d95-9123-1d911a167f3f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce1217af-820e-4e77-8da9-a1fe432a5798", "AQAAAAIAAYagAAAAEOYT5IgT7/4ri9dsiKiOJNhdTu/M0oQBswVeaLWdYfmw/n3ktfR+JUepHvWeNfSCSw==", "68b809da-0b47-4740-9a5c-07f53b7ec68e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95fd4abd-0626-49fd-956c-19438402a603",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cf0f70e-247f-44ce-8ad4-9c56dede4201", "AQAAAAIAAYagAAAAEKAQfT9s4own/oVX/NdUY/HT5BK0mkIt4j00yWHB5Iz1zF4unya3nXyZI0fk1f9Bkw==", "42ea2a59-f73f-497a-ac52-47fd1d0b7eca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97e0ae24-f7e2-4ad5-a1ee-570856fcf874",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f87b2e69-a117-4ba3-8cd4-f4a17ab607ed", "AQAAAAIAAYagAAAAEOG5p8Wcg72aZLwsb5umrJXsCFzp8Uc+HmegQuTt+spfpki1QyxeRlvDD2IHXKavnA==", "58206802-986b-496c-94bf-26b44574ef57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c33ee900-c261-4195-b8d6-2ac802657d95",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "734852e8-b2e3-46ca-877e-7379f056ff72", "AQAAAAIAAYagAAAAEMrmZR7U/hWaJxTylIPOxJf7G/Da2uWsajRF78kX+5kR2f5UgViStnXWVNTxMT6tpw==", "406aa4e1-57fd-4c26-8b23-5135c7a277b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e58ea87d-6a8f-49e0-939c-20d89f995574",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5db7eb4-6f1f-45c0-bb5b-9f592b8567f6", "AQAAAAIAAYagAAAAEJ2ODhc8oKkG1YBYs/HMerItphwpHCreXH+LP6dAmM7qYQgnpucK3h7byy0+POHnpw==", "37306f06-9a60-4599-8ff1-714fbe099c35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8d480c5-ebe1-45e3-a804-a9badf390003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b2dd471-8c70-4ead-a697-743a16cd9e28", "AQAAAAIAAYagAAAAEMg6kdn7plZgL2veTQJpHcTpC6Iev+sH6X3OeYooKBrcr9XdRLagR0LoeB6Ms+EWYA==", "7ec6e456-8f45-4131-b900-6c1163910e55" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "9829c5c5-b566-4688-a554-f34203a9eabc", "1f7ec708-e841-4ab2-846f-05c24fa18301" },
                    { "84a12d64-7281-48dd-a626-544f6726de28", "318f8ee8-cb12-4d95-9123-1d911a167f3f" },
                    { "9829c5c5-b566-4688-a554-f34203a9eabc", "95fd4abd-0626-49fd-956c-19438402a603" },
                    { "26a8fecd-8ec7-4306-b084-aefb1c433dd4", "97e0ae24-f7e2-4ad5-a1ee-570856fcf874" },
                    { "84a12d64-7281-48dd-a626-544f6726de28", "c33ee900-c261-4195-b8d6-2ac802657d95" },
                    { "84a12d64-7281-48dd-a626-544f6726de28", "e58ea87d-6a8f-49e0-939c-20d89f995574" },
                    { "84a12d64-7281-48dd-a626-544f6726de28", "f8d480c5-ebe1-45e3-a804-a9badf390003" }
                });
        }
    }
}
