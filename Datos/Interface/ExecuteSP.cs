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

    //CLASE QUE CREA LOS SP SEGUN LAS ESTRUCTURA DE LAS PETICIONES
    public class ExecuteSP : AccesoDB
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
        public DataTable ObtenerPorEntidad(E_ROL rol)
        {
            try
            {
                List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
                return obj_bd.ExecuteSPQuery(crearCadenaFinal(E_CODIGO_SP.SP_OBTENER, rol), lista);
            }
            catch (Exception ex)
            {

                throw new Exception(error + " al obtener tabla de " + rol + " " + ex.Message);
            }
        }

        public DataTable ObtenerPorId(E_ROL rol, List<CD_Parameter_SP> lista)
        {
            //<CD_Parameter_SP> lista = new List<CD_Parameter_SP> ();
            return obj_bd.ExecuteSPQuery(crearCadenaFinal(E_CODIGO_SP.SP_OBTENER_POR_ID, rol), lista);
        }
        //Crear entidad
        public bool Crear(E_ROL rol, List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery(crearCadenaFinal(E_CODIGO_SP.SP_CREAR, rol), lista);
            }
            catch (Exception ex)
            {
                throw new Exception(error + " al guardar un nuevo " + rol + " " + ex.Message);
            }
        }
        //Eliminar entidad
        public bool Eliminar(E_ROL rol, List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery(crearCadenaFinal(E_CODIGO_SP.SP_ELIMINAR, rol), lista);
            }
            catch (Exception ex)
            {
                throw new Exception(error + " al eliminar el " + rol + " " + ex.Message);
            }
        }
        //Actualiza entidad
        public bool Actualizar(E_ROL rol, List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery(crearCadenaFinal(E_CODIGO_SP.SP_ACTUALIZAR, rol), lista);
            }
            catch (Exception ex)
            {
                throw new Exception(error + " al actualizar el " + rol + " " + ex.Message);
            }
        }

        public DataTable ObtenerPorCedula(E_ROL rol, List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPQuery(crearCadenaFinal(E_CODIGO_SP.SP_OBTENER_POR_CEDULA, rol), lista);
            }
            catch (Exception ex)
            {
                throw new Exception(error + " al buscar el " + rol + " " + ex.Message);
            }
        }
    }
}
