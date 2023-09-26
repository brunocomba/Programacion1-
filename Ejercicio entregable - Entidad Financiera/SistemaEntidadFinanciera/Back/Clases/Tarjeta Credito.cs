using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class Tarjeta_Credito
    {
        public int ID { get; set; }
        public Cliente Cliente { get; set; }
        public decimal NroTarjeta { get; set; }
        public decimal LimiteCredito { get; set; }
        public decimal SaldoDisponible { get; set; }
        public decimal MontoDeuda { get; set; }
        public EstadoTarjetaCredito Estado { get; set; }

        public enum EstadoTarjetaCredito
        {
            Pausada = 0,
            Activa = 1
        }
    }
}
