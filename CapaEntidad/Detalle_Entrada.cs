using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Detalle_Entrada
    {
        public int IdDetalleEntrada { get; set; }
        public Producto oProducto { get; set; }
        public decimal PrecioEntrada { get; set; }
        public decimal PrecioSalida { get; set; }
        public int Cantidad { get; set; }
        public decimal MontoTotal { get; set; }
        public string FechaRegistro { get; set; }
    }
}
