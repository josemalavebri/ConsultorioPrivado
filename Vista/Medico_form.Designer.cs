namespace ConsultorioPrivado.Vista
{
    partial class Medico_form
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
            label3 = new Label();
            apellido_text = new TextBox();
            buscar_button = new Button();
            cedula_text = new TextBox();
            label4 = new Label();
            nombre_text = new TextBox();
            label2 = new Label();
            label1 = new Label();
            medicos_dgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)medicos_dgv).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(208, 60);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 19;
            label3.Text = "Apellido";
            // 
            // apellido_text
            // 
            apellido_text.Location = new Point(280, 57);
            apellido_text.Name = "apellido_text";
            apellido_text.Size = new Size(100, 23);
            apellido_text.TabIndex = 18;
            // 
            // buscar_button
            // 
            buscar_button.Location = new Point(208, 10);
            buscar_button.Name = "buscar_button";
            buscar_button.Size = new Size(75, 23);
            buscar_button.TabIndex = 17;
            buscar_button.Text = "Buscar";
            buscar_button.UseVisualStyleBackColor = true;
            // 
            // cedula_text
            // 
            cedula_text.Location = new Point(82, 11);
            cedula_text.Name = "cedula_text";
            cedula_text.Size = new Size(100, 23);
            cedula_text.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 19);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 15;
            label4.Text = "Cedula";
            // 
            // nombre_text
            // 
            nombre_text.Location = new Point(82, 57);
            nombre_text.Name = "nombre_text";
            nombre_text.Size = new Size(100, 23);
            nombre_text.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 13;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 104);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 12;
            label1.Text = "Medicos Agregados:";
            // 
            // medicos_dgv
            // 
            medicos_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            medicos_dgv.Location = new Point(12, 137);
            medicos_dgv.Name = "medicos_dgv";
            medicos_dgv.Size = new Size(596, 191);
            medicos_dgv.TabIndex = 11;
            // 
            // Medico_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 381);
            Controls.Add(label3);
            Controls.Add(apellido_text);
            Controls.Add(buscar_button);
            Controls.Add(cedula_text);
            Controls.Add(label4);
            Controls.Add(nombre_text);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(medicos_dgv);
            Name = "Medico_form";
            Text = "Paciente_form";
            Load += Paciente_form_Load;
            ((System.ComponentModel.ISupportInitialize)medicos_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox apellido_text;
        private Button buscar_button;
        private TextBox cedula_text;
        private Label label4;
        private TextBox nombre_text;
        private Label label2;
        private Label label1;
        private DataGridView medicos_dgv;
    }
}