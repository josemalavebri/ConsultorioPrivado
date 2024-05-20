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
            paciente_dgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)paciente_dgv).BeginInit();
            SuspendLayout();
            // 
            // paciente_dgv
            // 
            paciente_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            paciente_dgv.Location = new Point(42, 112);
            paciente_dgv.Name = "paciente_dgv";
            paciente_dgv.Size = new Size(553, 178);
            paciente_dgv.TabIndex = 0;
            // 
            // Paciente_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 381);
            Controls.Add(paciente_dgv);
            Name = "Paciente_form";
            Text = "Paciente_form";
            Load += Paciente_form_Load;
            ((System.ComponentModel.ISupportInitialize)paciente_dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView paciente_dgv;
    }
}