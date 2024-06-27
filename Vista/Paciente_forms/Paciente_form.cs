using ConsultorioPrivado.Controlador.Controlers;
using ConsultorioPrivado.Utilidad.Forms;
using ConsultorioPrivado.Vista.Paciente_forms;
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

namespace ConsultorioPrivado.Vista.Paciente
{
    public partial class Paciente_form : Form
    {
        private ControladorPaciente controlador;
        public Paciente_form()
        {
            controlador = new ControladorPaciente();
            InitializeComponent();
        }
        private void CargarDataGrid()
        {
            paciente_dgv.DataSource = controlador.ObtenerPorPaciente();

            int numero = paciente_dgv.ColumnCount;

            paciente_dgv.Columns["Editar"].DisplayIndex = numero - 1;
            paciente_dgv.Columns["Eliminar"].DisplayIndex = numero - 1;

            paciente_dgv.Columns["Editar"].Width = 75;
            paciente_dgv.Columns["Eliminar"].Width = 75;

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
        private void nuevo_button_Click(object sender, EventArgs e)
        {
            Form form = new add_Paciente_form();
            form.ShowDialog();
        }

        private void resetear_button_Click(object sender, EventArgs e)
        {
            ControlFormsText.EliminarTextos(cedula_text);
        }

        private void paciente_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (paciente_dgv.Columns[e.ColumnIndex].Name == "Editar")
            {
                int idPaciente = Convert.ToInt32(paciente_dgv.CurrentRow.
                     Cells["id"].Value.ToString());
                edit_Paciente_form editarPaciente = new edit_Paciente_form(idPaciente);
                editarPaciente.ShowDialog();
                CargarDataGrid();
            }

            if (paciente_dgv.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int id = Convert.ToInt32(paciente_dgv.CurrentRow.

                   Cells["Id"].Value.ToString()); ;
                Pacientes Paciente = new Pacientes();
                Paciente.Id = id;
                DialogResult result = MostrarMensaje();
                if (result == DialogResult.OK)
                {
                    //  controladorGeneral.Eliminar(Paciente, E_ROL._MEDICO);
                    CargarDataGrid();
                }
            }
        }
    }
}
