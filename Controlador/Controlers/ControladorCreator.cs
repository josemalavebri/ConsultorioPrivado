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

        public DataTable ObtenerEntidad(E_ROL rol)
        {
            string procedimientoAlmacenado = executeRolDB.crearProcedimientoAlmacenado(rol);
            return accesoDatos.ObtenerPorEntidad(procedimientoAlmacenado);
        }

        public bool CrearEntidad<T>(T entidad, E_ROL rol) where T : IEntidad
        {
            lista = propiedadesCreator.CrearListaPropiedades(entidad);
            string procedimientoAlmacenado = executeRolDB.crearProcedimientoAlmacenado(rol);
            return accesoDatos.CrearEntidad(procedimientoAlmacenado, lista);
        }

    }
}
