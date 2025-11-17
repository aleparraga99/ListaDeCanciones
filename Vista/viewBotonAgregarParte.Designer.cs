namespace Lista_de_canciones.Vista
{
    partial class viewBotonAgregarParte
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
            textBoxNombreParte = new TextBox();
            textBoxCantidadCompases = new TextBox();
            label3 = new Label();
            buttonAgregarParte = new Button();
            label5 = new Label();
            label6 = new Label();
            buttonVolver = new Button();
            SuspendLayout();
            // 
            // textBoxNombreParte
            // 
            textBoxNombreParte.Location = new Point(127, 12);
            textBoxNombreParte.Name = "textBoxNombreParte";
            textBoxNombreParte.Size = new Size(100, 23);
            textBoxNombreParte.TabIndex = 14;
            // 
            // textBoxCantidadCompases
            // 
            textBoxCantidadCompases.Location = new Point(144, 41);
            textBoxCantidadCompases.Name = "textBoxCantidadCompases";
            textBoxCantidadCompases.Size = new Size(83, 23);
            textBoxCantidadCompases.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(209, 26);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 4;
            // 
            // buttonAgregarParte
            // 
            buttonAgregarParte.Location = new Point(144, 87);
            buttonAgregarParte.Name = "buttonAgregarParte";
            buttonAgregarParte.Size = new Size(83, 23);
            buttonAgregarParte.TabIndex = 8;
            buttonAgregarParte.Text = "Agregar parte";
            buttonAgregarParte.UseVisualStyleBackColor = true;
            buttonAgregarParte.Click += buttonAgregarParte_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 44);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 13;
            label5.Text = "Cantidad de compases";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 15);
            label6.Name = "label6";
            label6.Size = new Size(109, 15);
            label6.TabIndex = 12;
            label6.Text = "Nombre de la parte";
            // 
            // buttonVolver
            // 
            buttonVolver.Location = new Point(12, 87);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(75, 23);
            buttonVolver.TabIndex = 16;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // viewBotonAgregarParte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 137);
            Controls.Add(buttonVolver);
            Controls.Add(textBoxNombreParte);
            Controls.Add(textBoxCantidadCompases);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(buttonAgregarParte);
            Controls.Add(label5);
            Name = "viewBotonAgregarParte";
            Text = "viewBotonAgregarParte";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNombreParte;
        private TextBox textBoxCantidadCompases;
        private Label label3;
        private Button buttonAgregarParte;
        private Label label5;
        private Label label6;
        private Button buttonVolver;
    }
}