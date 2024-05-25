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
        private bool primeraIteracion;

        private DataAccess operacionesDB;

        public ControladorGeneral()
        {
            operacionesDB = new ExecuteSP();
        }

        public  bool modificar<T>( T entidad, E_ROL rol) where T : IEntidad
        {
            primeraIteracion = true;
            List<CD_Parameter_SP> lista = crearListaPropiedades(primeraIteracion, entidad);
            return operacionesDB.crear(rol, lista);
        }

        public  bool crear<T>(T entidad, E_ROL rol) where T : IEntidad
        {
            bool primeraIteracion = false;
            List<CD_Parameter_SP> lista = crearListaPropiedades(primeraIteracion,entidad);
            return operacionesDB.crear(rol, lista);
        }


        public  DataTable getId<T>(T entidad, E_ROL rol) where T : IEntidad
        {
            primeraIteracion = true;
            List<CD_Parameter_SP> lista = crearListaPropiedades<T>( primeraIteracion, entidad);
            return operacionesDB.getId(rol,lista);

        }

        public  bool Eliminar<T>(T entidad, E_ROL rol) where T : IEntidad
        {
            primeraIteracion = true;
            List<CD_Parameter_SP> lista = crearListaPropiedades<T>(primeraIteracion, entidad);
            return operacionesDB.elimina(rol, lista);

        }

        public  DataTable get(E_ROL rol)
        {
            operacionesDB = new ExecuteSP();
            return operacionesDB.get(rol);

        }

        private static List<CD_Parameter_SP> crearListaPropiedades<T>(bool primeraIteracion, T entidad)
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
                var tipo = mapearTipo(propiedad.PropertyType);
                lista.Add(new CD_Parameter_SP(nombreParametro, valor, tipo));
            }
            return lista;
        }

        private static SqlDbType mapearTipo(Type tipo)
        {
            if (tipo == typeof(string))
                return SqlDbType.Text;
            if (tipo == typeof(int))
                return SqlDbType.Int;

            throw new ArgumentException("Tipo no soportado");
        }
      
    }
}
