using ConsultorioPrivado.Datos.Interface;
using ConsultorioPrivado.Modelo;
using ConsultorioPrivado.Utilidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Controlador
{
    public class ControladorPaciente
    {
        private InterfaceDatos interfaceDatos;

        private string rol;
        public ControladorPaciente()
        {

            interfaceDatos = new ExecuteSP();
            rol = ROL._PACIENTE.ToString();
        }

        public DataTable get()
        {
            return interfaceDatos.get(ROL._PACIENTE);
        }

        public bool crear(Paciente paciente)
        {
            List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
            lista.Add(new CD_Parameter_SP("@parametro1", paciente.Cedula, SqlDbType.Int));
            lista.Add(new CD_Parameter_SP("@parametro2", paciente.Nombre, SqlDbType.Text));
            lista.Add(new CD_Parameter_SP("@parametro3", paciente.Apellido, SqlDbType.Text));
            lista.Add(new CD_Parameter_SP("@parametro4", paciente.Correo, SqlDbType.Text));
            InterfaceDatos interfaceDatos = new ExecuteSP();
            return interfaceDatos.crear(ROL._PACIENTE, lista);
        }
    }
}
