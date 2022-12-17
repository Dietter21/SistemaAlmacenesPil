using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Salida
    {
        private CD_Salida objcd_Salida = new CD_Salida();

        public bool RestarStock(int idproducto, int cantidad) {
            return objcd_Salida.RestarStock(idproducto, cantidad);
        }

        public bool SumarStock(int idproducto, int cantidad) {
            return objcd_Salida.SumarStock(idproducto, cantidad);
        }

        public int ObtenerCorrelativo()
        {
            return objcd_Salida.ObtenerCorrelativo();
        }

        public bool Registrar(Salida obj, DataTable DetalleSalida, out string Mensaje)
        {
            return objcd_Salida.Registrar(obj, DetalleSalida, out Mensaje);
        }

        public Salida ObtenerSalida(string numero) {
            Salida oSalida = objcd_Salida.ObtenerSalida(numero);

            if (oSalida.IdSalida != 0) {
                List<Detalle_Salida> oDetalleSalida = objcd_Salida.ObtenerDetalleSalida(oSalida.IdSalida);
                oSalida.oDetalle_Salida = oDetalleSalida;
            }

            return oSalida;
        }



    }
}
