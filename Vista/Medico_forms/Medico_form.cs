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

namespace ConsultorioPrivado.Vista
{
    public partial class Medico_form : Form
    {
        ControladorGeneral controladorGeneral;
        public Medico_form()
        {
            InitializeComponent();
            controladorGeneral = new ControladorGeneral();

        }
        private void Medico_form_Load(object sender, EventArgs e)
        {
            CargarDataGrid();
        }

        private void CargarDataGrid()
        {

            medicos_dgv.DataSource = controladorGeneral.ObtenerPorEntidad(E_ROL._MEDICO);

            int numero = medicos_dgv.ColumnCount;

            medicos_dgv.Columns["Editar"].DisplayIndex = numero - 1;
            medicos_dgv.Columns["Eliminar"].DisplayIndex = numero - 1;

            medicos_dgv.Columns["Editar"].Width = 75;
            medicos_dgv.Columns["Eliminar"].Width = 75;

        }

        private void medicos_dgv_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void resetear_button_Click(object sender, EventArgs e)
        {
            ControlFormsText.EliminarTextos(nombre_text, cedula_text);
        }

        private void buscar_button_Click(object sender, EventArgs e)
        {
            Paciente Paciente = new Paciente();
            /*Paciente.Cedula = Convert.ToInt32(cedula_text.Text);*/
            controladorGeneral.ObtenerPorCedula(Paciente, E_ROL._MEDICO);
        }

        private void nuevo_button_Click(object sender, EventArgs e)
        {
            abrirAgregarPaciente();
        }

        private void abrirAgregarPaciente()
        {
            Form form = new AgregarPaciente_form();
            form.Show();
        }

        
        private DialogResult MostrarMensaje()
        {
            DialogResult result = MessageBox.Show(
                "Desea eliminar?\nSe eliminará de forma permanente",
                   "Confirmación",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
            return result;
        }

        private void resetear_button_Click_1(object sender, EventArgs e)
        {
            VaciarText();
        }

        private void VaciarText()
        {
            ControlFormsText.EliminarTextos(cedula_text, nombre_text);
        }

        private void nuevo_button_Click_1(object sender, EventArgs e)
        {
            Form form = new AgregarPaciente_form();
            form.ShowDialog();
        }
        //NO TERMINADO
        private void buscar_button_Click_1(object sender, EventArgs e)
        {
            Medico medico = new Medico();
            medico.Cedula = Convert.ToInt32(cedula_text.Text);
            /*controladorGeneral.onte(Paciente)*/
        }

        private void medicos_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (medicos_dgv.Columns[e.ColumnIndex].Name == "Editar")
            {
                int idMedico = Convert.ToInt32(medicos_dgv.CurrentRow.
                     Cells["id"].Value.ToString());
                EditarMedico_form editarMedico = new EditarMedico_form(idMedico);
                editarMedico.ShowDialog();
                CargarDataGrid();
            }

            if (medicos_dgv.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int id = Convert.ToInt32(medicos_dgv.CurrentRow.

                   Cells["Id"].Value.ToString()); ;
                Paciente Paciente = new Paciente();
                Paciente.Id = id;
                DialogResult result = MostrarMensaje();
                if (result == DialogResult.OK)
                {
                    controladorGeneral.Eliminar(Paciente, E_ROL._MEDICO);
                    CargarDataGrid();
                }
            }
        }
    }
}