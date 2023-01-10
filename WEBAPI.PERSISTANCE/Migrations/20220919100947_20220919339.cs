using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEBAPI.PERSISTANCE.Migrations
{
    public partial class _20220919339 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Designations",
                columns: table => new
                {
                    DesignationCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DesignationName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designations", x => x.DesignationCode);
                });

            migrationBuilder.CreateTable(
                name: "SkillTypes",
                columns: table => new
                {
                    SkillTypeCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SkillTypeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillTypes", x => x.SkillTypeCode);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Designations");

            migrationBuilder.DropTable(
                name: "SkillTypes");
        }
    }
}
