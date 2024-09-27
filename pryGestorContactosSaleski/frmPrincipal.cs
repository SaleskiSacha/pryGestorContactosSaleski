using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestorContactosSaleski
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        clsContactos objBaseDatos;
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            objBaseDatos = new clsContactos();
            objBaseDatos.ConectarBD();

            lblStatus.Text = objBaseDatos.EstadoDeConexion;

            lblStatus.BackColor = Color.Green;
            lblStatus.ForeColor = Color.White;
        }

        private void listarContactosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarListar newobj = new frmAgregarListar();
            this.Hide();
            newobj.ShowDialog();
            
        }

        private void eliminarOModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarEliminar newobj = new frmModificarEliminar();
            this.Hide();
            newobj.ShowDialog();
            
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void porCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarPorCategoria newobj = new frmBuscarPorCategoria();
            this.Hide();
            newobj.ShowDialog();
            
        }

        private void porNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarxNombre newobj = new frmBuscarxNombre();
            this.Hide();
            newobj.ShowDialog();
        }

        private void csvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objBaseDatos = new clsContactos();
            objBaseDatos.guardarArchivo();
            
            MessageBox.Show("Archivo exportado con Exito");
        }
    }
}
