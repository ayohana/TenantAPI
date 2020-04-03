using Microsoft.EntityFrameworkCore.Migrations;

namespace TenantAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tenants",
                columns: new[] { "TenantId", "ApartmentName", "ApartmentNumber", "Email", "FirstName", "IsBackgroundChecked", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "Baker Apartments", "221B", "assistant@holmes.com", "John", true, "Watson", "4477009999" },
                    { 2, "Baker Apartments", "221B", "detective@holmes.com", "Sherlock", true, "Holmes", "4477009999" },
                    { 3, "Baker Apartments", "221A", "housekeeper@holmes.com", "Mrs", true, "Hudson", "4477008888" },
                    { 4, "Downing Apartments", "303", "specialist@morgue.com", "Molly", true, "Hooper", "4476001111" },
                    { 5, "Stonyhurst Place", "V20", "mastermind@villain.com", "James", false, "Moriarty", "4470004444" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tenants",
                keyColumn: "TenantId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tenants",
                keyColumn: "TenantId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tenants",
                keyColumn: "TenantId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tenants",
                keyColumn: "TenantId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tenants",
                keyColumn: "TenantId",
                keyValue: 5);
        }
    }
}
