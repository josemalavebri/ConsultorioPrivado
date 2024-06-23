using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultorioPrivado.Controlador.Creators;
using ConsultorioPrivado.Controlador.Enums;
using ConsultorioPrivado.Datos.DbOpeaciones;
using ConsultorioPrivado.Vista.Utilidad.Forms;

namespace ConsultorioPrivado.Datos.Interface
{

    //CLASE QUE CREA LOS SP SEGUN LAS ESTRUCTURA DE LAS PETICIONES
    public class ExecuteSP : I_AccesoDB
    {

        private ExecuteQuery obj_bd;
        public ExecuteSP()
        {
            obj_bd = new ExecuteQuery();

        }

        public DataTable ObtenerPorEntidad(string sp_query)
        {
            try
            {
                List<ParametrosCreator> lista = new List<ParametrosCreator>();
                return obj_bd.ExecuteSPQuery(sp_query, lista);
            }
            catch (Exception ex)
            {
                throw new Exception("error al obtener tabla de " + sp_query + " " + ex.Message);
            }
        }

        public DataTable ObtenerPorId(string sp_query)
        {
            try
            {
                List<ParametrosCreator> lista = new List<ParametrosCreator>();
                return obj_bd.ExecuteSPQuery(sp_query, lista);
            }
            catch (Exception ex)
            {
                throw new Exception("error al buscar por ID de " + sp_query + " " + ex.Message);
            }
        }

        public DataTable ObtenerPorCedula(string sp_query)
        {
            try
            {
                List<ParametrosCreator> lista = new List<ParametrosCreator>();
                return obj_bd.ExecuteSPQuery(sp_query, lista);
            }
            catch (Exception ex)
            {
                throw new Exception("error al buscar por Cedula de " + sp_query + " " + ex.Message);
            }
        }
        
        //Eliminar entidad
        public bool EliminarEntidad(string sp_Non_query, List<ParametrosCreator> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery(sp_Non_query, lista);
            }
            catch (Exception ex)
            {
                throw new Exception("error  al eliminar entidad de " + sp_Non_query + " " + ex.Message);
            }

        }

        public bool CrearEntidad(string sp_Non_query, List<ParametrosCreator> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery(sp_Non_query, lista);
            }
            catch (Exception ex)
            {
                throw new Exception("error al crear entidad de " + sp_Non_query + " " + ex.Message);
            }
        }
        
        //Actualiza entidad
        public bool ActualizarEntidad(string sp_Non_query, List<ParametrosCreator> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery(sp_Non_query, lista);
            }
            catch (Exception ex)
            {
                throw new Exception("error al actualizar el " + sp_Non_query + " " + ex.Message);
            }
        }
        
    }
}
