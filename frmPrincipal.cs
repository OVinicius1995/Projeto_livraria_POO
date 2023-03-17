using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using livraria;
using MySql.Data.MySqlClient;
using DAL;
namespace livraria
{
    public partial class frmPai : Form
    {
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer horas = new System.Windows.Forms.Timer();
        livraria_DTO dto = new livraria_DTO();
        Livraria_BLL bll = new Livraria_BLL();
        BLL_Login log = new BLL_Login();
        AcessoBancoDados bd = new AcessoBancoDados();
        
        public frmPai()
        {
            InitializeComponent();

            myTimer.Tick += new EventHandler(timAtualiza_Tick);
            myTimer.Interval = 20000; //tempo em milesimos
            myTimer.Start();

            horas.Tick += new EventHandler(Timhoras_Tick);
            horas.Interval = 1; //tempo em milesimos
            horas.Start();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes objFrmClientes = new frmClientes();
            objFrmClientes.ShowDialog();            
            
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void livrosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmLivros objFrmLivros = new frmLivros();
            objFrmLivros.ShowDialog();
        }

        private void funcionariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmFuncionarios objFrmFuncionario = new frmFuncionarios();
            objFrmFuncionario.ShowDialog();
        }

        public void frmPai_Load(object sender, EventArgs e)
        {
            carrega_venda();
            txtPerfil.Text = livraria_DTO.getUsuario();
            
            txtMatricula.Focus();

            string mat = livraria_DTO.getTeste();
            carrega(mat);

        }
        public void carrega_venda()
        {
            dtgVenda.DataSource = bll.Venda_Livros();
            
        }

