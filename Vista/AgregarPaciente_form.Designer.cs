﻿namespace ConsultorioPrivado.Vista
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
            agregar_button = new Button();
            resetear_button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 21);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 60);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 100);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Cedula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 141);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Correo";
            // 
            // nombre_text
            // 
            nombre_text.Location = new Point(138, 21);
            nombre_text.Name = "nombre_text";
            nombre_text.Size = new Size(100, 23);
            nombre_text.TabIndex = 4;
            // 
            // apellido_text
            // 
            apellido_text.Location = new Point(138, 60);
            apellido_text.Name = "apellido_text";
            apellido_text.Size = new Size(100, 23);
            apellido_text.TabIndex = 5;
            // 
            // cedula_text
            // 
            cedula_text.Location = new Point(138, 100);
            cedula_text.Name = "cedula_text";
            cedula_text.Size = new Size(100, 23);
            cedula_text.TabIndex = 6;
            // 
            // correoText
            // 
            correoText.Location = new Point(138, 141);
            correoText.Name = "correoText";
            correoText.Size = new Size(100, 23);
            correoText.TabIndex = 7;
            // 
            // agregar_button
            // 
            agregar_button.Location = new Point(51, 190);
            agregar_button.Name = "agregar_button";
            agregar_button.Size = new Size(75, 23);
            agregar_button.TabIndex = 8;
            agregar_button.Text = "Agregar";
            agregar_button.UseVisualStyleBackColor = true;
            agregar_button.Click += agregar_button_Click;
            // 
            // resetear_button
            // 
            resetear_button.Location = new Point(149, 190);
            resetear_button.Name = "resetear_button";
            resetear_button.Size = new Size(75, 23);
            resetear_button.TabIndex = 9;
            resetear_button.Text = "Resetear";
            resetear_button.UseVisualStyleBackColor = true;
            resetear_button.Click += button1_Click;
            // 
            // AgregarPaciente_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 290);
            Controls.Add(resetear_button);
            Controls.Add(agregar_button);
            Controls.Add(correoText);
            Controls.Add(cedula_text);
            Controls.Add(apellido_text);
            Controls.Add(nombre_text);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarPaciente_form";
            Text = "AgregarPaciente_form";
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
        private Button agregar_button;
        private Button resetear_button;
    }
}