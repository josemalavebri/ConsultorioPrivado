namespace ConsultorioPrivado.Vista
{
    partial class Agenda_form
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            citas_panel = new TableLayoutPanel();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // citas_panel
            // 
            citas_panel.ColumnCount = 2;
            citas_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            citas_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.3333359F));
            citas_panel.Location = new Point(73, 12);
            citas_panel.Name = "citas_panel";
            citas_panel.RowCount = 2;
            citas_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            citas_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            citas_panel.Size = new Size(200, 357);
            citas_panel.TabIndex = 0;
            // 
            // Agenda_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 381);
            Controls.Add(citas_panel);
            Name = "Agenda_form";
            Text = "Agenda_form";
            Load += Agenda_form_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TableLayoutPanel citas_panel;
    }
}