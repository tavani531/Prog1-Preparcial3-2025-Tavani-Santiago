using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosDeMesaService
{
    public class Ventas
    {
        public int Codigo { get;  set; }
        public DateTime FechaVenta { get; set; }
        public string NombreCliente { get; set; }
        public string ProductoVendido { get; set; }
        public Pago Pago { get; set; }

        /*public Ventas(DateTime fechaVenta, string nombreCliente, string productoVendido, Pago pago)
        {
            FechaVenta = fechaVenta;
            NombreCliente = nombreCliente;
            ProductoVendido = productoVendido;
            Pago = pago;
        }*/
    }
}
