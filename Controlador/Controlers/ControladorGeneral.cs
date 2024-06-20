using ConsultorioPrivado.Controlador.Enums;
using ConsultorioPrivado.Datos.Interface;
using ConsultorioPrivado.Modelo;
using ConsultorioPrivado.Utilidad.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Controlador.Controlers
{
    //controlador que se encarga de las operaciones tipo CRUD
    public class ControladorGeneral
    {
        private ControladorCreator controladorCreator;


        public ControladorGeneral()
        {
            controladorCreator = new ControladorCreator();
        }

        public DataTable ObtenerPorMedico()
        {
            return controladorCreator.ObtenerEntidad(E_ROL._MEDICO);
        }

        //CREA LAS ENTIDADES
        public bool CrearMedico<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.CrearEntidad(entidad, E_ROL._MEDICO);
        }


        /*

       //BUSCA LAS ENTIDADES SEGUN LA CEDULA
       public DataTable ObtenerPorCedula<T>(T entidad, E_ROL rol) where T : IEntidad
       {
           lista.Clear();
           lista = propiedadesCreator.CrearListaPropiedadesCedula<T>(entidad);
           return operacionesDB.ObtenerPorCedula(rol, lista);
       }


       //ACTUALIZA LAS ENTIDADES
       public bool Actualizar<T>(T entidad, E_ROL rol) where T : IEntidad
       {
           lista.Clear();
           lista = propiedadesCreator.CrearListaPropiedades<T>(entidad);
           return operacionesDB.Actualizar(rol, lista);
       }


       //ELIMINA LAS ENTIDADES
       public bool Eliminar<T>(T entidad, E_ROL rol) where T : IEntidad
       {
           lista.Clear();
           lista = propiedadesCreator.CrearListaPropiedadesId<T>(entidad);
           return operacionesDB.Eliminar(rol, lista);
       }


       //OBTIENE UN REGISTRO DE ENTIDAD COMPLETO
       public DataTable ObtenerPorEntidad(E_ROL rol)
       {
           lista.Clear();
           operacionesDB = new ExecuteSP();
           return operacionesDB.ObtenerPorEntidad(rol);
       }

       public DataTable ObtenerPorId<T>(T entidad, E_ROL rol) where T : IEntidad
       {
           lista.Clear();
           lista = propiedadesCreator.CrearListaPropiedadesId<T>(entidad);
           return operacionesDB.ObtenerPorEntidad(rol, lista);
       }

       //CREA UNA LISTA CON LAS PROPIEDADES 
       */



    }
}
