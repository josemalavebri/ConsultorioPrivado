﻿using ConsultorioPrivado.Controlador.Controlers;
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
    public partial class Paciente_form : Form
    {
        ControladorMedico controladorGeneral;
        public Paciente_form()
        {
            InitializeComponent();
            controladorGeneral = new ControladorMedico();

        }

        private void Paciente_form_Load(object sender, EventArgs e)
        {
            pacientes_dgv.Rows.Clear();
           // pacientes_dgv.DataSource = controladorGeneral.ObtenerPorEntidad(E_ROL._PACIENTE);


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
