namespace ConsultorioPrivado.Vista.Paciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paciente_form));
            resetear_button = new Button();
            nuevo_button = new Button();
            buscar_button = new Button();
            cedula_text = new TextBox();
            label4 = new Label();
            label1 = new Label();
            paciente_dgv = new DataGridView();
            Editar = new DataGridViewImageColumn();
            Eliminar = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)paciente_dgv).BeginInit();
            SuspendLayout();
            // 
            // resetear_button
            // 
            resetear_button.Location = new Point(353, 17);
            resetear_button.Margin = new Padding(3, 4, 3, 4);
            resetear_button.Name = "resetear_button";
            resetear_button.Size = new Size(106, 41);
            resetear_button.TabIndex = 29;
            resetear_button.Text = "Resetear";
            resetear_button.UseVisualStyleBackColor = true;
            resetear_button.Click += resetear_button_Click;
            // 
            // nuevo_button
            // 
            nuevo_button.Location = new Point(2, 75);
            nuevo_button.Margin = new Padding(3, 4, 3, 4);
            nuevo_button.Name = "nuevo_button";
            nuevo_button.Size = new Size(197, 63);
            nuevo_button.TabIndex = 28;
            nuevo_button.Text = "Nuevo";
            nuevo_button.UseVisualStyleBackColor = true;
            nuevo_button.Click += nuevo_button_Click;
            // 
            // buscar_button
            // 
            buscar_button.Location = new Point(222, 19);
            buscar_button.Margin = new Padding(3, 4, 3, 4);
            buscar_button.Name = "buscar_button";
            buscar_button.Size = new Size(110, 39);
            buscar_button.TabIndex = 27;
            buscar_button.Text = "Buscar";
            buscar_button.UseVisualStyleBackColor = true;
            // 
            // cedula_text
            // 
            cedula_text.Location = new Point(73, 25);
            cedula_text.Margin = new Padding(3, 4, 3, 4);
            cedula_text.Name = "cedula_text";
            cedula_text.Size = new Size(114, 27);
            cedula_text.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 28);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 25;
            label4.Text = "Cedula";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 157);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 24;
            label1.Text = "Medicos Agregados:";
            // 
            // paciente_dgv
            // 
            paciente_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            paciente_dgv.Columns.AddRange(new DataGridViewColumn[] { Editar, Eliminar });
            paciente_dgv.Location = new Point(5, 201);
            paciente_dgv.Margin = new Padding(3, 4, 3, 4);
            paciente_dgv.Name = "paciente_dgv";
            paciente_dgv.RowHeadersWidth = 51;
            paciente_dgv.Size = new Size(973, 255);
            paciente_dgv.TabIndex = 23;
            paciente_dgv.CellClick += paciente_dgv_CellClick;
            // 
            // Editar
            // 
            Editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Editar.HeaderText = "Editar";
            Editar.Image = Properties.Resources._8188360;
            Editar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Editar.MinimumWidth = 6;
            Editar.Name = "Editar";
            Editar.Width = 54;
            // 
            // Eliminar
            // 
            Eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Image = (Image)resources.GetObject("Eliminar.Image");
            Eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Eliminar.MinimumWidth = 6;
            Eliminar.Name = "Eliminar";
            Eliminar.Width = 69;
            // 
            // Paciente_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 534);
            Controls.Add(resetear_button);
            Controls.Add(nuevo_button);
            Controls.Add(buscar_button);
            Controls.Add(cedula_text);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(paciente_dgv);
            Name = "Paciente_form";
            Text = "Pacientes";
            ((System.ComponentModel.ISupportInitialize)paciente_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button resetear_button;
        private Button nuevo_button;
        private Button buscar_button;
        private TextBox cedula_text;
        private Label label4;
        private Label label1;
        private DataGridView paciente_dgv;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Eliminar;
    }
}