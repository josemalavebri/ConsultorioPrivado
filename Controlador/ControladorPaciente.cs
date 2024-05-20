using ConsultorioPrivado.Datos.Interface;
using ConsultorioPrivado.Modelo;
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
        InterfaceDatos interfaceDatos;

        ControladorPaciente() {

            interfaceDatos = new ExecuteSP();
        }

        public DataTable get()
        {
            Parametrizacion parametrizacion = new Parametrizacion();

            List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();

            return interfaceDatos.get(CODIGO_SP.SP_GET,ROL._PACIENTE);
        }


        public bool crear(Paciente paciente)
        {
            Parametrizacion parametrizacion = new Parametrizacion();
            parametrizacion.añadirParametrosTexto(paciente.Nombre);

            List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
            lista.Add(new CD_Parameter_SP("@correo", paciente.Cedula, SqlDbType.Int));
            lista.Add(new CD_Parameter_SP("@nombre", paciente.Nombre, SqlDbType.Text));
            lista.Add(new CD_Parameter_SP("@apellido", paciente.Apellido, SqlDbType.Text));
            lista.Add(new CD_Parameter_SP("@correo", paciente.Correo, SqlDbType.Text));
            InterfaceDatos interfaceDatos = new ExecuteSP();

            return interfaceDatos.crear(CODIGO_SP.SP_CREA, ROL._PACIENTE, lista);
        }

        public bool modificar()
        {

        }

        public bool eliminar();

    }
}
