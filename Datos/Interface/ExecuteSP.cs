using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Datos.Interface
{
    internal class ExecuteSP : InterfaceDatos
    {
        private string cadenaFinal;

        public ExecuteSP() { }


        private ExecuteSQL obj_bd = new ExecuteSQL();


        public DataTable get(CODIGO_SP codigo_SP, ROL rol)
        {
            List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
            cadenaFinal = codigo_SP.ToString() + rol.ToString();
            return obj_bd.ExecuteSPQuery(cadenaFinal, lista);
        }

        public bool get_id(CODIGO_SP codigo_SP, ROL rol, List<CD_Parameter_SP> lista)
        {
            throw new NotImplementedException();
        }

        public bool crear(CODIGO_SP codigo_SP, ROL rol, List<CD_Parameter_SP> lista)
        {
            throw new NotImplementedException();
        }

        public bool eliminar(CODIGO_SP codigo_SP, ROL rol, List<CD_Parameter_SP> lista)
        {
            throw new NotImplementedException();
        }

       








        /*
public DataTable getLista(int id_provincia)
{
   try
   {
       string cadenaFinal = codigosSp[0] + tipoInterface;

       return obj_bd.ExecuteSP_Canton("SP_GET_CANTONES_BY_PROVINCIA", id_provincia);
   }
   catch (Exception ex)
   {
       throw new Exception("Error al Obtener Cantones " + ex.Message);
   }
}
public bool Eliminar(List<CD_Parameter_SP> lista)
{
   try
   {
       return obj_bd.ExecuteSPNonQuery("SP_ELIMINA_PROVINCIA", lista);
   }
   catch (Exception ex)
   {
       throw new Exception("Error al Eliminar Provincia " + ex.Message);
   }
}

public bool CreaProvincia(List<CD_Parameter_SP> lista)
{
   try
   {
       return obj_bd.ExecuteSPNonQuery("SP_CREA_PROVINCIA", lista);
   }
   catch (Exception ex)
   {
       throw new Exception("Error al Crear Provincia " + ex.Message);
   }
}

public bool ActualizarProvincia(List<CD_Parameter_SP> lista)
{
   try
   {
       return obj_bd.ExecuteSPNonQuery("SP_ACTUALIZA_PROVINCIA", lista);
   }
   catch (Exception ex)
   {
       throw new Exception("Error al Actualizar Provincia " + ex.Message);
   }
}

*/
    }
}
