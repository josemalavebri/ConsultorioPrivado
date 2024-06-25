using ConsultorioPrivado.Controlador.Controlers;
using ConsultorioPrivado.Modelo;
using ConsultorioPrivado.Vista.Utilidad.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioPrivado.Vista.Paciente_forms
{
    public partial class AgregarPaciente_form : Form
    {
        ControladorPaciente controlador;

        public AgregarPaciente_form()
        {
            InitializeComponent();
            cedula_textBox.TextChanged += textBoxes_TextChanged;
            nombre_textBox.TextChanged += textBoxes_TextChanged;
            apellido_textBox.TextChanged += textBoxes_TextChanged;
            correo_textBox.TextChanged += textBoxes_TextChanged;
            controlador = new ControladorPaciente();
            ControlFormsButton.desabilitarHabilitarBotones(false, resetear_button);
        }

        private void resetearButtonEstado(bool estado)
        {
            ControlFormsButton.desabilitarHabilitarBotones(estado, resetear_button);

        }

        private void textBoxes_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null)
            {
                resetearButtonEstado(true);
            }
        }

        private Paciente crearPacienteEntidad()
        {
            Paciente paciente = new Paciente();
            paciente.Cedula = Convert.ToInt32(cedula_textBox.Text.ToString());
            paciente.Nombre = nombre_textBox.Text.ToString();
            paciente.Apellido = apellido_textBox.Text.ToString();
            paciente.Correo = correo_textBox.Text.ToString();
            paciente.Telefono = Convert.ToInt32(telefono_textBox.Text);
            return paciente;
        }

        private void vaciarTexts()
        {
            ControlFormsText.EliminarTextos(cedula_textBox, nombre_textBox, apellido_textBox, correo_textBox, telefono_textBox);
        }

        private void agregar_button_Click(object sender, EventArgs e)
        {
            Paciente paciente = crearPacienteEntidad();
            if (controlador.CrearPaciente<Paciente>(paciente))
            {
                MessageBox.Show("Paciente Insertado Correctamente");
                this.Close();
            };
            vaciarTexts();
        }

        private void cancelar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetear_button_Click(object sender, EventArgs e)
        {
            vaciarTexts();
            ControlFormsButton.desabilitarHabilitarBotones(false, resetear_button);
        }
    }
}
