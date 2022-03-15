using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hamazon_DataAccess.Migrations
{
    public partial class AddingPersonTableToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Created",
                table: "People",
                newName: "UpdatedDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "People");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "People",
                newName: "Created");
        }
    }
}
