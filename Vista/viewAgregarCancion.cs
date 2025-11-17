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
using Microsoft.Identity.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lista_de_canciones.Vista
{
    public partial class viewAgregarCancion : Form
    {
        // Llamo a las instancias de la controllers usadas

        controllerAcorde oControllerAcorde = controllerAcorde.GetControllerAcorde();
        controllerParte oControllerParte = controllerParte.GetControllerParte();
        controllerCancion oControllerCancion = controllerCancion.GetControllerCancion();
        controllerCompas oControllerCompas = controllerCompas.GetControllerCompas();
        controllerParte_compas oControllerParte_Compas = controllerParte_compas.GetControllerParte_Compas();
        controllerCancion_parte oControllerCancion_parte = controllerCancion_parte.GetControllerParte_Compas();


        // Atributos de la vista

        private int idCancionActual;
        private int idGeneradoParte;


        // Constructor de la vista

        public viewAgregarCancion()
        {
            InitializeComponent();
        }


        // Eventos del load y de los botones

        private void viewAgregarCancion_Load_1(object sender, EventArgs e)
        {
            groupBoxCreadorDePartes.Enabled = false;
            dataGridViewPartesCompases.DataSource = null;
            configurarDataGridView();
            buttonEliminarParte.Enabled = false;

        }

        private void buttonGuardarNombreCancion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAutor.Text) || string.IsNullOrWhiteSpace(textBoxNombreCancion.Text))
            {
                MessageBox.Show("Debe completar ambos campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            guardarNombreYAutor();
            groupBoxCreadorDePartes.Enabled = true;
            actualizarDataGridView();
            bloquearBotonYTextBoxs();
        }

        private void buttonAgregarParte_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxCantidadCompases.Text, out int valor))
            {
                agregarParte();
                actualizarDataGridView();
                buttonEliminarParte.Enabled = true;
                vaciarTextBoxs();
            }
            else
            {
                MessageBox.Show("La cantidad de compases debe ser un número entero.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
        private void buttonEliminarParte_Click(object sender, EventArgs e)
        {
            parte oParte = (parte)dataGridViewPartesCompases.CurrentRow.DataBoundItem;
            var ventana = new viewEliminarParte(oParte);
            ventana.ShowDialog();
            actualizarDataGridView();
        }
        private void btnCancelarAgregarCancion_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Métodos usados de los eventos

        public void vaciarTextBoxs() {
            textBoxCantidadCompases.Text = "";
            textBoxNombreParte.Text = "";
        }
        public void bloquearBotonYTextBoxs() {

            buttonGuardarNombreCancion.Enabled = false;
            textBoxAutor.ReadOnly = true;
            textBoxNombreCancion.ReadOnly = true;
        }
        public void guardarNombreYAutor()
        {
            string autor = textBoxAutor.Text.Trim();
            string nombre = textBoxNombreCancion.Text.Trim();

            idCancionActual = oControllerCancion.crear(autor, nombre);

        }

        public void cargarParte_Compas(List<int> idsCompases)
        {

            for (var i = 0; i < idsCompases.Count; i++) // Se crean los elementos parte_compas en la tabla relacional
            {
                oControllerParte_Compas.crear(idGeneradoParte, idsCompases[i]);
            }
        }
        public void cargarCompases()
        {

            int cantidadCompases = int.Parse(textBoxCantidadCompases.Text);

            List<int> idsCompases = new List<int>();

            for (var i = 0; i < cantidadCompases; i++) // Se crean los objetos de compas dependiendo la cantidad de compases
            {
                int numero = i + 1;
                var aux2 = oControllerCompas.crear(numero); // Este metodo devuelve el id generado en la BBDD
                int idGeneradoCompas = aux2;
                idsCompases.Add(idGeneradoCompas);
            }

            cargarParte_Compas(idsCompases);

        }

        public void capturarParteYCompases()
        {

            string nombreParte = textBoxNombreParte.Text;
            int cantidadCompases = int.Parse(textBoxCantidadCompases.Text);

            idGeneradoParte = oControllerParte.crear(nombreParte, cantidadCompases); // Se crea el objeto parte en la BBDD y se devuelve el id

        }

        public void agregarParte()
        {

            capturarParteYCompases();
            oControllerCancion_parte.crear(idCancionActual, idGeneradoParte);    // Crear registro de cancion_parte en la tabla relacional
            cargarCompases(); // Se crean los compases ingresados

        }

        public void actualizarDataGridView()
        {
            dataGridViewPartesCompases.DataSource = null;
            List<parte> listaDePartes = oControllerParte.buscarPartesPorIdCancion(idCancionActual);
            dataGridViewPartesCompases.DataSource = listaDePartes;
            dataGridViewPartesCompases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void configurarDataGridView(){

            dataGridViewPartesCompases.MultiSelect = false;
            dataGridViewPartesCompases.AllowUserToResizeColumns = false;
            dataGridViewPartesCompases.AllowUserToResizeRows = false;
          
        }


    }
}
