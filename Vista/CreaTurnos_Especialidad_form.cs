using ConsultorioPrivado.Controlador;
using ConsultorioPrivado.Datos.Interface;
using ConsultorioPrivado.Modelo;
using ConsultorioPrivado.Utilidad.Datos;
using ConsultorioPrivado.Utilidad.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsultorioPrivado.Vista
{
    public partial class CreaTurnos_Especialidad_form : Form
    {
        private bool ins_nuevo = false;
        private int id_medico;
        private ControladorGeneral objcontrolador;
        public CreaTurnos_Especialidad_form()
        {
            InitializeComponent();
            objcontrolador = new ControladorGeneral();
            id_medico = 0;
        }

        private void CreaTurnos_Especialidad_Load(object sender, EventArgs e)
        {
            llenarCombos();
        }
        
        private void llenarCombos()
        {
            cmb_Jornada.DataSource = objcontrolador.cargarCombo(E_ROL.JORNADA);
            cmb_Dia.DataSource = objcontrolador.cargarCombo(E_ROL.DIA);
            cmb_Estado.DataSource = objcontrolador.cargarCombo(E_ROL.ESTADO);
            cmb_Doctor.DataSource = objcontrolador.getNombresCompletos(E_ROL._NOMBRES_MEDICO);
            cmb_Doctor.DisplayMember = "Nombres_Completos";
            cmb_Doctor.ValueMember = "ID_Medico";
            cmb_Doctor.SelectedIndex = -1;
        }
        private void btn_Canelar_Click(object sender, EventArgs e)
        {
            vaciasTexts();
            Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            int cantidad = Int32.Parse(txt_Numero_Turno.Text);
                for (int i = 1; i <= cantidad; i++)
                {
                    Turno turno = crearTurnos(i);
                    objcontrolador.crear(turno, E_ROL._TURNO);
                    
                }
            vaciasTexts();
            id_medico = 0;
                 
        }
        private void vaciasTexts()
        {
            ControlFormsText.EliminarTextos(txt_Numero_Turno);
            cmb_Dia.SelectedIndex = -1;
            cmb_Doctor.SelectedIndex = -1;
            cmb_Estado.SelectedIndex = -1;
            cmb_Jornada.SelectedIndex = -1;
        }

        private Turno crearTurnos(int numeroTurno)
        {
            Turno turno = new Turno();
            turno.Numero_Turno = numeroTurno;
            turno.Dia = cmb_Dia.Text;
            //id del medico
            turno.ID_Medico = Convert.ToInt32(txt_id_medico.Text);         
            turno.Jornada = cmb_Jornada.Text;
            turno.Fecha = Convert.ToDateTime(DTP_Fecha.Text);
            return turno;
        }

        private void cmb_Doctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Doctor.SelectedIndex == -1)
            {
                txt_Especialidad.Text = "";
                txt_id_medico.Text = "";
            }
            else
            {
                string especialidad;
                var indice = cmb_Doctor.SelectedIndex;
                if (indice != -1)
                {
                    DataRowView seleccionfila = (DataRowView)cmb_Doctor.SelectedItem;

                    string? v = Convert.ToString(seleccionfila["Especialidad"]);
                    especialidad = v;
                    txt_Especialidad.Text = especialidad;
                    id_medico = Convert.ToInt32(seleccionfila["ID_Medico"]);
                    txt_id_medico.Text = id_medico.ToString();
                }
            }
        }
    }
}
