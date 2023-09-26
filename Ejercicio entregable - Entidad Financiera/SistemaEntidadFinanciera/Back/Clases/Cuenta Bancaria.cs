

namespace Back.Clases
{
    public class Cuenta_Bancaria
    {
        public int ID { get; set; }
        public Cliente Cliente { get; set; }
        public decimal NroCuenta { get; set; }
        public decimal Saldo { get; set; }

        public TipoDeCuenta Tipo { get; set; } // Cuenta corriente o Caja de ahorro.
        public enum TipoDeCuenta
        {
            Corrite = 1,
            Ahorro= 2,
        }

        public override string ToString()
        {
            return $" Titular: {Cliente} --- Nro: {NroCuenta}";
        }

    }
}
