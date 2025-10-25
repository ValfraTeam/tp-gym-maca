using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace clasesGYM_.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUnusedIdFromSuscripcionCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "SuscripcionClientes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SuscripcionClientes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
