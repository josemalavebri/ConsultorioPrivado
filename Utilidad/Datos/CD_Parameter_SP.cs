using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Utilidad.Datos
{
    public class CD_Parameter_SP
    {

        private string nombre_parametro;
        private object valor_parametro;
        private SqlDbType tipo_dato;

        public CD_Parameter_SP()
        {
            nombre_parametro = string.Empty;
            valor_parametro = string.Empty;
            tipo_dato = SqlDbType.NVarChar;
        }

        public CD_Parameter_SP(string nombre_parametro, object valor_parametro, SqlDbType tipo_dato)
        {
            this.nombre_parametro = nombre_parametro;
            this.valor_parametro = valor_parametro;
            this.tipo_dato = tipo_dato;
        }

        public string NombreParametro
        {
            get { return nombre_parametro; }
            set { nombre_parametro = value; }
        }

        public object ValorParametro
        {
            get { return valor_parametro; }
            set { valor_parametro = value; }
        }

        public SqlDbType TipoDato
        {
            get { return tipo_dato; }
            set { tipo_dato = value; }
        }
    }
}
