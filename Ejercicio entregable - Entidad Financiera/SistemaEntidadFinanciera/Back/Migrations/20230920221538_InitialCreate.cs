using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DNI = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cuentas_Bancarias",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteID = table.Column<int>(type: "int", nullable: false),
                    NroCuenta = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Saldo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuentas_Bancarias", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cuentas_Bancarias_Clientes_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Clientes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tarjetas_Credito",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cuenta_BancariaID = table.Column<int>(type: "int", nullable: false),
                    NroTarjeta = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LimiteCredito = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SaldoDisponible = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarjetas_Credito", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tarjetas_Credito_Cuentas_Bancarias_Cuenta_BancariaID",
                        column: x => x.Cuenta_BancariaID,
                        principalTable: "Cuentas_Bancarias",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cuentas_Bancarias_ClienteID",
                table: "Cuentas_Bancarias",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Tarjetas_Credito_Cuenta_BancariaID",
                table: "Tarjetas_Credito",
                column: "Cuenta_BancariaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarjetas_Credito");

            migrationBuilder.DropTable(
                name: "Cuentas_Bancarias");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
