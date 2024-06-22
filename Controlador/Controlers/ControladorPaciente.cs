using ConsultorioPrivado.Controlador.Enums;
using ConsultorioPrivado.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Controlador.Controlers
{
    public class ControladorPaciente
    {
        private ControladorCreator controladorCreator;

        public ControladorPaciente()
        {
            controladorCreator = new ControladorCreator();

        }

        public DataTable ObtenerPorPaciente()
        {
            return controladorCreator.ObtenerEntidad(E_ROL._PACIENTE);
        }

        public bool CrearPaciente<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.CrearEntidad(entidad, E_ROL._PACIENTE);
        }

        public bool EliminarPaciente<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.EliminarEntidad(entidad,E_ROL._PACIENTE);
        }

        public bool ActualizarPaciente<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.ActualizarEntidad(entidad, E_ROL._PACIENTE);
        }
    }
}
