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
    //CONTROLADOR QUE SE ENCARGA DE LAS OPERACIONES TIPO CRUD DE LA ENTIDAD MEDICO

    public class ControladorMedico
    {
        private ControladorCreator controladorCreator;

        public ControladorMedico()
        {
            controladorCreator = new ControladorCreator();
        }
        
        //OBTIENE MEDICO
        public DataTable ObtenerPorMedico()
        {
            return controladorCreator.ObtenerPorEntidad(E_ROL._MEDICO);
        }

        //OBTIENE MEDICO POR ID
        public DataTable ObtenerPorId<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.ObtenerPorId(entidad, E_ROL._MEDICO);
        }

        //OBTIENE MEDICO POR CEDULA
        public DataTable ObtenerPorCedula<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.ObtenerPorCedula(entidad, E_ROL._MEDICO);
        }

        //ELIMINA MEDICO
        public bool EliminarMedico<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.EliminarEntidad(entidad, E_ROL._MEDICO);
        }

        //CREA MEDICO
        public bool CrearMedico<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.CrearEntidad(entidad, E_ROL._MEDICO);
        }
       
        //ACTUALIZA MEDICO
        public bool ActualizarMedico<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.ActualizarEntidad(entidad, E_ROL._MEDICO);
        }
       
    }
}
