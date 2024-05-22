using ConsultorioPrivado.Vista;

namespace ConsultorioPrivado
{
    public partial class Principal_form : Form
    {
        public Principal_form()
        {
            InitializeComponent();
            abrirFormulario(new AgregarPaciente_form());
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
