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
    public partial class viewEliminarParte : Form
    {
        // Llamo inastancias de las controllers necesarias

        controllerParte oControllerParte = controllerParte.GetControllerParte();
        controllerParte_compas oControllerParte_compas = controllerParte_compas.GetControllerParte_Compas();

        // Atributos

        parte parteParaEliminar;


        // Constructor de la vista

        public viewEliminarParte(parte oParte)
        {
            InitializeComponent();
            parteParaEliminar = oParte;

        }

        // Eventos de los botones
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int idEliminar = parteParaEliminar.id;
            oControllerParte_compas.eliminar(idEliminar);
            oControllerParte.eliminar(idEliminar);
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
