namespace Lista_de_canciones.Vista
{
    partial class viewPartes
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
            dataGridViewPartes = new DataGridView();
            buttonCancelar = new Button();
            buttonEliminar = new Button();
            buttonAgregarAcordes = new Button();
            buttonAgregarParte = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPartes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewPartes
            // 
            dataGridViewPartes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPartes.Location = new Point(20, 28);
            dataGridViewPartes.Name = "dataGridViewPartes";
            dataGridViewPartes.Size = new Size(240, 177);
            dataGridViewPartes.TabIndex = 0;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(278, 295);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(102, 38);
            buttonCancelar.TabIndex = 1;
            buttonCancelar.Text = "Volver";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(281, 69);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(75, 23);
            buttonEliminar.TabIndex = 4;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonAgregarAcordes
            // 
            buttonAgregarAcordes.Location = new Point(96, 220);
            buttonAgregarAcordes.Name = "buttonAgregarAcordes";
            buttonAgregarAcordes.Size = new Size(106, 34);
            buttonAgregarAcordes.TabIndex = 5;
            buttonAgregarAcordes.Text = "Agregar acordes";
            buttonAgregarAcordes.UseVisualStyleBackColor = true;
            buttonAgregarAcordes.Click += buttonAgregarAcordes_Click;
            // 
            // buttonAgregarParte
            // 
            buttonAgregarParte.Location = new Point(281, 28);
            buttonAgregarParte.Name = "buttonAgregarParte";
            buttonAgregarParte.Size = new Size(75, 23);
            buttonAgregarParte.TabIndex = 6;
            buttonAgregarParte.Text = "Agregar";
            buttonAgregarParte.UseVisualStyleBackColor = true;
            buttonAgregarParte.Click += buttonAgregarParte_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewPartes);
            groupBox1.Controls.Add(buttonAgregarAcordes);
            groupBox1.Controls.Add(buttonAgregarParte);
            groupBox1.Controls.Add(buttonEliminar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 277);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Partes de la canción";
            // 
            // viewPartes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 355);
            Controls.Add(groupBox1);
            Controls.Add(buttonCancelar);
            Name = "viewPartes";
            Text = "viewPartes";
            Load += viewPartes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPartes).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPartes;
        private Button buttonCancelar;
        private Button buttonEliminar;
        private Button buttonAgregarAcordes;
        private Button buttonAgregarParte;
        private GroupBox groupBox1;
    }
}