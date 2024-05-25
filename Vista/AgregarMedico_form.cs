using ConsultorioPrivado.Controlador;
using ConsultorioPrivado.Datos.Interface;
using ConsultorioPrivado.Modelo;
using ConsultorioPrivado.Utilidad.Forms;
using Microsoft.Identity.Client.NativeInterop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace ConsultorioPrivado.Vista
{
    public partial class AgregarMedico_form : Form
    {

        ControladorGeneral controlador;
        public AgregarMedico_form()
        {
            InitializeComponent();
            cedula_text.TextChanged += textBoxes_TextChanged;
            nombre_text.TextChanged += textBoxes_TextChanged;
            apellido_text.TextChanged += textBoxes_TextChanged;
            correoText.TextChanged += textBoxes_TextChanged;
            controlador = new ControladorGeneral();
            ControlFormsButton.desabilitarHabilitarBotones(false, resetear_button);

        }

        private void agregar_button_Click(object sender, EventArgs e)
        {
            Paciente paciente = crearPacienteDatos();
            controlador.crear( paciente, E_ROL._PACIENTE);
            vaciarTexts();
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
            vaciarTexts();
            ControlFormsButton.desabilitarHabilitarBotones(false, resetear_button);
        }

        private void textBoxes_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null)
            {
                resetearButtonEstado(true);
            }
        }

        private void vaciarTexts()
        {
            ControlFormsText.EliminarTextos(cedula_text, nombre_text, apellido_text, correoText);
        }


        private void resetearButtonEstado(bool estado)
        {
            ControlFormsButton.desabilitarHabilitarBotones(estado, resetear_button);

        }
    }
}
