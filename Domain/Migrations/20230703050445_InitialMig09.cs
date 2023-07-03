using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class InitialMig09 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c83c69e-b796-46bd-b0cb-69edac9d3cce", "AQAAAAIAAYagAAAAEG4AJTQ7af8GuYeD/g/RC3D3PPPGxdoUHKskJQojLgP7TOOg2R5akZAldD1BuQzZ/A==", "a5ab0e5b-cd06-4b7e-a8b4-e2d0898979d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6c1c714-ec8c-4434-ab52-a79fec5992c2", "AQAAAAIAAYagAAAAEIVShUq1F0JAbAf8sAu/FDWxXuDYQ9vatVhcOkEsYCtR0Z7Jx5eF7ZgLTRWOi4W0Cw==", "d6ebcb33-ad46-489d-a183-cb895eb5db30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd1ffefc-8728-49ea-a116-6795c00a6a5f", "AQAAAAIAAYagAAAAEAPABiMLC4dY4YuYIeFlquQdnOj9WnXh28YZqU9So8PoHF3uIp88lTWgdGIJ9DU0Zg==", "4bb15081-a627-4963-b647-a944374b310d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08bf8b8d-f34b-45b6-bb71-3651c901d02c", "AQAAAAIAAYagAAAAEBPutvVKf2rOnBepi/dooV8s0JeVRGu+XlyuRgg6AyzS0+WEXx1FX+YkF9x8a80Xfw==", "69fe0ed2-d48c-4e84-8295-4ed6745c488f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df96b22b-81d1-4e89-80e3-3fb9ff39645e", "AQAAAAIAAYagAAAAEC2CMAScvjmUvNEFh8+vcLlmWTO3ZqAN8y5WNMkCBeEbEtqNhsPG+nLNolpq3dQrGw==", "338e1bad-6596-47ba-a043-ecc914533647" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56a5b583-d3aa-46ac-a4b2-6353243661f9", "AQAAAAIAAYagAAAAEFIbchK+gKK0HEGgdHlClpp0Ha3boccJ81CRNGFZqaJge/RxyILKmalll22CfTOZZg==", "38485e14-20ed-4197-bba8-a339bc4b4d8d" });
        }
    }
}
