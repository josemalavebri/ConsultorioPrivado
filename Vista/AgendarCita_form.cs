using ConsultorioPrivado.Vista.Paciente_forms;
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
    public partial class AgendarCita_form : Form
    {
        public AgendarCita_form()
        {
            InitializeComponent();
        }

        private void AgendarCita_form_Load(object sender, EventArgs e)
        {

        }

        private void buscarPaciente_button_Click(object sender, EventArgs e)
        {

        }

        private void agregarPaciente_button_Click(object sender, EventArgs e)
        {
            Form form = new AgregarPaciente_form();
            form.Show();
        }

        private void buscarMedico_button_Click(object sender, EventArgs e)
        {
            Form form = new Medico_form();
            form.Show();
        }
    }
}
