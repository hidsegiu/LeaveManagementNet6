using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bbb7235a-02e5-47d2-a58c-484782713b7f",
                column: "ConcurrencyStamp",
                value: "82dfc875-889d-44a6-bdf8-b05522a374c2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbf1dc7j-cf6a-1534-9534-d4177d64c17a",
                column: "ConcurrencyStamp",
                value: "214f34ad-fd30-4927-ae1b-45f9d97971df");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "daf7dc7a-cf6a-4834-9544-d4177d64b48d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b39c1e4-c58b-4208-9835-254ee56d585f", "AQAAAAEAACcQAAAAEHV/QUIp7+tum+e12Ur7KryxbLt06QPDn+RqQH1TbQ/UTD/uD9ZCwlZ8tU4rSptBxw==", "174fdfe0-7187-440f-9113-b8aa5f6a91e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddd7435a-02e5-41d2-a58c-484782713b7f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27806b63-12f6-4340-b06f-025c3b4718a1", "AQAAAAEAACcQAAAAENfdwzA+gss5MBgjnk8NjjKf/8eC0eMOf/qPfS3lF0IAel9jtwFLIzWK9eJRynk+cA==", "b3c07cd2-9c54-4d5a-8440-59e730c71dfe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bbb7235a-02e5-47d2-a58c-484782713b7f",
                column: "ConcurrencyStamp",
                value: "e1e6e6f6-f5eb-48bd-8c65-2a9db76c106e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbf1dc7j-cf6a-1534-9534-d4177d64c17a",
                column: "ConcurrencyStamp",
                value: "d4849396-c272-4d29-9064-e25db8ca4018");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "daf7dc7a-cf6a-4834-9544-d4177d64b48d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "897154b5-a251-4822-88a3-6e2737e5e8dc", "AQAAAAEAACcQAAAAEIdH0N11iVVr1xMoge9ZBWKR8k7mT2KVugSZOMPPc6yRDuAihkIM0Ur9tuudOPcZgg==", "13ca5d5c-9644-4766-8f89-e554182f3a30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddd7435a-02e5-41d2-a58c-484782713b7f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57f6cd20-82a6-420f-adf6-4bdd51e54719", "AQAAAAEAACcQAAAAEIIxiy/bcZy8+bVKnPaa/4mUdwiplqLlGtyPrn8YwZ7eBI88Q2mnzYichb+SuNAQkw==", "fed837da-30ca-40fe-8735-17586e6b354e" });
        }
    }
}
