using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bbb7235a-02e5-47d2-a58c-484782713b7f",
                column: "ConcurrencyStamp",
                value: "1f471f3b-16d9-4ea1-8f2e-2318cba92a88");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbf1dc7j-cf6a-1534-9534-d4177d64c17a",
                column: "ConcurrencyStamp",
                value: "cceb764c-abc6-4fac-9920-40b169dcbecc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "daf7dc7a-cf6a-4834-9544-d4177d64b48d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6488ce50-9ade-4d72-b06c-0664eb154fa9", "AQAAAAEAACcQAAAAEAPE2YnOYYWhBdsjgoA2MxnqExpLxZ7XXW0cdUEsl5fu2b1U6w/p/JwP9+I1UImQ5w==", "2d4498fa-b6f8-43f5-a01a-b0384f88c07c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddd7435a-02e5-41d2-a58c-484782713b7f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f27d614-de76-4d42-b85d-d10956a989d7", "AQAAAAEAACcQAAAAEPtAPo6lsbOVircl649B4qIASvgRX/i7F0A9jUPL09KwFE6ZZjA0mUAAawRncHj3PQ==", "1a4317d8-431f-4e36-bd9a-7402e02630f4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bbb7235a-02e5-47d2-a58c-484782713b7f",
                column: "ConcurrencyStamp",
                value: "e6873934-3cf0-4fcf-9759-6d96466ddc23");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbf1dc7j-cf6a-1534-9534-d4177d64c17a",
                column: "ConcurrencyStamp",
                value: "4b1f9497-4837-431e-976b-a3cb3ba77592");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "daf7dc7a-cf6a-4834-9544-d4177d64b48d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "776cd685-b58f-452b-8139-b43e9ddb7826", "AQAAAAEAACcQAAAAEH9gkHbHcjfgUgAUieLhwqR5ZnanDry5lWlkwcbqg4uD5xsXVhQLeTT/JNTq6wnmIA==", "5fd81107-6bff-46ee-af85-173bbb286a22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddd7435a-02e5-41d2-a58c-484782713b7f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0be65c9f-da47-4fde-9e98-a446d6e858f6", "AQAAAAEAACcQAAAAEF6tfJHbcnZsSHb27QsjCeS6SzOyGD5az/bM/O7UILSnaRU5cLiOvWFT8XYn6XxuKA==", "1e4b9c60-433a-4758-b337-6f5c22676c47" });
        }
    }
}
