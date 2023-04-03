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
            dtgBuscaClientes.DataSource = bll.Seleciona_clientes();
        }
    }
}
