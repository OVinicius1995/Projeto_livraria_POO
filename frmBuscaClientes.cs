using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace livraria
{
    public partial class frmBuscaClientes : Form
    {
        Livraria_BLL bll = new Livraria_BLL();
        public frmBuscaClientes()
        {
            InitializeComponent();
        }

        private void frmBuscaClientes_Load(object sender, EventArgs e)
        {
            dtgBuscarClientes.DataSource = bll.Seleciona_clientes();
        }

        private void frmBuscaClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                livraria_DTO.setCliente("");
                livraria_DTO.setCodCliente("");
            }
        }

        private void dtgBuscarClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            livraria_DTO.setCliente(dtgBuscarClientes.Rows[e.RowIndex].Cells[1].Value.ToString());
            livraria_DTO.setCodCliente(dtgBuscarClientes.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.Close();
        }

        private void txtBuscarClientes_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarClientes.Text != "")
            {
                var nomeCli = txtBuscarClientes.Text;
                dtgBuscarClientes.DataSource = bll.Seleciona_clientes_Filtro(nomeCli);
            }
            else
            {
                dtgBuscarClientes.DataSource = bll.Seleciona_clientes();
            }
        }
    }
}
