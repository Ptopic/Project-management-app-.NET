using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectManagement.Migrations
{
    /// <inheritdoc />
    public partial class TasksMakeAssigneeNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3b33299b-8ef7-4b3b-93f6-d6b349d8b21e", null, "User", "USER" },
                    { "761b4d2a-a774-4627-b542-ba2bceb8dda9", null, "Manager", "MANAGER" },
                    { "cd5abcbc-e8fd-47b5-adea-0abfbe6939be", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f7ec708-e841-4ab2-846f-05c24fa18301",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b324209e-3cd8-4e05-9cfc-eac6cb3f31ea", "AQAAAAIAAYagAAAAEBZFiqsFZZqB/nn6/GN0zmVHL+/e9POiWg+49cNnJSuh9YztfR1Oh7BSB0I0rSrZpg==", "66085e26-ecd3-46ec-9cad-740f6cebb011" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "318f8ee8-cb12-4d95-9123-1d911a167f3f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f864ecaa-9b85-4b40-8ce6-fb78aeaca306", "AQAAAAIAAYagAAAAEGVq8uKroXMfNw0yvZnjvefyTvMNxiXHECVHBALU9x4PxVZUDKj58VoKSYyVy+RiRg==", "31bb9d4c-acd1-404a-a960-fbe6270a8174" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95fd4abd-0626-49fd-956c-19438402a603",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4cab2088-2ce0-4684-8ab9-4dc673ffc2d2", "AQAAAAIAAYagAAAAEINbU9nOrjc5ZgcxkCDPoPz39iOvpEaS1U5g+W5VPK+503c6xLq/bTJNaaPskPz39g==", "deadb207-7bf9-403b-b409-803a52c3ffae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97e0ae24-f7e2-4ad5-a1ee-570856fcf874",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83230bf0-1f11-44ce-891a-d5b1dcdf3963", "AQAAAAIAAYagAAAAEHT+mw+dxE6ztMFEcWorIdJpP5EfP+iG07TIVnArvqB6UuJC5XoSzyut7TnxZDydtA==", "702db372-9929-477d-9901-675b93664ddb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c33ee900-c261-4195-b8d6-2ac802657d95",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6897b8aa-c4f4-4ea8-9df7-ca8698581910", "AQAAAAIAAYagAAAAELSCFhyBZhm/YujeS7RD03jOc8SZWBRnUhrMCBr20+jZLLfLrK0qXOKyn0ORebqwLA==", "92d096e0-c221-419d-9f9e-ac305cad883c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e58ea87d-6a8f-49e0-939c-20d89f995574",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2daf725f-3297-4368-8c7b-c93985bdda83", "AQAAAAIAAYagAAAAEBa1pBz26Dcsii3Vj5UqM7/yC2uPuWA3AwEbPFFUXY4r/D/XgANH8o7CIOedNZFISA==", "c53cd1f6-7934-4ffa-bfd6-e8958da30eaf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8d480c5-ebe1-45e3-a804-a9badf390003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b023eb2c-4236-472c-b618-d57be6f86553", "AQAAAAIAAYagAAAAEF2KdnQoM19Zl2xgoAds6iPRpBTlKaTf+KrRaY6Cz0K/sPKhM6vz/v2eU8SCjVaaow==", "e841eb37-9519-4af9-8140-446318348db7" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "761b4d2a-a774-4627-b542-ba2bceb8dda9", "1f7ec708-e841-4ab2-846f-05c24fa18301" },
                    { "3b33299b-8ef7-4b3b-93f6-d6b349d8b21e", "318f8ee8-cb12-4d95-9123-1d911a167f3f" },
                    { "761b4d2a-a774-4627-b542-ba2bceb8dda9", "95fd4abd-0626-49fd-956c-19438402a603" },
                    { "cd5abcbc-e8fd-47b5-adea-0abfbe6939be", "97e0ae24-f7e2-4ad5-a1ee-570856fcf874" },
                    { "3b33299b-8ef7-4b3b-93f6-d6b349d8b21e", "c33ee900-c261-4195-b8d6-2ac802657d95" },
                    { "3b33299b-8ef7-4b3b-93f6-d6b349d8b21e", "e58ea87d-6a8f-49e0-939c-20d89f995574" },
                    { "3b33299b-8ef7-4b3b-93f6-d6b349d8b21e", "f8d480c5-ebe1-45e3-a804-a9badf390003" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "761b4d2a-a774-4627-b542-ba2bceb8dda9", "1f7ec708-e841-4ab2-846f-05c24fa18301" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3b33299b-8ef7-4b3b-93f6-d6b349d8b21e", "318f8ee8-cb12-4d95-9123-1d911a167f3f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "761b4d2a-a774-4627-b542-ba2bceb8dda9", "95fd4abd-0626-49fd-956c-19438402a603" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cd5abcbc-e8fd-47b5-adea-0abfbe6939be", "97e0ae24-f7e2-4ad5-a1ee-570856fcf874" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3b33299b-8ef7-4b3b-93f6-d6b349d8b21e", "c33ee900-c261-4195-b8d6-2ac802657d95" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3b33299b-8ef7-4b3b-93f6-d6b349d8b21e", "e58ea87d-6a8f-49e0-939c-20d89f995574" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3b33299b-8ef7-4b3b-93f6-d6b349d8b21e", "f8d480c5-ebe1-45e3-a804-a9badf390003" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b33299b-8ef7-4b3b-93f6-d6b349d8b21e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "761b4d2a-a774-4627-b542-ba2bceb8dda9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd5abcbc-e8fd-47b5-adea-0abfbe6939be");

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
    }
}
