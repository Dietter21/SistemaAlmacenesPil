﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Reporte
    {
        private CD_Reporte objcd_reporte = new CD_Reporte();

        public List<ReporteEntrada> Entrada(string fechainicio, string fechafin, int idproveedor)
        {
            return objcd_reporte.Entrada(fechainicio, fechafin, idproveedor);
        }


        public List<ReporteSalida> Salida(string fechainicio, string fechafin)
        {
            return objcd_reporte.Salida(fechainicio, fechafin);
        }
    }
}
