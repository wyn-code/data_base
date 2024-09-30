namespace practica_papu
{
    partial class VerLocalidades
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
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.btmBuscar = new System.Windows.Forms.Button();
            this.dgvLocal = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(37, 33);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(178, 20);
            this.txtLocal.TabIndex = 0;
            // 
            // btmBuscar
            // 
            this.btmBuscar.Location = new System.Drawing.Point(221, 30);
            this.btmBuscar.Name = "btmBuscar";
            this.btmBuscar.Size = new System.Drawing.Size(75, 23);
            this.btmBuscar.TabIndex = 1;
            this.btmBuscar.Text = "Buscar";
            this.btmBuscar.UseVisualStyleBackColor = true;
            this.btmBuscar.Click += new System.EventHandler(this.btmBuscar_Click);
            // 
            // dgvLocal
            // 
            this.dgvLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocal.Location = new System.Drawing.Point(37, 59);
            this.dgvLocal.Name = "dgvLocal";
            this.dgvLocal.Size = new System.Drawing.Size(390, 243);
            this.dgvLocal.TabIndex = 2;
            // 
            // VerLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 338);
            this.Controls.Add(this.dgvLocal);
            this.Controls.Add(this.btmBuscar);
            this.Controls.Add(this.txtLocal);
            this.Name = "VerLocalidades";
            this.Text = "Listado de Localidades";
            this.Load += new System.EventHandler(this.VerLocalidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Button btmBuscar;
        private System.Windows.Forms.DataGridView dgvLocal;
    }
}