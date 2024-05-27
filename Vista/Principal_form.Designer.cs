namespace ConsultorioPrivado
{
    partial class Principal_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            agendacitas_button = new Button();
            agendarCitas_button = new Button();
            pacientes_button = new Button();
            medicos_Button = new Button();
            principal_panel = new Panel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(agendacitas_button);
            flowLayoutPanel1.Controls.Add(agendarCitas_button);
            flowLayoutPanel1.Controls.Add(pacientes_button);
            flowLayoutPanel1.Controls.Add(medicos_Button);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(2, 100);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(109, 349);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // agendacitas_button
            // 
            agendacitas_button.Location = new Point(3, 3);
            agendacitas_button.Name = "agendacitas_button";
            agendacitas_button.Size = new Size(100, 35);
            agendacitas_button.TabIndex = 4;
            agendacitas_button.Text = "Agenda";
            agendacitas_button.UseVisualStyleBackColor = true;
            agendacitas_button.Click += agendacitas_button_Click;
            // 
            // agendarCitas_button
            // 
            agendarCitas_button.Location = new Point(3, 44);
            agendarCitas_button.Name = "agendarCitas_button";
            agendarCitas_button.Size = new Size(100, 35);
            agendarCitas_button.TabIndex = 1;
            agendarCitas_button.Text = "Agendar Cita";
            agendarCitas_button.UseVisualStyleBackColor = true;
            agendarCitas_button.Click += button1_Click;
            // 
            // pacientes_button
            // 
            pacientes_button.Location = new Point(3, 85);
            pacientes_button.Name = "pacientes_button";
            pacientes_button.Size = new Size(100, 35);
            pacientes_button.TabIndex = 2;
            pacientes_button.Text = "Pacientes";
            pacientes_button.UseVisualStyleBackColor = true;
            pacientes_button.Click += pacientes_button_Click;
            // 
            // medicos_Button
            // 
            medicos_Button.Location = new Point(3, 126);
            medicos_Button.Name = "medicos_Button";
            medicos_Button.Size = new Size(100, 35);
            medicos_Button.TabIndex = 3;
            medicos_Button.Text = "Medicos";
            medicos_Button.UseVisualStyleBackColor = true;
            medicos_Button.Click += medicos_Button_Click;
            // 
            // principal_panel
            // 
            principal_panel.Location = new Point(114, 29);
            principal_panel.Name = "principal_panel";
            principal_panel.Size = new Size(660, 420);
            principal_panel.TabIndex = 1;
            // 
            // Principal_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(principal_panel);
            Controls.Add(flowLayoutPanel1);
            Name = "Principal_form";
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button agendarCitas_button;
        private Panel principal_panel;
        private Button pacientes_button;
        private Button medicos_Button;
        private Button agendacitas_button;
    }
}
