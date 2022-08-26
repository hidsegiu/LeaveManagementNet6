using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
