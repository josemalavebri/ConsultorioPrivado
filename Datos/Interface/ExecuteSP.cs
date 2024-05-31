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
    public class ExecuteSP : DataAccess
    {
        private StringBuilder cadenaFinal;
        private ExecuteQuery obj_bd;
        private string error;
        public ExecuteSP()
        {
            obj_bd = new ExecuteQuery();
            cadenaFinal = new StringBuilder();
            error = "Error";
        }
        public string crearCadenaFinal(E_CODIGO_SP codigo, E_ROL rol)
        {
            cadenaFinal.Clear();
            cadenaFinal.Append(codigo);
            cadenaFinal.Append(rol);
            return cadenaFinal.ToString();
        }
        // Ver tabla entidad
        public DataTable getTabla(E_ROL rol)
        {
            try
            {
                List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
                return obj_bd.ExecuteSPQuery(crearCadenaFinal(E_CODIGO_SP.SP_GET, rol), lista);
            }
            catch (Exception ex)
            {

                throw new Exception(error + " al obtener tabla de " + rol + " " + ex.Message);
            }
        }
        public DataTable getId(E_ROL rol, List<CD_Parameter_SP> lista)
        {
            //<CD_Parameter_SP> lista = new List<CD_Parameter_SP> ();
            return obj_bd.ExecuteSPQuery(crearCadenaFinal(E_CODIGO_SP.SP_GET_ID, rol), lista);
        }
        //Crear entidad
        public bool crear(E_ROL rol, List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery(crearCadenaFinal(E_CODIGO_SP.SP_CREA, rol), lista);
            }
            catch (Exception ex)
            {
                throw new Exception(error + " al guardar un nuevo " + rol + " " + ex.Message);
            }
        }
        //Eliminar entidad
        public bool eliminar(E_ROL rol, List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery(crearCadenaFinal(E_CODIGO_SP.SP_ELIMINA, rol), lista);
            }
            catch (Exception ex)
            {
                throw new Exception(error + " al eliminar el " + rol + " " + ex.Message);
            }
        }
        //Actualiza entidad
        public bool actualizar(E_ROL rol, List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery(crearCadenaFinal(E_CODIGO_SP.SP_ACTUALIZA, rol), lista);
            }
            catch (Exception ex)
            {
                throw new Exception(error + " al actualizar el " + rol + " " + ex.Message);
            }
        }

        public DataTable getCedula(E_ROL rol, List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPQuery(crearCadenaFinal(E_CODIGO_SP.SP_GET_CEDULA, rol), lista);
            }
            catch (Exception ex)
            {
                throw new Exception(error + " al buscar el " + rol + " " + ex.Message);
            }
        }

        public DataTable nombresCompletos(E_ROL rol)
        {
            try
            {
                List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
                return obj_bd.ExecuteSPQuery(crearCadenaFinal(E_CODIGO_SP.SP_GET, rol), lista);
            }
            catch (Exception ex)
            {
                throw new Exception(error + " al obtener los nombres completos de " + rol + " " + ex.Message);
            }
        }

        public DataTable buscar(E_ROL rol, List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPQuery(crearCadenaFinal(E_CODIGO_SP.SP_BUSCAR, rol), lista);
            }
            catch (Exception ex)
            {
                throw new Exception(error + " al buscar el " + rol + " " + ex.Message);
            }
        }
    }
}
