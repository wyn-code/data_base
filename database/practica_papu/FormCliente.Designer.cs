namespace practica_papu
{
    partial class FormCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApel = new System.Windows.Forms.TextBox();
            this.txtNomb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbLocal = new System.Windows.Forms.ComboBox();
            this.txtDirecc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btmRegist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Doc.";
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(12, 29);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(134, 21);
            this.cmbTipoDoc.TabIndex = 1;
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(169, 30);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(190, 20);
            this.txtDoc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nro. Doc.";
            // 
            // fecha
            // 
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(400, 30);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(96, 20);
            this.fecha.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha Nac.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apelido";
            // 
            // txtApel
            // 
            this.txtApel.Location = new System.Drawing.Point(12, 76);
            this.txtApel.Name = "txtApel";
            this.txtApel.Size = new System.Drawing.Size(207, 20);
            this.txtApel.TabIndex = 8;
            // 
            // txtNomb
            // 
            this.txtNomb.Location = new System.Drawing.Point(249, 76);
            this.txtNomb.Name = "txtNomb";
            this.txtNomb.Size = new System.Drawing.Size(247, 20);
            this.txtNomb.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Localidad";
            // 
            // cmbLocal
            // 
            this.cmbLocal.FormattingEnabled = true;
            this.cmbLocal.Location = new System.Drawing.Point(12, 124);
            this.cmbLocal.Name = "cmbLocal";
            this.cmbLocal.Size = new System.Drawing.Size(207, 21);
            this.cmbLocal.TabIndex = 12;
            // 
            // txtDirecc
            // 
            this.txtDirecc.Location = new System.Drawing.Point(246, 125);
            this.txtDirecc.Name = "txtDirecc";
            this.txtDirecc.Size = new System.Drawing.Size(250, 20);
            this.txtDirecc.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Direccion";
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(9, 175);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(137, 20);
            this.txtCel.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Celular";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(175, 175);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(269, 20);
            this.txtEmail.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(175, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Email";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(50, 217);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Activo";
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(9, 261);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox.Size = new System.Drawing.Size(487, 87);
            this.txtBox.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Observación";
            // 
            // btmRegist
            // 
            this.btmRegist.Location = new System.Drawing.Point(204, 368);
            this.btmRegist.Name = "btmRegist";
            this.btmRegist.Size = new System.Drawing.Size(75, 23);
            this.btmRegist.TabIndex = 23;
            this.btmRegist.Text = "Registrar";
            this.btmRegist.UseVisualStyleBackColor = true;
            this.btmRegist.Click += new System.EventHandler(this.btmRegist_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 410);
            this.Controls.Add(this.btmRegist);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDirecc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbLocal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNomb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDoc);
            this.Controls.Add(this.cmbTipoDoc);
            this.Controls.Add(this.label1);
            this.Name = "FormCliente";
            this.Text = "Alta de Cliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApel;
        private System.Windows.Forms.TextBox txtNomb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbLocal;
        private System.Windows.Forms.TextBox txtDirecc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btmRegist;
    }
}