using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultorioPrivado.Utilidad;

namespace ConsultorioPrivado.Datos.Interface
{
    internal class ExecuteSP : InterfaceDatos
    {
        private string cadenaFinal;
        private ExecuteQuery obj_bd;

        public ExecuteSP() {
            obj_bd = new ExecuteQuery();
        }

        public string crearCadenaFinal(CODIGO_SP codigo, ROL rol) { return "" + codigo + rol; }

        public DataTable get(ROL rol)
        {
            crearCadenaFinal(CODIGO_SP.SP_GET, rol);
            List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
            cadenaFinal = crearCadenaFinal(CODIGO_SP.SP_GET, rol);
            return obj_bd.ExecuteSPQuery(cadenaFinal, lista);
        }

        public bool getId(ROL rol, List<CD_Parameter_SP> lista)
        {
            cadenaFinal = crearCadenaFinal(CODIGO_SP.SP_GET_ID, rol);
            return obj_bd.ExecuteSPNonQuery(cadenaFinal, lista);
        }

        public bool crear(ROL rol, List<CD_Parameter_SP> lista)
        {
            cadenaFinal = crearCadenaFinal(CODIGO_SP.SP_CREA, rol);
            return obj_bd.ExecuteSPNonQuery(cadenaFinal, lista);
        }

        public bool actualiza(ROL rol, List<CD_Parameter_SP> lista)
        {
            cadenaFinal = crearCadenaFinal(CODIGO_SP.SP_ACTUALIZA, rol);
            return obj_bd.ExecuteSPNonQuery(cadenaFinal, lista);
        }

        public bool elimina( ROL rol, List<CD_Parameter_SP> lista)
        {
            cadenaFinal = crearCadenaFinal(CODIGO_SP.SP_ELIMINA, rol);
            return obj_bd.ExecuteSPNonQuery(cadenaFinal, lista);
        }

        
    }
}
