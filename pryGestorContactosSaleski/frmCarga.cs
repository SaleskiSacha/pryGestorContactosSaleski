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
    public partial class frmCarga : Form
    {
        public frmCarga()
        {
            InitializeComponent();
        }

        private void frmCarga_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar2.Increment(5);

            if (progressBar2.Value < 100)
            {
                progressBar2.Value++;
            }

            if (progressBar2.Value == 100)
            {
                timer1.Enabled = false;
                frmPrincipal frmPrincipal = new frmPrincipal();
                this.Hide();
                frmPrincipal.Show();
            }
        }
    }
}
