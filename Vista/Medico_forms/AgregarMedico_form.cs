using ConsultorioPrivado.Controlador.Controlers;
using ConsultorioPrivado.Controlador.Enums;
using ConsultorioPrivado.Datos.Interface;
using ConsultorioPrivado.Modelo;
using ConsultorioPrivado.Vista.Utilidad.Forms;
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
        ControladorMedico controlador;//ya la
        public AgregarMedico_form()//ya la
        {
            InitializeComponent();
            cedula_text.TextChanged += textBoxes_TextChanged;
            nombre_text.TextChanged += textBoxes_TextChanged;
            apellido_text.TextChanged += textBoxes_TextChanged;
            correoText.TextChanged += textBoxes_TextChanged;
            controlador = new ControladorMedico();
            ControlFormsButton.desabilitarHabilitarBotones(false, resetear_button);
        }

        private void agregar_button_Click(object sender, EventArgs e)//ya la
        {
            
            Medico medico = crearMedicoEntidad();
            if(controlador.CrearMedico<Medico>(medico))
            {
                MessageBox.Show("Medico Insertado Correctamente");
                this.Close();
            };
            vaciarTexts();
            
        }

        private Medico crearMedicoEntidad()//ya la
        {
            Medico medico = new Medico();
            medico.Cedula = Convert.ToInt32(cedula_text.Text.ToString());
            medico.Nombre = nombre_text.Text.ToString();
            medico.Apellido = apellido_text.Text.ToString();
            medico.Correo = correoText.Text.ToString();
            medico.Telefono = Convert.ToInt32(telefono_text.Text);
            medico.Especialidad_id = especialidad_combo.SelectedIndex+1;
            return medico;
        }

        private void button1_Click(object sender, EventArgs e)//ya la
        {
            vaciarTexts();
            ControlFormsButton.desabilitarHabilitarBotones(false, resetear_button);
        }

        private void textBoxes_TextChanged(object sender, EventArgs e)//ya la
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null)
            {
                resetearButtonEstado(true);
            }
        }

        private void vaciarTexts()//ya la
        {
            ControlFormsText.EliminarTextos(cedula_text, nombre_text, apellido_text, correoText);
        }

        private void resetearButtonEstado(bool estado)//ya la
        {
            ControlFormsButton.desabilitarHabilitarBotones(estado, resetear_button);

        }

        private void cancelar_button_Click(object sender, EventArgs e)//ya la
        {
            this.Close();
        }

        private void AgregarMedico_form_Load(object sender, EventArgs e)
        {

        }
    }
}
