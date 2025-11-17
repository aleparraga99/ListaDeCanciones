namespace Lista_de_canciones.Vista
{
    partial class viewModificarNombreAutor
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
            buttonVolver = new Button();
            buttonGuardar = new Button();
            textBoxNombre = new TextBox();
            textBoxAutor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonVolver
            // 
            buttonVolver.Location = new Point(186, 120);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(82, 40);
            buttonVolver.TabIndex = 0;
            buttonVolver.Text = "Cancelar";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(35, 120);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(87, 40);
            buttonGuardar.TabIndex = 1;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(121, 61);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(137, 23);
            textBoxNombre.TabIndex = 2;
            // 
            // textBoxAutor
            // 
            textBoxAutor.Location = new Point(121, 24);
            textBoxAutor.Name = "textBoxAutor";
            textBoxAutor.Size = new Size(137, 23);
            textBoxAutor.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 24);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 4;
            label1.Text = "Autor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 64);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // viewModificarNombreAutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 187);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxAutor);
            Controls.Add(textBoxNombre);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonVolver);
            Name = "viewModificarNombreAutor";
            Text = "viewModificarNombreAutor";
            Load += viewModificarNombreAutor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonVolver;
        private Button buttonGuardar;
        private TextBox textBoxNombre;
        private TextBox textBoxAutor;
        private Label label1;
        private Label label2;
    }
}