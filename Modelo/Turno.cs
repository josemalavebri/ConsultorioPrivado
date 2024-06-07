using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Modelo
{
    public class Turno : IEntidad
    {
        private int id_turno;
        private int numero_turno;
        private string dia;
        private string jornada;
        private string estado;
        private int id_medico;
        private DateTime fecha;

        public Turno()
        {
            id_medico = 0;
            id_turno = 0;
            numero_turno = 0;
            dia = string.Empty;
            jornada = string.Empty;
            estado = "Disponible";
            fecha = new DateTime();
        }
        public Turno(int id_turno, int numero_turno,
                     string dia,
                    string jornada, string estado,
                     int id_medico, DateTime fecha)
        {
            this.id_turno = id_turno;
            this.numero_turno = numero_turno;
            this.dia = dia;
            this.jornada = jornada;
            this.estado = estado;
            this.id_medico = id_medico;
            this.fecha = fecha;
        }
        public int ID_Turno { get { return id_turno; } set { id_turno = value; } }
        public int Numero_Turno { get { return numero_turno; } set { numero_turno = value; } }
        public string Dia { get { return dia; } set { dia = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public string Jornada { get { return jornada; } set { jornada = value; } }
        public string Estado { get { return estado; } set { estado = value; } }
        public int ID_Medico { get { return id_medico; } set { id_medico = value; } }


    }
}
