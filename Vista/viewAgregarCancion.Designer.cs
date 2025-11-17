namespace Lista_de_canciones.Vista
{
    partial class viewAgregarCancion
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
            textBoxNombreCancion = new TextBox();
            textBoxAutor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonAgregarParte = new Button();
            textBoxCantidadCompases = new TextBox();
            textBoxNombreParte = new TextBox();
            label5 = new Label();
            label6 = new Label();
            groupBoxCreadorDePartes = new GroupBox();
            buttonEliminarParte = new Button();
            dataGridViewPartesCompases = new DataGridView();
            groupBoxCreadorDeCanciones = new GroupBox();
            buttonGuardarNombreCancion = new Button();
            btnCancelarAgregarCancion = new Button();
            groupBoxCreadorDePartes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPartesCompases).BeginInit();
            groupBoxCreadorDeCanciones.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxNombreCancion
            // 
            textBoxNombreCancion.Location = new Point(66, 27);
            textBoxNombreCancion.Name = "textBoxNombreCancion";
            textBoxNombreCancion.Size = new Size(157, 23);
            textBoxNombreCancion.TabIndex = 0;
            // 
            // textBoxAutor
            // 
            textBoxAutor.Location = new Point(66, 56);
            textBoxAutor.Name = "textBoxAutor";
            textBoxAutor.Size = new Size(157, 23);
            textBoxAutor.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 56);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 2;
            label1.Text = "Autor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 30);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(205, 41);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 4;
            // 
            // buttonAgregarParte
            // 
            buttonAgregarParte.Location = new Point(108, 104);
            buttonAgregarParte.Name = "buttonAgregarParte";
            buttonAgregarParte.Size = new Size(115, 23);
            buttonAgregarParte.TabIndex = 8;
            buttonAgregarParte.Text = "Agregar parte";
            buttonAgregarParte.UseVisualStyleBackColor = true;
            buttonAgregarParte.Click += buttonAgregarParte_Click;
            // 
            // textBoxCantidadCompases
            // 
            textBoxCantidadCompases.Location = new Point(140, 56);
            textBoxCantidadCompases.Name = "textBoxCantidadCompases";
            textBoxCantidadCompases.Size = new Size(83, 23);
            textBoxCantidadCompases.TabIndex = 15;
            // 
            // textBoxNombreParte
            // 
            textBoxNombreParte.Location = new Point(123, 27);
            textBoxNombreParte.Name = "textBoxNombreParte";
            textBoxNombreParte.Size = new Size(100, 23);
            textBoxNombreParte.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 59);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 13;
            label5.Text = "Cantidad de compases";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 30);
            label6.Name = "label6";
            label6.Size = new Size(109, 15);
            label6.TabIndex = 12;
            label6.Text = "Nombre de la parte";
            // 
            // groupBoxCreadorDePartes
            // 
            groupBoxCreadorDePartes.Controls.Add(textBoxNombreParte);
            groupBoxCreadorDePartes.Controls.Add(textBoxCantidadCompases);
            groupBoxCreadorDePartes.Controls.Add(label3);
            groupBoxCreadorDePartes.Controls.Add(buttonAgregarParte);
            groupBoxCreadorDePartes.Controls.Add(label5);
            groupBoxCreadorDePartes.Controls.Add(label6);
            groupBoxCreadorDePartes.Location = new Point(20, 171);
            groupBoxCreadorDePartes.Name = "groupBoxCreadorDePartes";
            groupBoxCreadorDePartes.Size = new Size(253, 143);
            groupBoxCreadorDePartes.TabIndex = 16;
            groupBoxCreadorDePartes.TabStop = false;
            groupBoxCreadorDePartes.Text = "Creador de partes";
            // 
            // buttonEliminarParte
            // 
            buttonEliminarParte.Location = new Point(571, 38);
            buttonEliminarParte.Name = "buttonEliminarParte";
            buttonEliminarParte.Size = new Size(75, 23);
            buttonEliminarParte.TabIndex = 24;
            buttonEliminarParte.Text = "Eliminar";
            buttonEliminarParte.UseVisualStyleBackColor = true;
            buttonEliminarParte.Click += buttonEliminarParte_Click;
            // 
            // dataGridViewPartesCompases
            // 
            dataGridViewPartesCompases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPartesCompases.Location = new Point(283, 26);
            dataGridViewPartesCompases.Name = "dataGridViewPartesCompases";
            dataGridViewPartesCompases.Size = new Size(266, 241);
            dataGridViewPartesCompases.TabIndex = 23;
            // 
            // groupBoxCreadorDeCanciones
            // 
            groupBoxCreadorDeCanciones.Controls.Add(buttonGuardarNombreCancion);
            groupBoxCreadorDeCanciones.Controls.Add(textBoxNombreCancion);
            groupBoxCreadorDeCanciones.Controls.Add(label2);
            groupBoxCreadorDeCanciones.Controls.Add(textBoxAutor);
            groupBoxCreadorDeCanciones.Controls.Add(label1);
            groupBoxCreadorDeCanciones.Location = new Point(20, 12);
            groupBoxCreadorDeCanciones.Name = "groupBoxCreadorDeCanciones";
            groupBoxCreadorDeCanciones.Size = new Size(253, 143);
            groupBoxCreadorDeCanciones.TabIndex = 21;
            groupBoxCreadorDeCanciones.TabStop = false;
            groupBoxCreadorDeCanciones.Text = "Canción";
            // 
            // buttonGuardarNombreCancion
            // 
            buttonGuardarNombreCancion.Location = new Point(148, 100);
            buttonGuardarNombreCancion.Name = "buttonGuardarNombreCancion";
            buttonGuardarNombreCancion.Size = new Size(75, 23);
            buttonGuardarNombreCancion.TabIndex = 4;
            buttonGuardarNombreCancion.Text = "Guardar";
            buttonGuardarNombreCancion.UseVisualStyleBackColor = true;
            buttonGuardarNombreCancion.Click += buttonGuardarNombreCancion_Click;
            // 
            // btnCancelarAgregarCancion
            // 
            btnCancelarAgregarCancion.Location = new Point(562, 307);
            btnCancelarAgregarCancion.Name = "btnCancelarAgregarCancion";
            btnCancelarAgregarCancion.Size = new Size(84, 32);
            btnCancelarAgregarCancion.TabIndex = 22;
            btnCancelarAgregarCancion.Text = "Volver";
            btnCancelarAgregarCancion.UseVisualStyleBackColor = true;
            btnCancelarAgregarCancion.Click += btnCancelarAgregarCancion_Click;
            // 
            // viewAgregarCancion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 351);
            Controls.Add(btnCancelarAgregarCancion);
            Controls.Add(dataGridViewPartesCompases);
            Controls.Add(groupBoxCreadorDeCanciones);
            Controls.Add(groupBoxCreadorDePartes);
            Controls.Add(buttonEliminarParte);
            Name = "viewAgregarCancion";
            Text = "viewAgregarCancion";
            Load += viewAgregarCancion_Load_1;
            groupBoxCreadorDePartes.ResumeLayout(false);
            groupBoxCreadorDePartes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPartesCompases).EndInit();
            groupBoxCreadorDeCanciones.ResumeLayout(false);
            groupBoxCreadorDeCanciones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxNombreCancion;
        private TextBox textBoxAutor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonAgregarParte;
        private TextBox textBoxCantidadCompases;
        private TextBox textBoxNombreParte;
        private Label label5;
        private Label label6;
        private GroupBox groupBoxCreadorDePartes;
        private GroupBox groupBoxCreadorDeCanciones;
        private Button btnCancelarAgregarCancion;
        private DataGridView dataGridViewPartesCompases;
        private Button buttonEliminarParte;
        private Button buttonGuardarNombreCancion;
    }
}