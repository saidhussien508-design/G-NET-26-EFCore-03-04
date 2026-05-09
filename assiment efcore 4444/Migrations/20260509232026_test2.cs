using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assimentefcore4444.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountStatus",
                table: "customerAcount",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "OwnerShipStartDate",
                table: "customerAcount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "OwnerShipType",
                table: "customerAcount",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountStatus",
                table: "customerAcount");

            migrationBuilder.DropColumn(
                name: "OwnerShipStartDate",
                table: "customerAcount");

            migrationBuilder.DropColumn(
                name: "OwnerShipType",
                table: "customerAcount");
        }
    }
}
