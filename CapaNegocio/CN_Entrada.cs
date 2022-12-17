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
    public class CN_Entrada
    {

        private CD_Entrada objcd_Entrada = new CD_Entrada();


        public int ObtenerCorrelativo()
        {
            return objcd_Entrada.ObtenerCorrelativo();
        }

        public bool Registrar(Entrada obj,DataTable DetalleEntrad, out string Mensaje)
        {
            return objcd_Entrada.Registrar(obj, DetalleEntrad, out Mensaje);
        }

        public Entrada ObtenerEntrada(string numero) {

            Entrada oEntrada = objcd_Entrada.ObtenerEntrada(numero);

            if (oEntrada.IdEntrada != 0) {
                List<Detalle_Entrada> oDetalleEntrada = objcd_Entrada.ObtenerDetalleEntrada(oEntrada.IdEntrada);

                oEntrada.oDetalleEntrada = oDetalleEntrada;
            }
            return oEntrada;
        }


    }
}
