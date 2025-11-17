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
    public partial class viewEliminarConfirmacion : Form
    {
        // Llamo a las intancias de las cotrollers necesarias
        controllerCancion oControllerCancion = controllerCancion.GetControllerCancion();
        controllerCancion_parte oControllerCancion_parte = controllerCancion_parte.GetControllerParte_Compas();


        // Atributos

        private int idParaEliminar;


        // Constructor de la vista

        public viewEliminarConfirmacion(int id)
        {
            InitializeComponent();
            idParaEliminar = id;
        }


        // Eventos de los botones

        private void buttonEliminarSi_Click(object sender, EventArgs e)
        {
            oControllerCancion_parte.eliminarPorIdCancion(idParaEliminar);
            oControllerCancion.eliminar(idParaEliminar);
            this.Close();
        }

        private void buttonEliminarNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
