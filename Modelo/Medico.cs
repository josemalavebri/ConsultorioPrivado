using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultorioPrivado.Utilidad.Datos;

namespace ConsultorioPrivado.Modelo
{
    public class Medico : IEntidad
    {
        private int id_medico;
        private string cedula;
        private string nombre;
        private string apellido;
        private string especialidad;
        private string telefono;
        private string correo;
        private string direccion;
        public Medico()
        {
            id_medico = 0;
            cedula = string.Empty;
            nombre = string.Empty;
            apellido = string.Empty;
            especialidad = string.Empty;
            telefono = string.Empty;
            correo = string.Empty;
            direccion = string.Empty;

        }

        public Medico(int id_medico, string cedula,
                      string nombre, string apellido,
                      string especialidad, string telefono,
                      string correo, string direccion)
        {
            this.id_medico = id_medico;
            this.nombre = nombre;
            this.cedula = cedula;
            this.apellido = apellido;
            this.especialidad = especialidad;
            this.telefono = telefono;
            this.correo = correo;
            this.direccion = direccion;
        }

        public int ID_Medico { get => id_medico; set => id_medico = value; }
        public string Cedula { get => cedula; set => cedula = value; }

        public string Nombres { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
    }
}
