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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lista_de_canciones.Vista
{
    public partial class viewModificarNombreAutor : Form
    {
        // Llamo a las intancias de las controllers necesarias
        controllerCancion oControllerCancion = controllerCancion.GetControllerCancion();


        // Atributos

        private int idCancionSeleccionada;
        private string autorNuevo;
        private string nombreNuevo;


        // Eventos del load y los botones

        public viewModificarNombreAutor(cancion cancionParaMoficar)
        {
            InitializeComponent();
            idCancionSeleccionada = cancionParaMoficar.id;
            autorNuevo = cancionParaMoficar.autor;
            nombreNuevo = cancionParaMoficar.nombre;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewModificarNombreAutor_Load(object sender, EventArgs e)
        {
            asignarValoresTextBox();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAutor.Text) || string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                MessageBox.Show("Debes completar todos los campos.","", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cancion oCancion = capturarValoresTextBox();
            oControllerCancion.modificar(oCancion);
            this.Close();

        }


        // Métodos usados por el load y eventos

        public void asignarValoresTextBox() {
            textBoxAutor.Text = autorNuevo;
            textBoxNombre.Text = nombreNuevo;
        }

        public cancion capturarValoresTextBox() {
            autorNuevo = textBoxAutor.Text;
            nombreNuevo = textBoxNombre.Text;

            cancion nuevaCancion = new cancion(idCancionSeleccionada, autorNuevo, nombreNuevo);
            return nuevaCancion;
        }
    }
}
