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
            medico_dgv = new DataGridView();
            label1 = new Label();
            nuevoMedico_Button = new Button();
            ((System.ComponentModel.ISupportInitialize)medico_dgv).BeginInit();
            SuspendLayout();
            // 
            // medico_dgv
            // 
            medico_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            medico_dgv.Location = new Point(43, 104);
            medico_dgv.Name = "medico_dgv";
            medico_dgv.Size = new Size(666, 178);
            medico_dgv.TabIndex = 0;
            medico_dgv.CellContentClick += paciente_dgv_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 60);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 1;
            label1.Text = "Medicos Agregados:";
            // 
            // nuevoMedico_Button
            // 
            nuevoMedico_Button.Location = new Point(519, 60);
            nuevoMedico_Button.Name = "nuevoMedico_Button";
            nuevoMedico_Button.Size = new Size(100, 35);
            nuevoMedico_Button.TabIndex = 2;
            nuevoMedico_Button.Text = "Nuevo Medico";
            nuevoMedico_Button.UseVisualStyleBackColor = true;
            nuevoMedico_Button.Click += nuevoPaciente_Button_Click;
            // 
            // Medico_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 405);
            Controls.Add(nuevoMedico_Button);
            Controls.Add(label1);
            Controls.Add(medico_dgv);
            Name = "Medico_form";
            Text = "Paciente_form";
            Load += Paciente_form_Load;
            ((System.ComponentModel.ISupportInitialize)medico_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView medico_dgv;
        private Label label1;
        protected Button nuevoMedico_Button;
    }
}