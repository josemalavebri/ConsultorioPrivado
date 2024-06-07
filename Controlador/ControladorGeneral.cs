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
    //controlador que se encarga de las operaciones tipo CRUD
    public class ControladorGeneral 
    {
        private bool primeraIteracion;
        private AccesoDB operacionesDB;
        private List<CD_Parameter_SP> lista;

        public ControladorGeneral()
        {
            operacionesDB = new ExecuteSP();
            lista = new List<CD_Parameter_SP>();
            primeraIteracion = false;
        }
        //CREA LAS ENTIDADES
        public bool Crear<T>(T entidad, E_ROL rol) where T : IEntidad
        {
            lista.Clear();
            bool primeraIteracion = true;
            lista = CrearListaPropiedades<T>(primeraIteracion, entidad);
            return operacionesDB.Crear(rol, lista);
        }

        //BUSCA LAS ENTIDADES SEGUN LA CEDULA
        public DataTable ObtenerPorCedula<T>(T entidad, E_ROL rol) where T : IEntidad
        {
            lista.Clear();
            primeraIteracion = false;
            lista = CrearListaPropiedadesCedula<T>(primeraIteracion, entidad);
            return operacionesDB.ObtenerPorCedula(rol, lista);
        }


        //ACTUALIZA LAS ENTIDADES
        public bool Actualizar<T>(T entidad, E_ROL rol) where T : IEntidad
        {
            lista.Clear();
            primeraIteracion = true;
            lista = CrearListaPropiedades<T>(primeraIteracion, entidad);
            return operacionesDB.Actualizar(rol, lista);
        }


        //ELIMINA LAS ENTIDADES
        public bool Eliminar<T>(T entidad, E_ROL rol) where T : IEntidad
        {
            lista.Clear();
            primeraIteracion = true;
            lista = CrearListaPropiedadesId<T>(primeraIteracion, entidad);
            return operacionesDB.Eliminar(rol, lista);
        }


        //OBTIENE UN REGISTRO DE ENTIDAD COMPLETO
        public DataTable ObtenerPorEntidad(E_ROL rol)
        {
            lista.Clear();
            operacionesDB = new ExecuteSP();
            return operacionesDB.ObtenerPorEntidad(rol);
        }

        public DataTable ObtenerPorId<T>(T entidad, E_ROL rol)
        {
            lista.Clear();
            lista = CrearListaPropiedadesId<T>(primeraIteracion, entidad);
            return operacionesDB.ObtenerPorId(rol, lista);
        }

        //CREA UNA LISTA CON LAS PROPIEDADES 
        private List<CD_Parameter_SP> CrearListaPropiedades<T>(bool primeraIteracion, T entidad)
        {
            lista.Clear();
            var propiedades = typeof(T).GetProperties();

            foreach (var propiedad in propiedades)
            {
                    var nombreParametro = $"@{propiedad.Name}";
                    var valor = propiedad.GetValue(entidad);
                    var tipo = MapearTipo(propiedad.PropertyType);
                    lista.Add(new CD_Parameter_SP(nombreParametro, valor, tipo));
            }

            return lista;
        }

        private List<CD_Parameter_SP> CrearListaPropiedadesId<T>(bool primeraIteracion, T entidad)
        {
            lista.Clear();
            var propiedades = typeof(T).GetProperties();
            foreach (var propiedad in propiedades)
            {
                if (propiedad.Name.ToLower() == "id")
                {
                    var nombreParametro = $"@{propiedad.Name}";
                    var valor = propiedad.GetValue(entidad);
                    var tipo = MapearTipo(propiedad.PropertyType);
                    lista.Add(new CD_Parameter_SP(nombreParametro, valor, tipo));
                    break;
                }
            }

            return lista;
        }

        private List<CD_Parameter_SP> CrearListaPropiedadesCedula<T>(bool primeraIteracion, T entidad)
        {
            lista.Clear();
            var propiedades = typeof(T).GetProperties();
            foreach (var propiedad in propiedades)
            {
                if (propiedad.Name.ToLower() == "cedula")
                {
                    var nombreParametro = $"@{propiedad.Name}";
                    var valor = propiedad.GetValue(entidad);
                    var tipo = MapearTipo(propiedad.PropertyType);
                    lista.Add(new CD_Parameter_SP(nombreParametro, valor, tipo));
                    break;
                }
            }

            return lista;
        }

        private bool EsValorValido(object valor)
        {
            if (valor == null)
            {   
                return false;
            }

            if (valor is string strValue && string.IsNullOrWhiteSpace(strValue))
            {
                return false;
            }

            if (valor is int intValue && intValue == 0)
            {
                return false;
            }
            return false;
        }

            //MAPEA LOS TIPOS DE LAS ENTIDADES
            private static SqlDbType MapearTipo(Type tipo)
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

        
    }
}
