using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreEntitity.Migrations
{
    public partial class assignrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [dbo].[IDN_TRN_ROLE] ([UserId],[RoleId]) VALUES ('2a686299-48c4-4c54-bc0b-dfbcbbe7d0a3', 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
