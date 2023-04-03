
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscaClientes));
            this.dtgBuscarClientes = new System.Windows.Forms.DataGridView();
            this.lblPesquisaCLientes = new System.Windows.Forms.Label();
            this.txtBuscarClientes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscarClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgBuscarClientes
            // 
            this.dtgBuscarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBuscarClientes.Location = new System.Drawing.Point(3, 44);
            this.dtgBuscarClientes.Name = "dtgBuscarClientes";
            this.dtgBuscarClientes.ReadOnly = true;
            this.dtgBuscarClientes.Size = new System.Drawing.Size(643, 257);
            this.dtgBuscarClientes.TabIndex = 0;
            this.dtgBuscarClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBuscarClientes_CellContentClick);
            // 
            // lblPesquisaCLientes
            // 
            this.lblPesquisaCLientes.AutoSize = true;
            this.lblPesquisaCLientes.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisaCLientes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPesquisaCLientes.Location = new System.Drawing.Point(0, 13);
            this.lblPesquisaCLientes.Name = "lblPesquisaCLientes";
            this.lblPesquisaCLientes.Size = new System.Drawing.Size(229, 19);
            this.lblPesquisaCLientes.TabIndex = 1;
            this.lblPesquisaCLientes.Text = "Pesquisa de clientes por nome:";
            // 
            // txtBuscarClientes
            // 
            this.txtBuscarClientes.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarClientes.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtBuscarClientes.Location = new System.Drawing.Point(230, 11);
            this.txtBuscarClientes.Name = "txtBuscarClientes";
            this.txtBuscarClientes.Size = new System.Drawing.Size(416, 23);
            this.txtBuscarClientes.TabIndex = 2;
            this.txtBuscarClientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarClientes.TextChanged += new System.EventHandler(this.txtBuscarClientes_TextChanged);
            // 
            // frmBuscaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(650, 305);
            this.Controls.Add(this.txtBuscarClientes);
            this.Controls.Add(this.lblPesquisaCLientes);
            this.Controls.Add(this.dtgBuscarClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmBuscaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BuscaClientes";
            this.Load += new System.EventHandler(this.frmBuscaClientes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBuscaClientes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscarClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgBuscarClientes;
        private System.Windows.Forms.Label lblPesquisaCLientes;
        private System.Windows.Forms.TextBox txtBuscarClientes;
    }
}