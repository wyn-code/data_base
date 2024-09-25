using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_papu
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            DataTable dt = new DataTable();
            string query = "SELECT * FROM TiposDocs ORDER BY TipoDoc ASC";
            dt = Metodos.Leer(query);
            cmbTipoDoc.DataSource = dt;
            cmbTipoDoc.ValueMember = "idTipoDoc";
            cmbTipoDoc.DisplayMember = "TipoDoc";
            cmbTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDoc.SelectedIndex = 0;

            query = "SELECT * FROM Localidades ORDER BY Localidad ASC";
            dt = Metodos.Leer(query);
            cmbLocal.DataSource = dt; // .DataSource, enlaza datos
            cmbLocal.ValueMember = "idlocalidad"; //.ValueMember, obtiene o establece una cadena que especifica la propiedad
                                                  // o columna de la que obtener valor
            cmbLocal.DisplayMember = "localidad"; // .DisplayMember, representa la informacion de texto que se muestra 
                                                  // la lista desplegable del cuadro combinado.
            cmbLocal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLocal.SelectedIndex = 0;


            fecha.MaxDate = DateTime.Today;
            txtApel.MaxLength = 30;
            txtNomb.MaxLength = 30;
            txtDirecc.MaxLength = 50;
            txtCel.MaxLength = 30;
            txtEmail.MaxLength = 50;
            txtBox.MaxLength = 250;

            checkBox1.Checked = true;

        }

        private bool validar()
        {
            bool ok = false;
            int num;

            if(int.TryParse(txtDoc.Text.Trim(), out num) && txtDoc.Text.Trim() != String.Empty)
            {
                if(txtApel.Text.Trim() != String.Empty)
                {
                    if(txtNomb.Text.Trim() != String.Empty)
                    {
                        if(txtDirecc.Text.Trim() != String.Empty)
                        {
                            if (int.TryParse(txtCel.Text, out num) && txtCel.Text.Trim() != String.Empty)
                            {
                                if (txtEmail.Text.Trim() == String.Empty)
                                {
                                    ok = true;
                                }
                                else
                                {
                                    Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                                    if (regex.Match(txtEmail.Text).Success)
                                    {
                                        ok = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Email no es válido.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                }
                            } else
                            {
                                MessageBox.Show("No ha completado el celular", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        } else
                        {
                            MessageBox.Show("No ha completado la dirección", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } else
                    {
                        MessageBox.Show("No ha completado el nombre", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else
                {
                    MessageBox.Show("No ha completado el apellido", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("No ha completado el documento", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ok;

        }

        private void btmRegist_Click(object sender, EventArgs e)
        {
            if(validar())
            {
                string mail;
                string obvs;
                string activo;

                if(txtEmail.Text.Trim() != String.Empty)
                {
                    mail = $"'{txtEmail.Text.Trim()}'";
                } else
                {
                    mail = "NULL";
                }

                if(txtBox.Text != String.Empty)
                {
                    obvs = $"'{txtBox.Text.Trim()}'";
                } else
                {
                    obvs = "NULL";
                }

                if(checkBox1.Checked)
                {
                    activo = "1";
                } else
                {
                    activo = "0";
                }

                string sql;
                sql = $"INSERT INTO Clientes (Apellido,Nombre,IdTipoDoc,NDoc,FechaNac,Direccion,IdLocalidad,Cel,Email,Activo,Observaciones) " +
                    $"VALUES ('{txtApel.Text}','{txtNomb.Text}','{cmbTipoDoc.SelectedValue}','{txtDoc.Text}'," +
                    $"'{fecha.Value.ToShortDateString()}','{txtDirecc.Text}','{cmbLocal.SelectedValue}','{txtCel.Text}'," +
                    $"{mail},{activo},{obvs})";
                Metodos.Cargar(sql);

                MessageBox.Show("Cliente Registrado!", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtApel.Clear();
                txtNomb.Clear();
                txtDoc.Clear();
                txtCel.Clear();
                txtDirecc.Clear();
                txtBox.Clear();
                txtEmail.Clear();
                fecha.Value = DateTime.Today;
            }
        }
    }
}
