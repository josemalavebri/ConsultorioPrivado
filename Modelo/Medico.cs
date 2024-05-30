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
        private int cedula;

        private string nombre;
        private string apellido;
        private Especialidad especialidad;
        private int telefono;
        private string correo;

        public Medico()
        {

        }

        public Medico(int id,int cedula, string nombre, string apellido, Especialidad especialidad, int telefono, string correo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Cedula = cedula;
            this.Apellido = apellido;
            this.Especialidad = especialidad;
            this.Telefono = telefono;
            this.Correo = correo;
        }

        public int Id { get => id; set => id = value; }
        public int Cedula { get => cedula; set => cedula = value; }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        internal Especialidad Especialidad { get => especialidad; set => especialidad = value; }
    }
}
