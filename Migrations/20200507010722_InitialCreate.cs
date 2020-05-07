using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TenantAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tenants",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(maxLength: 12, nullable: false),
                    ApartmentName = table.Column<string>(nullable: false),
                    ApartmentNumber = table.Column<string>(maxLength: 5, nullable: false),
                    IsBackgroundChecked = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenants", x => x.TenantId);
                });

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
            migrationBuilder.DropTable(
                name: "Tenants");
        }
    }
}
