using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Datos
{

    //CLASE DE CONEXION CON LA BASE DE DATOS
    public class ConexionDB
    {

        //CADENA DE CONEXION
        private SqlConnection conexion = new SqlConnection("server=LAPTOP-3RL0DTQR\\MSSQLSERVERR; database=Consultorio; Integrated Security=true; TrustServerCertificate=true");


        //ABRE UNA CONEXION
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
        //CIERRA UNA CONEXION

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
