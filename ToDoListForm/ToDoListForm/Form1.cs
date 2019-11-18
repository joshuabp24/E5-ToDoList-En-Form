using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoListForm
{
    public partial class frmActividades : Form
    {
        //se instancia la ListaT de forma global
        List<Tarea> ListaT = new List<Tarea>();
        public frmActividades()
        {
            InitializeComponent();
        }
        

        private void CmdSalida_Click(object sender, EventArgs e)
        {
            //Se cierra el programa
            Close();
        }
      

        public void CmdCrear_Click(object sender, EventArgs e)
        {//Aqui instancio la clase tarea para crear objetos y meterlos a la lista que fue creada de forma global
            Tarea t = new Tarea();
            t.Nombre = txtNombre.Text;
            t.Actividad = txtActividad.Text;
            t.Hora = txtHora.Text;
            t.Fecha = txtFecha.Text;
            t.Status = txtStatus.Text;
            ListaT.Add(t);
            MessageBox.Show("Se ha creado la tarea exitosamente");
            Limpiar();
        }
        public void Limpiar()
        {
            //Metodo para limpiar las cajas de texto y las listas
            txtActividad.Clear();
            txtFecha.Clear();
            txtHora.Clear();
            txtNombre.Clear();
            txtStatus.Clear();
            txtNombre.Focus();
            txtCambiarStatus.Clear();
            txtDetalles.Clear();
            txtNuevoStatus.Clear();
            ListaDetalle.Items.Clear();
            ListaStatus.Items.Clear();
            ListaTareas.Items.Clear();
        }

        private void CmdListar_Click(object sender, EventArgs e)
        {//boton para mostrar las tareas atraves de un foreach
            ListaTareas.Items.Clear();
            foreach (var item in ListaT)
            {
                ListaTareas.Items.Add(item.Actividad);
            }
        }

        private void CmdDetalles_Click(object sender, EventArgs e)
        {
            ListaDetalle.Items.Clear();
            //se crea una variable para poder validar una situacion mas adelante en el codigo
            int c=0;
            //For each para ver si el nombre ingresado por el usuario es igual al de alguna de las actividades
            foreach (var item in ListaT)
            {
                //if para evitar el error null
                if (ListaT.Count != 0)
                {
                    
                    if (item.Actividad == txtDetalles.Text)
                    {
                        ListaDetalle.Items.Add(item.Nombre);
                        ListaDetalle.Items.Add(item.Actividad);
                        ListaDetalle.Items.Add(item.Hora);
                        ListaDetalle.Items.Add(item.Fecha);
                        ListaDetalle.Items.Add(item.Status);
                        c = c + 1;
                    }
                }
            }
            //if en el cual se utiliza un contador para dar a conocer al usuario sus errores
            if (c == 0)
            {
                MessageBox.Show("Nombre de actividad invalido pruebe nuevamente");
            }
        }

        private void CmdStatus_Click(object sender, EventArgs e)
        {//Boton que muestra los status actuales a traves de un foreach
            ListaStatus.Items.Clear();
            foreach (var item in ListaT)
            {
                ListaStatus.Items.Add(item.Actividad+": "+item.Status);
            }
        }

        private void CmdCambiarStatus_Click(object sender, EventArgs e)
        {//parecido al metodo para mostrar detalles aqui se hace algo similar
            foreach (var item in ListaT)
            {//vuelvo a utilizar el if para evitar el null
                if (ListaT.Count != 0)
                {
                    //Se valida que el nombre de una actividad corresponda a lo ingresado por el usuario
                    if (item.Actividad == txtCambiarStatus.Text)
                    {
                        //variable de datos temporal para poder imprimir el cambio de status
                        var temp = item.Status;
                        item.Status = txtNuevoStatus.Text;
                        MessageBox.Show("Se ha cambiado exitosamente el estado de *"+temp+" a *"+item.Status);
                        Limpiar();
                    }
                }
            }
        }

        private void CmdLimpiar_Click(object sender, EventArgs e)
        {//boton para limpiar en el cual se utiliza el metodo Limpiar anteriormente creado
            Limpiar();
        }
    }
}
