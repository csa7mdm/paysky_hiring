using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class InitialMig07 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bf3fade-55c0-4335-bedc-badfed2351ea", "AQAAAAIAAYagAAAAEPPaxkS2qLJF/3VvYfceOkC8pl+0w4IIg0jQBvX0H/ipCcWHHLySpUfWbiqmIOr4mw==", "a592de38-422d-47bf-95d5-0de1d8929764" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c24e664-f5b8-4c20-8dfb-50d76c22628e", "AQAAAAIAAYagAAAAEIXf2aQQHQvwKaZhAviuj9JNvpbzkzvFop6pqXs2umE+8jO8Ays4mZqo3udq9zKprA==", "74dc7b2c-bdd1-4e6f-876e-dd393f5f34cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d7ec14a-8458-4576-b322-fef1c8abdf2f", "AQAAAAIAAYagAAAAEBNBq8SpZyl2jv1ASCWbYziK9N4kbIx5pl3GYMytMeMdfq33hipeiFOvt7SoXnesUA==", "c496c7a0-f16a-4cee-8311-1d0b2c871ca9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db743838-f73a-4c87-8736-24eb64687d3d", "AQAAAAIAAYagAAAAEIrfXmPdUuQnwKgMQG8iuN4Dnevqrm8Z1rwrrlkjG9U5b0F8Y+rYhr0lyI4gI0jsgQ==", "730b45eb-e876-4a58-8658-194689010813" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a107544-7ae6-41d4-acb1-fb0dca5e417e", "AQAAAAIAAYagAAAAEHfELkqIi0B0qwoCKCyD+nTqUzzAgPVdaGySCsrEZ6rx4wNpqluvN5jPN+5UmLkyQA==", "5f58813b-3f36-4e7c-bded-cc7fa163eb26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09c0630a-0bab-42cb-b0af-1ab9c8f49d2d", "AQAAAAIAAYagAAAAEED7RMrsWU5QZmKs1TCFb7teGNXxWANO+zxA0I+T/96CORIGyT//yvt75XCza0s9Hg==", "5e8c2c0b-39cc-43b6-bcd5-9692c1be9f0c" });
        }
    }
}
