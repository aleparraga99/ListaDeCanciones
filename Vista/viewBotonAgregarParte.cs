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

namespace Lista_de_canciones.Vista
{
    public partial class viewBotonAgregarParte : Form
    {
        // Llamo a las intancias de las controller necesarias
        controllerParte oControllerParte = controllerParte.GetControllerParte();
        controllerCancion_parte oControllerCancion_parte = controllerCancion_parte.GetControllerParte_Compas();
        controllerCompas oControllerCompas = controllerCompas.GetControllerCompas();
        controllerParte_compas oControllerParte_Compas = controllerParte_compas.GetControllerParte_Compas();

        // Atributos

        private int idGeneradoParte;
        private int idCancion;


        // Constructor de la vista
        public viewBotonAgregarParte(int idCancionSeleccionada)
        {
            InitializeComponent();
            idCancion = idCancionSeleccionada;
        }


        // Eventos de los botones
        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAgregarParte_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxNombreParte.Text) || string.IsNullOrWhiteSpace(textBoxCantidadCompases.Text))
            {
                MessageBox.Show("Debe completar ambos campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(textBoxCantidadCompases.Text, out int valor))
            {
                capturarParteYCompases();
                oControllerCancion_parte.crear(idCancion, idGeneradoParte);    // Crear registro de cancion_parte en la tabla relacional
                cargarCompases();
            }
            else
            {
                MessageBox.Show("La cantidad de compases debe ser un número entero.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.Close();
        }


       // Métodos usados por los botones
        public void capturarParteYCompases()
        {

            string nombreParte = textBoxNombreParte.Text;
            int cantidadCompases = int.Parse(textBoxCantidadCompases.Text);

            idGeneradoParte = oControllerParte.crear(nombreParte, cantidadCompases); // Se crea el objeto parte en la BBDD y se devuelve el id

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

        public void cargarParte_Compas(List<int> idsCompases)
        {

            for (var i = 0; i < idsCompases.Count; i++) // Se crean los elementos parte_compas en la tabla relacional
            {
                oControllerParte_Compas.crear(idGeneradoParte, idsCompases[i]);
            }
        }
    }
}
