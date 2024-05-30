using ConsultorioPrivado.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultorioPrivado.Datos.Interface;
using System.Windows.Forms;
using ConsultorioPrivado.Modelo;
using ConsultorioPrivado.Utilidad.Datos;

namespace ConsultorioPrivado.Vista
{
    public partial class AsignarTurno : Form
    {
        private ControladorGeneral objcontrolador;
        private int id_turno;
        private string estado;
        public AsignarTurno()
        {
            InitializeComponent();
            objcontrolador = new ControladorGeneral();
            id_turno = 0;
            estado=string.Empty;
        }

        private void AsignarTurno_Load(object sender, EventArgs e)
        {
            llenarCombo();
        }
        private void llenarCombo()
        {
            cmb_Especialidad.DataSource = objcontrolador.cargarCombo(E_ROL.ESPECIALIDAD);
        }

        private void Cmb_Especialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Especialidad.SelectedIndex != -1)
            {
                string estado = "Disponible";
                Turno turno = crearTurnos(estado);
                Medico medico = crearMedicoDatos();

                DGV_Turnos.DataSource = objcontrolador.obtenerTurno(medico, turno, E_ROL._TURNO, "Especialidad", "Estado");
            }
        }
        private Turno crearTurnos(string estado)
        {
            Turno turno = new Turno();
            turno.Estado = estado;
            return turno;
        }
        private Medico crearMedicoDatos()
        {
            Medico medico = new Medico();
            medico.Especialidad = cmb_Especialidad.Text;
            return medico;
        }

        private void DGV_Turnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var fila = e.RowIndex;
            if (fila >= 0)
            {
                txt_Numero.Text = DGV_Turnos.Rows[fila].Cells["Numero_Turno"].Value.ToString();
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Paciente paciente = buscarPacienteDatos();
            DataTable resultado = objcontrolador.buscar(paciente, E_ROL._PACIENTE);
            if (resultado.Rows.Count > 0)
            {
                foreach (DataRow fila in resultado.Rows)
                {
                    txt_ID_Paciente.Text = fila["ID_Paciente"].ToString();
                    txt_Nombre.Text = fila["Nombres_Paciente"].ToString();
                    txt_Apellido.Text = fila["Apellidos_Paciente"].ToString();
                    txt_Telefono.Text = fila["Telefono_Paciente"].ToString();
                }
            }
        }
        private Paciente buscarPacienteDatos()
        {
            Paciente paciente = new Paciente();
            paciente.Cedula = txt_Cedula.Text.ToString();
            /*paciente.Nombres = txt_Nombre.Text.ToString();
            paciente.Apellidos = txt_Apellido.Text.ToString();
            paciente.Direccion = txt_Telefono.Text.ToString();
            paciente.Telefono = txt_Telefono.Text;*/
            return paciente;
        }

        private void DGV_Turnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var fila = e.RowIndex;

            if (fila >= 0)
            {
                txt_Numero.Text = DGV_Turnos.Rows[fila].Cells["Numero_Turno"].Value.ToString();
                id_turno = Convert.ToInt32(DGV_Turnos.Rows[fila].Cells["ID_Turno"].Value.ToString());
                //estado = DGV_Turnos.Rows[fila].Cells["Estado"].Value.ToString();
            }
        }

        private void btn_Asignar_Click(object sender, EventArgs e)
        {
            estado = "Ocupado";
            Asignar asignar = new Asignar();
            Turno turno = new Turno();
            asignar.ID_Paciente=Convert.ToInt32(txt_ID_Paciente.Text);
            asignar.ID_Turno = id_turno;
            asignar.Estado = estado;
            turno.Estado = estado;
            objcontrolador.crear(asignar, E_ROL._ASIGNA);
            objcontrolador.actualizarEstadoTurno(turno);
        }
        
    }
}
