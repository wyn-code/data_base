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

            DataTable dt = new DataTable();
            string query = "SELECT * FROM Localidades ORDER BY Localidad ASC";
            dt = Metodos.Leer(query);
            cmbListClient.DataSource = dt;
            cmbListClient.ValueMember = "IdLocalidad";
            cmbListClient.DisplayMember = "Localidad";
            cmbListClient.SelectedIndex = 0;
            cmbListClient.DropDownStyle = ComboBoxStyle.DropDownList;
            chkBox.Checked = true;

            CargarGrilla();

        } 

        private void CargarGrilla()
        {
            string query;

            if (chkBox.Checked == true)
            {
                query = "SELECT c.*, l.Localidad, t.TipoDoc FROM Clientes c JOIN Localidades l " +
                        "ON c.IdLocalidad = l.IdLocalidad JOIN TiposDocs t ON c.IdTipoDoc = t.IdTipoDoc " +
                        "ORDER BY Nombre, Apellido ASC";
            } else
            {
                query = $"SELECT c.*, l.Localidad, t.TipoDoc FROM Clientes c JOIN Localidades l " +
                        $"ON c.IdLocalidad = l.IdLocalidad JOIN TiposDocs t ON c.IdTipoDoc = t.IdTipoDoc " +
                        $"WHERE c.IdLocalidad = {cmbListClient.SelectedValue} ORDER BY Nombre, Apellido ASC";
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
    }
}
