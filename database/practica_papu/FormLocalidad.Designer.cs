namespace practica_papu
{
    partial class FormLocalidad
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.btmRegist = new System.Windows.Forms.Button();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Localidad:";
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(42, 80);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(176, 20);
            this.txtLocal.TabIndex = 1;
            // 
            // btmRegist
            // 
            this.btmRegist.Location = new System.Drawing.Point(67, 106);
            this.btmRegist.Name = "btmRegist";
            this.btmRegist.Size = new System.Drawing.Size(75, 23);
            this.btmRegist.TabIndex = 2;
            this.btmRegist.Text = "Registrar";
            this.btmRegist.UseVisualStyleBackColor = true;
            this.btmRegist.Click += new System.EventHandler(this.btmRegist_Click);
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(42, 41);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cod. Postal:";
            // 
            // FormLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 181);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btmRegist);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.label1);
            this.Name = "FormLocalidad";
            this.Text = "Localidad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Button btmRegist;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label2;
    }
}

