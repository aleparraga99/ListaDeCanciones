namespace Lista_de_canciones.Vista
{
    partial class viewEliminarConfirmacion
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
            buttonEliminarSi = new Button();
            buttonEliminarNo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 31);
            label1.Name = "label1";
            label1.Size = new Size(203, 15);
            label1.TabIndex = 0;
            label1.Text = "¿Desea eliminar la canción de la lista?";
            // 
            // buttonEliminarSi
            // 
            buttonEliminarSi.Location = new Point(53, 73);
            buttonEliminarSi.Name = "buttonEliminarSi";
            buttonEliminarSi.Size = new Size(75, 23);
            buttonEliminarSi.TabIndex = 1;
            buttonEliminarSi.Text = "Eliminar";
            buttonEliminarSi.UseVisualStyleBackColor = true;
            buttonEliminarSi.Click += buttonEliminarSi_Click;
            // 
            // buttonEliminarNo
            // 
            buttonEliminarNo.Location = new Point(193, 73);
            buttonEliminarNo.Name = "buttonEliminarNo";
            buttonEliminarNo.Size = new Size(68, 26);
            buttonEliminarNo.TabIndex = 2;
            buttonEliminarNo.Text = "Cancelar";
            buttonEliminarNo.UseVisualStyleBackColor = true;
            buttonEliminarNo.Click += buttonEliminarNo_Click;
            // 
            // viewEliminarConfirmacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 130);
            Controls.Add(buttonEliminarNo);
            Controls.Add(buttonEliminarSi);
            Controls.Add(label1);
            Name = "viewEliminarConfirmacion";
            Text = "viewEliminarConfirmacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonEliminarSi;
        private Button buttonEliminarNo;
    }
}