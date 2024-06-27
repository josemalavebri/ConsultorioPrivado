using ConsultorioPrivado.Controlador.Controlers;
using ConsultorioPrivado.Utilidad.Forms;
using ConsultorioPrivado.Modelo;
using ConsultorioPrivado.Modelo;
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
    public partial class edit_Paciente_form : Form
    {
        private int id;
        ControladorPaciente controlador;
        public edit_Paciente_form(int id)
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

        private void agregarDatosFormularios()
        {
            //Arreglar bien esto
            Pacientes pacientes = new Pacientes();
            pacientes.Id = id;
            DataTable datosPaciente = controlador.ObtenerPorId(id);
            if (datosPaciente.Rows.Count > 0)
            {
                DataRow row = datosPaciente.Rows[0];
                id_textBox.Text = row["id"].ToString();
                nombre_textBox.Text = row["nombre"].ToString();
                apellido_textBox.Text = row["apellido"].ToString();
                cedula_textBox.Text = row["cedula"].ToString();
                telefono_textBox.Text = row["telefono"].ToString();
                correo_textBox.Text = row["correo"].ToString();
            }

        }


        private void textBoxes_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null)
            {
                resetearButtonEstado(true);
            }
        }
        private void resetearButtonEstado(bool estado)
        {
            ControlFormsButton.desabilitarHabilitarBotones(estado, resetear_button);

        }
        private void cancelar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void vaciarTexts()
        {
            ControlFormsText.EliminarTextos(cedula_textBox, nombre_textBox, apellido_textBox, correo_textBox, telefono_textBox);
        }

        private void agregar_button_Click(object sender, EventArgs e)
        {
            Pacientes pacientes = crearPacienteDatos();
            if (controlador.ActualizarPaciente(pacientes))
            {
                vaciarTexts();
                MessageBox.Show("Medico Actualizado");
                this.Close();
            }
        }

        private Pacientes crearPacienteDatos()
        {
            Pacientes pacientes = new Pacientes();
            pacientes.Id = Convert.ToInt32(id_textBox.Text.ToString());
            pacientes.Cedula = Convert.ToInt32(cedula_textBox.Text.ToString());
            pacientes.Nombre = nombre_textBox.Text.ToString();
            pacientes.Apellido = apellido_textBox.Text.ToString();
            pacientes.Correo = correo_textBox.Text.ToString();
            pacientes.Telefono = Convert.ToInt32(telefono_textBox.Text);
            return pacientes;
        }

        private void edit_Paciente_form_Load(object sender, EventArgs e)
        {
            agregarDatosFormularios();
        }
    }
}
