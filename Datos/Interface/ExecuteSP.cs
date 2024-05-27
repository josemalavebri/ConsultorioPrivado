using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultorioPrivado.Datos.DbOpeaciones;
using ConsultorioPrivado.Utilidad.Datos;

namespace ConsultorioPrivado.Datos.Interface
{
    internal class ExecuteSP : DataAccess
    {
        private StringBuilder cadenaFinal;
        private ExecuteQuery obj_bd;

        public ExecuteSP() {
            obj_bd = new ExecuteQuery();
            cadenaFinal= new StringBuilder();
        }

        public string crearCadenaFinal(E_CODIGO_SP codigo, E_ROL rol) {
            cadenaFinal.Clear();
            cadenaFinal.Append(codigo);
            cadenaFinal.Append(rol);
            return cadenaFinal.ToString();
        }
            
        public DataTable get(E_ROL rol)
        {
            List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
            return obj_bd.ExecuteSPQuery(crearCadenaFinal(E_CODIGO_SP.SP_GET, rol), lista);
        }

        public DataTable getId(E_ROL rol, List<CD_Parameter_SP> lista)
        {
            return obj_bd.ExecuteSPQuery(crearCadenaFinal(E_CODIGO_SP.SP_GET_ID, rol), lista);
        }

        public bool crear(E_ROL rol, List<CD_Parameter_SP> lista)
        {
            return obj_bd.ExecuteSPNonQuery(crearCadenaFinal(E_CODIGO_SP.SP_CREA, rol), lista);
        }
       
        public bool eliminar( E_ROL rol, List<CD_Parameter_SP> lista)
        {
            return obj_bd.ExecuteSPNonQuery(crearCadenaFinal(E_CODIGO_SP.SP_ELIMINA, rol), lista);
        }

        public bool actualizar(E_ROL rol, List<CD_Parameter_SP> lista)
        {
            return obj_bd.ExecuteSPNonQuery(crearCadenaFinal(E_CODIGO_SP.SP_ACTUALIZA, rol), lista);
        }

        public DataTable getCedula(E_ROL rol, List<CD_Parameter_SP> lista)
        {
            return obj_bd.ExecuteSPQuery(crearCadenaFinal(E_CODIGO_SP.SP_GET_CEDULA, rol), lista);

        }

       
    }
}
