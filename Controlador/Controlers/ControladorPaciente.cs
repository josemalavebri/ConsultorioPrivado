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
    //controlador que se encarga de las operaciones tipo CRUD de la entidad paciente

    public class ControladorPaciente
    {
        private ControladorCreator controladorCreator;

        public ControladorPaciente()
        {
            controladorCreator = new ControladorCreator();
        }

        //OBTIENE PACIENTE
        public DataTable ObtenerPorPaciente()
        {
            return controladorCreator.ObtenerPorEntidad(E_ROL._PACIENTE);
        }

        //OBTIENE PACIENTE POR ID
        public DataTable ObtenerPorId<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.ObtenerPorId(entidad, E_ROL._PACIENTE);
        }

        //OBTIENE PACIENTE POR CEDULA
        public DataTable ObtenerPorCedula<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.ObtenerPorCedula(entidad, E_ROL._PACIENTE);
        }

        //ELIMINA PACIENTE
        public bool EliminarPaciente<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.EliminarEntidad(entidad, E_ROL._PACIENTE);
        }

        //CREA PACIENTE
        public bool CrearPaciente<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.CrearEntidad(entidad, E_ROL._PACIENTE);
        }

        //ACTUALIZA PACIENTE
        public bool ActualizarPaciente<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.ActualizarEntidad(entidad, E_ROL._PACIENTE);
        }

    }
}
