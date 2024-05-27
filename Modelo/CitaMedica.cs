using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Modelo
{
    internal class CitaMedica : IEntidad
    {
        private int idCitaMedica;
        private Paciente paciente;
        private Medico medico;
        private DateTime horaConsulta;

        public CitaMedica(int idCitaMedica, Paciente paciente, DateTime horaConsulta, Medico medico)
        {
            this.IdCitaMedica = idCitaMedica;
            this.Paciente = paciente;
            this.HoraConsulta = horaConsulta;
            this.Medico = medico;
        }

        public int IdCitaMedica { get => idCitaMedica; set => idCitaMedica = value; }
        public DateTime HoraConsulta { get => horaConsulta; set => horaConsulta = value; }
        internal Paciente Paciente { get => paciente; set => paciente = value; }
        internal Medico Medico { get => medico; set => medico = value; }
    }
}
