using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoPartsFinal.Migrations
{
    /// <inheritdoc />
    public partial class productos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    ProductoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductoNombre = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProductoMonto = table.Column<double>(type: "float", nullable: false),
                    ProductoCantidad = table.Column<double>(type: "float", nullable: false),
                    ProductoDescripcion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ProductoImagenUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.ProductoId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Producto");
        }
    }
}
