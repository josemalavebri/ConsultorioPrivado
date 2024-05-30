namespace ConsultorioPrivado.Vista
{
    partial class AgregarPaciente_form
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
            label4 = new Label();
            nombre_text = new TextBox();
            apellido_text = new TextBox();
            cedula_text = new TextBox();
            correoText = new TextBox();
            aceptar_button = new Button();
            cancelar_button = new Button();
            telefono_text = new TextBox();
            label5 = new Label();
            resetear_button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 109);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Cedula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 150);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Correo";
            // 
            // nombre_text
            // 
            nombre_text.Location = new Point(117, 30);
            nombre_text.Name = "nombre_text";
            nombre_text.Size = new Size(100, 23);
            nombre_text.TabIndex = 4;
            // 
            // apellido_text
            // 
            apellido_text.Location = new Point(117, 69);
            apellido_text.Name = "apellido_text";
            apellido_text.Size = new Size(100, 23);
            apellido_text.TabIndex = 5;
            // 
            // cedula_text
            // 
            cedula_text.Location = new Point(117, 109);
            cedula_text.Name = "cedula_text";
            cedula_text.Size = new Size(100, 23);
            cedula_text.TabIndex = 6;
            // 
            // correoText
            // 
            correoText.Location = new Point(117, 150);
            correoText.Name = "correoText";
            correoText.Size = new Size(100, 23);
            correoText.TabIndex = 7;
            // 
            // aceptar_button
            // 
            aceptar_button.Location = new Point(30, 238);
            aceptar_button.Name = "aceptar_button";
            aceptar_button.Size = new Size(75, 23);
            aceptar_button.TabIndex = 8;
            aceptar_button.Text = "Aceptar";
            aceptar_button.UseVisualStyleBackColor = true;
            aceptar_button.Click += agregar_button_Click;
            // 
            // cancelar_button
            // 
            cancelar_button.Location = new Point(90, 280);
            cancelar_button.Name = "cancelar_button";
            cancelar_button.Size = new Size(75, 23);
            cancelar_button.TabIndex = 10;
            cancelar_button.Text = "Cancelar";
            cancelar_button.UseVisualStyleBackColor = true;
            cancelar_button.Click += cancelar_button_Click;
            // 
            // telefono_text
            // 
            telefono_text.Location = new Point(117, 190);
            telefono_text.Name = "telefono_text";
            telefono_text.Size = new Size(100, 23);
            telefono_text.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 190);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 12;
            label5.Text = "Telefono";
            // 
            // resetear_button
            // 
            resetear_button.Enabled = false;
            resetear_button.Location = new Point(127, 238);
            resetear_button.Name = "resetear_button";
            resetear_button.Size = new Size(75, 23);
            resetear_button.TabIndex = 15;
            resetear_button.Text = "Resetear";
            resetear_button.UseVisualStyleBackColor = true;
            resetear_button.Click += resetear_button_Click;
            // 
            // AgregarPaciente_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 355);
            Controls.Add(resetear_button);
            Controls.Add(telefono_text);
            Controls.Add(label5);
            Controls.Add(cancelar_button);
            Controls.Add(aceptar_button);
            Controls.Add(correoText);
            Controls.Add(cedula_text);
            Controls.Add(apellido_text);
            Controls.Add(nombre_text);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarPaciente_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarPaciente_form";
            Load += AgregarPaciente_form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nombre_text;
        private TextBox apellido_text;
        private TextBox cedula_text;
        private TextBox correoText;
        private Button aceptar_button;
        private Button cancelar_button;
        private TextBox telefono_text;
        private Label label5;
        private Button resetear_button;
    }
}