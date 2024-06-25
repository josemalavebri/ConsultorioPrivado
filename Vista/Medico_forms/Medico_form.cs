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

namespace ConsultorioPrivado.Vista
{
    public partial class Medico_form : Form
    {
        private ControladorMedico controladorMedico;
        public Medico_form()
        {
            InitializeComponent();
            controladorMedico = new ControladorMedico();

        }
        private void Medico_form_Load(object sender, EventArgs e)
        {
            CargarDataGrid();
            
        }

        public void CargarDataGrid()
        {

            medicos_dgv.DataSource = controladorMedico.ObtenerPorMedico();

            int numero = medicos_dgv.ColumnCount;

            medicos_dgv.Columns["Editar"].DisplayIndex = numero - 1; 
            medicos_dgv.Columns["Eliminar"].DisplayIndex = numero - 1;

            medicos_dgv.Columns["Editar"].Width = 75;
            medicos_dgv.Columns["Eliminar"].Width = 75;
        }
        
        private void buscar_button_Click(object sender, EventArgs e)
        {
            Paciente Paciente = new Paciente();
           
            /*Paciente.Cedula = Convert.ToInt32(cedula_text.Text);*/
            
            /*controladorGeneral.ObtenerPorCedula(Paciente, E_ROL._MEDICO);*/
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
            ControlFormsText.EliminarTextos(cedula_text);
            CargarDataGrid();
        }

        private void nuevo_button_Click_1(object sender, EventArgs e)
        {
            Form form = new AgregarMedico_form();
            form.ShowDialog();
        }

        /*/NO TERMINADO
        private void buscar_button_Click_1(object sender, EventArgs e)
        {
            Medico medico = new Medico();
            medico.Cedula = Convert.ToInt32(cedula_text.Text);

            if(medicos_dgv.ColumnCount>0)
           // medicos_dgv.DataSource = controladorGeneral.ObtenerPorCedula(medico, E_ROL._MEDICO);

            if (medicos_dgv.ColumnCount > 0){
                MessageBox.Show("Medico Encontrado");
                int numero = medicos_dgv.ColumnCount;
                medicos_dgv.Columns["Editar"].DisplayIndex = numero - 1;
                medicos_dgv.Columns["Eliminar"].DisplayIndex = numero - 1;
                medicos_dgv.Columns["Editar"].Width = 75;
                medicos_dgv.Columns["Eliminar"].Width = 75;
            }
        }*/

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
                   Cells["Id"].Value.ToString());
                Medico medico = new Medico();
                medico.Id = id;
                DialogResult result = MostrarMensaje();
                if (result == DialogResult.OK)
                {
                    controladorMedico.EliminarMedico<Medico>(medico); 
                    CargarDataGrid();
                }
            }
        }
    }
}