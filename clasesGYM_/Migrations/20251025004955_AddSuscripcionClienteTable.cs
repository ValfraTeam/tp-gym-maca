using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace clasesGYM_.Migrations
{
    /// <inheritdoc />
    public partial class AddSuscripcionClienteTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Clases_ClaseId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Suscripciones_TipoSuscripcionId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_ClaseId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_TipoSuscripcionId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Vigencia",
                table: "Suscripciones");

            migrationBuilder.DropColumn(
                name: "ClaseId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "FechaInicio",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "TipoSuscripcionId",
                table: "Clientes");

            migrationBuilder.AddColumn<int>(
                name: "ClientePagoId",
                table: "Pagos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SuscripcionPagoId",
                table: "Pagos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SuscripcionClientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    SuscripcionId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuscripcionClientes", x => new { x.ClienteId, x.SuscripcionId });
                    table.ForeignKey(
                        name: "FK_SuscripcionClientes_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SuscripcionClientes_Suscripciones_SuscripcionId",
                        column: x => x.SuscripcionId,
                        principalTable: "Suscripciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_ClientePagoId",
                table: "Pagos",
                column: "ClientePagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_SuscripcionPagoId",
                table: "Pagos",
                column: "SuscripcionPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_SuscripcionClientes_SuscripcionId",
                table: "SuscripcionClientes",
                column: "SuscripcionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Clientes_ClientePagoId",
                table: "Pagos",
                column: "ClientePagoId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Suscripciones_SuscripcionPagoId",
                table: "Pagos",
                column: "SuscripcionPagoId",
                principalTable: "Suscripciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Clientes_ClientePagoId",
                table: "Pagos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Suscripciones_SuscripcionPagoId",
                table: "Pagos");

            migrationBuilder.DropTable(
                name: "SuscripcionClientes");

            migrationBuilder.DropIndex(
                name: "IX_Pagos_ClientePagoId",
                table: "Pagos");

            migrationBuilder.DropIndex(
                name: "IX_Pagos_SuscripcionPagoId",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "ClientePagoId",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "SuscripcionPagoId",
                table: "Pagos");

            migrationBuilder.AddColumn<int>(
                name: "Vigencia",
                table: "Suscripciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClaseId",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaInicio",
                table: "Clientes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "TipoSuscripcionId",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ClaseId",
                table: "Clientes",
                column: "ClaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_TipoSuscripcionId",
                table: "Clientes",
                column: "TipoSuscripcionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Clases_ClaseId",
                table: "Clientes",
                column: "ClaseId",
                principalTable: "Clases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Suscripciones_TipoSuscripcionId",
                table: "Clientes",
                column: "TipoSuscripcionId",
                principalTable: "Suscripciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
