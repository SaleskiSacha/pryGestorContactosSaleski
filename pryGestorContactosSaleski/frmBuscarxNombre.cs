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
    public partial class frmBuscarxNombre : Form
    {
        public frmBuscarxNombre()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreBuscado = txtNombre.Text;

            // Instancia de la clase de contactos
            clsContactos contactos = new clsContactos();

            // Llamar al método de búsqueda
            List<clsContactos> resultados = contactos.BuscarContactoPorNombre(nombreBuscado);

            // Mostrar los resultados en un DataGridView (o cualquier otro control)
            dgv1.Rows.Clear(); // Limpiar la grilla antes de agregar los nuevos resultados

            foreach (var contacto in resultados)
            {
                dgv1.Rows.Add(contacto.ID_Contacto, contacto.Numero, contacto.Nombre, contacto.Apellido, contacto.Correo, contacto.Categoria);
            }

            if (resultados.Count == 0)
            {
                MessageBox.Show("No se encontraron contactos con ese nombre.", "Resultado de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal newobj = new frmPrincipal();
            this.Hide();
            newobj.ShowDialog();
        }
    }
}
