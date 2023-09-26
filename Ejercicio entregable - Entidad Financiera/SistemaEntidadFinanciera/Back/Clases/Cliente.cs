

namespace Back.Clases
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public EstadoCliente Estado { get; set; }

        public enum EstadoCliente
        {
            Pausado = 0,
            Activo = 1
        }
        public override string ToString()
        {
            return $"{Nombre} {Apellido}"; 
        }
       
    }
}
