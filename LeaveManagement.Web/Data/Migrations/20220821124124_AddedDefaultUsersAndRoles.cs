using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bbb7235a-02e5-47d2-a58c-484782713b7f", "e6873934-3cf0-4fcf-9759-6d96466ddc23", "Administrator", "ADMINISTRATOR" },
                    { "dbf1dc7j-cf6a-1534-9534-d4177d64c17a", "4b1f9497-4837-431e-976b-a3cb3ba77592", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "daf7dc7a-cf6a-4834-9544-d4177d64b48d", 0, "776cd685-b58f-452b-8139-b43e9ddb7826", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", true, "System", "User", false, null, "USER@LOCALHOST.COM", "USER", "AQAAAAEAACcQAAAAEH9gkHbHcjfgUgAUieLhwqR5ZnanDry5lWlkwcbqg4uD5xsXVhQLeTT/JNTq6wnmIA==", null, false, "5fd81107-6bff-46ee-af85-173bbb286a22", null, false, "user" },
                    { "ddd7435a-02e5-41d2-a58c-484782713b7f", 0, "0be65c9f-da47-4fde-9e98-a446d6e858f6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", true, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMINISTRATOR", "AQAAAAEAACcQAAAAEF6tfJHbcnZsSHb27QsjCeS6SzOyGD5az/bM/O7UILSnaRU5cLiOvWFT8XYn6XxuKA==", null, false, "1e4b9c60-433a-4758-b337-6f5c22676c47", null, false, "administrator" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "dbf1dc7j-cf6a-1534-9534-d4177d64c17a", "daf7dc7a-cf6a-4834-9544-d4177d64b48d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bbb7235a-02e5-47d2-a58c-484782713b7f", "ddd7435a-02e5-41d2-a58c-484782713b7f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dbf1dc7j-cf6a-1534-9534-d4177d64c17a", "daf7dc7a-cf6a-4834-9544-d4177d64b48d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bbb7235a-02e5-47d2-a58c-484782713b7f", "ddd7435a-02e5-41d2-a58c-484782713b7f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bbb7235a-02e5-47d2-a58c-484782713b7f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbf1dc7j-cf6a-1534-9534-d4177d64c17a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "daf7dc7a-cf6a-4834-9544-d4177d64b48d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddd7435a-02e5-41d2-a58c-484782713b7f");
        }
    }
}
