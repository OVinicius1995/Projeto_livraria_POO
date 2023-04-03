
namespace livraria
{
    partial class frmBuscaClientes
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
            this.dtgBuscaClientes = new System.Windows.Forms.DataGridView();
            this.lblPesquisaCLientes = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgBuscaClientes
            // 
            this.dtgBuscaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBuscaClientes.Location = new System.Drawing.Point(3, 44);
            this.dtgBuscaClientes.Name = "dtgBuscaClientes";
            this.dtgBuscaClientes.Size = new System.Drawing.Size(643, 257);
            this.dtgBuscaClientes.TabIndex = 0;
            // 
            // lblPesquisaCLientes
            // 
            this.lblPesquisaCLientes.AutoSize = true;
            this.lblPesquisaCLientes.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisaCLientes.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPesquisaCLientes.Location = new System.Drawing.Point(0, 13);
            this.lblPesquisaCLientes.Name = "lblPesquisaCLientes";
            this.lblPesquisaCLientes.Size = new System.Drawing.Size(229, 19);
            this.lblPesquisaCLientes.TabIndex = 1;
            this.lblPesquisaCLientes.Text = "Pesquisa de clientes por nome:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.Location = new System.Drawing.Point(230, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(416, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmBuscaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 305);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPesquisaCLientes);
            this.Controls.Add(this.dtgBuscaClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBuscaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BuscaClientes";
            this.Load += new System.EventHandler(this.frmBuscaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgBuscaClientes;
        private System.Windows.Forms.Label lblPesquisaCLientes;
        private System.Windows.Forms.TextBox textBox1;
    }
}