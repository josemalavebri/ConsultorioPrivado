using ConsultorioPrivado.Controlador;
using ConsultorioPrivado.Modelo;
using ConsultorioPrivado.Utilidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioPrivado.Vista
{
    public partial class AgregarPaciente_form : Form
    {

        ControladorPaciente controladorPaciente;
        public AgregarPaciente_form()
        {
            InitializeComponent();
            controladorPaciente = new ControladorPaciente();
        }

        private void agregar_button_Click(object sender, EventArgs e)
        {
            controladorPaciente.crear(crearPacienteDatos());
            resetearControles();

        }

        private Paciente crearPacienteDatos()
        {
            Paciente paciente = new Paciente();
            paciente.Cedula = Convert.ToInt32(cedula_text.Text.ToString());
            paciente.Nombre = nombre_text.Text.ToString();
            paciente.Apellido = apellido_text.Text.ToString();
            paciente.Correo = correoText.Text.ToString();
            return paciente;
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            resetearControles();
        }

       private void resetearControles()
        {
            ControlForms.eliminarCuatroTextoBoxs(cedula_text, nombre_text, apellido_text, correoText);

        }


    }
}
