namespace Lista_de_canciones.Vista
{
    partial class viewEliminarParte
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
            buttonEliminar = new Button();
            buttonCancelar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(99, 87);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(75, 23);
            buttonEliminar.TabIndex = 0;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(257, 87);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 1;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 26);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 2;
            label1.Text = "¿Eliminar parte?";
            // 
            // viewEliminarParte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 144);
            Controls.Add(label1);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonEliminar);
            Name = "viewEliminarParte";
            Text = "viewEliminarParte";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEliminar;
        private Button buttonCancelar;
        private Label label1;
    }
}