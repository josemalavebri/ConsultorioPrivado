namespace ConsultorioPrivado.Vista.Paciente
{
    partial class add_Paciente_form
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
            cancelar_button = new Button();
            telefono_textBox = new TextBox();
            telefono_label = new Label();
            resetear_button = new Button();
            agregar_button = new Button();
            correo_textBox = new TextBox();
            cedula_textBox = new TextBox();
            apellido_textBox = new TextBox();
            nombre_textBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // cancelar_button
            // 
            cancelar_button.Location = new Point(213, 361);
            cancelar_button.Margin = new Padding(3, 4, 3, 4);
            cancelar_button.Name = "cancelar_button";
            cancelar_button.Size = new Size(86, 31);
            cancelar_button.TabIndex = 29;
            cancelar_button.Text = "Cancelar";
            cancelar_button.UseVisualStyleBackColor = true;
            cancelar_button.Click += cancelar_button_Click;
            // 
            // telefono_textBox
            // 
            telefono_textBox.Location = new Point(249, 240);
            telefono_textBox.Margin = new Padding(3, 4, 3, 4);
            telefono_textBox.Name = "telefono_textBox";
            telefono_textBox.Size = new Size(114, 27);
            telefono_textBox.TabIndex = 26;
            // 
            // telefono_label
            // 
            telefono_label.AutoSize = true;
            telefono_label.Location = new Point(129, 240);
            telefono_label.Name = "telefono_label";
            telefono_label.Size = new Size(67, 20);
            telefono_label.TabIndex = 25;
            telefono_label.Text = "Telefono";
            // 
            // resetear_button
            // 
            resetear_button.Location = new Point(262, 309);
            resetear_button.Margin = new Padding(3, 4, 3, 4);
            resetear_button.Name = "resetear_button";
            resetear_button.Size = new Size(86, 31);
            resetear_button.TabIndex = 24;
            resetear_button.Text = "Resetear";
            resetear_button.UseVisualStyleBackColor = true;
            // 
            // agregar_button
            // 
            agregar_button.Location = new Point(145, 309);
            agregar_button.Margin = new Padding(3, 4, 3, 4);
            agregar_button.Name = "agregar_button";
            agregar_button.Size = new Size(86, 31);
            agregar_button.TabIndex = 23;
            agregar_button.Text = "Aceptar";
            agregar_button.UseVisualStyleBackColor = true;
            // 
            // correo_textBox
            // 
            correo_textBox.Location = new Point(249, 184);
            correo_textBox.Margin = new Padding(3, 4, 3, 4);
            correo_textBox.Name = "correo_textBox";
            correo_textBox.Size = new Size(114, 27);
            correo_textBox.TabIndex = 22;
            // 
            // cedula_textBox
            // 
            cedula_textBox.Location = new Point(249, 139);
            cedula_textBox.Margin = new Padding(3, 4, 3, 4);
            cedula_textBox.Name = "cedula_textBox";
            cedula_textBox.Size = new Size(114, 27);
            cedula_textBox.TabIndex = 21;
            // 
            // apellido_textBox
            // 
            apellido_textBox.Location = new Point(249, 95);
            apellido_textBox.Margin = new Padding(3, 4, 3, 4);
            apellido_textBox.Name = "apellido_textBox";
            apellido_textBox.Size = new Size(114, 27);
            apellido_textBox.TabIndex = 20;
            // 
            // nombre_textBox
            // 
            nombre_textBox.Location = new Point(249, 43);
            nombre_textBox.Margin = new Padding(3, 4, 3, 4);
            nombre_textBox.Name = "nombre_textBox";
            nombre_textBox.Size = new Size(114, 27);
            nombre_textBox.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(129, 184);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 18;
            label4.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 139);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 17;
            label3.Text = "Cedula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 95);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 16;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 43);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 15;
            label1.Text = "Nombre";
            // 
            // add_Paciente_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 441);
            Controls.Add(cancelar_button);
            Controls.Add(telefono_textBox);
            Controls.Add(telefono_label);
            Controls.Add(resetear_button);
            Controls.Add(agregar_button);
            Controls.Add(correo_textBox);
            Controls.Add(cedula_textBox);
            Controls.Add(apellido_textBox);
            Controls.Add(nombre_textBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "add_Paciente_form";
            Text = "Añadir Paciente";
            Load += add_Paciente_form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelar_button;
        private TextBox telefono_textBox;
        private Label telefono_label;
        private Button resetear_button;
        private Button agregar_button;
        private TextBox correo_textBox;
        private TextBox cedula_textBox;
        private TextBox apellido_textBox;
        private TextBox nombre_textBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}