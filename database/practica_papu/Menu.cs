using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_papu
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CenterToScreen();
            VerClientes frmVerClient = new VerClientes();
            frmVerClient.ShowDialog();
        }

        private void localidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VerLocalidades frmVerLocal = new VerLocalidades();
            frmVerLocal.ShowDialog();
            this.CenterToScreen();
        }
    }
}
