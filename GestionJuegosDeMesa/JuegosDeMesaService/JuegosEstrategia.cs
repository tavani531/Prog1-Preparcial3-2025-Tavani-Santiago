using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosDeMesaService
{
    public class JuegosEstrategia:Productos
    {
        public Enums.DificultadJuego Dificultad { get; set; }
        public int TiempoJuego { get; set; } 
        public int EdadMinima { get; set; }
        public int NroJugadoresSoportado { get; set; }

        public JuegosEstrategia(string nombreJuego, string editorial, int precioBase, DateTime fechaPublicacion, DateTime fechaLimiteComercializacion, Enums.DificultadJuego dificultad, int tiempoJuego, int edadMinima, int nroJugadoresSoportado)
            : base(nombreJuego, editorial, precioBase, fechaPublicacion, fechaLimiteComercializacion)
        {
            Dificultad = dificultad;
            TiempoJuego = tiempoJuego;
            EdadMinima = edadMinima;
            NroJugadoresSoportado = nroJugadoresSoportado;
        }
    }
}
