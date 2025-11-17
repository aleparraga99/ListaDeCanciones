namespace Lista_de_canciones
{
    partial class viewInicio
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
            dataGridViewCanciones = new DataGridView();
            labelInicio = new Label();
            btnAgregarCancion = new Button();
            btnEliminarCancion = new Button();
            btnModificarCancion = new Button();
            buttonPartesYAcordes = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCanciones).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCanciones
            // 
            dataGridViewCanciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCanciones.Location = new Point(24, 80);
            dataGridViewCanciones.Name = "dataGridViewCanciones";
            dataGridViewCanciones.Size = new Size(410, 153);
            dataGridViewCanciones.TabIndex = 0;
            // 
            // labelInicio
            // 
            labelInicio.AutoSize = true;
            labelInicio.Location = new Point(177, 35);
            labelInicio.Name = "labelInicio";
            labelInicio.Size = new Size(103, 15);
            labelInicio.TabIndex = 1;
            labelInicio.Text = "Lista de canciones";
            // 
            // btnAgregarCancion
            // 
            btnAgregarCancion.Location = new Point(152, 262);
            btnAgregarCancion.Name = "btnAgregarCancion";
            btnAgregarCancion.Size = new Size(128, 39);
            btnAgregarCancion.TabIndex = 2;
            btnAgregarCancion.Text = "Agregar cancion";
            btnAgregarCancion.UseVisualStyleBackColor = true;
            btnAgregarCancion.Click += btnAgregarCancion_Click;
            // 
            // btnEliminarCancion
            // 
            btnEliminarCancion.Location = new Point(483, 137);
            btnEliminarCancion.Name = "btnEliminarCancion";
            btnEliminarCancion.Size = new Size(75, 23);
            btnEliminarCancion.TabIndex = 3;
            btnEliminarCancion.Text = "Eliminar";
            btnEliminarCancion.UseVisualStyleBackColor = true;
            btnEliminarCancion.Click += btnEliminarCancion_Click;
            // 
            // btnModificarCancion
            // 
            btnModificarCancion.Location = new Point(483, 95);
            btnModificarCancion.Name = "btnModificarCancion";
            btnModificarCancion.Size = new Size(75, 23);
            btnModificarCancion.TabIndex = 4;
            btnModificarCancion.Text = "Modificar";
            btnModificarCancion.UseVisualStyleBackColor = true;
            btnModificarCancion.Click += btnModificarCancion_Click;
            // 
            // buttonPartesYAcordes
            // 
            buttonPartesYAcordes.Location = new Point(462, 181);
            buttonPartesYAcordes.Name = "buttonPartesYAcordes";
            buttonPartesYAcordes.Size = new Size(130, 23);
            buttonPartesYAcordes.TabIndex = 5;
            buttonPartesYAcordes.Text = "Partes y acordes";
            buttonPartesYAcordes.UseVisualStyleBackColor = true;
            buttonPartesYAcordes.Click += buttonPartesYAcordes_Click;
            // 
            // viewInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 330);
            Controls.Add(buttonPartesYAcordes);
            Controls.Add(btnModificarCancion);
            Controls.Add(btnEliminarCancion);
            Controls.Add(btnAgregarCancion);
            Controls.Add(labelInicio);
            Controls.Add(dataGridViewCanciones);
            Name = "viewInicio";
            Text = "Form1";
            Load += viewInicio_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCanciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCanciones;
        private Label labelInicio;
        private Button btnAgregarCancion;
        private Button btnEliminarCancion;
        private Button btnModificarCancion;
        private Button buttonPartesYAcordes;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
