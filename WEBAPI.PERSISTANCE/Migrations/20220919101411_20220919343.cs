using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEBAPI.PERSISTANCE.Migrations
{
    public partial class _20220919343 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SkillTypes",
                table: "SkillTypes");

            migrationBuilder.RenameTable(
                name: "SkillTypes",
                newName: "tblRefSkillType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblRefSkillType",
                table: "tblRefSkillType",
                column: "SkillTypeCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tblRefSkillType",
                table: "tblRefSkillType");

            migrationBuilder.RenameTable(
                name: "tblRefSkillType",
                newName: "SkillTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SkillTypes",
                table: "SkillTypes",
                column: "SkillTypeCode");
        }
    }
}
