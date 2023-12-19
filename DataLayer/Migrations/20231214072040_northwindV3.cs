using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class northwindV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePrivileges_Privileges_EmployeeId",
                table: "EmployeePrivileges");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePrivileges_PriviligeId",
                table: "EmployeePrivileges",
                column: "PriviligeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePrivileges_Privileges_PriviligeId",
                table: "EmployeePrivileges",
                column: "PriviligeId",
                principalTable: "Privileges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePrivileges_Privileges_PriviligeId",
                table: "EmployeePrivileges");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePrivileges_PriviligeId",
                table: "EmployeePrivileges");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePrivileges_Privileges_EmployeeId",
                table: "EmployeePrivileges",
                column: "EmployeeId",
                principalTable: "Privileges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
