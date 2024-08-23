using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectManagement.Migrations
{
    /// <inheritdoc />
    public partial class ChangeUserRoleToEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Role", "SecurityStamp" },
                values: new object[] { "671dce9a-0319-4982-a06e-1a294aa0d5dd", "AQAAAAIAAYagAAAAELXYm+6ve8LBdMym2vOoFaw0JdrkP9CQJeqgu8sS7Q+CyXVwdsHVeG2HFZ9VS5gwTg==", 1, "5d301250-7d3c-4dc9-85c4-70f61dbcedec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "318f8ee8-cb12-4d95-9123-1d911a167f3f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Role", "SecurityStamp" },
                values: new object[] { "4b9ef53f-d1d9-4e41-85ea-e589d10da6d4", "AQAAAAIAAYagAAAAEEmZE1I3ubwezWRqkDpoEbM9D+grvDbtVtuNf8n9Ye4QxhnVECxmKIFCrTwJga8buQ==", 2, "0f9824e0-9893-4b40-b64e-72fdd825ed66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95fd4abd-0626-49fd-956c-19438402a603",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Role", "SecurityStamp" },
                values: new object[] { "b8b4426f-c5e6-4203-985a-08ad7555ab59", "AQAAAAIAAYagAAAAEOhvwUdZSzs7OU1121QPTrxNAd1Sudfd1RiyMkbJT3r6TdCjkC7Jtq1buaUlGeam4Q==", 1, "a89cc3b0-1162-4b7e-a797-34d4a779c8e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97e0ae24-f7e2-4ad5-a1ee-570856fcf874",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Role", "SecurityStamp" },
                values: new object[] { "493ce2f7-b204-4f76-9674-7cd4998f4029", "AQAAAAIAAYagAAAAEKRpTyw9yvnwjNVpVN1gfYo/kuETMmkeyNmALNLYyPuMmUSahtWB4TTgTlmaYzgWPw==", 0, "048c9ade-622f-493c-b7eb-9ccd6745566b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c33ee900-c261-4195-b8d6-2ac802657d95",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Role", "SecurityStamp" },
                values: new object[] { "c52d492a-1ad9-41f9-b0d7-d7b682689d23", "AQAAAAIAAYagAAAAEIaYX4WhzSuboruv9T/r1jr9K0ygpqI3xzYouRWJulbcV0WJm9132gJVzfvC8a36aQ==", 2, "1c46f7a4-be47-4c6e-ac35-d13b7257584e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e58ea87d-6a8f-49e0-939c-20d89f995574",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Role", "SecurityStamp" },
                values: new object[] { "3a7fc064-0096-4d80-8946-0485fbefe071", "AQAAAAIAAYagAAAAEGPCIeMmh4SpWHTgHZUwxSsscFpxWasdxrWITnkXHPA9oVm+ir6rRbRK5kj3qSe5bg==", 2, "c20e1fcc-50ff-4787-9bf7-dfc09568eefa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8d480c5-ebe1-45e3-a804-a9badf390003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Role", "SecurityStamp" },
                values: new object[] { "2b4eaad2-43c3-403e-89eb-5dc96374b3fb", "AQAAAAIAAYagAAAAEKCp6gRijlSelJ+Ne/NDTjTpZbZnxkClxwp4V0Ih7O4BAKiOB7NG4mSk0KT0pELYjg==", 2, "88550273-fb35-4cb2-934a-7b45d22bac4d" });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");

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
    }
}
