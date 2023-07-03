using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class InitialMig04 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "IsActive", "LockoutEnabled", "LockoutEnd", "ModifiedDate", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegistrationDate", "SecurityStamp", "TwoFactorEnabled", "UserId", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "fef2259b-6066-4550-a79e-f31a99673724", null, "admin@xyz.com", true, false, false, null, null, null, "ADMIN", "1234", "AQAAAAIAAYagAAAAEF47iML3iRANeWUtMjMd88hV9o4zrv6J83U95wncyGQ9J7VoemJvKKisjer/UlJWVg==", null, false, null, "7dc0b084-6d10-42d8-9c64-dba8407f0c0f", false, null, "Admin" },
                    { "2", 0, "598c6732-6bd8-4543-820c-86268c5c8e00", null, "employee@xyz.com", true, false, false, null, null, null, "EMPLOYEE", "1234", "AQAAAAIAAYagAAAAEOgFfYWWQXSg2Moccsj3TRko49CDsy0xHpd38/ukH3XC+zcR7Zs1TxckIm+yY+JD+Q==", null, false, null, "082f6ee9-f608-4884-9632-ebbb96bd369a", false, null, "Employee" },
                    { "3", 0, "cde71b6d-b563-4d5f-af3b-2317b54a0096", null, "applicant@xyz.com", true, false, false, null, null, null, "APPLICANT", "1234", "AQAAAAIAAYagAAAAEEfTyOWhrIVi3fxLC32Q/vKba0MEgf90DUU9a9/ZlR0qf5iFtM+dD54ic4lF0Kaa1g==", null, false, null, "7d7099d0-04b5-4bc5-a27f-a971cb73a1b5", false, null, "Applicant" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");
        }
    }
}
