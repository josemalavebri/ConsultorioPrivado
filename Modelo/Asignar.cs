using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Modelo
{
    public class Asignar : IEntidad
    {
        private int id_paciente;
        private int id_turno;
        private int id_asignar;
        private string estado;

        public Asignar() { }
        public Asignar(int id_paciente, int id_turno, int id_asignar, string estado)
        {
            this.id_paciente = id_paciente;
            this.id_turno = id_turno;
            this.id_asignar = id_asignar;
            this.estado = estado;
        }
        public int ID_Asignar { get { return id_paciente; } set { id_paciente = value; } }
        public int ID_Turno { get { return id_turno; } set { id_turno = value; } }
        public int ID_Paciente { get { return id_asignar; } set { id_asignar = value; } }
        public string Estado { get { return estado; } set { estado = value; } }
    }
}
