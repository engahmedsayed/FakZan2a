using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Acme.FakZan2a.Migrations
{
    public partial class UpdatedUserEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>("FullNameArabic", "AbpUsers", "nvarchar(256)", maxLength: 255, nullable: true);
            migrationBuilder.AddColumn<string>("FullNameEnglish", "AbpUsers", "nvarchar(256)", maxLength: 255, nullable: true);
            migrationBuilder.AddColumn<string>("DateOfBirth", "AbpUsers", "datetime2", nullable: true);
            migrationBuilder.AddColumn<string>("Gender", "AbpUsers", "int", nullable: true);
            migrationBuilder.AddColumn<string>("Mobile", "AbpUsers", "nvarchar(15)", maxLength: 15, nullable: true);
            migrationBuilder.AddColumn<string>("WhatsAppNumber", "AbpUsers", "nvarchar(15)", maxLength: 15, nullable: true);
            migrationBuilder.AddColumn<string>("UserType", "AbpUsers", "int",  nullable: true);
            migrationBuilder.AddColumn<string>("LanguagePreference", "AbpUsers", "int", nullable: true);
            migrationBuilder.AddColumn<string>("IsActive", "AbpUsers", "bit", nullable: true);


           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("FullNameArabic", "AbpUsers");
            migrationBuilder.DropColumn("FullNameEnglish", "AbpUsers");
            migrationBuilder.DropColumn("DateOfBirth", "AbpUsers");
            migrationBuilder.DropColumn("Gender", "AbpUsers");
            migrationBuilder.DropColumn("Mobile", "AbpUsers");
            migrationBuilder.DropColumn("WhatsAppNumber", "AbpUsers");
            migrationBuilder.DropColumn("UserType", "AbpUsers");
            migrationBuilder.DropColumn("LanguagePreference", "AbpUsers");
            migrationBuilder.DropColumn("IsActive", "AbpUsers");
        }
    }
}
