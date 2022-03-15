﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hamazon_DataAccess.Migrations
{
    public partial class AddPersonTableToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimesInstallments = table.Column<short>(type: "smallint", nullable: false),
                    PaidInstallments = table.Column<short>(type: "smallint", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
