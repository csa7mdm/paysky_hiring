using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class InitialMig08 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "00000000-0000-0000-0000-000000000000");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "00000000-0000-0000-0000-000000000000");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "00000000-0000-0000-0000-000000000000");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "08bf8b8d-f34b-45b6-bb71-3651c901d02c", "ADMIN@XYZ.COM", "AQAAAAIAAYagAAAAEBPutvVKf2rOnBepi/dooV8s0JeVRGu+XlyuRgg6AyzS0+WEXx1FX+YkF9x8a80Xfw==", "69fe0ed2-d48c-4e84-8295-4ed6745c488f", "admin@xyz.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "df96b22b-81d1-4e89-80e3-3fb9ff39645e", "EMPLOYEE@XYZ.COM", "AQAAAAIAAYagAAAAEC2CMAScvjmUvNEFh8+vcLlmWTO3ZqAN8y5WNMkCBeEbEtqNhsPG+nLNolpq3dQrGw==", "338e1bad-6596-47ba-a043-ecc914533647", "employee@xyz.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "56a5b583-d3aa-46ac-a4b2-6353243661f9", "APPLICANT@XYZ.COM", "AQAAAAIAAYagAAAAEFIbchK+gKK0HEGgdHlClpp0Ha3boccJ81CRNGFZqaJge/RxyILKmalll22CfTOZZg==", "38485e14-20ed-4197-bba8-a339bc4b4d8d", "applicant@xyz.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3bf3fade-55c0-4335-bedc-badfed2351ea", "ADMIN", "AQAAAAIAAYagAAAAEPPaxkS2qLJF/3VvYfceOkC8pl+0w4IIg0jQBvX0H/ipCcWHHLySpUfWbiqmIOr4mw==", "a592de38-422d-47bf-95d5-0de1d8929764", "Admin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1c24e664-f5b8-4c20-8dfb-50d76c22628e", "EMPLOYEE", "AQAAAAIAAYagAAAAEIXf2aQQHQvwKaZhAviuj9JNvpbzkzvFop6pqXs2umE+8jO8Ays4mZqo3udq9zKprA==", "74dc7b2c-bdd1-4e6f-876e-dd393f5f34cf", "Employee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1d7ec14a-8458-4576-b322-fef1c8abdf2f", "APPLICANT", "AQAAAAIAAYagAAAAEBNBq8SpZyl2jv1ASCWbYziK9N4kbIx5pl3GYMytMeMdfq33hipeiFOvt7SoXnesUA==", "c496c7a0-f16a-4cee-8311-1d0b2c871ca9", "Applicant" });
        }
    }
}
