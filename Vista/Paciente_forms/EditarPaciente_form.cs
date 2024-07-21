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
    public partial class EditarPaciente_form : Form
    {
        private int id;
        ControladorPaciente controlador;

        public EditarPaciente_form(int id)
        {
            InitializeComponent();
            cedula_textBox.TextChanged += textBoxes_TextChanged;
            nombre_textBox.TextChanged += textBoxes_TextChanged;
            apellido_textBox.TextChanged += textBoxes_TextChanged;
            correo_textBox.TextChanged += textBoxes_TextChanged;
            controlador = new ControladorPaciente();
            ControlFormsButton.desabilitarHabilitarBotones(false, resetear_button);
            this.id = id;
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

        private void agregarDatosFormulario()
        {

            Medico medico = new Medico();
            medico.Id = id;
            DataTable datosMedicos = controlador.ObtenerPorId<Medico>(medico);
            if (datosMedicos.Rows.Count > 0)
            {
                DataRow row = datosMedicos.Rows[0];
                id_textBox.Text = row["id"].ToString();
                nombre_textBox.Text = row["nombre"].ToString();
                apellido_textBox.Text = row["apellido"].ToString();
                cedula_textBox.Text = row["cedula"].ToString();
                telefono_textBox.Text = row["telefono"].ToString();
                correo_textBox.Text = row["correo"].ToString();
            }
        }

        private void EditarPaciente_form_Load(object sender, EventArgs e)
        {
            agregarDatosFormulario();
        }

        private void cancelar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Paciente crearPacienteDatos()
        {
            Paciente paciente = new Paciente();
            paciente.Id = Convert.ToInt32(id_textBox.Text.ToString());
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
            Paciente paciente = crearPacienteDatos();
            if (controlador.ActualizarPaciente<Paciente>(paciente))
            {
                vaciarTexts();
                MessageBox.Show("Paciente Actualizado");
                this.Close();
            }
        }

        private void resetear_button_Click(object sender, EventArgs e)
        {
            vaciarTexts();
            ControlFormsButton.desabilitarHabilitarBotones(false, resetear_button);
        }
    }
}
