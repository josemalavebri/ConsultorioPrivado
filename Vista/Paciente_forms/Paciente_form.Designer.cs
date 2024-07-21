namespace ConsultorioPrivado.Vista
{
    partial class Paciente_form
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
            pacientes_dgv = new DataGridView();
            Editar = new DataGridViewImageColumn();
            Eliminar = new DataGridViewImageColumn();
            label1 = new Label();
            label4 = new Label();
            cedula_text = new TextBox();
            buscar_button = new Button();
            label2 = new Label();
            nombre_text = new TextBox();
            apellido_text = new TextBox();
            resetear_button = new Button();
            nuevo_button = new Button();
            ((System.ComponentModel.ISupportInitialize)pacientes_dgv).BeginInit();
            SuspendLayout();
            // 
            // pacientes_dgv
            // 
            pacientes_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pacientes_dgv.Columns.AddRange(new DataGridViewColumn[] { Editar, Eliminar });
            pacientes_dgv.Location = new Point(12, 148);
            pacientes_dgv.Name = "pacientes_dgv";
            pacientes_dgv.Size = new Size(851, 191);
            pacientes_dgv.TabIndex = 0;
            pacientes_dgv.CellClick += pacientes_dgv_CellClick;
            // 
            // Editar
            // 
            Editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Editar.HeaderText = "Editar";
            Editar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Editar.Name = "Editar";
            Editar.Resizable = DataGridViewTriState.True;
            Editar.Width = 43;
            // 
            // Eliminar
            // 
            Eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Eliminar.HeaderText = "Eliminar";
            Eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Eliminar.Name = "Eliminar";
            Eliminar.Resizable = DataGridViewTriState.True;
            Eliminar.Width = 56;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 119);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 1;
            label1.Text = "Pacientes Agregados:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 34);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 6;
            label4.Text = "Cedula";
            // 
            // cedula_text
            // 
            cedula_text.Location = new Point(92, 26);
            cedula_text.Name = "cedula_text";
            cedula_text.Size = new Size(100, 23);
            cedula_text.TabIndex = 7;
            // 
            // buscar_button
            // 
            buscar_button.Location = new Point(233, 26);
            buscar_button.Name = "buscar_button";
            buscar_button.Size = new Size(75, 23);
            buscar_button.TabIndex = 8;
            buscar_button.Text = "Buscar";
            buscar_button.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 75);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // nombre_text
            // 
            nombre_text.Location = new Point(92, 72);
            nombre_text.Name = "nombre_text";
            nombre_text.Size = new Size(100, 23);
            nombre_text.TabIndex = 3;
            // 
            // apellido_text
            // 
            apellido_text.Location = new Point(218, 72);
            apellido_text.Name = "apellido_text";
            apellido_text.Size = new Size(100, 23);
            apellido_text.TabIndex = 9;
            // 
            // resetear_button
            // 
            resetear_button.Location = new Point(335, 26);
            resetear_button.Name = "resetear_button";
            resetear_button.Size = new Size(75, 23);
            resetear_button.TabIndex = 10;
            resetear_button.Text = "Resetear";
            resetear_button.UseVisualStyleBackColor = true;
            resetear_button.Click += resetear_button_Click;
            // 
            // nuevo_button
            // 
            nuevo_button.Location = new Point(405, 59);
            nuevo_button.Name = "nuevo_button";
            nuevo_button.Size = new Size(170, 47);
            nuevo_button.TabIndex = 11;
            nuevo_button.Text = "Nuevo";
            nuevo_button.UseVisualStyleBackColor = true;
            nuevo_button.Click += nuevo_button_Click;
            // 
            // Paciente_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 381);
            Controls.Add(nuevo_button);
            Controls.Add(resetear_button);
            Controls.Add(apellido_text);
            Controls.Add(buscar_button);
            Controls.Add(cedula_text);
            Controls.Add(label4);
            Controls.Add(nombre_text);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pacientes_dgv);
            Name = "Paciente_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Paciente_form";
            Load += Paciente_form_Load;
            ((System.ComponentModel.ISupportInitialize)pacientes_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView pacientes_dgv;
        private Label label1;
        private Label label4;
        private TextBox cedula_text;
        private Button buscar_button;
        private Label label2;
        private TextBox nombre_text;
        private TextBox apellido_text;
        private Button resetear_button;
        private Button nuevo_button;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Eliminar;
    }
}