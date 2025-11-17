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
    public partial class viewPartes : Form
    {
        // Llamo a las intancias de las controllers necesarias

        controllerParte oControllerParte = controllerParte.GetControllerParte();


        // Atributos de la vista

        public int idCancion;


        // Constructor de la vista

        public viewPartes(int idCancionSeleccionada)
        {
            InitializeComponent();
            idCancion = idCancionSeleccionada;
        }


        // Eventos del load y los botones

        private void viewPartes_Load(object sender, EventArgs e)
        {
            cargarDataGridView();
            configurarDataGridView();
         
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAgregarAcordes_Click(object sender, EventArgs e)
        {
            if (dataGridViewPartes.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una parte.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else {
                int id = Convert.ToInt32(dataGridViewPartes.CurrentRow.Cells["id"].Value);
                var ventana = new viewAcordes(id);
                ventana.ShowDialog();
                configurarDataGridView();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            validarSeleccionNula();
            parte oParte = (parte)dataGridViewPartes.CurrentRow.DataBoundItem;
            var ventana = new viewEliminarParte(oParte);
            ventana.ShowDialog();
            cargarDataGridView();
            configurarDataGridView();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            validarSeleccionNula();
            parte oParte = (parte)dataGridViewPartes.CurrentRow.DataBoundItem;
            var ventana = new viewEliminarParte(oParte);
            ventana.ShowDialog();
            cargarDataGridView();
            configurarDataGridView();
        }

        private void buttonAgregarParte_Click(object sender, EventArgs e)
        {
            var ventana = new viewBotonAgregarParte(idCancion);
            ventana.ShowDialog();
            cargarDataGridView();
            configurarDataGridView();
        }


        // Métodos usados por los eventos y botones

        public void validarSeleccionNula() {

            if (dataGridViewPartes.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una parte.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        public void cargarDataGridView()
        {
            dataGridViewPartes.DataSource = null;
            List<parte> listaDePartes = oControllerParte.buscarPartesPorIdCancion(idCancion);
            dataGridViewPartes.DataSource = listaDePartes;
            dataGridViewPartes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void configurarDataGridView() {

            dataGridViewPartes.Columns["id"].Visible = false;
            dataGridViewPartes.AllowUserToResizeColumns = false;
            dataGridViewPartes.AllowUserToResizeRows = false;
            dataGridViewPartes.MultiSelect = false;
        }
    }
}
