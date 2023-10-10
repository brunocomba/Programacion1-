using Back.Clases;
using Microsoft.EntityFrameworkCore;

namespace Back.ConeccionBD
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cuenta_Bancaria> Cuentas_Bancarias { get; set; }
        public DbSet<Tarjeta_Credito> Tarjetas_Credito { get; set; }
        public DbSet<Compra_Tarjeta> Compras_Tarjeta { get; set; }

        // coneccion base de datos sql
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = LAPTOP-64KVEN22; database = EntidadFinancieraBD3; trusted_connection = true; Encrypt = False");
        }
    }
}
