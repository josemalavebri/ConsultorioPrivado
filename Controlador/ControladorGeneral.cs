using ConsultorioPrivado.Datos.Interface;
using ConsultorioPrivado.Modelo;
using ConsultorioPrivado.Utilidad.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Controlador
{
    public class ControladorGeneral
    {

        public static bool CrearEntidad<T>(bool primeraIteracion, T entidad, E_ROL rol) where T : IEntidad
        {

            List<CD_Parameter_SP> lista = crearListaPropiedades(primeraIteracion,entidad);
            InterfaceDatos interfaceDatos = new ExecuteSP();
            return interfaceDatos.crear(rol, lista);
        }


        private static List<CD_Parameter_SP> crearListaPropiedades<T>(bool primeraIteracion,T entidad)
        {
            List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
            var propiedades = typeof(T).GetProperties();
            foreach (var propiedad in propiedades)
            {
                if (primeraIteracion)
                {
                    primeraIteracion = false;
                    continue;
                }
                var nombreParametro = $"@{propiedad.Name}";
                var valor = propiedad.GetValue(entidad);
                var tipo = MapearTipo(propiedad.PropertyType);
                lista.Add(new CD_Parameter_SP(nombreParametro, valor, tipo));
            }
            return lista;
        }
        private static SqlDbType MapearTipo(Type tipo)
        {
            if (tipo == typeof(string))
                return SqlDbType.Text;
            if (tipo == typeof(int))
                return SqlDbType.Int;

            throw new ArgumentException("Tipo no soportado");
        }
    }
}
