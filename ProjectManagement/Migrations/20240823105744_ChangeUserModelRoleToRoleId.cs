using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectManagement.Migrations
{
    /// <inheritdoc />
    public partial class ChangeUserModelRoleToRoleId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "RoleId",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ec90567-a1de-49bd-8bfb-5ab1854a6494", null, "Admin", "ADMIN" },
                    { "891468ea-4f3c-49a2-9873-2493b429e540", null, "User", "USER" },
                    { "b7260b39-9424-4268-9f81-be2f31754e8d", null, "Manager", "MANAGER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f7ec708-e841-4ab2-846f-05c24fa18301",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RoleId", "SecurityStamp" },
                values: new object[] { "a603d82e-d219-479e-8732-a1afe26e31ec", "AQAAAAIAAYagAAAAEKy1ES6CCEOqg0PR8w3u5Xj9OhtXa8O8QoSxlC609P+wZLcXqxrKCd6JU+mnmbymJw==", "b7260b39-9424-4268-9f81-be2f31754e8d", "af00476a-31f5-4dbe-ae12-c14668ce152d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "318f8ee8-cb12-4d95-9123-1d911a167f3f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RoleId", "SecurityStamp" },
                values: new object[] { "c308e9aa-83cd-48c5-bbda-18589f591977", "AQAAAAIAAYagAAAAEMuLiIK04gNIxf393BnHVtjNxuv5CkVjcrMj3Ro/y24Ej5dYRpusCOtA8bF9mAYkCQ==", "891468ea-4f3c-49a2-9873-2493b429e540", "58d2f917-fa3a-4dc8-9ce2-02922de73eea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95fd4abd-0626-49fd-956c-19438402a603",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RoleId", "SecurityStamp" },
                values: new object[] { "0c4b481f-6758-4133-b077-4d5729af5af3", "AQAAAAIAAYagAAAAEAJl/PzLKrAn9erdCBsWoVilxwXaBVkpuVJAhAcfpo254iZ3qCxgYl+7VPYGGIvsLA==", "b7260b39-9424-4268-9f81-be2f31754e8d", "8cf46f17-bca4-4303-b2a5-1db016f0872c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97e0ae24-f7e2-4ad5-a1ee-570856fcf874",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RoleId", "SecurityStamp" },
                values: new object[] { "e9fb682e-77b7-4415-b922-514c7faeefdc", "AQAAAAIAAYagAAAAELMyo4YuhtQUoi4RtdCBMiM7uqqaLRAPE5S2kw6U0YK95PUNpH2Xwma4RhbJ6TQ0YA==", "1ec90567-a1de-49bd-8bfb-5ab1854a6494", "ebccbbdd-0d0e-4c4a-a255-b1dc3ef5bc51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c33ee900-c261-4195-b8d6-2ac802657d95",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RoleId", "SecurityStamp" },
                values: new object[] { "56fc80fe-9527-426a-b7d8-5870e99c15fd", "AQAAAAIAAYagAAAAENjVsFWD1s97Md4DBm7omkxYLDcSS5+9YO+9MRiTNe2+EI+xQIm5C6MV/WrYXHwD/g==", "891468ea-4f3c-49a2-9873-2493b429e540", "9bba4d20-8fa1-471d-bfc3-d1f2149335e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e58ea87d-6a8f-49e0-939c-20d89f995574",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RoleId", "SecurityStamp" },
                values: new object[] { "363fc217-052e-452e-9911-2877b12b92e2", "AQAAAAIAAYagAAAAEJb72mRYLZBRQQEFwKUbWQpKnOoYFp6rFKMYM0LdvA9tsiZcx+V5eihgFd38nMQZ6g==", "891468ea-4f3c-49a2-9873-2493b429e540", "36219ec0-96d8-4c0d-85f3-3ffe0ae1824e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8d480c5-ebe1-45e3-a804-a9badf390003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RoleId", "SecurityStamp" },
                values: new object[] { "490ccb53-0be5-422d-a1c7-ba8b8999ddc5", "AQAAAAIAAYagAAAAENewe3JhqLoKh3BJF15mfJ8Y1LlEwXI2Ticgpzug8aKvB0V/Xu2KqVW03v2MVbwTAA==", "891468ea-4f3c-49a2-9873-2493b429e540", "7b9a51f4-aa99-490d-9326-f92d4175b30e" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b7260b39-9424-4268-9f81-be2f31754e8d", "1f7ec708-e841-4ab2-846f-05c24fa18301" },
                    { "891468ea-4f3c-49a2-9873-2493b429e540", "318f8ee8-cb12-4d95-9123-1d911a167f3f" },
                    { "b7260b39-9424-4268-9f81-be2f31754e8d", "95fd4abd-0626-49fd-956c-19438402a603" },
                    { "1ec90567-a1de-49bd-8bfb-5ab1854a6494", "97e0ae24-f7e2-4ad5-a1ee-570856fcf874" },
                    { "891468ea-4f3c-49a2-9873-2493b429e540", "c33ee900-c261-4195-b8d6-2ac802657d95" },
                    { "891468ea-4f3c-49a2-9873-2493b429e540", "e58ea87d-6a8f-49e0-939c-20d89f995574" },
                    { "891468ea-4f3c-49a2-9873-2493b429e540", "f8d480c5-ebe1-45e3-a804-a9badf390003" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b7260b39-9424-4268-9f81-be2f31754e8d", "1f7ec708-e841-4ab2-846f-05c24fa18301" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "891468ea-4f3c-49a2-9873-2493b429e540", "318f8ee8-cb12-4d95-9123-1d911a167f3f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b7260b39-9424-4268-9f81-be2f31754e8d", "95fd4abd-0626-49fd-956c-19438402a603" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1ec90567-a1de-49bd-8bfb-5ab1854a6494", "97e0ae24-f7e2-4ad5-a1ee-570856fcf874" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "891468ea-4f3c-49a2-9873-2493b429e540", "c33ee900-c261-4195-b8d6-2ac802657d95" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "891468ea-4f3c-49a2-9873-2493b429e540", "e58ea87d-6a8f-49e0-939c-20d89f995574" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "891468ea-4f3c-49a2-9873-2493b429e540", "f8d480c5-ebe1-45e3-a804-a9badf390003" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ec90567-a1de-49bd-8bfb-5ab1854a6494");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "891468ea-4f3c-49a2-9873-2493b429e540");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7260b39-9424-4268-9f81-be2f31754e8d");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "AspNetUsers");

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
    }
}
