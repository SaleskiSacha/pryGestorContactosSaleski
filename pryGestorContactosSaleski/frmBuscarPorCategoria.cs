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
    public partial class frmBuscarPorCategoria : Form
    {
        public frmBuscarPorCategoria()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal newbj = new frmPrincipal();
            newbj.ShowDialog();
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Int32 IdCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
            clsContactos BusquedaxCategoria = new clsContactos();
            BusquedaxCategoria.ListarUsuariosxCat(dgv1, IdCategoria);
        }

        private void frmBuscarPorCategoria_Load(object sender, EventArgs e)
        {
            clsContactos contactos = new clsContactos();
            clsCategoria cate = new clsCategoria();
            cate.CargaCmbCategoria(cmbCategoria);
            cmbCategoria.SelectedIndex = -1;
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedIndex == -1) 
                btnBuscar.Enabled = false;
            else
            {
                btnBuscar.Enabled=true;
            }
            
        }
    }
}
