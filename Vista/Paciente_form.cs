using ConsultorioPrivado.Controlador;
using ConsultorioPrivado.Modelo;
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
        I_Controlador<Paciente> iControlador;
        public Paciente_form()
        {
            InitializeComponent();
            iControlador = new ControladorPaciente();

        }

        private void Paciente_form_Load(object sender, EventArgs e)
        {
            pacientes_dgv.Rows.Clear();
            pacientes_dgv.DataSource = iControlador.get();


        }

        private void paciente_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nuevoPaciente_Button_Click(object sender, EventArgs e)
        {
            Form nuevoPaciente = new  AgregarPaciente_form();
            nuevoPaciente.Show();
        }
    }
}
