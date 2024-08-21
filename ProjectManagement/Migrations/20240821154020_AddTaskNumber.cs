using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddTaskNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "TaskNumber",
                table: "TasksDefinitions",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0529dea3-59f2-49cd-9dec-ef3f8d10615d", null, "User", "USER" },
                    { "1bbe22e0-7667-48a8-9eb4-e3aac3f49835", null, "Manager", "MANAGER" },
                    { "63ac20a4-b671-4026-8d63-7f01033854e9", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f7ec708-e841-4ab2-846f-05c24fa18301",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "996bd2ba-3603-455c-98e7-d348d90c3f84", "AQAAAAIAAYagAAAAEMDnkgjnhke806/9eWhmoyFFYthCRWUTbyPfAn0lHWzHeUog3qMkVprOzYpTmk6Rcw==", "137e003b-484e-4716-b6a6-d9cbb473d0ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "318f8ee8-cb12-4d95-9123-1d911a167f3f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1883136b-cfd2-40a3-9f54-22045ab8fae2", "AQAAAAIAAYagAAAAEDhXfLoC4muZfb4dzQagSeJmH83s5tbZ8azv97NIQjwgiVPgFfahPv+5OMr1rUExrg==", "b20d88df-706f-4ae1-980e-9dc3eada7648" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95fd4abd-0626-49fd-956c-19438402a603",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27f2c76c-8b23-4028-9c5a-c3a3f1a7b5b3", "AQAAAAIAAYagAAAAEDgAtlNmcF844Kws7JBd7fUR2xIQ00wO6YPaX4bCC+Rvmr2dXUjdh2XhctLQGKDJeQ==", "b52eb282-7bb2-4d09-945c-d5183ddd279f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97e0ae24-f7e2-4ad5-a1ee-570856fcf874",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "632b7dd7-1deb-4b13-ab15-bd09155df034", "AQAAAAIAAYagAAAAEKyrUPIP9HxXXDtEMH5RbLsyDfbajwTIKGcVNmXz2japtg/tzUuSrtbJ6dyYUruyYg==", "4ee4e6ac-7710-4859-96a7-2be08776be67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c33ee900-c261-4195-b8d6-2ac802657d95",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d3af5e1-d6e4-4aef-9db2-854e27e923ca", "AQAAAAIAAYagAAAAEIMzFbwDb01Ic8A/8ulLNAp7X2ukYCGOudiZVUnthr1y5L3rnBGj6apbMS9MgSIvvA==", "e333246e-8b6c-4f1c-a6da-64cc6a887384" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e58ea87d-6a8f-49e0-939c-20d89f995574",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a98b5e70-b94b-415f-b46d-9ecb566d8d94", "AQAAAAIAAYagAAAAECnbwVp8Wk8xFGXrRg/QcDK0eWxMaoqv/E3XetHyhBsglRj3Cll2pElcwrW30Y+Ztg==", "b2691c84-8611-4b81-9f84-e15873b6ce06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8d480c5-ebe1-45e3-a804-a9badf390003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cfd4a9d-9486-449a-8ba0-b33b1cc8c9d6", "AQAAAAIAAYagAAAAEH/wDpFvjk/mLJ5tw+OkEP4gNbeVXI4a0pSZAN0HjKZK08vwsfxq7mQ3JGwcCTLWdw==", "425d78a4-d6bf-4037-8a63-c9c805a4e454" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1bbe22e0-7667-48a8-9eb4-e3aac3f49835", "1f7ec708-e841-4ab2-846f-05c24fa18301" },
                    { "0529dea3-59f2-49cd-9dec-ef3f8d10615d", "318f8ee8-cb12-4d95-9123-1d911a167f3f" },
                    { "1bbe22e0-7667-48a8-9eb4-e3aac3f49835", "95fd4abd-0626-49fd-956c-19438402a603" },
                    { "63ac20a4-b671-4026-8d63-7f01033854e9", "97e0ae24-f7e2-4ad5-a1ee-570856fcf874" },
                    { "0529dea3-59f2-49cd-9dec-ef3f8d10615d", "c33ee900-c261-4195-b8d6-2ac802657d95" },
                    { "0529dea3-59f2-49cd-9dec-ef3f8d10615d", "e58ea87d-6a8f-49e0-939c-20d89f995574" },
                    { "0529dea3-59f2-49cd-9dec-ef3f8d10615d", "f8d480c5-ebe1-45e3-a804-a9badf390003" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bbe22e0-7667-48a8-9eb4-e3aac3f49835", "1f7ec708-e841-4ab2-846f-05c24fa18301" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0529dea3-59f2-49cd-9dec-ef3f8d10615d", "318f8ee8-cb12-4d95-9123-1d911a167f3f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bbe22e0-7667-48a8-9eb4-e3aac3f49835", "95fd4abd-0626-49fd-956c-19438402a603" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "63ac20a4-b671-4026-8d63-7f01033854e9", "97e0ae24-f7e2-4ad5-a1ee-570856fcf874" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0529dea3-59f2-49cd-9dec-ef3f8d10615d", "c33ee900-c261-4195-b8d6-2ac802657d95" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0529dea3-59f2-49cd-9dec-ef3f8d10615d", "e58ea87d-6a8f-49e0-939c-20d89f995574" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0529dea3-59f2-49cd-9dec-ef3f8d10615d", "f8d480c5-ebe1-45e3-a804-a9badf390003" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0529dea3-59f2-49cd-9dec-ef3f8d10615d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1bbe22e0-7667-48a8-9eb4-e3aac3f49835");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63ac20a4-b671-4026-8d63-7f01033854e9");

            migrationBuilder.DropColumn(
                name: "TaskNumber",
                table: "TasksDefinitions");

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
        }
    }
}
