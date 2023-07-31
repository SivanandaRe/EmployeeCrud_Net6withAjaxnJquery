using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeDataAccessLayer.Migrations
{
    public partial class EmployeeTableColumnmodify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "decimal(10,2)",
                table: "Employees",
                newName: "Salary");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Salary",
                table: "Employees",
                newName: "decimal(10,2)");
        }
    }
}
