using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Exam_Practice.Migrations
{
    public partial class initall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "country",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "username",
                table: "Students",
                newName: "message");

            migrationBuilder.RenameColumn(
                name: "mphone",
                table: "Students",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "gender",
                table: "Students",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Students",
                newName: "Price");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "message",
                table: "Students",
                newName: "username");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Students",
                newName: "mphone");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Students",
                newName: "gender");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Students",
                newName: "email");

            migrationBuilder.AddColumn<string>(
                name: "country",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
