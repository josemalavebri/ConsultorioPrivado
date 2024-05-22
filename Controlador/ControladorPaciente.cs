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
    public class ControladorPaciente : I_Controlador<Paciente>
    {
        private InterfaceDatos interfaceDatos;


        private string rol;
        public ControladorPaciente()
        {

            interfaceDatos = new ExecuteSP();
            rol = E_ROL._PACIENTE.ToString();
        }

        public DataTable getId(Paciente paciente)
        {
            throw new NotImplementedException();
        }

        public DataTable get()
        {
            return interfaceDatos.get(E_ROL._PACIENTE);
        }

        public bool crear(Paciente paciente)
        {
            List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
            lista.Add(new CD_Parameter_SP("@parametro1", paciente.Cedula, SqlDbType.Int));
            lista.Add(new CD_Parameter_SP("@parametro2", paciente.Nombre, SqlDbType.Text));
            lista.Add(new CD_Parameter_SP("@parametro3", paciente.Apellido, SqlDbType.Text));
            lista.Add(new CD_Parameter_SP("@parametro4", paciente.Correo, SqlDbType.Text));
            InterfaceDatos interfaceDatos = new ExecuteSP();
            return interfaceDatos.crear(E_ROL._PACIENTE, lista);
        }

        public bool modificar(Paciente objeto)
        {
            throw new NotImplementedException();
        }

        public bool eliminar(Paciente objeto)
        {
            throw new NotImplementedException();
        }

       
    }
}
