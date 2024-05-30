namespace ConsultorioPrivado.Vista
{
    partial class AsignarTurno
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
            cmb_Especialidad = new ComboBox();
            Especialidad = new Label();
            DGV_Turnos = new DataGridView();
            label1 = new Label();
            txt_Numero = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_ID_Paciente = new TextBox();
            txt_Telefono = new TextBox();
            txt_Apellido = new TextBox();
            txt_Nombre = new TextBox();
            txt_Cedula = new TextBox();
            btn_Buscar = new Button();
            btn_Asignar = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DGV_Turnos).BeginInit();
            SuspendLayout();
            // 
            // cmb_Especialidad
            // 
            cmb_Especialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Especialidad.FormattingEnabled = true;
            cmb_Especialidad.Location = new Point(122, 27);
            cmb_Especialidad.Name = "cmb_Especialidad";
            cmb_Especialidad.Size = new Size(259, 28);
            cmb_Especialidad.TabIndex = 0;
            cmb_Especialidad.SelectedIndexChanged += Cmb_Especialidad_SelectedIndexChanged;
            // 
            // Especialidad
            // 
            Especialidad.AutoSize = true;
            Especialidad.Location = new Point(12, 30);
            Especialidad.Name = "Especialidad";
            Especialidad.Size = new Size(93, 20);
            Especialidad.TabIndex = 1;
            Especialidad.Text = "Especialidad";
            // 
            // DGV_Turnos
            // 
            DGV_Turnos.AllowUserToAddRows = false;
            DGV_Turnos.AllowUserToOrderColumns = true;
            DGV_Turnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Turnos.Location = new Point(12, 282);
            DGV_Turnos.Name = "DGV_Turnos";
            DGV_Turnos.ReadOnly = true;
            DGV_Turnos.RowHeadersWidth = 51;
            DGV_Turnos.Size = new Size(1002, 300);
            DGV_Turnos.TabIndex = 2;
            DGV_Turnos.CellClick += DGV_Turnos_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 92);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 3;
            label1.Text = "Numero del turno";
            // 
            // txt_Numero
            // 
            txt_Numero.Enabled = false;
            txt_Numero.Location = new Point(166, 85);
            txt_Numero.Name = "txt_Numero";
            txt_Numero.ReadOnly = true;
            txt_Numero.Size = new Size(146, 27);
            txt_Numero.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(484, 31);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 5;
            label2.Text = "ID Paciente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 149);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 6;
            label3.Text = "Apellidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(484, 111);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 7;
            label4.Text = "Nombres";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(484, 72);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 8;
            label5.Text = "Cedula";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(484, 195);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 9;
            label6.Text = "Telefono";
            // 
            // txt_ID_Paciente
            // 
            txt_ID_Paciente.Enabled = false;
            txt_ID_Paciente.Location = new Point(591, 28);
            txt_ID_Paciente.Name = "txt_ID_Paciente";
            txt_ID_Paciente.ReadOnly = true;
            txt_ID_Paciente.Size = new Size(125, 27);
            txt_ID_Paciente.TabIndex = 10;
            // 
            // txt_Telefono
            // 
            txt_Telefono.Location = new Point(591, 188);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.Size = new Size(195, 27);
            txt_Telefono.TabIndex = 12;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(591, 146);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(240, 27);
            txt_Apellido.TabIndex = 13;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(591, 108);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(240, 27);
            txt_Nombre.TabIndex = 14;
            // 
            // txt_Cedula
            // 
            txt_Cedula.Location = new Point(591, 69);
            txt_Cedula.Name = "txt_Cedula";
            txt_Cedula.Size = new Size(195, 27);
            txt_Cedula.TabIndex = 15;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Location = new Point(825, 69);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(94, 29);
            btn_Buscar.TabIndex = 16;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // button2
            // 
            btn_Asignar.Location = new Point(395, 608);
            btn_Asignar.Name = "btn_Asignar";
            btn_Asignar.Size = new Size(94, 29);
            btn_Asignar.TabIndex = 17;
            btn_Asignar.Text = "Asignar";
            btn_Asignar.UseVisualStyleBackColor = true;
            btn_Asignar.Click += btn_Asignar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(551, 608);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 18;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(166, 146);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(146, 27);
            textBox1.TabIndex = 19;
            // 
            // AsignarTurno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 649);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(btn_Asignar);
            Controls.Add(btn_Buscar);
            Controls.Add(txt_Cedula);
            Controls.Add(txt_Nombre);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_Telefono);
            Controls.Add(txt_ID_Paciente);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_Numero);
            Controls.Add(label1);
            Controls.Add(DGV_Turnos);
            Controls.Add(Especialidad);
            Controls.Add(cmb_Especialidad);
            Name = "AsignarTurno";
            Text = "AsignarTurno";
            Load += AsignarTurno_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_Turnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb_Especialidad;
        private Label Especialidad;
        private DataGridView DGV_Turnos;
        private Label label1;
        private TextBox txt_Numero;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_ID_Paciente;
        private TextBox txt_Telefono;
        private TextBox txt_Apellido;
        private TextBox txt_Nombre;
        private TextBox txt_Cedula;
        private Button btn_Buscar;
        private Button btn_Asignar;
        private Button button3;
        private TextBox textBox1;
    }
}