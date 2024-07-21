using ConsultorioPrivado.Controlador.Creators;
using ConsultorioPrivado.Controlador.Enums;
using ConsultorioPrivado.Datos.Interface;
using ConsultorioPrivado.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Controlador.Controlers
{
    internal class ControladorCreator
    {
        private List<ParametrosCreator> lista;
        private CadenaSPCreator executeRolDB;
        private PropiedadesCreator propiedadesCreator;
        private I_AccesoDB accesoDatos;

        public ControladorCreator()
        {
            lista = new List<ParametrosCreator>();
            executeRolDB = new CadenaSPCreator();
            propiedadesCreator = new PropiedadesCreator();
            accesoDatos = new ExecuteSP();
        }

        //OBTIENE UNA TABLA DE LA ENTIDAD UTILIZANDO EL PROCEDIMIENTO ALMACENADO Y ROL ESPECIFICADOS
        public DataTable ObtenerPorEntidad( E_ROL rol)
        {
            string procedimientoAlmacenado = executeRolDB.crearProcedimientoAlmacenado(E_CODIGO_SP.SP_OBTENER_POR,rol);
            return accesoDatos.ObtenerPorEntidad(procedimientoAlmacenado);
        }

        ////OBTIENE UNA TABLA DE LA ENTIDAD POR ID UTILIZANDO EL PROCEDIMIENTO ALMACENADO Y ROL ESPECIFICADOS
        public DataTable ObtenerPorId<T>(T entidad, E_ROL rol) where T : IEntidad
        {
            lista = propiedadesCreator.CrearListaPropiedadesId(entidad);
            string procedimientoAlmacenado = executeRolDB.crearProcedimientoAlmacenado(E_CODIGO_SP.SP_OBTENER_POR_ID, rol);
            return accesoDatos.ObtenerPorId(procedimientoAlmacenado, lista);
        }

        //OBTIENE UNA TABLA DE LA ENTIDAD POR CEDULA UTILIZANDO EL PROCEDIMIENTO ALMACENADO Y ROL ESPECIFICADOS
        public DataTable ObtenerPorCedula<T>(T entidad, E_ROL rol) where T : IEntidad
        {
            lista = propiedadesCreator.CrearListaPropiedadesCedula(entidad);
            string procedimientoAlmacenado = executeRolDB.crearProcedimientoAlmacenado(E_CODIGO_SP.SP_OBTENER_POR_CEDULA, rol);
            return accesoDatos.ObtenerPorCedula(procedimientoAlmacenado, lista);
        }

        //ELIMINA LA ENTIDAD UTILIZANDO EL PROCEDIMIENTO ALMACENADO Y ROL ESPECIFICADOS 
        public bool EliminarEntidad<T>(T entidad, E_ROL rol) where T : IEntidad
        {
            lista = propiedadesCreator.CrearListaPropiedadesId(entidad);
            string procedimientoAlmacenado = executeRolDB.crearProcedimientoAlmacenado(E_CODIGO_SP.SP_ELIMINAR, rol);
            return accesoDatos.EliminarEntidad(procedimientoAlmacenado, lista);
        }

        //CREA LA ENTIDAD UTILIZANDO EL PROCEDIMIENTO ALMACENADO Y ROL ESPECIFICADOS 
        public bool CrearEntidad<T>(T entidad, E_ROL rol) where T : IEntidad
        {
            lista = propiedadesCreator.CrearListaPropiedades(entidad);
            string procedimientoAlmacenado = executeRolDB.crearProcedimientoAlmacenado(E_CODIGO_SP.SP_CREAR, rol);
            return accesoDatos.CrearEntidad(procedimientoAlmacenado, lista);
        }

        //ACTUALIZA LA ENTIDAD UTILIZANDO EL PROCEDIMIENTO ALMACENADO Y ROL ESPECIFICADOS 
        public bool ActualizarEntidad<T>(T entidad, E_ROL rol) where T : IEntidad
        {
            lista = propiedadesCreator.CrearListaPropiedades(entidad);
            string procedimientoAlmacenado = executeRolDB.crearProcedimientoAlmacenado(E_CODIGO_SP.SP_ACTUALIZAR, rol);
            return accesoDatos.ActualizarEntidad(procedimientoAlmacenado, lista);
        }

    }
}
