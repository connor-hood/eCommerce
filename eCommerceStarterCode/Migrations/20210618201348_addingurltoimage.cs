using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class addingurltoimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f64552a-ba2b-481d-b90a-f1abc716f3c6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa1a3a22-44d2-4fa4-89da-4bb0b45a7f7a");

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6e1786f7-723f-4c0b-8104-7086730c48b8", "2287d27e-d5fc-4368-990d-48bbf2e00952", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "33174f2d-754b-4029-8332-5b560f39f0d5", "6e7250cc-1980-44e9-9d2d-4850af8aaa15", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33174f2d-754b-4029-8332-5b560f39f0d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e1786f7-723f-4c0b-8104-7086730c48b8");

            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Products");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fa1a3a22-44d2-4fa4-89da-4bb0b45a7f7a", "57d82cbf-f725-45fc-98aa-f837269f5c4e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6f64552a-ba2b-481d-b90a-f1abc716f3c6", "9b82e80b-f0fa-475b-917e-ddc50a9624ba", "Admin", "ADMIN" });
        }
    }
}
