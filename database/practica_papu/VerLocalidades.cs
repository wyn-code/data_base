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
    public partial class VerLocalidades : Form
    {
        public VerLocalidades()
        {
            InitializeComponent();
        }

        private void VerLocalidades_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void CargarGrilla()
        {
            string query;

            if(txtLocal.Text.Trim() == String.Empty)
            {
                query = "SELECT * FROM Localidades ORDER BY Localidad ASC";
            } else
            {
                query = $"SELECT * FROM Localidades WHERE Localidad LIKE '{txtLocal.Text.Trim()}%' ORDER BY Localidad ASC";
            }

            DataTable dt = new DataTable();
            dt = Metodos.Leer(query);

            dgvLocal.DataSource = dt;

            dgvLocal.AllowUserToAddRows = false;
            dgvLocal.AllowUserToDeleteRows = false;
            dgvLocal.ReadOnly = true;
            dgvLocal.Columns["IdLocalidad"].Visible = false;
            dgvLocal.Columns["CodigoPostal"].HeaderText = "C.P";
            dgvLocal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void btmBuscar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}
