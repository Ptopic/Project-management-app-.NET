using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectManagement.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ManagerId = table.Column<string>(type: "text", nullable: true),
                    TeamId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_AspNetUsers_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Projects_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTeams",
                columns: table => new
                {
                    TeamId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTeams", x => new { x.TeamId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserTeams_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserTeams_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TasksDefinitions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uuid", nullable: false),
                    AssigneeId = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DueDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TasksDefinitions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TasksDefinitions_AspNetUsers_AssigneeId",
                        column: x => x.AssigneeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TasksDefinitions_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "26a8fecd-8ec7-4306-b084-aefb1c433dd4", null, "Admin", "ADMIN" },
                    { "84a12d64-7281-48dd-a626-544f6726de28", null, "User", "USER" },
                    { "9829c5c5-b566-4688-a554-f34203a9eabc", null, "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1f7ec708-e841-4ab2-846f-05c24fa18301", 0, "7caffe59-31a8-442e-99ca-86f4a39e12c4", "petar.topic@blankhq.co", true, "Manager2", "Manager2", false, null, "PETAR.TOPIC@BLANKHQ.CO", "MANAGER2", "AQAAAAIAAYagAAAAEHXIbfRhCvKl6UcyTd/0PXOSqJgJnLAm6UABxNUDYXRJEf4RoWfS0h4uHa1lLduUHw==", null, false, "55a95ff4-57bf-4c5c-a8f1-e595175772fc", false, "manager2" },
                    { "318f8ee8-cb12-4d95-9123-1d911a167f3f", 0, "ce1217af-820e-4e77-8da9-a1fe432a5798", "user4@gmail.com", true, "User4", "User4", false, null, "USER4@GMAIL.COM", "USER4", "AQAAAAIAAYagAAAAEOYT5IgT7/4ri9dsiKiOJNhdTu/M0oQBswVeaLWdYfmw/n3ktfR+JUepHvWeNfSCSw==", null, false, "68b809da-0b47-4740-9a5c-07f53b7ec68e", false, "user4" },
                    { "95fd4abd-0626-49fd-956c-19438402a603", 0, "6cf0f70e-247f-44ce-8ad4-9c56dede4201", "manager@gmail.com", true, "Manager", "Manager", false, null, "MANAGER@GMAIL.COM", "MANAGER1", "AQAAAAIAAYagAAAAEKAQfT9s4own/oVX/NdUY/HT5BK0mkIt4j00yWHB5Iz1zF4unya3nXyZI0fk1f9Bkw==", null, false, "42ea2a59-f73f-497a-ac52-47fd1d0b7eca", false, "manager1" },
                    { "97e0ae24-f7e2-4ad5-a1ee-570856fcf874", 0, "f87b2e69-a117-4ba3-8cd4-f4a17ab607ed", "admin@gmail.com", true, "Admin", "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN1", "AQAAAAIAAYagAAAAEOG5p8Wcg72aZLwsb5umrJXsCFzp8Uc+HmegQuTt+spfpki1QyxeRlvDD2IHXKavnA==", null, false, "58206802-986b-496c-94bf-26b44574ef57", false, "admin1" },
                    { "c33ee900-c261-4195-b8d6-2ac802657d95", 0, "734852e8-b2e3-46ca-877e-7379f056ff72", "user3@gmail.com", true, "User3", "User3", false, null, "USER3@GMAIL.COM", "USER3", "AQAAAAIAAYagAAAAEMrmZR7U/hWaJxTylIPOxJf7G/Da2uWsajRF78kX+5kR2f5UgViStnXWVNTxMT6tpw==", null, false, "406aa4e1-57fd-4c26-8b23-5135c7a277b5", false, "user3" },
                    { "e58ea87d-6a8f-49e0-939c-20d89f995574", 0, "f5db7eb4-6f1f-45c0-bb5b-9f592b8567f6", "petartopic2002@gmail.com", true, "User", "User", false, null, "PETARTOPIC2002@GMAIL.COM", "USER1", "AQAAAAIAAYagAAAAEJ2ODhc8oKkG1YBYs/HMerItphwpHCreXH+LP6dAmM7qYQgnpucK3h7byy0+POHnpw==", null, false, "37306f06-9a60-4599-8ff1-714fbe099c35", false, "user1" },
                    { "f8d480c5-ebe1-45e3-a804-a9badf390003", 0, "9b2dd471-8c70-4ead-a697-743a16cd9e28", "user2@gmail.com", true, "User2", "User2", false, null, "USER2@GMAIL.COM", "USER2", "AQAAAAIAAYagAAAAEMg6kdn7plZgL2veTQJpHcTpC6Iev+sH6X3OeYooKBrcr9XdRLagR0LoeB6Ms+EWYA==", null, false, "7ec6e456-8f45-4131-b900-6c1163910e55", false, "user2" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("241347d2-44a4-420c-8e0f-b27e8fdb8c1a"), "Team 1" },
                    { new Guid("26f7c123-0749-4f53-892f-055d8e1fbcf0"), "Team 2" },
                    { new Guid("297f0f61-1ac0-4652-9423-4fb558209d6e"), "Team 3" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ManagerId",
                table: "Projects",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_TeamId",
                table: "Projects",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_TasksDefinitions_AssigneeId",
                table: "TasksDefinitions",
                column: "AssigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_TasksDefinitions_ProjectId",
                table: "TasksDefinitions",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTeams_UserId",
                table: "UserTeams",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "TasksDefinitions");

            migrationBuilder.DropTable(
                name: "UserTeams");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
