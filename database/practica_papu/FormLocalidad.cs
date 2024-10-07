using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_papu
{
    public partial class FormLocalidad : Form
    {
        public FormLocalidad()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private bool validar()
        {
            bool ok = false;
            int num;

            if (int.TryParse(txtCod.Text.Trim(), out num) && txtCod.Text.Trim() != String.Empty) 
            { 
                if(txtLocal.Text.Trim() != String.Empty)
                {
                    ok = true;
                } else
                {
                    MessageBox.Show("Localidad vacia.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }  
            } else
            {
                MessageBox.Show("Código postal vacio.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ok;
        }

        private void btmRegist_Click(object sender, EventArgs e)
        {
            
            if (validar()) 
            {
                    string query = $"INSERT INTO Localidades (codigopostal, localidad) VALUES " +
                    $"('{txtCod.Text}', '{txtLocal.Text}')";
                    Metodos.Cargar(query);

                    MessageBox.Show("Localidad Registrada!", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtCod.Clear();
                    txtLocal.Clear();               
            }     
        }
    }
}
