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
    public partial class frmRegistroVideos : Form
    {
        public frmRegistroVideos()
        {
            InitializeComponent();
        }

        private void pagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Videos a menu princiapl
            frmMenuPrincipal menu = new frmMenuPrincipal();
            menu.Show(this);
            this.Hide();
        }

        private void btnAgregarVideo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodVideo.Text) || string.IsNullOrWhiteSpace(txtNombreVideo.Text) || cboGeneroVideo.SelectedIndex == -1 || cboFormatoVideo.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtDescripcionVideo.Text) || string.IsNullOrWhiteSpace(txtDuracionVideo.Text) || string.IsNullOrWhiteSpace(txtLanzamientoVideo.Text) ||
                string.IsNullOrWhiteSpace(txtClasificacionEdadVideo.Text) || string.IsNullOrWhiteSpace(txtDirector.Text) || checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else {
                MessageBox.Show("Se guado exitosamente el video", "Validación");
                return;
            }

            // Código para guardar los datos en la BDaquí
        }
    }
}
