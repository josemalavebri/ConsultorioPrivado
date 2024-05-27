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
            medicos_dgv.Rows.Clear();
            medicos_dgv.DataSource = controladorGeneral.get(E_ROL._MEDICO); ;
        }

        private void medicos_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void resetear_button_Click(object sender, EventArgs e)
        {
            ControlFormsText.EliminarTextos(nombre_text, apellido_text, cedula_text);
        }

        private void buscar_button_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico();
            medico.Cedula = Convert.ToInt32(cedula_text.Text);
            controladorGeneral.getCedula(medico,E_ROL._MEDICO);
        }
    }
}