        private void dtgVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtMatricula.Text = dtgVenda.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtIsbn.Text = dtgVenda.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dtgVenda.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAutor.Text = dtgVenda.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEditora.Text = dtgVenda.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNacionalidade.Text = dtgVenda.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtClassificacao.Text = dtgVenda.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtQtde.Text = dtgVenda.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtValor.Text = dtgVenda.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            if (txtVenda.Text == "")
            {
                MessageBox.Show("Não foi especificado a quantidade de livros a ser vendido", "Quantidade", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (txtMatricula.Text == "")
            {
                var result = MessageBox.Show("A matricula não foi informada, deseja fazer a compra sem informar a matricula ?", "Iformação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        dto.Isbn = txtIsbn.Text;
                        dto.Venda = int.Parse(txtVenda.Text);
                        dto.Quantidade = int.Parse(txtQtde.Text);
                        dto.Nome = txtNome.Text;
                        dto.Valor = int.Parse(txtValor.Text);

                        var resultado = dto.Quantidade - dto.Venda;

                        var resultado1 = dto.Venda * dto.Valor;

                        txtValor.Text = resultado1.ToString();

                        bd.Conectar();
                        string comando = "UPDATE Obras set Quantidade = '" + resultado + "'  where ISBN = " + dto.Isbn;
                        bd.ExecutarComandoSQL(comando);

                        MessageBox.Show("O livro: " + " \"" + dto.Nome + " \"" + " foi vendido", "Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpar();
                        carrega_venda();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }

            else if (txtVenda.Text == txtVenda.Text)
            {
                try
                {
                    dto.Matriculla = int.Parse(txtMatricula.Text);
                    dto.Isbn = txtIsbn.Text;
                    dto.Venda = int.Parse(txtVenda.Text);
                    dto.Quantidade = int.Parse(txtQtde.Text);
                    dto.Nome = txtNome.Text;
                    dto.Valor = int.Parse(txtValor.Text);

                    var resultado = dto.Quantidade - dto.Venda;

                    var resultado1 = dto.Venda++;

                    txtValor.Text = resultado.ToString();

                    bd.Conectar();
                    string comando = "UPDATE Obras set Quantidade = '" + resultado + "'  where ISBN = " + dto.Isbn;
                    bd.ExecutarComandoSQL(comando);

                    MessageBox.Show("O livro: " + " \"" + dto.Nome + " \"" + " foi vendido", "Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    bd.Conectar();
                    //string comando1 = "INSERT INTO Funcionarios (vendidos) VALUES ('" + resultado1 + "',' where Matricula = '" + dto.Matriculla + "')";
                    string comando1 = "UPDATE Funcionarios set vendidos = '" + resultado1 + "'  where Matricula = " + dto.Matriculla;
                    bd.ExecutarComandoSQL(comando1);
                    carrega_venda();
                    limpar();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


            else if (txtMatricula.Text == txtMatricula.Text)
            {

                try
                {
                    dto.Matriculla = int.Parse(txtMatricula.Text);
                    dto.Isbn = txtIsbn.Text;
                    dto.Venda = int.Parse(txtVenda.Text);
                    dto.Quantidade = int.Parse(txtQtde.Text);
                    dto.Nome = txtNome.Text;
                    dto.Valor = int.Parse(txtValor.Text);

                    var resultado = dto.Quantidade - dto.Venda;

                    var resultado1 = dto.Venda++;

                    txtValor.Text = resultado1.ToString();

                    bd.Conectar();
                    string comando = "UPDATE Obras set Quantidade = '" + resultado + "'  where ISBN = " + dto.Isbn;
                    bd.ExecutarComandoSQL(comando);

                    MessageBox.Show("O livro: " + " \"" + dto.Nome + " \"" + " foi vendido", "Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    bd.Conectar();
                    //string comando1 = "INSERT INTO Funcionarios (vendidos) VALUES ('" + resultado1 + "',' where Matricula = '" + dto.Matriculla + "')";
                    string comando1 = "UPDATE Funcionarios set vendidos = '" + resultado1 + "'  where Matricula = " + dto.Matriculla;
                    bd.ExecutarComandoSQL(comando1);
                    carrega_venda();
                    limpar();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
            public void limpar()
            {
                txtIsbn.Clear();
                txtNome.Clear();
                txtAutor.Clear();
                txtEditora.Clear();
                txtNacionalidade.Clear();
                txtClassificacao.Clear();
                txtQtde.Clear();
                txtVenda.Clear();
                txtValor.Clear();
                txtMatricula.Clear();
                txtMatricula.Focus();
            }

            private void txtVenda_TextChanged(object sender, EventArgs e)
            {
                if (txtVenda.Text == "")
                {

                }
                else
                {
                    dto.Isbn = txtIsbn.Text;
                   dto.Venda = int.Parse(txtVenda.Text);
                    dto.Quantidade = int.Parse(txtQtde.Text);
                    dto.Nome = txtNome.Text;
                    dto.Valor = int.Parse(txtValor.Text);

                    var resultado = dto.Quantidade - dto.Venda;

                    var resultado1 = dto.Venda * dto.Valor;

                    txtValor.Text = resultado1.ToString();

                    
                }
         }

            private void timAtualiza_Tick(object sender, EventArgs e)
            {
                carrega_venda();
                
            }

            private void button1_Click(object sender, EventArgs e)
            {
                limpar();
            }

            private void Timhoras_Tick(object sender, EventArgs e)
            {
                lblNow.Text = (DateTime.Now.ToString());
            }

            private void btnPesquisa_Click(object sender, EventArgs e)
            {
                if (cmbPesquisa.Text == "Nome")
                {


                    dto.Nome = txtNome.Text;
                    dtgVenda.DataSource = bll.Pesquisa_livroNome(dto);

                }
                if (cmbPesquisa.Text == "Autor")
                {

                    dto.Autor = txtAutor.Text;
                    var result = dtgVenda.DataSource = bll.Pesquisa_livroAutor(dto);
                    result = dtgVenda.Rows.ToString();

                }
                if (cmbPesquisa.Text == "Editora")
                {
                    dto.Editora = txtEditora.Text;
                    dtgVenda.DataSource = bll.Pesquisa_livroEditora(dto);
                }

                if (cmbPesquisa.Text == "Nacionalidade")
                {

                    dto.Nacionalidade = txtNacionalidade.Text;
                    dtgVenda.DataSource = bll.Pesquisa_livroNacionalidade(dto);
                }
                if (cmbPesquisa.Text == "Classificacao")
                {
                    dto.Classificacao = txtClassificacao.Text;
                    dtgVenda.DataSource = bll.Pesquisa_livroClassificacao(dto);
                }
            }

            private void cmbPesquisa_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (cmbPesquisa.Text == "Nome")
                {

                    txtNome.Focus();
                    txtIsbn.Enabled = false;
                    txtAutor.Enabled = false;
                    txtEditora.Enabled = false;
                    txtNome.Enabled = true;
                    txtClassificacao.Enabled = false;
                    txtNacionalidade.Enabled = false;
                }
                if (cmbPesquisa.Text == "Autor")
                {

                    txtAutor.Focus();
                    txtIsbn.Enabled = false;
                    txtAutor.Enabled = true;
                    txtEditora.Enabled = false;
                    txtNome.Enabled = false;
                    txtClassificacao.Enabled = false;
                    txtNacionalidade.Enabled = false;
                }

                if (cmbPesquisa.Text == "Editora")
                {

                    txtEditora.Focus();
                    txtIsbn.Enabled = false;
                    txtAutor.Enabled = false;
                    txtEditora.Enabled = true;
                    txtNome.Enabled = false;
                    txtClassificacao.Enabled = false;
                    txtNacionalidade.Enabled = false;
                }

                if (cmbPesquisa.Text == "Nacionalidade")
                {

                    txtNacionalidade.Focus();
                    txtIsbn.Enabled = false;
                    txtAutor.Enabled = false;
                    txtEditora.Enabled = false;
                    txtNome.Enabled = false;
                    txtClassificacao.Enabled = false;
                    txtNacionalidade.Enabled = true;
                }

                if (cmbPesquisa.Text == "Classificacoes")
                {

                    txtClassificacao.Focus();
                    txtIsbn.Enabled = false;
                    txtAutor.Enabled = false;
                    txtEditora.Enabled = false;
                    txtNome.Enabled = false;
                    txtNacionalidade.Enabled = false;
                    txtClassificacao.Enabled = true;
                }
            }


            public void carrega(string teste) 
            {

            
            try
            {

                  bd.Conectar();
                  DataTable dt = new DataTable();
                  dt = bd.RetDataTable("SELECT * FROM Funcionarios WHERE Nome LIKE '" + teste + "%'");
                  string[] matricula = new string[] { dt.Rows[0].ItemArray[0].ToString()};
                  txtMat.Text = matricula[0].ToString();
                  txtMatricula.Text = matricula[0].ToString();

            }
            catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Console.ReadLine();
                }
            }


        private void btnAtualiza_Click(object sender, EventArgs e)
            {
                limpar();
                carrega_venda();
            }

        private void pnlBotao_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
