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

        public bool CrearPaciente<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.CrearEntidad(entidad, Enums.E_ROL._PACIENTE);
        }

        public bool EliminarPaciente<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.EliminarEntidad(entidad, Enums.E_ROL._PACIENTE);
        }

        //No estoy seguro de este pero pongamoslo por si acaso por el momento
        public bool ActualizarPaciente<T>(T entidad) where T : IEntidad
        {
            return controladorCreator.ActualizarEntidad(entidad, Enums.E_ROL._PACIENTE);
        }
        public DataTable ObtenerPaciente()
        {
            return controladorCreator.ObtenerEntidad(Enums.E_ROL._PACIENTE);
        }

    }
}
