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
    public partial class VerClientes : Form
    {
        public VerClientes()
        {
            InitializeComponent();
        }

        private void VerClientes_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            chkBox.Checked = true;

            DataTable dt = new DataTable();
            string query = "SELECT * FROM Localidades ORDER BY Localidad ASC";
            dt = Metodos.Leer(query);
            cmbListClient.DataSource = dt;
            cmbListClient.ValueMember = "IdLocalidad";
            cmbListClient.DisplayMember = "Localidad";
            cmbListClient.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbListClient.SelectedIndex = 0;


        } 

        private void CargarGrilla()
        {
            string query;

            if (chkBox.Checked == true)
            {
                query = "SELECT c1.*, TipoDoc FROM " +
                        "(SELECT c.*, Localidad FROM Clientes c JOIN Localidades l ON c.IdLocalidad = l.IdLocalidad) " +
                        "AS c1 JOIN TiposDocs t ON c1.IdTipoDoc = t.IdTipoDoc " +
                        "ORDER BY Apellido, Nombre ASC";
            }
            else
            {
                query = $"SELECT c1.*, TipoDoc FROM " +
                        $"(SELECT c.*, Localidad FROM Clientes c JOIN Localidades l ON c.IdLocalidad = l.IdLocalidad) " +
                        $"AS c1 JOIN TiposDocs t ON c1.IdTipoDoc = t.IdTipoDoc " +
                        $"WHERE c1.IdLocalidad = {cmbListClient.SelectedValue} " +
                        $"ORDER BY Apellido, Nombre ASC;";

            }

            DataTable dt = new DataTable();
            dt = Metodos.Leer(query);

            dgvClient.DataSource = dt;

            dgvClient.AllowUserToDeleteRows = false;
            dgvClient.AllowUserToAddRows = false;
            dgvClient.ReadOnly = true;
            dgvClient.Columns["IdCliente"].Visible = false;
            dgvClient.Columns["IdTipoDoc"].Visible = false;
            dgvClient.Columns["IdLocalidad"].Visible = false;
            dgvClient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }

        private void chkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBox.Checked)
            {
                cmbListClient.Enabled = false;
            } else
            {
                cmbListClient.Enabled = true;   
            }

            CargarGrilla();
        }

        private void VerClientes_Activated(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void cmbListClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}
