using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class InitialMig06 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db743838-f73a-4c87-8736-24eb64687d3d", "ADMIN@XYZ.COM", "ADMIN", "AQAAAAIAAYagAAAAEIrfXmPdUuQnwKgMQG8iuN4Dnevqrm8Z1rwrrlkjG9U5b0F8Y+rYhr0lyI4gI0jsgQ==", "730b45eb-e876-4a58-8658-194689010813" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a107544-7ae6-41d4-acb1-fb0dca5e417e", "EMPLOYEE@XYZ.COM", "EMPLOYEE", "AQAAAAIAAYagAAAAEHfELkqIi0B0qwoCKCyD+nTqUzzAgPVdaGySCsrEZ6rx4wNpqluvN5jPN+5UmLkyQA==", "5f58813b-3f36-4e7c-bded-cc7fa163eb26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09c0630a-0bab-42cb-b0af-1ab9c8f49d2d", "APPLICANT@XYZ.COM", "APPLICANT", "AQAAAAIAAYagAAAAEED7RMrsWU5QZmKs1TCFb7teGNXxWANO+zxA0I+T/96CORIGyT//yvt75XCza0s9Hg==", "5e8c2c0b-39cc-43b6-bcd5-9692c1be9f0c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57d5c85c-f23a-4956-a3de-29174ced0782", null, null, "AQAAAAIAAYagAAAAENuk60iVbBSl65jp3pkfrye9fpvvRm13WBd7IS9+ENCW73mSJih/ZeH9JUsCw67xSg==", "56de9d8e-a3b6-407c-aec5-eb829c4aa6e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f78cc884-a9e8-4931-bbf3-4be77a1f80d1", null, null, "AQAAAAIAAYagAAAAEPP1v5PTt1sTl9yMtbhhkfL4C0TFznSKpYJCtQFUdEB9uzKqadYwXuImetnz9rO84g==", "3c0522a8-ffaf-40e3-af03-bdb24f428cd9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfb880fe-04a0-4e00-9870-def2d8349ccb", null, null, "AQAAAAIAAYagAAAAEKTNXnNG0GVy3lF+SSJgcxEjHRUTqE6OjUo7RyTzoGs2wUuh0KpnsLXq9HjW+8oLOw==", "7b3fb582-68ac-4c89-9f93-5f0b36f4ba0d" });
        }
    }
}
