using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Modelo
{
    internal class CitaMedica
    {
        private int idCitaMedica;
        private Paciente paciente;
        private Medico medico;
        private TipoConsulta tipoConsulta;
        private DateTime fechaConsulta;

        public CitaMedica(int idCitaMedica, Paciente paciente, DateTime fechaConsulta, TipoConsulta tipoConsulta, Medico medico)
        {
            this.IdCitaMedica = idCitaMedica;
            this.Paciente = paciente;
            this.FechaConsulta = fechaConsulta;
            this.Medico = medico;
            this.TipoConsulta = tipoConsulta;
        }

        public int IdCitaMedica { get => idCitaMedica; set => idCitaMedica = value; }
        public DateTime FechaConsulta { get => fechaConsulta; set => fechaConsulta = value; }
        internal Paciente Paciente { get => paciente; set => paciente = value; }
        internal Medico Medico { get => medico; set => medico = value; }
        internal TipoConsulta TipoConsulta { get => tipoConsulta; set => tipoConsulta = value; }
    }
}
