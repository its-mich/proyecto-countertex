using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MicroServiceCounterTex.Migrations
{
    /// <inheritdoc />
    public partial class FechaContratotipoDateOnlyporDateTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaContrato",
                table: "Empleado",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaContrato",
                table: "Empleado",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
