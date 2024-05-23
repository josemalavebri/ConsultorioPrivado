﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultorioPrivado.Utilidad.Datos;

namespace ConsultorioPrivado.Datos.Interface
{
    internal class ExecuteSP : InterfaceDatos
    {
        private string cadenaFinal;
        private ExecuteQuery obj_bd;

        public ExecuteSP() {
            obj_bd = new ExecuteQuery();
        }

        public string crearCadenaFinal(E_CODIGO_SP codigo, E_ROL rol) { return "" + codigo + rol; }

        public DataTable get(E_ROL rol)
        {
            List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
            cadenaFinal = crearCadenaFinal(E_CODIGO_SP.SP_GET, rol);
            return obj_bd.ExecuteSPQuery(cadenaFinal, lista);
        }

        public bool getId(E_ROL rol, List<CD_Parameter_SP> lista)
        {
            cadenaFinal = crearCadenaFinal(E_CODIGO_SP.SP_GET_ID, rol);
            return obj_bd.ExecuteSPNonQuery(cadenaFinal, lista);
        }

        public bool crear(E_ROL rol, List<CD_Parameter_SP> lista)
        {
            cadenaFinal = crearCadenaFinal(E_CODIGO_SP.SP_CREA, rol);
            return obj_bd.ExecuteSPNonQuery(cadenaFinal, lista);
        }

        public bool actualiza(E_ROL rol, List<CD_Parameter_SP> lista)
        {
            cadenaFinal = crearCadenaFinal(E_CODIGO_SP.SP_ACTUALIZA, rol);
            return obj_bd.ExecuteSPNonQuery(cadenaFinal, lista);
        }

        public bool elimina( E_ROL rol, List<CD_Parameter_SP> lista)
        {
            cadenaFinal = crearCadenaFinal(E_CODIGO_SP.SP_ELIMINA, rol);
            return obj_bd.ExecuteSPNonQuery(cadenaFinal, lista);
        }

        
    }
}
