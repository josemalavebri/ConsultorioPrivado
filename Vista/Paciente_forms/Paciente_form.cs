using ConsultorioPrivado.Controlador.Controlers;
using ConsultorioPrivado.Controlador.Enums;
using ConsultorioPrivado.Datos.Interface;
using ConsultorioPrivado.Modelo;
using ConsultorioPrivado.Vista.Paciente_forms;
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

namespace ConsultorioPrivado.Vista
{
    public partial class Paciente_form : Form
    {
        ControladorPaciente controladorPaciente;
        public Paciente_form()
        {
            InitializeComponent();
            controladorPaciente = new ControladorPaciente();

        }

        private void Paciente_form_Load(object sender, EventArgs e)
        {
            CargarDataGrid();

        }

        public void CargarDataGrid()
        {
            pacientes_dgv.DataSource = controladorPaciente.ObtenerPorPaciente();

            int numero = pacientes_dgv.ColumnCount;

            pacientes_dgv.Columns["Editar"].DisplayIndex = numero - 1;
            pacientes_dgv.Columns["Eliminar"].DisplayIndex = numero - 1;

            pacientes_dgv.Columns["Editar"].Width = 75;
            pacientes_dgv.Columns["Eliminar"].Width = 75;
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

        private void pacientes_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (pacientes_dgv.Columns[e.ColumnIndex].Name == "Editar")
            {
                int idPaciente = Convert.ToInt32(pacientes_dgv.CurrentRow.
                     Cells["id"].Value.ToString());
                EditarPaciente_form editarPaciente = new EditarPaciente_form(idPaciente);
                editarPaciente.ShowDialog();
                CargarDataGrid();
            }

            if (pacientes_dgv.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int id = Convert.ToInt32(pacientes_dgv.CurrentRow.
                   Cells["Id"].Value.ToString());
                Paciente paciente = new Paciente();
                paciente.Id = id;
                DialogResult result = MostrarMensaje();
                if (result == DialogResult.OK)
                {
                    controladorPaciente.EliminarPaciente<Paciente>(paciente);
                    CargarDataGrid();
                }
            }
        }

        private void nuevo_button_Click(object sender, EventArgs e)
        {
            Form form = new AgregarPaciente_form();
            form.ShowDialog();
        }

        private void resetear_button_Click(object sender, EventArgs e)
        {
            ControlFormsText.EliminarTextos(cedula_text);
            CargarDataGrid();
        }
    }
}
