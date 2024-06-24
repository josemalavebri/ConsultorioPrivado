using ConsultorioPrivado.Controlador.Creators;
using ConsultorioPrivado.Controlador.Enums;
using ConsultorioPrivado.Datos.Interface;
using ConsultorioPrivado.Modelo;
using ConsultorioPrivado.Vista.Utilidad.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Controlador.Controlers
{
    //controlador que se encarga de las operaciones tipo CRUD de la entidad medico


    public class ControladorMedico
    {
        private ControladorCreator controladorCreator;


        // MEDICO 

        public ControladorMedico()
        {
            controladorCreator = new ControladorCreator();
        }
        
        public DataTable ObtenerPorMedico()
        {
            return controladorCreator.ObtenerPorEntidad(E_ROL._MEDICO);
        }

        public DataTable ObtenerPorId()
        {
            return controladorCreator.ObtenerPorId(E_ROL._MEDICO);
        }

        public DataTable ObtenerPorCedula()
        {
            return controladorCreator.ObtenerPorCedula(E_ROL._MEDICO);
        }

        //ELIMINA LAS ENTIDADES
        public bool EliminarMedico<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.EliminarEntidad(entidad, E_ROL._MEDICO);
        }

        //CREA LAS ENTIDADES
        public bool CrearMedico<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.CrearEntidad(entidad, E_ROL._MEDICO);
        }
       
        //ACTUALIZA LAS ENTIDADES
        public bool ActualizarMedico<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.ActualizarEntidad(entidad, E_ROL._MEDICO);
        }
       
    }
}
