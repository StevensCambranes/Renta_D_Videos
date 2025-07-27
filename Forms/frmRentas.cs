using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renta_De_Videos.Forms
{
    public partial class frmRentas : Form
    {
        public frmRentas()
        {
            InitializeComponent();
        }

        private void pagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // rentas a menu
            frmMenuPrincipal menu = new frmMenuPrincipal();
            menu.Show();
            this.Hide();
        }
    }
}
