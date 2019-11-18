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
        {
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
            //Metodo para limpiar las cajas de texto
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
        {
            ListaTareas.Items.Clear();
            foreach (var item in ListaT)
            {
                ListaTareas.Items.Add(item.Actividad);
            }
        }

        private void CmdDetalles_Click(object sender, EventArgs e)
        {
            ListaDetalle.Items.Clear();
            int c=0;
            foreach (var item in ListaT)
            {
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
            if (c == 0)
            {
                MessageBox.Show("Nombre de actividad invalido pruebe nuevamente");
            }
        }

        private void CmdStatus_Click(object sender, EventArgs e)
        {
            ListaStatus.Items.Clear();
            foreach (var item in ListaT)
            {
                ListaStatus.Items.Add(item.Actividad+": "+item.Status);
            }
        }

        private void CmdCambiarStatus_Click(object sender, EventArgs e)
        {
            foreach (var item in ListaT)
            {
                if (ListaT.Count != 0)
                {
                    if (item.Actividad == txtCambiarStatus.Text)
                    {
                        var temp = item.Status;
                        item.Status = txtNuevoStatus.Text;
                        MessageBox.Show("Se ha cambiado exitosamente el estado de *"+temp+" a *"+item.Status);
                        Limpiar();
                    }
                }
            }
        }

        private void CmdLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
