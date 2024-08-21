using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddKeyToProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "Projects",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3ce75831-c8db-4d9b-87fc-7997bec2d80f", null, "Admin", "ADMIN" },
                    { "56f760e2-929f-4c56-9399-7d438eaf5ff9", null, "User", "USER" },
                    { "5ccb1e33-e368-42da-89ad-9b89985197df", null, "Manager", "MANAGER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f7ec708-e841-4ab2-846f-05c24fa18301",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6628d9ec-707b-4025-ac1a-4cf0e0a3aa50", "AQAAAAIAAYagAAAAEFPRVuxIJMwfTzbvaQRocNfVxPQMiB2zilVex2P92e1QvAKKE3Z+aeaKHzLQWeHSxQ==", "95eedf9e-2d04-42ae-bce8-03e17ab57d05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "318f8ee8-cb12-4d95-9123-1d911a167f3f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa168ad2-40ea-4a5e-ac91-61588f59fa03", "AQAAAAIAAYagAAAAEAi94+lVEXVWWkSEHdb59FiCsU670paDRU+f21eAO5AqsamBTVIYPpEWDDDeTOCO5g==", "188dc8d6-2d1f-4e3c-8e74-c47be1fb77b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95fd4abd-0626-49fd-956c-19438402a603",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "975e7533-5316-4544-8fa5-2912341e870f", "AQAAAAIAAYagAAAAEFl3soFIPKyQKM7GK8p9p2/jqiT37mLj4r/PEs5NFhunqudczPQIoADwMh2ldXHqnw==", "06b1308a-275f-4e39-9c1b-3ec35a9cc11c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97e0ae24-f7e2-4ad5-a1ee-570856fcf874",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03a27f27-3e43-4315-a5ea-c7d7c78a0d4d", "AQAAAAIAAYagAAAAELQi6xsKmBahd7TBuuofMOiGJt/XEEFoiOjwF2rF/4q1hL+8EekgZ7wumoKsG85FFg==", "6a58e230-7c4c-4655-934d-6a186aebddf6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c33ee900-c261-4195-b8d6-2ac802657d95",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01c20b34-b507-476e-83cc-e43165271ccc", "AQAAAAIAAYagAAAAEFc0Y286SuJaNe7WQAS5oUEYb+k07XMc7MDRzegwK2a4MZSWk+Psr1tcvMg4IUkl/w==", "d6e36b2f-84d6-4daf-a53a-725c03919251" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e58ea87d-6a8f-49e0-939c-20d89f995574",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1e7137c-df29-4358-b7c7-4af2a6cc0c0f", "AQAAAAIAAYagAAAAEDhiVHaGReFPnvzMWd0VnhdOuYdCJI3QTvHCVFcunpQ9AFI7ocRTRHAh5iHrg5qbwA==", "4abb15aa-a299-40f7-811d-1909b6d13627" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8d480c5-ebe1-45e3-a804-a9badf390003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b8f8c3f-4c62-477f-982b-0669ff231c43", "AQAAAAIAAYagAAAAEHaZBW4yIpohzj3/RI+0vixnlopUEeOdTHmqsZKILwlxX+jpTtHzKeg5XNo3vqR86Q==", "6d2bd8bc-ce4c-424c-addd-8e011fad2769" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5ccb1e33-e368-42da-89ad-9b89985197df", "1f7ec708-e841-4ab2-846f-05c24fa18301" },
                    { "56f760e2-929f-4c56-9399-7d438eaf5ff9", "318f8ee8-cb12-4d95-9123-1d911a167f3f" },
                    { "5ccb1e33-e368-42da-89ad-9b89985197df", "95fd4abd-0626-49fd-956c-19438402a603" },
                    { "3ce75831-c8db-4d9b-87fc-7997bec2d80f", "97e0ae24-f7e2-4ad5-a1ee-570856fcf874" },
                    { "56f760e2-929f-4c56-9399-7d438eaf5ff9", "c33ee900-c261-4195-b8d6-2ac802657d95" },
                    { "56f760e2-929f-4c56-9399-7d438eaf5ff9", "e58ea87d-6a8f-49e0-939c-20d89f995574" },
                    { "56f760e2-929f-4c56-9399-7d438eaf5ff9", "f8d480c5-ebe1-45e3-a804-a9badf390003" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5ccb1e33-e368-42da-89ad-9b89985197df", "1f7ec708-e841-4ab2-846f-05c24fa18301" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "56f760e2-929f-4c56-9399-7d438eaf5ff9", "318f8ee8-cb12-4d95-9123-1d911a167f3f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5ccb1e33-e368-42da-89ad-9b89985197df", "95fd4abd-0626-49fd-956c-19438402a603" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3ce75831-c8db-4d9b-87fc-7997bec2d80f", "97e0ae24-f7e2-4ad5-a1ee-570856fcf874" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "56f760e2-929f-4c56-9399-7d438eaf5ff9", "c33ee900-c261-4195-b8d6-2ac802657d95" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "56f760e2-929f-4c56-9399-7d438eaf5ff9", "e58ea87d-6a8f-49e0-939c-20d89f995574" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "56f760e2-929f-4c56-9399-7d438eaf5ff9", "f8d480c5-ebe1-45e3-a804-a9badf390003" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ce75831-c8db-4d9b-87fc-7997bec2d80f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56f760e2-929f-4c56-9399-7d438eaf5ff9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ccb1e33-e368-42da-89ad-9b89985197df");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "Projects");

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
    }
}
