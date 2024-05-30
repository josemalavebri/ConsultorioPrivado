using ConsultorioPrivado.Datos.Interface;
using ConsultorioPrivado.Modelo;
using ConsultorioPrivado.Utilidad.Datos;
using System;
using System.Collections;
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
        private List<CD_Parameter_SP> lista;

        public ControladorGeneral()
        {
            operacionesDB = new ExecuteSP();
            lista = new List<CD_Parameter_SP>();
        }

        public bool crear<T>(T entidad, E_ROL rol) where T : IEntidad
        {
            lista.Clear();
            bool primeraIteracion = false;
            lista = crearListaPropiedades(primeraIteracion, entidad);
            return operacionesDB.crear(rol, lista);
        }

        public DataTable getId<T>(T entidad, E_ROL rol) where T : IEntidad
        {
            lista.Clear();
            primeraIteracion = true;
            lista = crearListaPropiedades<T>(primeraIteracion, entidad);
            return operacionesDB.getId(rol, lista);
        }

        public DataTable getCedula<T>(T entidad, E_ROL rol) where T : IEntidad
        {
            lista.Clear();
            primeraIteracion = false;
            lista = crearListaPropiedades<T>(primeraIteracion, entidad);
            return operacionesDB.getCedula( rol, lista);
        }

        public bool actualizar<T>(T entidad, E_ROL rol) where T : IEntidad
        {
            lista.Clear();
            primeraIteracion = true;
            lista = crearListaPropiedades<T>(primeraIteracion, entidad);
            return operacionesDB.actualizar(rol, lista);
        }

        public bool eliminar<T>(T entidad, E_ROL rol) where T : IEntidad
        {
            lista.Clear();
            primeraIteracion = true;
            lista = crearListaPropiedades<T>(primeraIteracion, entidad);
            return operacionesDB.eliminar(rol, lista);
        }

        public DataTable get(E_ROL rol)
        {
            lista.Clear();
            operacionesDB = new ExecuteSP();
            return operacionesDB.get(rol);
        }

        private List<CD_Parameter_SP> crearListaPropiedades<T>(bool primeraIteracion, T entidad)
        {
            lista.Clear();
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

        private List<CD_Parameter_SP> crearListaCedula<T>(bool primeraIteracion, T entidad)
        {
            lista.Clear();
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
