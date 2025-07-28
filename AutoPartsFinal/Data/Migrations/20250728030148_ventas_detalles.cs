using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutoPartsFinal.Migrations
{
    /// <inheritdoc />
    public partial class ventas_detalles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "11111111-aaaa-bbbb-cccc-111111111111", "33333333-aaaa-bbbb-cccc-333333333333" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "22222222-aaaa-bbbb-cccc-222222222222", "44444444-aaaa-bbbb-cccc-444444444444" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11111111-aaaa-bbbb-cccc-111111111111");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22222222-aaaa-bbbb-cccc-222222222222");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33333333-aaaa-bbbb-cccc-333333333333");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-aaaa-bbbb-cccc-444444444444");

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    VentaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.VentaId);
                });

            migrationBuilder.CreateTable(
                name: "VentasDetalle",
                columns: table => new
                {
                    DetalleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Monto = table.Column<double>(type: "float", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    ValorCobrado = table.Column<double>(type: "float", nullable: false),
                    VentaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VentasDetalle", x => x.DetalleId);
                    table.ForeignKey(
                        name: "FK_VentasDetalle_Ventas_VentaId",
                        column: x => x.VentaId,
                        principalTable: "Ventas",
                        principalColumn: "VentaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VentasDetalle_VentaId",
                table: "VentasDetalle",
                column: "VentaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VentasDetalle");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "11111111-aaaa-bbbb-cccc-111111111111", null, "Admin", "ADMIN" },
                    { "22222222-aaaa-bbbb-cccc-222222222222", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "33333333-aaaa-bbbb-cccc-333333333333", 0, "00000000-1111-2222-3333-444444444444", "johan@gmail.com", true, false, null, "JOHAN@GMAIL.COM", "JOHAN@GMAIL.COM", "AQAAAAIAAYagAAAAEDWtRg8BB9gXfYyT4QSIBzOhnT7P0ueVTMrcS8n6lsWWQgucmZKpHFyNTJA7C10aRw==", null, false, "A1B2C3D4E5F6A1B2C3D4E5F6A1B2C3D4", false, "johan@gmail.com" },
                    { "44444444-aaaa-bbbb-cccc-444444444444", 0, "55555555-6666-7777-8888-999999999999", "pedro@gmail.com", true, false, null, "PEDRO@GMAIL.COM", "PEDRO@GMAIL.COM", "AQAAAAIAAYagAAAAEL1za3G9uM6D/m90hVZyXj/adFuLGJ+4v1KtOve+aZGLCNLNMB9BLBrgLZWrHEYb4A==", null, false, "F6E5D4C3B2A1F6E5D4C3B2A1F6E5D4C3", false, "pedro@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "11111111-aaaa-bbbb-cccc-111111111111", "33333333-aaaa-bbbb-cccc-333333333333" },
                    { "22222222-aaaa-bbbb-cccc-222222222222", "44444444-aaaa-bbbb-cccc-444444444444" }
                });
        }
    }
}
