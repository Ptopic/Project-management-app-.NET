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
                keyValue: "06537370-3313-4fc7-a251-16257465497a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43626f79-4335-4271-9263-4656c022a11c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77d7ed5a-5daa-4331-9b99-3a434496d376");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bb2a815f-59f8-478f-9515-1e44439e9ebb", null, "User", "USER" },
                    { "c4c06e72-ca00-4b9d-913b-2fc92c0163ab", null, "Admin", "ADMIN" },
                    { "d26a7e20-2de6-4103-aa8f-a8c085a912dc", null, "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TeamId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1f7ec708-e841-4ab2-846f-05c24fa18301", 0, "06dcaf08-14f9-4988-bd72-6a9abf8d262f", "petar.topic@blankhq.co", true, "Manager2", "Manager2", false, null, "PETAR.TOPIC@BLANKHQ.CO", "MANAGER2", "AQAAAAIAAYagAAAAECwnZc13ayLi/ZFMfVqJNwB9n5r0MOh4F9ieNKe8Ea57HgnZkh+imJZv+B3KciJtMg==", null, false, "6af8bbc3-3e98-403d-85aa-44218571d20a", null, false, "manager2" },
                    { "318f8ee8-cb12-4d95-9123-1d911a167f3f", 0, "50c11e12-387e-4cd3-91a8-fd3761c5424d", "user4@gmail.com", true, "User4", "User4", false, null, "USER4@GMAIL.COM", "USER4", "AQAAAAIAAYagAAAAEG8o6uzLfA+vm9Ux8PnZCJEn8bg4ccjOeAlt0zePq/EZ8nMB/1ZBbn+1MBH4TMpStA==", null, false, "c5173457-03e5-4411-8017-d0a96009df03", null, false, "user4" },
                    { "95fd4abd-0626-49fd-956c-19438402a603", 0, "2a11d340-e858-4b84-9ff4-4541c96b7d44", "manager@gmail.com", true, "Manager", "Manager", false, null, "MANAGER@GMAIL.COM", "MANAGER1", "AQAAAAIAAYagAAAAEMz9tIY2vePkmZ1goGHPTueGMjU21nJ8kTmURM/lnuEuZVx1FpT9tIVHJjqh/p2lag==", null, false, "0a4fc695-fa0e-43ef-8acb-482690a4d5f9", null, false, "manager1" },
                    { "97e0ae24-f7e2-4ad5-a1ee-570856fcf874", 0, "63e2daa4-a8f3-4ddb-aac8-41673721cadb", "admin@gmail.com", true, "Admin", "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN1", "AQAAAAIAAYagAAAAEOP9wDj39kxoEuo5VZ8P9+O7AFSikzkXsa0aB+mO6wkbHFR99wxiGoYMww+wNeuAeQ==", null, false, "e8f32869-55bb-4c41-8aa3-31ee12ed3d1e", null, false, "admin1" },
                    { "c33ee900-c261-4195-b8d6-2ac802657d95", 0, "43dec181-fb7a-43ce-b7b7-e7e93f1c8a99", "user3@gmail.com", true, "User3", "User3", false, null, "USER3@GMAIL.COM", "USER3", "AQAAAAIAAYagAAAAEL1X289ybpBUDtOMobAu3X3h5Totari1ItsDtjhz+qFtmV9dYIvocrbFIGOsVnUJdA==", null, false, "7979534f-9509-4506-a3b4-2409ba7ab2b9", null, false, "user3" },
                    { "e58ea87d-6a8f-49e0-939c-20d89f995574", 0, "92f10ac8-ac1c-4348-9834-0480f1811c15", "petartopic2002@gmail.com", true, "User", "User", false, null, "PETARTOPIC2002@GMAIL.COM", "USER1", "AQAAAAIAAYagAAAAEGFioBR6wDrxPyIGlfGY9J/kCaxWdTcivyJu7EMfvKI2e8MQ+2ik9auQNxZAS7TX6g==", null, false, "45dc32e3-1866-466f-82d0-72d4c2075f65", null, false, "user1" },
                    { "f8d480c5-ebe1-45e3-a804-a9badf390003", 0, "42c68a6d-0336-4504-bc4d-25f7f35f52d0", "user2@gmail.com", true, "User2", "User2", false, null, "USER2@GMAIL.COM", "USER2", "AQAAAAIAAYagAAAAELP3/55+CL9U2C86Vy4fP9VS5qMKbCIGJes+NdTeFjpdN9+qmGQSmwNqXZiJhfP2jA==", null, false, "c938636a-fdf5-45cd-b26d-fa9ea8ecc91e", null, false, "user2" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "d26a7e20-2de6-4103-aa8f-a8c085a912dc", "1f7ec708-e841-4ab2-846f-05c24fa18301" },
                    { "bb2a815f-59f8-478f-9515-1e44439e9ebb", "318f8ee8-cb12-4d95-9123-1d911a167f3f" },
                    { "d26a7e20-2de6-4103-aa8f-a8c085a912dc", "95fd4abd-0626-49fd-956c-19438402a603" },
                    { "c4c06e72-ca00-4b9d-913b-2fc92c0163ab", "97e0ae24-f7e2-4ad5-a1ee-570856fcf874" },
                    { "bb2a815f-59f8-478f-9515-1e44439e9ebb", "c33ee900-c261-4195-b8d6-2ac802657d95" },
                    { "bb2a815f-59f8-478f-9515-1e44439e9ebb", "e58ea87d-6a8f-49e0-939c-20d89f995574" },
                    { "bb2a815f-59f8-478f-9515-1e44439e9ebb", "f8d480c5-ebe1-45e3-a804-a9badf390003" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d26a7e20-2de6-4103-aa8f-a8c085a912dc", "1f7ec708-e841-4ab2-846f-05c24fa18301" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bb2a815f-59f8-478f-9515-1e44439e9ebb", "318f8ee8-cb12-4d95-9123-1d911a167f3f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d26a7e20-2de6-4103-aa8f-a8c085a912dc", "95fd4abd-0626-49fd-956c-19438402a603" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c4c06e72-ca00-4b9d-913b-2fc92c0163ab", "97e0ae24-f7e2-4ad5-a1ee-570856fcf874" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bb2a815f-59f8-478f-9515-1e44439e9ebb", "c33ee900-c261-4195-b8d6-2ac802657d95" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bb2a815f-59f8-478f-9515-1e44439e9ebb", "e58ea87d-6a8f-49e0-939c-20d89f995574" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bb2a815f-59f8-478f-9515-1e44439e9ebb", "f8d480c5-ebe1-45e3-a804-a9badf390003" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb2a815f-59f8-478f-9515-1e44439e9ebb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4c06e72-ca00-4b9d-913b-2fc92c0163ab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d26a7e20-2de6-4103-aa8f-a8c085a912dc");

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
                    { "06537370-3313-4fc7-a251-16257465497a", null, "User", "USER" },
                    { "43626f79-4335-4271-9263-4656c022a11c", null, "Admin", "ADMIN" },
                    { "77d7ed5a-5daa-4331-9b99-3a434496d376", null, "Manager", "MANAGER" }
                });
        }
    }
}
