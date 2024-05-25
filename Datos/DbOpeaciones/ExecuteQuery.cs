using ConsultorioPrivado.Utilidad.Datos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Datos.DbOpeaciones
{
    internal class ExecuteQuery
    {

        private ConexionDB conn = new ConexionDB();

        public bool ExecuteSPNonQuery(string nombre_sp, List<CD_Parameter_SP> lista_parametros)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombre_sp;
            if (lista_parametros.Count > 0)
            {
                foreach (var parametro in lista_parametros)
                    comando.Parameters.Add(parametro.NombreParametro, parametro.TipoDato).Value = parametro.ValorParametro;
            }
            comando.Connection = conn.AbrirConexion();
            var resultado = comando.ExecuteNonQuery();
            conn.CerrarConexion();
            if (resultado > 0)
                return true;
            else
                return false;
        }

        public DataTable ExecuteSPQuery(string nombre_sp, List<CD_Parameter_SP> lista_parametros)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombre_sp;
            if (lista_parametros.Count > 0)
            {
                foreach (var parametro in lista_parametros)
                    comando.Parameters.Add(parametro.NombreParametro, parametro.TipoDato).Value = parametro.ValorParametro;
            }

            comando.Connection = conn.AbrirConexion();

            SqlDataReader reader = comando.ExecuteReader();

            using (var tabla = new DataTable())
            {
                tabla.Load(reader);
                reader.DisposeAsync();
                conn.CerrarConexion();
                return tabla;
            }
        }

    }
}
