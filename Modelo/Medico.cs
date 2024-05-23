using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Modelo
{
    public class Medico : IEntidad
    {
        private int id;
        private string nombre;
        private string apellido;
        private Especialidad especialidad;
        private string telefono;
        private string correo;

        public Medico(int id, string nombre, string apellido, Especialidad especialidad, string telefono, string correo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Especialidad = especialidad;
            this.Telefono = telefono;
            this.Correo = correo;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        internal Especialidad Especialidad { get => especialidad; set => especialidad = value; }
    }
}
