namespace ConsultorioPrivado.Vista
{
    partial class AgendarCita_form
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            agregarPaciente_button = new Button();
            buscarPaciente_button = new Button();
            datosPaciente = new TextBox();
            buscarMedico_button = new Button();
            comboBox1 = new ComboBox();
            agendarCita_button = new Button();
            resetear_button = new Button();
            ultimasCitas_dgv = new DataGridView();
            label4 = new Label();
            eliminarCita_button = new Button();
            datosPaciente_text = new TextBox();
            modificarPaciente_button = new Button();
            ((System.ComponentModel.ISupportInitialize)ultimasCitas_dgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Paciente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 1;
            label2.Text = "Medico Disponible";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 2;
            label3.Text = "T‬ipo Consulta";
            // 
            // agregarPaciente_button
            // 
            agregarPaciente_button.Location = new Point(293, 8);
            agregarPaciente_button.Name = "agregarPaciente_button";
            agregarPaciente_button.Size = new Size(79, 23);
            agregarPaciente_button.TabIndex = 3;
            agregarPaciente_button.Text = "Nuevo";
            agregarPaciente_button.UseVisualStyleBackColor = true;
            agregarPaciente_button.Click += agregarPaciente_button_Click;
            // 
            // buscarPaciente_button
            // 
            buscarPaciente_button.Location = new Point(398, 8);
            buscarPaciente_button.Name = "buscarPaciente_button";
            buscarPaciente_button.Size = new Size(79, 23);
            buscarPaciente_button.TabIndex = 4;
            buscarPaciente_button.Text = "Buscar";
            buscarPaciente_button.UseVisualStyleBackColor = true;
            buscarPaciente_button.Click += buscarPaciente_button_Click;
            // 
            // datosPaciente
            // 
            datosPaciente.Location = new Point(143, 45);
            datosPaciente.Name = "datosPaciente";
            datosPaciente.ReadOnly = true;
            datosPaciente.Size = new Size(122, 23);
            datosPaciente.TabIndex = 5;
            // 
            // buscarMedico_button
            // 
            buscarMedico_button.Location = new Point(293, 49);
            buscarMedico_button.Name = "buscarMedico_button";
            buscarMedico_button.Size = new Size(152, 23);
            buscarMedico_button.TabIndex = 6;
            buscarMedico_button.Text = "Seleccionar Medico";
            buscarMedico_button.UseVisualStyleBackColor = true;
            buscarMedico_button.Click += buscarMedico_button_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(144, 93);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            // 
            // agendarCita_button
            // 
            agendarCita_button.Location = new Point(19, 143);
            agendarCita_button.Name = "agendarCita_button";
            agendarCita_button.Size = new Size(99, 23);
            agendarCita_button.TabIndex = 8;
            agendarCita_button.Text = "Agendar Cita";
            agendarCita_button.UseVisualStyleBackColor = true;
            // 
            // resetear_button
            // 
            resetear_button.Location = new Point(153, 143);
            resetear_button.Name = "resetear_button";
            resetear_button.Size = new Size(75, 23);
            resetear_button.TabIndex = 9;
            resetear_button.Text = "Resetear";
            resetear_button.UseVisualStyleBackColor = true;
            // 
            // ultimasCitas_dgv
            // 
            ultimasCitas_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ultimasCitas_dgv.Location = new Point(12, 219);
            ultimasCitas_dgv.Name = "ultimasCitas_dgv";
            ultimasCitas_dgv.Size = new Size(620, 150);
            ultimasCitas_dgv.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 186);
            label4.Name = "label4";
            label4.Size = new Size(141, 15);
            label4.TabIndex = 11;
            label4.Text = "Ultimas Citas Agendadas:";
            // 
            // eliminarCita_button
            // 
            eliminarCita_button.Location = new Point(473, 190);
            eliminarCita_button.Name = "eliminarCita_button";
            eliminarCita_button.Size = new Size(106, 23);
            eliminarCita_button.TabIndex = 12;
            eliminarCita_button.Text = "Eliminar Cita";
            eliminarCita_button.UseVisualStyleBackColor = true;
            // 
            // datosPaciente_text
            // 
            datosPaciente_text.Location = new Point(143, 9);
            datosPaciente_text.Name = "datosPaciente_text";
            datosPaciente_text.ReadOnly = true;
            datosPaciente_text.Size = new Size(122, 23);
            datosPaciente_text.TabIndex = 13;
            // 
            // modificarPaciente_button
            // 
            modificarPaciente_button.Location = new Point(255, 143);
            modificarPaciente_button.Name = "modificarPaciente_button";
            modificarPaciente_button.Size = new Size(75, 23);
            modificarPaciente_button.TabIndex = 14;
            modificarPaciente_button.Text = "Modificar";
            modificarPaciente_button.UseVisualStyleBackColor = true;
            // 
            // AgendarCita_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 381);
            Controls.Add(modificarPaciente_button);
            Controls.Add(datosPaciente_text);
            Controls.Add(eliminarCita_button);
            Controls.Add(label4);
            Controls.Add(ultimasCitas_dgv);
            Controls.Add(resetear_button);
            Controls.Add(agendarCita_button);
            Controls.Add(comboBox1);
            Controls.Add(buscarMedico_button);
            Controls.Add(datosPaciente);
            Controls.Add(buscarPaciente_button);
            Controls.Add(agregarPaciente_button);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(660, 420);
            Name = "AgendarCita_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agendar Cita";
            Load += AgendarCita_form_Load;
            ((System.ComponentModel.ISupportInitialize)ultimasCitas_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button agregarPaciente_button;
        private Button buscarPaciente_button;
        private TextBox datosPaciente;
        private Button buscarMedico_button;
        private ComboBox comboBox1;
        private Button agendarCita_button;
        private Button resetear_button;
        private DataGridView ultimasCitas_dgv;
        private Label label4;
        private Button eliminarCita_button;
        private TextBox datosPaciente_text;
        private Button modificarPaciente_button;
    }
}