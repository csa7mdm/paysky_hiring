using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class InitialMig05 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "2", "2" },
                    { "3", "3" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "Password", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57d5c85c-f23a-4956-a3de-29174ced0782", null, null, "AQAAAAIAAYagAAAAENuk60iVbBSl65jp3pkfrye9fpvvRm13WBd7IS9+ENCW73mSJih/ZeH9JUsCw67xSg==", "56de9d8e-a3b6-407c-aec5-eb829c4aa6e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "Password", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f78cc884-a9e8-4931-bbf3-4be77a1f80d1", null, null, "AQAAAAIAAYagAAAAEPP1v5PTt1sTl9yMtbhhkfL4C0TFznSKpYJCtQFUdEB9uzKqadYwXuImetnz9rO84g==", "3c0522a8-ffaf-40e3-af03-bdb24f428cd9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "Password", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfb880fe-04a0-4e00-9870-def2d8349ccb", null, null, "AQAAAAIAAYagAAAAEKTNXnNG0GVy3lF+SSJgcxEjHRUTqE6OjUo7RyTzoGs2wUuh0KpnsLXq9HjW+8oLOw==", "7b3fb582-68ac-4c89-9f93-5f0b36f4ba0d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "Password", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fef2259b-6066-4550-a79e-f31a99673724", "ADMIN", "1234", "AQAAAAIAAYagAAAAEF47iML3iRANeWUtMjMd88hV9o4zrv6J83U95wncyGQ9J7VoemJvKKisjer/UlJWVg==", "7dc0b084-6d10-42d8-9c64-dba8407f0c0f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "Password", "PasswordHash", "SecurityStamp" },
                values: new object[] { "598c6732-6bd8-4543-820c-86268c5c8e00", "EMPLOYEE", "1234", "AQAAAAIAAYagAAAAEOgFfYWWQXSg2Moccsj3TRko49CDsy0xHpd38/ukH3XC+zcR7Zs1TxckIm+yY+JD+Q==", "082f6ee9-f608-4884-9632-ebbb96bd369a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "Password", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cde71b6d-b563-4d5f-af3b-2317b54a0096", "APPLICANT", "1234", "AQAAAAIAAYagAAAAEEfTyOWhrIVi3fxLC32Q/vKba0MEgf90DUU9a9/ZlR0qf5iFtM+dD54ic4lF0Kaa1g==", "7d7099d0-04b5-4bc5-a27f-a971cb73a1b5" });
        }
    }
}
