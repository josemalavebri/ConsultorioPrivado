using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Controlador.Creators
{
    public class ParametrosCreator
    {
        private string nombre_parametro;
        private object valor_parametro;
        private SqlDbType tipo_dato;

        public ParametrosCreator()
        {
            nombre_parametro = string.Empty;
            valor_parametro = string.Empty;
            tipo_dato = SqlDbType.NVarChar;
        }

        public ParametrosCreator(string nombre_parametro, object valor_parametro, SqlDbType tipo_dato)
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
