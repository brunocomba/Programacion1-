using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreatete2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarjetas_Credito_Cuentas_Bancarias_Cuenta_BancariaID",
                table: "Tarjetas_Credito");

            migrationBuilder.RenameColumn(
                name: "Cuenta_BancariaID",
                table: "Tarjetas_Credito",
                newName: "ClienteID");

            migrationBuilder.RenameIndex(
                name: "IX_Tarjetas_Credito_Cuenta_BancariaID",
                table: "Tarjetas_Credito",
                newName: "IX_Tarjetas_Credito_ClienteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarjetas_Credito_Clientes_ClienteID",
                table: "Tarjetas_Credito",
                column: "ClienteID",
                principalTable: "Clientes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarjetas_Credito_Clientes_ClienteID",
                table: "Tarjetas_Credito");

            migrationBuilder.RenameColumn(
                name: "ClienteID",
                table: "Tarjetas_Credito",
                newName: "Cuenta_BancariaID");

            migrationBuilder.RenameIndex(
                name: "IX_Tarjetas_Credito_ClienteID",
                table: "Tarjetas_Credito",
                newName: "IX_Tarjetas_Credito_Cuenta_BancariaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarjetas_Credito_Cuentas_Bancarias_Cuenta_BancariaID",
                table: "Tarjetas_Credito",
                column: "Cuenta_BancariaID",
                principalTable: "Cuentas_Bancarias",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
