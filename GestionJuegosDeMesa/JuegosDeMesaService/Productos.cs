using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace JuegosDeMesaService
{
    public abstract class Productos
    {
        private static int contCod = 1;
        public int Codigo { get; private set; } 
        public string NombreJuego { get; set; }
        public string Editorial { get; set; }
        public int PrecioBase { get; set; }
        public DateTime FechaPublicacion { get; set; }  
        public DateTime FechaLimiteComercializacion { get; set; }

        public Productos(string nombreJuego, string editorial, int precioBase, DateTime fechaPublicacion, DateTime fechaLimiteComercializacion)
        {
            Codigo = contCod;
            NombreJuego = nombreJuego;
            Editorial = editorial;
            PrecioBase = precioBase;
            FechaPublicacion = fechaPublicacion;
            FechaLimiteComercializacion = fechaLimiteComercializacion;

            contCod++;
        }
    }
}
