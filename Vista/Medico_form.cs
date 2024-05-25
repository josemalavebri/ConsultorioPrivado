using ConsultorioPrivado.Controlador;
using ConsultorioPrivado.Datos.Interface;
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
    public partial class Medico_form : Form
    {
        ControladorGeneral controladorGeneral;
        public Medico_form()
        {
            InitializeComponent();
             controladorGeneral = new ControladorGeneral();

        }

        private void Paciente_form_Load(object sender, EventArgs e)
        {
            medico_dgv.Rows.Clear();
            controladorGeneral.get(E_ROL._DOCTOR);


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
