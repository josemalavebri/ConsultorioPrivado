using ConsultorioPrivado.Vista;

namespace ConsultorioPrivado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            abrirFormulario(new Paciente_form());
        }

        private void abrirFormulario(Form form)
        {
            while (principal_panel.Controls.Count > 0)
            {
                principal_panel.Controls.RemoveAt(0);
            }
            Form formularioHijo = form;
            form.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            principal_panel.Controls.Add(formularioHijo);
            formularioHijo.Show();
        }



    }
}
