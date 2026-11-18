using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogWebsiteProject.Migrations;

/// <inheritdoc />
public partial class _20261118044642_InitialCreate : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "foodBankVolunteerDatas",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                VolunteerDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                VolunteerHours = table.Column<int>(type: "int", nullable: false),
                VolunteerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                VolunteerTask = table.Column<string>(type: "nvarchar(max)", nullable: false),
                VolunteerComments = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_foodBankVolunteerDatas", x => x.Id);
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "foodBankVolunteerDatas");
    }
}
