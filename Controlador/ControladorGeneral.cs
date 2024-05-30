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
            bool primeraIteracion = true;
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
        public DataTable buscar<T>(T entidad, E_ROL rol) where T : IEntidad
        {
            lista.Clear();
            primeraIteracion = true;
            lista = obtenerCedula<T>(entidad);
            return operacionesDB.buscar(rol, lista);
        }
        public DataTable getCedula<T>(T entidad, E_ROL rol) where T : IEntidad
        {
            lista.Clear();
            primeraIteracion = false;
            lista = crearListaPropiedades<T>(primeraIteracion, entidad);
            return operacionesDB.getCedula(rol, lista);
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
        public DataTable getNombresCompletos(E_ROL rol)
        {
            lista.Clear();
            operacionesDB = new ExecuteSP();
            return operacionesDB.getTabla(rol);
        }
        public DataTable getTabla(E_ROL rol)
        {
            lista.Clear();
            operacionesDB = new ExecuteSP();
            return operacionesDB.nombresCompletos(rol);
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
        private List<CD_Parameter_SP> obtenerParametros<T1, T2>(T1 entidad1, T2 entidad2, string nombrePropiedad1, string nombrePropiedad2)
        {
            lista.Clear();
            var propiedades = typeof(T1).GetProperties().Concat(typeof(T2).GetProperties());

            foreach (var propiedad in propiedades)
            {
                if (propiedad.Name == nombrePropiedad1 || propiedad.Name == nombrePropiedad2)
                {
                    var nombreParametro = $"@{propiedad.Name}";
                    var valor = propiedad.DeclaringType == typeof(T1) ? propiedad.GetValue(entidad1) : propiedad.GetValue(entidad2);
                    var tipo = mapearTipo(propiedad.PropertyType);
                    lista.Add(new CD_Parameter_SP(nombreParametro, valor, tipo));
                }
            }
            return lista;
        }
        public DataTable obtenerTurno<T1, T2>(T1 entidad1, T2 entidad2, E_ROL rol, string propiedad1, string propiedad2)
            where T1 : IEntidad
            where T2 : IEntidad
        {
            lista.Clear();
            primeraIteracion = false;
            lista = obtenerParametros(entidad1, entidad2, propiedad1, propiedad2);
            return operacionesDB.buscar(rol, lista);
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
        public List<CD_Parameter_SP> obtenerCedula<T>(T entidad)
        {
            //List<string> listaParametros=new List<string>();
            lista.Clear();
            var propiedades = typeof(T).GetProperties();

            var propiedadCedula = propiedades.FirstOrDefault(p => p.Name == "Cedula");
            if (propiedadCedula != null)
            {
                var nombreParametro = $"@{propiedadCedula.Name}";
                var valor = propiedadCedula.GetValue(entidad);
                var tipo = mapearTipo(propiedadCedula.PropertyType);
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
            if (tipo == typeof(DateTime))
                return SqlDbType.Date;
            if (tipo == typeof(Enum))
                return SqlDbType.Text;
            throw new ArgumentException("Tipo no soportado");
        }
        /*public List<string> cargarDias()
        {
            List<string> lista = new List<string>();
            foreach (var item in Enum.GetValues(typeof(Dias)))
            {
                lista.Add(item.ToString());
            }
            return lista;
        }
        public List<string> cargarJornadas()
        {
            List<string> lista = new List<string>();
            foreach (var item in Enum.GetValues(typeof(Jornada)))
            {
                lista.Add(item.ToString());
            }
            return lista;
        }*/
        private static readonly Dictionary<E_ROL, Type> RolEnum = new Dictionary<E_ROL, Type>
        {
            {E_ROL.ESPECIALIDAD, typeof(Especialidad)},
            {E_ROL.JORNADA, typeof(Jornada)},
            {E_ROL.DIA,typeof(Dias)},
            {E_ROL.ESTADO,typeof(Estado)}
        };
        public List<string> cargarCombo(E_ROL rol)
        {
            List<string> lista = new List<string>();
            lista.Add("SELECCIONE " + rol);
            if (RolEnum.TryGetValue(rol, out var enumType))
            {
                foreach (var item in Enum.GetValues(enumType))
                {
                    lista.Add(item.ToString());
                }
            }
            return lista;
        }
    }
}
