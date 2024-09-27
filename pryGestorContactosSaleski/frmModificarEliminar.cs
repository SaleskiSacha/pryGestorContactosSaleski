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
    public partial class frmModificarEliminar : Form
    {
        public frmModificarEliminar()
        {
            InitializeComponent();
        }
        clsContactos clsContactos = new clsContactos();
        clsCategoria clsCategoria = new clsCategoria();
        private void frmModificarEliminar_Load(object sender, EventArgs e)
        {
            clsCategoria Categoria = new clsCategoria();
            Categoria.CargaCmbCategoria(cmbCategoria);
            cmbCategoria.SelectedIndex = -1;
            Limpiar();
        }
        private void Habilitar()
        {
            if (txtBuscar.Text == "")
            {
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }
        private void Limpiar()
        {

            txtNombre.Text = "";
            txtNombre.ReadOnly = true;
            txtNumero.ReadOnly = true;
            txtIdContacto.ReadOnly = true;
            txtApellido.ReadOnly = true;
            cmbCategoria.Enabled = false;
            txtCorreo.ReadOnly = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = false;

        }

        private void lblCategoria_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string numero = Convert.ToString(txtNumero.Text);
            Int32 IdContacto = Convert.ToInt32(txtIdContacto.Text);
            string Nombre = txtNombre.Text;
            string Apellido = txtApellido.Text;
            string Correo = txtCorreo.Text;
            Int32 Categoria = Convert.ToInt32(cmbCategoria.SelectedValue);
            clsContactos contactos = new clsContactos();
            contactos.Numero = numero;
            contactos.Nombre = Nombre;
            contactos.Apellido = Apellido;
            contactos.Correo = Correo;
            contactos.Categoria = Categoria;
            contactos.ModificarContacto(IdContacto);
            txtNumero.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtIdContacto.Text = "";
            cmbCategoria.SelectedIndex = -1;
            MessageBox.Show("CONTACTO MODIFICADO CON ÉXITO");
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
            txtNombre.ReadOnly = false;
            txtCorreo.ReadOnly = false;
            cmbCategoria.Enabled = true;
            txtApellido.ReadOnly = false;
            txtNumero.ReadOnly = false;

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Int32 codi = Convert.ToInt32(txtBuscar.Text);
            clsContactos contactos = new clsContactos();
            clsCategoria categoria = new clsCategoria();
            contactos.Buscar(codi);
            if (contactos.ID_Contacto != codi)
            {
                MessageBox.Show("El Contacto no se encuentra registrado");
                txtBuscar.Text = "";
            }
            else
            {
                txtIdContacto.Text = Convert.ToString(contactos.ID_Contacto);
                txtNumero.Text = Convert.ToString(contactos.Numero);
                txtNombre.Text = contactos.Nombre;
                txtApellido.Text = contactos.Apellido;
                txtCorreo.Text = contactos.Correo;
                categoria.BuscarCateogira(contactos.Categoria);
                cmbCategoria.Text = categoria.Detalle;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Int32 codi = Convert.ToInt32(txtBuscar.Text);
            clsContactos Eliminar = new clsContactos();
            Eliminar.EliminarContacto(codi);
            txtNumero.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtIdContacto.Text = "";
            cmbCategoria.SelectedIndex = -1;
        }

        private void txtIdContacto_TextChanged(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal newbj = new frmPrincipal();
            newbj.ShowDialog();
            this.Hide();
        }

       // private void btnGuardar_Click(object sender, EventArgs e)
        //{

        //}
    }
}
