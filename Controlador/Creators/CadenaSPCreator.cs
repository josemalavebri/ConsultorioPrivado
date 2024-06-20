using ConsultorioPrivado.Controlador.Enums;
using ConsultorioPrivado.Datos.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Controlador.Creators
{
    internal class CadenaSPCreator
    {

        private StringBuilder cadenaFinal;

        public CadenaSPCreator()
        {

            cadenaFinal = new StringBuilder();
        }

        private string CrearCadenaFinal(E_CODIGO_SP codigo, E_ROL rol)
        {
            cadenaFinal.Clear();
            cadenaFinal.Append(codigo);
            cadenaFinal.Append(rol);
            return cadenaFinal.ToString();
        }


        public string crearProcedimientoAlmacenado(E_ROL rol)
        {
            return CrearCadenaFinal(E_CODIGO_SP.SP_OBTENER_POR, rol);

        }



    }
}
