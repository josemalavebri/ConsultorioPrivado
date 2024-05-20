using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Modelo
{
    public class Paciente
    {
        private int id;
        private int cedula;
        private string nombre;
        private string apellido;
        private string correo;

        public Paciente(int id, int cedula, string nombre, string apellido, string correo)
        {
            this.id = id;
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
        }

        public int Id { get => id; set => id = value; }
        public int Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Correo { get => correo; set => correo = value; }
    }
}
