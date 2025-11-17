namespace Lista_de_canciones.Vista
{
    partial class viewAcordes
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
            dataGridViewCompasAcorde = new DataGridView();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            comboBoxBajo = new ComboBox();
            comboBoxExtension = new ComboBox();
            comboBoxModo = new ComboBox();
            comboBoxTonica = new ComboBox();
            label7 = new Label();
            comboBoxCompases = new ComboBox();
            btnGuardar = new Button();
            groupBox1 = new GroupBox();
            buttonVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompasAcorde).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewCompasAcorde
            // 
            dataGridViewCompasAcorde.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCompasAcorde.Location = new Point(290, 12);
            dataGridViewCompasAcorde.Name = "dataGridViewCompasAcorde";
            dataGridViewCompasAcorde.Size = new Size(205, 164);
            dataGridViewCompasAcorde.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(179, 24);
            label11.Name = "label11";
            label11.Size = new Size(30, 15);
            label11.TabIndex = 27;
            label11.Text = "Bajo";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(115, 24);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 26;
            label10.Text = "Extensión";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(62, 24);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 25;
            label9.Text = "Modo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 24);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 24;
            label8.Text = "Tónica";
            // 
            // comboBoxBajo
            // 
            comboBoxBajo.FormattingEnabled = true;
            comboBoxBajo.Items.AddRange(new object[] { "-", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" });
            comboBoxBajo.Location = new Point(179, 42);
            comboBoxBajo.Name = "comboBoxBajo";
            comboBoxBajo.Size = new Size(40, 23);
            comboBoxBajo.TabIndex = 23;
            // 
            // comboBoxExtension
            // 
            comboBoxExtension.FormattingEnabled = true;
            comboBoxExtension.Items.AddRange(new object[] { "-", "4", "5", "6", "7", "9", "11", "13" });
            comboBoxExtension.Location = new Point(120, 42);
            comboBoxExtension.Name = "comboBoxExtension";
            comboBoxExtension.Size = new Size(44, 23);
            comboBoxExtension.TabIndex = 22;
            // 
            // comboBoxModo
            // 
            comboBoxModo.FormattingEnabled = true;
            comboBoxModo.Items.AddRange(new object[] { "M", "m", "maj", "dis", "5" });
            comboBoxModo.Location = new Point(62, 42);
            comboBoxModo.Name = "comboBoxModo";
            comboBoxModo.Size = new Size(44, 23);
            comboBoxModo.TabIndex = 21;
            // 
            // comboBoxTonica
            // 
            comboBoxTonica.FormattingEnabled = true;
            comboBoxTonica.Items.AddRange(new object[] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" });
            comboBoxTonica.Location = new Point(5, 42);
            comboBoxTonica.Name = "comboBoxTonica";
            comboBoxTonica.Size = new Size(45, 23);
            comboBoxTonica.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(62, 28);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 19;
            label7.Text = "Compás";
            // 
            // comboBoxCompases
            // 
            comboBoxCompases.FormattingEnabled = true;
            comboBoxCompases.Location = new Point(119, 25);
            comboBoxCompases.Name = "comboBoxCompases";
            comboBoxCompases.Size = new Size(60, 23);
            comboBoxCompases.TabIndex = 18;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(64, 81);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(124, 23);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(comboBoxTonica);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(comboBoxModo);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(comboBoxExtension);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(comboBoxBajo);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(31, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(235, 108);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acorde";
            // 
            // buttonVolver
            // 
            buttonVolver.Location = new Point(361, 195);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(75, 23);
            buttonVolver.TabIndex = 29;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // viewAcordes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 242);
            Controls.Add(buttonVolver);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Controls.Add(comboBoxCompases);
            Controls.Add(dataGridViewCompasAcorde);
            Name = "viewAcordes";
            Text = "viewAcordes";
            Load += viewAcordes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompasAcorde).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewCompasAcorde;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private ComboBox comboBoxBajo;
        private ComboBox comboBoxExtension;
        private ComboBox comboBoxModo;
        private ComboBox comboBoxTonica;
        private Label label7;
        private ComboBox comboBoxCompases;
        private Button btnGuardar;
        private GroupBox groupBox1;
        private Button buttonVolver;
    }
}