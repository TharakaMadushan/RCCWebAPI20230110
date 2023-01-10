using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEBAPI.PERSISTANCE.Migrations
{
    public partial class _202209211036 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Designations",
                table: "Designations");

            migrationBuilder.DropColumn(
                name: "DesignationCode",
                table: "Designations");

            migrationBuilder.RenameTable(
                name: "Designations",
                newName: "tblRefDesignation");

            migrationBuilder.RenameColumn(
                name: "SkillTypeName",
                table: "tblRefSkillType",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "tblRefSkillType",
                newName: "Active");

            migrationBuilder.RenameColumn(
                name: "SkillTypeCode",
                table: "tblRefSkillType",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "tblRefDesignation",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "DesignationName",
                table: "tblRefDesignation",
                newName: "DesigDes");

            migrationBuilder.AddColumn<string>(
                name: "DesigCode",
                table: "tblRefDesignation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblRefDesignation",
                table: "tblRefDesignation",
                column: "DesigCode");

            migrationBuilder.CreateTable(
                name: "tblRefDayType",
                columns: table => new
                {
                    DayTypeCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DayTypeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRefDayType", x => x.DayTypeCode);
                });

            migrationBuilder.CreateTable(
                name: "tblRefEmployee",
                columns: table => new
                {
                    EmployeeCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EmployeeDes = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TPNo1 = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: false),
                    TPNo2 = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: false),
                    Fax = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: false),
                    Email = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: false),
                    NIC = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: false),
                    EPFNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SkillTypeCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DesignationCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRefEmployee", x => x.EmployeeCode);
                });

            migrationBuilder.CreateTable(
                name: "tblRefProject",
                columns: table => new
                {
                    ProjectCode = table.Column<string>(type: "nvarchar(210)", maxLength: 210, nullable: false),
                    ProjectLink = table.Column<int>(type: "int", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ActiveProject = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRefProject", x => x.ProjectCode);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblRefDayType");

            migrationBuilder.DropTable(
                name: "tblRefEmployee");

            migrationBuilder.DropTable(
                name: "tblRefProject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblRefDesignation",
                table: "tblRefDesignation");

            migrationBuilder.DropColumn(
                name: "DesigCode",
                table: "tblRefDesignation");

            migrationBuilder.RenameTable(
                name: "tblRefDesignation",
                newName: "Designations");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tblRefSkillType",
                newName: "SkillTypeName");

            migrationBuilder.RenameColumn(
                name: "Active",
                table: "tblRefSkillType",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "tblRefSkillType",
                newName: "SkillTypeCode");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Designations",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "DesigDes",
                table: "Designations",
                newName: "DesignationName");

            migrationBuilder.AddColumn<string>(
                name: "DesignationCode",
                table: "Designations",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Designations",
                table: "Designations",
                column: "DesignationCode");
        }
    }
}
