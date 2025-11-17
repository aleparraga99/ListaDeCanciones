using Lista_de_canciones.Controller;
using Lista_de_canciones.Vista;
using Lista_de_canciones.Model;
using System.Windows.Forms;

namespace Lista_de_canciones
{
    public partial class viewInicio : Form
    {
        // Llamo a una instancia de la controller de cancion

        controllerCancion oControllerCancion = controllerCancion.GetControllerCancion();


        // Constructor de la vista
        public viewInicio()
        {
            InitializeComponent();
        }


        // Eventos del load y botones

        private void viewInicio_Load(object sender, EventArgs e)
        {
            cargarDataGridView();
            dataGridViewCanciones.MultiSelect = false;
            dataGridViewCanciones.AllowUserToResizeColumns = false;
        }

        private void btnAgregarCancion_Click(object sender, EventArgs e)
        {
            var ventana = new viewAgregarCancion();
            ventana.ShowDialog();
            cargarDataGridView();
            
        }

        private void btnModificarCancion_Click(object sender, EventArgs e)
        {
            if (!validarSeleccionNula())
            {
                return;
            }
            cancion cancionParaModificar = capturarNombreAutorIdCancion();
            var ventana = new viewModificarNombreAutor(cancionParaModificar);
            ventana.ShowDialog();
            cargarDataGridView();

            }
        

        private void btnEliminarCancion_Click(object sender, EventArgs e)
        {
            if (!validarSeleccionNula())
            {
                return;
            }

            int id = Convert.ToInt32(dataGridViewCanciones.CurrentRow.Cells["id"].Value);
            var ventana = new viewEliminarConfirmacion(id);
            ventana.ShowDialog();
            cargarDataGridView();
        }

        private void buttonPartesYAcordes_Click(object sender, EventArgs e)
        {
            if (!validarSeleccionNula()) {
                return;
             }
            int idCancion = Convert.ToInt32(dataGridViewCanciones.CurrentRow.Cells["id"].Value);
            var ventana = new viewPartes(idCancion);
            ventana.ShowDialog();
        }

        // Métodos usados por el load y los eventos

        public bool validarSeleccionNula() {
            if (dataGridViewCanciones.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una canción.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;

        }
        public void cargarDataGridView()
        {

            List<cancion> canciones = oControllerCancion.buscarNombreYAutor();
            dataGridViewCanciones.DataSource = null;
            dataGridViewCanciones.DataSource = canciones;
            dataGridViewCanciones.Columns["id"].Visible = false;
            dataGridViewCanciones.Columns["oEstructura"].Visible = false;
            dataGridViewCanciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCanciones.AllowUserToResizeRows = false;
            dataGridViewCanciones.AllowUserToResizeColumns = false;

        }

        public cancion capturarNombreAutorIdCancion()
        {

            int idCancion = Convert.ToInt32(dataGridViewCanciones.CurrentRow.Cells["id"].Value);
            string autorCancion = dataGridViewCanciones.CurrentRow.Cells["autor"].Value.ToString();
            string nombreCancion = dataGridViewCanciones.CurrentRow.Cells["nombre"].Value.ToString();

            cancion oCancion = new cancion(idCancion, autorCancion, nombreCancion);
            return oCancion;
        }

       
    }
}
