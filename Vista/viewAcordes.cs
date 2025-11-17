using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lista_de_canciones.Controller;
using Lista_de_canciones.Model;

namespace Lista_de_canciones.Vista
{
    public partial class viewAcordes : Form
    {
        // Se llaman a las instancias de las controllers necesarias

        controllerAcorde oControllerAcorde = controllerAcorde.GetControllerAcorde();
        controllerCompas_acorde oControllerCompas_Acorde = controllerCompas_acorde.GetControllerCompas_acorde();
        controllerCompas oControllerCompas = controllerCompas.GetControllerCompas();


        // Atributos de la vista

        private int idGeneradoAcorde;
        private int idParteSeleccionada;


        // Constructor de la vista

        public viewAcordes(int id)
        {
            InitializeComponent();
            idParteSeleccionada = id;
        }


        // Eventos del load y los botones

        private void viewAcordes_Load(object sender, EventArgs e)
        {
            cargarComboBoxCompases();
            cargarDataGridView();
            configurarDataGridView();
           
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (!validarComboBoxesNulos()) {

                return;
            }
            capturarAcorde();
            insertarCompas_acordes();
            cargarDataGridView();
            configurarDataGridView();
        }


        // Métodos usados por los eventos

        public void configurarDataGridView()
        {

            dataGridViewCompasAcorde.MultiSelect = false;
            dataGridViewCompasAcorde.AllowUserToResizeColumns = false;
            dataGridViewCompasAcorde.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void insertarCompas_acordes()
        {
            oControllerCompas_Acorde.crear(idGeneradoAcorde, idParteSeleccionada);
        }
        public void cargarComboBoxCompases()
        {
           
            List<int> numerosDeCompases = oControllerCompas.buscarNumerosDeCompases(idParteSeleccionada);
            comboBoxCompases.DataSource = numerosDeCompases;
        }
        public void capturarAcorde()
        {
            string tonica = comboBoxTonica.SelectedItem.ToString();
            string modo = comboBoxModo.SelectedItem.ToString();
            string extension = comboBoxExtension.SelectedItem.ToString();
            string bajo = comboBoxBajo.SelectedItem.ToString();

            idGeneradoAcorde = oControllerAcorde.crear(tonica, modo, extension, bajo);
        }

        public void cargarDataGridView()
        {

            List<compas> compases = oControllerCompas.buscarCompasesYacordes(idParteSeleccionada);

            // Debería de desarmar los acordes para mostrarlos como una concatenación de strings
            dataGridViewCompasAcorde.DataSource = compases;
            dataGridViewCompasAcorde.Columns["id"].Visible = false;
        }
        private void buttonVolver_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        public bool validarComboBoxesNulos() {

            if (comboBoxCompases.SelectedIndex == -1 || comboBoxTonica.SelectedIndex == -1 || comboBoxModo.SelectedIndex == -1 || comboBoxExtension.SelectedIndex == -1 || comboBoxBajo.SelectedIndex == -1) {
                MessageBox.Show("Debe elegir compás y acorde completo", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        
        
            
        }
    }
}

