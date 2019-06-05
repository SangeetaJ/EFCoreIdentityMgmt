using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreEntitity.Migrations
{
    public partial class seedRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO[dbo].[IDN_MST_ROLE]([Id],[Name],[NormalizedName],[Discriminator],[VALID_FROM],[VALID_TO]) VALUES (1,'Admin','Administrator','Administrator','04 June 2019','04 June 2019')");           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
