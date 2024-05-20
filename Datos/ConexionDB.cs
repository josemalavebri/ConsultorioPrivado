using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Datos
{
    internal class ConexionDB
    {
        private SqlConnection conexion = new SqlConnection("server=Robert; database=Consultorio; Integrated Security=true");

        public SqlConnection AbrirConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
                throw;
            }

            return conexion;
        }

        public SqlConnection CerrarConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
                throw;
            }

            return conexion;
        }
    }
}
