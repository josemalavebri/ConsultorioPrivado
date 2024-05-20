using ConsultorioPrivado.Controlador;
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
            paciente_dgv.Rows.Clear();
            paciente_dgv.DataSource = controladorPaciente.get();
            Console.WriteLine(controladorPaciente.ToString());
        }
    }
}
