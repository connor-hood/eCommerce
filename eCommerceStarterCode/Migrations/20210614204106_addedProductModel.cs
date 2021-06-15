using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class addedProductModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36ad0057-acd7-464c-afc1-85c83a8b7de0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65613cf8-01c6-4fdc-b28f-0f556c89bcb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0adef3fd-5887-45fd-af60-eb152e56ad5c", "2770f0df-92e9-4221-8aa4-621151c1edfa", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7dd359c6-f5c3-4897-b43b-e4b5ba0c7a3e", "23a344bf-c362-47a2-8f3c-be0792abe67f", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0adef3fd-5887-45fd-af60-eb152e56ad5c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7dd359c6-f5c3-4897-b43b-e4b5ba0c7a3e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "36ad0057-acd7-464c-afc1-85c83a8b7de0", "ef6c0adc-00b4-4c14-87fb-12f425ecd1e4", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "65613cf8-01c6-4fdc-b28f-0f556c89bcb4", "1658be91-b626-49a5-9eb1-1f955eb32cd9", "Admin", "ADMIN" });
        }
    }
}
