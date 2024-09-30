namespace practica_papu
{
    partial class VerClientes
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
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.chkBox = new System.Windows.Forms.CheckBox();
            this.cmbListClient = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClient
            // 
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Location = new System.Drawing.Point(12, 39);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.Size = new System.Drawing.Size(835, 303);
            this.dgvClient.TabIndex = 0;
            // 
            // chkBox
            // 
            this.chkBox.AutoSize = true;
            this.chkBox.Location = new System.Drawing.Point(359, 14);
            this.chkBox.Name = "chkBox";
            this.chkBox.Size = new System.Drawing.Size(56, 17);
            this.chkBox.TabIndex = 1;
            this.chkBox.Text = "Todos";
            this.chkBox.UseVisualStyleBackColor = true;
            this.chkBox.CheckedChanged += new System.EventHandler(this.chkBox_CheckedChanged);
            // 
            // cmbListClient
            // 
            this.cmbListClient.FormattingEnabled = true;
            this.cmbListClient.Location = new System.Drawing.Point(12, 12);
            this.cmbListClient.Name = "cmbListClient";
            this.cmbListClient.Size = new System.Drawing.Size(341, 21);
            this.cmbListClient.TabIndex = 2;
            // 
            // VerClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 376);
            this.Controls.Add(this.cmbListClient);
            this.Controls.Add(this.chkBox);
            this.Controls.Add(this.dgvClient);
            this.Name = "VerClientes";
            this.Text = "Listado de Clientes";
            this.Activated += new System.EventHandler(this.chkBox_CheckedChanged);
            this.Load += new System.EventHandler(this.VerClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.CheckBox chkBox;
        private System.Windows.Forms.ComboBox cmbListClient;
    }
}