using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08628688-6499-431d-bcf3-662452348c90");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ae4c390-93e4-4c93-b210-07207689d7f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9ba048e-baa6-4553-9c81-8004ff43f419");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "45b9ac83-d043-4e9a-a6fa-c01af2789963", null, "Manager", "MANAGER" },
                    { "a6cb3476-9c3d-489d-8092-8036b303325b", null, "Admin", "ADMIN" },
                    { "bb19e8c6-fda7-4bab-8e86-be75f6465ae7", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TeamId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1f7ec708-e841-4ab2-846f-05c24fa18301", 0, "183208a5-2d41-4565-98a2-5e325d16a51e", "petar.topic@blankhq.co", true, "Manager2", "Manager2", false, null, "PETAR.TOPIC@BLANKHQ.CO", "PETAR.TOPIC@BLANKHQ.CO", "AQAAAAIAAYagAAAAED6ZaLYdJxjGXGMav0T/FjrH+QToja5Cmm5qsLxumxKi8+WZk9CcAg6ZMY+xJfLc3w==", null, false, "157125e7-1d6a-40c6-9c8f-f75ac6172767", null, false, "petar.topic@blankhq.co" },
                    { "318f8ee8-cb12-4d95-9123-1d911a167f3f", 0, "ae7eb016-9d6b-478f-b922-d715e2507266", "user4@gmail.com", true, "User4", "User4", false, null, "USER4@GMAIL.COM", "USER4@GMAIL.COM", "AQAAAAIAAYagAAAAEFKtz2kGun2v1sSJKkPiZsZ1KDkFhQO98TQbrir7Evv8t0CWarAXALCreYwzUihItg==", null, false, "89b9616b-4fc0-4496-9f7a-0009625be3d9", null, false, "user4@gmail.com" },
                    { "95fd4abd-0626-49fd-956c-19438402a603", 0, "8096b2c2-4a50-4c16-90a5-ee61e71f73bd", "manager@gmail.com", true, "Manager", "Manager", false, null, "MANAGER@GMAIL.COM", "MANAGER@GMAIL.COM", "AQAAAAIAAYagAAAAEOGZoeNCqpdGVYQVMqBRTLZgk8FlsxH21pOKUTL/I/heqWs20Cr5QRhY1RWRepeKTQ==", null, false, "05949da8-c76d-498d-977b-51879f189d8f", null, false, "manager@gmail.com" },
                    { "97e0ae24-f7e2-4ad5-a1ee-570856fcf874", 0, "b2e64761-4858-4c98-ae19-75c115550f98", "admin@gmail.com", true, "Admin", "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAELzB3QAo6SG24a7Cod9dkh7ZJw10rohZ0HG3Mr4e8WdpTDqrpbYruS/I0Xr0VdQOzQ==", null, false, "653634fa-b226-4787-b79c-59b14ecde51c", null, false, "admin@gmail.com" },
                    { "c33ee900-c261-4195-b8d6-2ac802657d95", 0, "4f42d9d4-ad8d-4345-9355-11ce8829350e", "user3@gmail.com", true, "User3", "User3", false, null, "USER3@GMAIL.COM", "USER3@GMAIL.COM", "AQAAAAIAAYagAAAAEHYx7omS+CZRcUhf/i/A2Zz1IwxA8tKD9R4QRoLDPkDZT+0v2W0l2CdPSM1LtvafHg==", null, false, "8569ff3a-04f6-4d69-95a3-7590e3eaafa2", null, false, "user3@gmail.com" },
                    { "e58ea87d-6a8f-49e0-939c-20d89f995574", 0, "0b315a51-4a17-48ba-b642-56ba31f8b8f6", "petartopic2002@gmail.com", true, "User", "User", false, null, "PETARTOPIC2002@GMAIL.COM", "PETARTOPIC2002@GMAIL.COM", "AQAAAAIAAYagAAAAELESM94DQ37tWGkGUeURwCAu1bafnjmUNbYLfBtTJqSP4HCkPBC3SNVgPsN5EgXzWw==", null, false, "64cdac11-ddae-4d49-a374-13448b2245ca", null, false, "petartopic2002@gmail.com" },
                    { "f8d480c5-ebe1-45e3-a804-a9badf390003", 0, "ddbd5743-fa19-4d1b-b814-c321bf0e010a", "user2@gmail.com", true, "User2", "User2", false, null, "USER2@GMAIL.COM", "USER2@GMAIL.COM", "AQAAAAIAAYagAAAAEEFWRYxtI5kTtYh5P2I+NynyBPgne3uAuf1OeBqdYOJznulsdJWtRPdg1digfSbFUA==", null, false, "d4b5c71e-4caa-4193-a343-00165833d15b", null, false, "user2@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "45b9ac83-d043-4e9a-a6fa-c01af2789963", "1f7ec708-e841-4ab2-846f-05c24fa18301" },
                    { "bb19e8c6-fda7-4bab-8e86-be75f6465ae7", "318f8ee8-cb12-4d95-9123-1d911a167f3f" },
                    { "45b9ac83-d043-4e9a-a6fa-c01af2789963", "95fd4abd-0626-49fd-956c-19438402a603" },
                    { "a6cb3476-9c3d-489d-8092-8036b303325b", "97e0ae24-f7e2-4ad5-a1ee-570856fcf874" },
                    { "bb19e8c6-fda7-4bab-8e86-be75f6465ae7", "c33ee900-c261-4195-b8d6-2ac802657d95" },
                    { "bb19e8c6-fda7-4bab-8e86-be75f6465ae7", "e58ea87d-6a8f-49e0-939c-20d89f995574" },
                    { "bb19e8c6-fda7-4bab-8e86-be75f6465ae7", "f8d480c5-ebe1-45e3-a804-a9badf390003" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "45b9ac83-d043-4e9a-a6fa-c01af2789963", "1f7ec708-e841-4ab2-846f-05c24fa18301" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bb19e8c6-fda7-4bab-8e86-be75f6465ae7", "318f8ee8-cb12-4d95-9123-1d911a167f3f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "45b9ac83-d043-4e9a-a6fa-c01af2789963", "95fd4abd-0626-49fd-956c-19438402a603" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a6cb3476-9c3d-489d-8092-8036b303325b", "97e0ae24-f7e2-4ad5-a1ee-570856fcf874" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bb19e8c6-fda7-4bab-8e86-be75f6465ae7", "c33ee900-c261-4195-b8d6-2ac802657d95" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bb19e8c6-fda7-4bab-8e86-be75f6465ae7", "e58ea87d-6a8f-49e0-939c-20d89f995574" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bb19e8c6-fda7-4bab-8e86-be75f6465ae7", "f8d480c5-ebe1-45e3-a804-a9badf390003" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45b9ac83-d043-4e9a-a6fa-c01af2789963");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6cb3476-9c3d-489d-8092-8036b303325b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb19e8c6-fda7-4bab-8e86-be75f6465ae7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f7ec708-e841-4ab2-846f-05c24fa18301");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "318f8ee8-cb12-4d95-9123-1d911a167f3f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95fd4abd-0626-49fd-956c-19438402a603");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97e0ae24-f7e2-4ad5-a1ee-570856fcf874");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c33ee900-c261-4195-b8d6-2ac802657d95");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e58ea87d-6a8f-49e0-939c-20d89f995574");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8d480c5-ebe1-45e3-a804-a9badf390003");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "08628688-6499-431d-bcf3-662452348c90", null, "Admin", "ADMIN" },
                    { "3ae4c390-93e4-4c93-b210-07207689d7f9", null, "Manager", "MANAGER" },
                    { "e9ba048e-baa6-4553-9c81-8004ff43f419", null, "User", "USER" }
                });
        }
    }
}
