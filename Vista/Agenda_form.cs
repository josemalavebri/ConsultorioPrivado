﻿using System;
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
    public partial class Agenda_form : Form
    {
        public Agenda_form()
        {
            InitializeComponent();
        }

        private void Agenda_form_Load(object sender, EventArgs e)
        {
            agregarCitas();
        }

        private void agregarCitas()
        {
            Label label = new Label();
            Label label1 = new Label();
            Label label2 = new Label();
            Label label3= new Label();
            Label label4 = new Label();
            Label label5 = new Label();



            label.Text = "0";
            label1.Text = "1";
            label2.Text = "2";
            label3.Text = "3";
            label4.Text = "4";
            label5.Text = "5";



            citas_panel.Controls.Add(label,0,0);
            citas_panel.Controls.Add(label1, 0, 1);
            citas_panel.Controls.Add(label2, 1, 0);
            citas_panel.Controls.Add(label3, 1, 1);
            citas_panel.Controls.Add(label4, 2, 0);
            citas_panel.Controls.Add(label5, 2, 1);




        }
    }
}
