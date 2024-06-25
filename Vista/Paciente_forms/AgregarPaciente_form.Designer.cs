namespace ConsultorioPrivado.Vista.Paciente_forms
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
            nombre_label = new Label();
            apellido_label = new Label();
            cedula_label = new Label();
            correo_label = new Label();
            telefono_label = new Label();
            cedula_textBox = new TextBox();
            nombre_textBox = new TextBox();
            apellido_textBox = new TextBox();
            correo_textBox = new TextBox();
            telefono_textBox = new TextBox();
            agregar_button = new Button();
            resetear_button = new Button();
            cancelar_button = new Button();
            SuspendLayout();
            // 
            // nombre_label
            // 
            nombre_label.AutoSize = true;
            nombre_label.Location = new Point(60, 70);
            nombre_label.Name = "nombre_label";
            nombre_label.Size = new Size(51, 15);
            nombre_label.TabIndex = 0;
            nombre_label.Text = "Nombre";
            // 
            // apellido_label
            // 
            apellido_label.AutoSize = true;
            apellido_label.Location = new Point(60, 112);
            apellido_label.Name = "apellido_label";
            apellido_label.Size = new Size(51, 15);
            apellido_label.TabIndex = 1;
            apellido_label.Text = "Apellido";
            // 
            // cedula_label
            // 
            cedula_label.AutoSize = true;
            cedula_label.Location = new Point(60, 28);
            cedula_label.Name = "cedula_label";
            cedula_label.Size = new Size(44, 15);
            cedula_label.TabIndex = 2;
            cedula_label.Text = "Cedula";
            // 
            // correo_label
            // 
            correo_label.AutoSize = true;
            correo_label.Location = new Point(60, 157);
            correo_label.Name = "correo_label";
            correo_label.Size = new Size(43, 15);
            correo_label.TabIndex = 3;
            correo_label.Text = "Correo";
            // 
            // telefono_label
            // 
            telefono_label.AutoSize = true;
            telefono_label.Location = new Point(60, 198);
            telefono_label.Name = "telefono_label";
            telefono_label.Size = new Size(51, 15);
            telefono_label.TabIndex = 4;
            telefono_label.Text = "telefono";
            // 
            // cedula_textBox
            // 
            cedula_textBox.Location = new Point(161, 25);
            cedula_textBox.Name = "cedula_textBox";
            cedula_textBox.Size = new Size(100, 23);
            cedula_textBox.TabIndex = 5;
            // 
            // nombre_textBox
            // 
            nombre_textBox.Location = new Point(161, 67);
            nombre_textBox.Name = "nombre_textBox";
            nombre_textBox.Size = new Size(100, 23);
            nombre_textBox.TabIndex = 6;
            // 
            // apellido_textBox
            // 
            apellido_textBox.Location = new Point(161, 109);
            apellido_textBox.Name = "apellido_textBox";
            apellido_textBox.Size = new Size(100, 23);
            apellido_textBox.TabIndex = 7;
            // 
            // correo_textBox
            // 
            correo_textBox.Location = new Point(161, 154);
            correo_textBox.Name = "correo_textBox";
            correo_textBox.Size = new Size(100, 23);
            correo_textBox.TabIndex = 8;
            // 
            // telefono_textBox
            // 
            telefono_textBox.Location = new Point(161, 195);
            telefono_textBox.Name = "telefono_textBox";
            telefono_textBox.Size = new Size(100, 23);
            telefono_textBox.TabIndex = 9;
            // 
            // agregar_button
            // 
            agregar_button.Location = new Point(53, 253);
            agregar_button.Name = "agregar_button";
            agregar_button.Size = new Size(75, 23);
            agregar_button.TabIndex = 10;
            agregar_button.Text = "Aceptar";
            agregar_button.UseVisualStyleBackColor = true;
            // 
            // resetear_button
            // 
            resetear_button.Location = new Point(161, 253);
            resetear_button.Name = "resetear_button";
            resetear_button.Size = new Size(75, 23);
            resetear_button.TabIndex = 11;
            resetear_button.Text = "Resetear";
            resetear_button.UseVisualStyleBackColor = true;
            // 
            // cancelar_button
            // 
            cancelar_button.Location = new Point(105, 298);
            cancelar_button.Name = "cancelar_button";
            cancelar_button.Size = new Size(75, 23);
            cancelar_button.TabIndex = 12;
            cancelar_button.Text = "Cancelar";
            cancelar_button.UseVisualStyleBackColor = true;
            // 
            // AgregarPaciente_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 370);
            Controls.Add(cancelar_button);
            Controls.Add(resetear_button);
            Controls.Add(agregar_button);
            Controls.Add(telefono_textBox);
            Controls.Add(correo_textBox);
            Controls.Add(apellido_textBox);
            Controls.Add(nombre_textBox);
            Controls.Add(cedula_textBox);
            Controls.Add(telefono_label);
            Controls.Add(correo_label);
            Controls.Add(cedula_label);
            Controls.Add(apellido_label);
            Controls.Add(nombre_label);
            Name = "AgregarPaciente_form";
            Text = "AgregarPaciente_form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nombre_label;
        private Label apellido_label;
        private Label cedula_label;
        private Label correo_label;
        private Label telefono_label;
        private TextBox cedula_textBox;
        private TextBox nombre_textBox;
        private TextBox apellido_textBox;
        private TextBox correo_textBox;
        private TextBox telefono_textBox;
        private Button agregar_button;
        private Button resetear_button;
        private Button cancelar_button;
    }
}