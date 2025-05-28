using System.Security.Authentication.ExtendedProtection;

namespace JuegosDeMesaService
{
    public class Plataforma
    {
        public (int,int) NivelDeDiversion(Productos producto)
        {
            int nivelDeDiversion = 0;

            if (producto is JuegosEstrategia estrategia)
            {
                nivelDeDiversion = 60;

                if (estrategia.Dificultad == Enums.DificultadJuego.Alta)
                {
                    nivelDeDiversion += 15;
                }
                if (estrategia.TiempoJuego > 90)
                {
                    nivelDeDiversion += 10;
                }
            }else if(producto is JuegosCartas cartas)
            {
                nivelDeDiversion = 50;

                if (cartas.Expansiones== true)
                {
                    nivelDeDiversion += 20;
                }
                if (cartas.TipoCartas == Enums.TipoCartas.Coleccionables)
                {
                    nivelDeDiversion += 10;
                }
            }
            int precioTotal=producto.PrecioBase + (producto.PrecioBase * nivelDeDiversion);
            return (nivelDeDiversion,precioTotal);
        }
        public List<Productos> Listaproductos { get; set; } = new();
        public List<Ventas> ListaVentas { get; set; } = new();
        int contVentas = 1;
        public (bool, string) RegistrarVenta(string nombreClienta, int codProducto)
        {
            var producto = Listaproductos.FirstOrDefault(p => p.Codigo == codProducto);

            if (producto == null)
            {
                return (false, "Producto no encontrado.");
            }
            if (producto.FechaLimiteComercializacion < DateTime.Now)
            {
                return (false, "Producto no disponible por fecha.");
            }
            Pago pago = new Pago
            {
                Codigo = contVentas,
                MontoTotal = producto.PrecioBase,
                FechaPago = DateTime.Now
            };
            Ventas venta = new Ventas
            {
                Codigo = contVentas,
                FechaVenta=DateTime.Now,
                NombreCliente = nombreClienta,
                ProductoVendido = producto.NombreJuego,
                Pago=pago
            };
            ListaVentas.Add(venta);
            return (true, $"Venta registrada con éxito. Código de venta: {contVentas}");
        }
    }
}
