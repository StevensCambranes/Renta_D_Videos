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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void registrarRentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Menu a Registrar Renta
            frmRentas rentas = new frmRentas();
            rentas.Show();
            this.Hide();
        }

        private void regsitroVideosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Menu a Registro Videos
            frmRegistroVideos registroVideos = new frmRegistroVideos();
            registroVideos.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Menu a LogIn
            frmLogIn logIn = new frmLogIn();
            logIn.Show();
            this.Hide();
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Menu a SignIn
            frmSignIn signIn = new frmSignIn();
            signIn.Show();
        }
    }
}
