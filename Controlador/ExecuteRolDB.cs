using ConsultorioPrivado.Controlador;
using ConsultorioPrivado.Datos.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Controlador
{
    public class ExecuteRolDB
    {
        AccesoDB accesoDatos;
        private StringBuilder cadenaFinal;

        public ExecuteRolDB()
        {
            accesoDatos = new ExecuteSP();
            cadenaFinal = new StringBuilder();
        }

        public string CrearCadenaFinal(E_CODIGO_SP codigo, E_ROL rol)
        {
            cadenaFinal.Clear();
            cadenaFinal.Append(codigo);
            cadenaFinal.Append(rol);
            return cadenaFinal.ToString();
        }


        public DataTable ObtenerEntidad(E_ROL rol)
        {
            return accesoDatos.ObtenerPorEntidad(CrearCadenaFinal(E_CODIGO_SP.SP_OBTENER_POR, rol));
        }


    }
}
