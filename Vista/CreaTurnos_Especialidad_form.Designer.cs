namespace ConsultorioPrivado.Vista
{
    partial class CreaTurnos_Especialidad_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            label5 = new Label();
            cmb_Doctor = new ComboBox();
            txt_Especialidad = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label10 = new Label();
            txt_id_medico = new TextBox();
            label9 = new Label();
            DTP_Fecha = new DateTimePicker();
            pictureBox1 = new PictureBox();
            txt_Numero_Turno = new TextBox();
            cmb_Dia = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            label7 = new Label();
            btn_Agregar = new Button();
            label3 = new Label();
            cmb_Jornada = new ComboBox();
            cmb_Estado = new ComboBox();
            btn_Cancelar = new Button();
            tabPage2 = new TabPage();
            label8 = new Label();
            DGV_Turnos = new DataGridView();
            label6 = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            fileSystemWatcher2 = new FileSystemWatcher();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Turnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 84);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 2;
            label1.Text = "Especialidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 43);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 20;
            label5.Text = "Doctor";
            // 
            // cmb_Doctor
            // 
            cmb_Doctor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Doctor.FormattingEnabled = true;
            cmb_Doctor.Location = new Point(107, 36);
            cmb_Doctor.Name = "cmb_Doctor";
            cmb_Doctor.Size = new Size(285, 28);
            cmb_Doctor.TabIndex = 21;
            cmb_Doctor.SelectedIndexChanged += cmb_Doctor_SelectedIndexChanged;
            // 
            // txt_Especialidad
            // 
            txt_Especialidad.Location = new Point(218, 81);
            txt_Especialidad.Name = "txt_Especialidad";
            txt_Especialidad.ReadOnly = true;
            txt_Especialidad.RightToLeft = RightToLeft.No;
            txt_Especialidad.Size = new Size(253, 27);
            txt_Especialidad.TabIndex = 22;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 61);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(926, 540);
            tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(txt_id_medico);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(DTP_Fecha);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(txt_Numero_Turno);
            tabPage1.Controls.Add(txt_Especialidad);
            tabPage1.Controls.Add(cmb_Dia);
            tabPage1.Controls.Add(cmb_Doctor);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(btn_Agregar);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(cmb_Jornada);
            tabPage1.Controls.Add(cmb_Estado);
            tabPage1.Controls.Add(btn_Cancelar);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(918, 507);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Crear Turnos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(429, 43);
            label10.Name = "label10";
            label10.Size = new Size(78, 20);
            label10.TabIndex = 27;
            label10.Text = "ID Medico";
            // 
            // txt_id_medico
            // 
            txt_id_medico.Enabled = false;
            txt_id_medico.Location = new Point(513, 36);
            txt_id_medico.Name = "txt_id_medico";
            txt_id_medico.ReadOnly = true;
            txt_id_medico.Size = new Size(125, 27);
            txt_id_medico.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(173, 225);
            label9.Name = "label9";
            label9.Size = new Size(47, 20);
            label9.TabIndex = 25;
            label9.Text = "Fecha";
            // 
            // DTP_Fecha
            // 
            DTP_Fecha.Location = new Point(259, 220);
            DTP_Fecha.Name = "DTP_Fecha";
            DTP_Fecha.Size = new Size(298, 27);
            DTP_Fecha.TabIndex = 24;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._2764452;
            pictureBox1.Location = new Point(644, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 228);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // txt_Numero_Turno
            // 
            txt_Numero_Turno.Location = new Point(290, 127);
            txt_Numero_Turno.Name = "txt_Numero_Turno";
            txt_Numero_Turno.Size = new Size(125, 27);
            txt_Numero_Turno.TabIndex = 8;
            // 
            // cmb_Dia
            // 
            cmb_Dia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Dia.FormattingEnabled = true;
            cmb_Dia.Location = new Point(259, 172);
            cmb_Dia.Name = "cmb_Dia";
            cmb_Dia.Size = new Size(235, 28);
            cmb_Dia.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(144, 277);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 10;
            label4.Text = "Jornada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 130);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 4;
            label2.Text = "Cantidad de turnos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(151, 322);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 18;
            label7.Text = "Estado";
            // 
            // btn_Agregar
            // 
            btn_Agregar.Location = new Point(173, 392);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(94, 29);
            btn_Agregar.TabIndex = 16;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(173, 180);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 6;
            label3.Text = "Dia";
            // 
            // cmb_Jornada
            // 
            cmb_Jornada.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Jornada.FormattingEnabled = true;
            cmb_Jornada.Location = new Point(259, 269);
            cmb_Jornada.Name = "cmb_Jornada";
            cmb_Jornada.Size = new Size(235, 28);
            cmb_Jornada.TabIndex = 11;
            // 
            // cmb_Estado
            // 
            cmb_Estado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Estado.FormattingEnabled = true;
            cmb_Estado.Items.AddRange(new object[] { "Disponible", "Ocupado", "Finalizado" });
            cmb_Estado.Location = new Point(259, 314);
            cmb_Estado.Name = "cmb_Estado";
            cmb_Estado.Size = new Size(235, 28);
            cmb_Estado.TabIndex = 19;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(338, 392);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(94, 29);
            btn_Cancelar.TabIndex = 17;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Canelar_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(DGV_Turnos);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(918, 507);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ver Turnos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 34);
            label8.Name = "label8";
            label8.Size = new Size(93, 20);
            label8.TabIndex = 1;
            label8.Text = "Especialidad";
            // 
            // DGV_Turnos
            // 
            DGV_Turnos.AllowUserToAddRows = false;
            DGV_Turnos.AllowUserToDeleteRows = false;
            DGV_Turnos.AllowUserToOrderColumns = true;
            DGV_Turnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Turnos.Location = new Point(6, 142);
            DGV_Turnos.Name = "DGV_Turnos";
            DGV_Turnos.ReadOnly = true;
            DGV_Turnos.RowHeadersWidth = 51;
            DGV_Turnos.Size = new Size(906, 359);
            DGV_Turnos.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 22);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 23;
            label6.Text = "Turnos";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fileSystemWatcher2
            // 
            fileSystemWatcher2.EnableRaisingEvents = true;
            fileSystemWatcher2.SynchronizingObject = this;
            // 
            // CreaTurnos_Especialidad_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 613);
            Controls.Add(label6);
            Controls.Add(tabControl1);
            Name = "CreaTurnos_Especialidad_form";
            Text = "CreaTurnos_Especialidad";
            Load += CreaTurnos_Especialidad_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Turnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Label label5;
        private ComboBox cmb_Doctor;
        private TextBox txt_Especialidad;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txt_Numero_Turno;
        private ComboBox cmb_Dia;
        private Label label4;
        private Label label2;
        private Label label7;
        private Button btn_Agregar;
        private Label label3;
        private ComboBox cmb_Jornada;
        private ComboBox cmb_Estado;
        private Button btn_Cancelar;
        private Label label6;
        private PictureBox pictureBox1;
        private DataGridView DGV_Turnos;
        private FileSystemWatcher fileSystemWatcher1;
        private FileSystemWatcher fileSystemWatcher2;
        private Label label8;
        private DateTimePicker DTP_Fecha;
        private Label label9;
        private Label label10;
        private TextBox txt_id_medico;
    }
}