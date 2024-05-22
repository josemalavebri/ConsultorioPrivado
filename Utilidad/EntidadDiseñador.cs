using ConsultorioPrivado.Datos.Interface;
using ConsultorioPrivado.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Utilidad
{
    public class EntidadDiseñador
    {

        public bool CrearEntidad<T>(T entidad, E_ROL rol) where T : IEntidad
        {
            List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
            var propiedades = typeof(T).GetProperties();
            foreach (var propiedad in propiedades)
            {
                var nombreParametro = $"@{propiedad.Name}";
                var valor = propiedad.GetValue(entidad);
                var tipo = MapearTipo(propiedad.PropertyType);
                lista.Add(new CD_Parameter_SP(nombreParametro, valor, tipo));
            }
            InterfaceDatos interfaceDatos = new ExecuteSP();
            return interfaceDatos.crear(rol, lista);
        }

        private SqlDbType MapearTipo(Type tipo)
        {
            if (tipo == typeof(int))
                return SqlDbType.Int;
            if (tipo == typeof(string))
                return SqlDbType.Text;
            throw new ArgumentException("Tipo no soportado");
        }
    }
}
