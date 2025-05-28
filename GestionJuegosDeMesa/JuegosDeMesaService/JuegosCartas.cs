using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosDeMesaService
{
    public class JuegosCartas:Productos
    {
        public Enums.TipoCartas TipoCartas { get; set; }
        public int CantidadCartas { get; set; }
        public bool Expansiones { get; set; }
        public string MaterialCartas { get; set; }  

        public JuegosCartas(string nombreJuego, string editorial, int precioBase, DateTime fechaPublicacion, DateTime fechaLimiteComercializacion, Enums.TipoCartas tipoCartas, int cantidadCartas, bool expansiones, string materialCartas)
            : base(nombreJuego, editorial, precioBase, fechaPublicacion, fechaLimiteComercializacion)
        {
            TipoCartas = tipoCartas;
            CantidadCartas = cantidadCartas;
            Expansiones = expansiones;
            MaterialCartas = materialCartas;
        }
    }
}
