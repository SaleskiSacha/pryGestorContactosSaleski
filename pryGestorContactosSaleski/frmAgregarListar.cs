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
    public partial class frmAgregarListar : Form
    {
        public frmAgregarListar()
        {
            InitializeComponent();
        }
        clsContactos newobj;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsContactos newobj = new clsContactos();
            Int32 codi = Convert.ToInt32(txtID.Text);
            newobj.Buscar(codi);

            if (newobj.ID_Contacto != codi)
            {
                newobj.ID_Contacto = Convert.ToInt32(txtID.Text);
                newobj.Numero = Convert.ToString(txtNumero.Text);
                newobj.Nombre = txtNombre.Text;
                newobj.Apellido = txtApellido.Text;
                newobj.Correo = txtCorreo.Text;
                newobj.Categoria = Convert.ToInt32(cmbCategoria.SelectedIndex);

                newobj.AgregarContacto();
                MessageBox.Show("Contacto agregado con éxito");
                txtID.Text = "";
                txtNombre.Text = "";
                txtNumero.Text = "";
                txtApellido.Text = "";
                txtCorreo.Text = "";
                cmbCategoria.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Contacto YA REGISTRADO");
                txtID.Text = "";
                txtNombre.Text = "";
                txtNumero.Text = "";
                txtApellido.Text = "";
                txtCorreo.Text = "";
                cmbCategoria.SelectedIndex = 0;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsContactos clsContactos = new clsContactos();
            clsContactos.ListarContactos(dgv1);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal newobj = new frmPrincipal();
            newobj.ShowDialog();
            this.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarEliminar obj = new frmModificarEliminar();
            obj.ShowDialog();
            this.Hide();
        }

        private void frmAgregarListar_Load(object sender, EventArgs e)
        {

        }
    }
}
