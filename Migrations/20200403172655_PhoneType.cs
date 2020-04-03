using Microsoft.EntityFrameworkCore.Migrations;

namespace TenantAPI.Migrations
{
    public partial class PhoneType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Tenants",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Phone",
                table: "Tenants",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 12);
        }
    }
}
