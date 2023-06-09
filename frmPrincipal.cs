﻿using System;
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
        DAO_Mysql dao = new DAO_Mysql();

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
            txtClienteVenda.Focus();

            carrega_venda();
            txtVenda.Enabled = false;
            btnVenda.Enabled = false;
            txtPerfil.Text = livraria_DTO.getPegamat();
            string mat = livraria_DTO.getPegamat();
            carregaFunc(mat);

        }
        public void carrega_venda()
        {

            dtgVenda.DataSource = bll.Busca_Livros();
            checaValoresNegativos();
        }

        private void dtgVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtVenda.Enabled = true;
            txtClienteVenda.Focus();
            //txtMatricula.Text = dtgVenda.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtIsbn.Text = dtgVenda.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dtgVenda.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAutor.Text = dtgVenda.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEditora.Text = dtgVenda.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNacionalidade.Text = dtgVenda.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtClassificacao.Text = dtgVenda.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtQtde.Text = dtgVenda.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtValor.Text = dtgVenda.Rows[e.RowIndex].Cells[7].Value.ToString();
            mTBValor.Text = dtgVenda.Rows[e.RowIndex].Cells[7].Value.ToString();


        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            if (txtIsbn.Text == "" || txtVenda.Text == "")
            {

                MessageBox.Show("Não foi especificado a quantidade de livros a ser vendido, ou não foi selecionado o livro. Verifique!", "Venda de livros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtVenda.Enabled = false;
                limpar();
            }

            else if (txtMatricula.Text == "" || txtClienteVenda.Text == "")
            {
                var result = MessageBox.Show("A matricula ou o cliente não foram informados, deseja fazer a compra sem informar a matricula/cliente ?", "Iformação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        if (txtMatricula.Text != "")
                        {

                            dto.Isbn = txtIsbn.Text;
                            dto.Vendidos = int.Parse(txtVenda.Text);
                            dto.Quantidade = int.Parse(txtQtde.Text);
                            dto.Nome = txtNome.Text;
                            dto.Valor = int.Parse(txtValor.Text);
                            dto.Matriculla = int.Parse(txtMatricula.Text);

                            //var resultado = dto.Quantidade - dto.Venda;

                            var resultado = dto.Venda * dto.Valor;

                            txtValor.Text = resultado.ToString();


                            bll.VenderLivros(dto);

                            MessageBox.Show("O livro: " + " \"" + dto.Nome + " \"" + " foi vendido", "Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpar();
                            carrega_venda();
                        }
                        else
                        {
                            dto.Isbn = txtIsbn.Text;
                            dto.Vendidos = int.Parse(txtVenda.Text);
                            dto.Quantidade = int.Parse(txtQtde.Text);
                            dto.Nome = txtNome.Text;
                            dto.Valor = int.Parse(txtValor.Text);
                            //dto.Matriculla = int.Parse(txtMatricula.Text);

                            //var resultado = dto.Quantidade - dto.Venda;

                            var resultado = dto.Venda * dto.Valor;

                            txtValor.Text = resultado.ToString();


                            bll.VenderLivros(dto);

                            MessageBox.Show("O livro: " + " \"" + dto.Nome + " \"" + " foi vendido", "Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpar();
                            carrega_venda();
                            checaValoresNegativos();
                        }

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                else if (result == System.Windows.Forms.DialogResult.No)
                {
                    txtClienteVenda.Focus();
                }
            }

            else if (txtMatricula.Text == txtMatricula.Text)
            {

                try
                {
                    dto.Matriculla = int.Parse(txtMatricula.Text);
                    dto.Isbn = txtIsbn.Text;
                    dto.Vendidos = int.Parse(txtVenda.Text);
                    dto.Quantidade = int.Parse(txtQtde.Text);
                    dto.Nome = txtNome.Text;
                    dto.Valor = int.Parse(txtValor.Text);

                    //var resultado = dto.Quantidade - dto.Venda;
                    var resultado = dto.Venda++;

                    txtValor.Text = resultado.ToString();
                    bll.VenderLivros(dto);

                    MessageBox.Show("O livro: " + " \"" + dto.Nome + " \"" + " foi vendido", "Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    carrega_venda();
                    limpar();
                    checaValoresNegativos();
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
            mTBValor.Clear();
            cmbPesquisa.Text = "";
            txtClienteVenda.Clear();
            txtClienteVenda.Focus();
            checaValoresNegativos();

            txtIsbn.Enabled = false;
            txtNome.Enabled = false;
            txtAutor.Enabled = false;
            txtEditora.Enabled = false;
            txtNacionalidade.Enabled = false;
            txtClassificacao.Enabled = false;
            txtQtde.Enabled = false;
            txtVenda.Enabled = false;
            txtValor.Enabled = false;
            mTBValor.Enabled = false;
        }

        private void txtVenda_TextChanged(object sender, EventArgs e)
        {
            var quantidade = txtQtde.Text;
            var vendidos = txtVenda.Text;

            if (txtQtde.Text == "" || txtVenda.Text == "")
            {

                limpar();
                btnVenda.Enabled = false;
                txtVenda.Enabled = false;

                MessageBox.Show("Livro não selecionado ou valor alterado. Selecione o livro novamente por favor!", "Livro não selecionado ou valor alterado.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else if (int.Parse(vendidos) > int.Parse(quantidade))
            {
                limpar();
                MessageBox.Show("O valor de livros vendidos está maior do que o estoque, verifique!", "Selecione o livro novamente por favor!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValor.Text = "";
                txtVenda.Text = "";
                mTBValor.Text = "";

                btnVenda.Enabled = false;
            }

            else if (txtVenda.Text == "" || txtIsbn.Text == "")
            {
                limpar();
                MessageBox.Show("Selecione um livro", "Selecione o livro novamente por favor!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValor.Text = "";
                txtVenda.Text = "";
                mTBValor.Text = "";
                btnVenda.Enabled = false;
                txtVenda.Enabled = false;

            }
            else
            {
                dto.Isbn = txtIsbn.Text;
                dto.Venda = int.Parse(txtVenda.Text);
                dto.Quantidade = int.Parse(txtQtde.Text);
                dto.Nome = txtNome.Text;
                dto.Valor = int.Parse(txtValor.Text);

                var resultado = dto.Venda * dto.Valor;

                txtValor.Text = resultado.ToString();
                mTBValor.Text = resultado.ToString();

                btnVenda.Enabled = true;
                txtVenda.Enabled = true;

            }
        }

        private void timAtualiza_Tick(object sender, EventArgs e)
        {
            carrega_venda();
            checaValoresNegativos();
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
            if (cmbPesquisa.Text == "Classificacoes")
            {
                dto.Classificacao = txtClassificacao.Text;
                dtgVenda.DataSource = bll.Pesquisa_livroClassificacao(dto);
            }
            checaValoresNegativos();
        }

        private void cmbPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPesquisa.Text == "Nome")
            {
                txtIsbn.Enabled = false;
                txtAutor.Enabled = false;
                txtEditora.Enabled = false;
                txtClassificacao.Enabled = false;
                txtNacionalidade.Enabled = false;
                txtQtde.Enabled = false;

                txtIsbn.Clear();
                txtAutor.Clear();
                txtEditora.Clear();
                txtClassificacao.Clear();
                txtNacionalidade.Clear();
                txtQtde.Clear();
                mTBValor.Clear();

                txtNome.Enabled = true;
                txtNome.Focus();
                
            }
            if (cmbPesquisa.Text == "Autor")
            {
                txtIsbn.Enabled = false;
                txtEditora.Enabled = false;
                txtNome.Enabled = false;
                txtClassificacao.Enabled = false;
                txtNacionalidade.Enabled = false;
                txtQtde.Enabled = false;

                txtIsbn.Clear();
                txtEditora.Clear();
                txtNome.Clear();
                txtClassificacao.Clear();
                txtNacionalidade.Clear();
                txtQtde.Clear();
                mTBValor.Clear();

                txtAutor.Enabled = true;
                txtAutor.Focus();
            }

            if (cmbPesquisa.Text == "Editora")
            {
                txtIsbn.Enabled = false;
                txtAutor.Enabled = false;
                txtNome.Enabled = false;
                txtClassificacao.Enabled = false;
                txtNacionalidade.Enabled = false;
                txtQtde.Enabled = false;

                txtIsbn.Clear();
                txtAutor.Clear();
                txtNome.Clear();
                txtClassificacao.Clear();
                txtNacionalidade.Clear();
                txtQtde.Clear();
                mTBValor.Clear();

                txtEditora.Enabled = true;
                txtEditora.Focus();
            }

            if (cmbPesquisa.Text == "Nacionalidade")
            {
                txtIsbn.Enabled = false;
                txtAutor.Enabled = false;
                txtEditora.Enabled = false;
                txtNome.Enabled = false;
                txtClassificacao.Enabled = false;
                txtQtde.Enabled = false;

                txtIsbn.Clear();
                txtAutor.Clear();
                txtEditora.Clear();
                txtNome.Clear();
                txtClassificacao.Clear();
                txtQtde.Clear();
                mTBValor.Clear();

                txtNacionalidade.Enabled = true;
                txtNacionalidade.Focus();
            }

            if (cmbPesquisa.Text == "Classificacoes")
            {
                txtIsbn.Enabled = false;
                txtAutor.Enabled = false;
                txtEditora.Enabled = false;
                txtNome.Enabled = false;
                txtNacionalidade.Enabled = false;
                txtQtde.Enabled = false;

                txtIsbn.Clear();
                txtAutor.Clear();
                txtEditora.Clear();
                txtNome.Clear();
                txtNacionalidade.Clear();
                txtQtde.Clear();
                mTBValor.Clear();


                txtClassificacao.Enabled = true;
                txtClassificacao.Focus();
            }
        }


        public void carregaFunc(string nomeFunc)
        {

            if (nomeFunc == "" || nomeFunc == null)
            {


                txtMat.Text = "";

            }
            else
            {
                try
                {

                    dao.Conectar();
                    DataTable dt = new DataTable();
                    dt = dao.RetDataTable("SELECT * FROM Funcionarios WHERE Nome LIKE '" + nomeFunc + "%'");
                    string[] matricula = new string[] { dt.Rows[0].ItemArray[0].ToString() };
                    string[] name = new string[] { dt.Rows[0].ItemArray[1].ToString() };
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
        }

        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            limpar();
            carrega_venda();
        }

        private void frmPai_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void txtVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmLivros objFrmLivros = new frmLivros();
            objFrmLivros.ShowDialog();
        }

        private void txtClienteVenda_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F2)
            {
                txtClienteVenda.Text = "";
                frmBuscaClientes objFrmClientes = new frmBuscaClientes();
                objFrmClientes.ShowDialog();

                if (livraria_DTO.getCliente() == null)
                {
                    txtClienteVenda.Text = "";
                    txtClienteVenda.Focus();
                }
                else
                {
                    txtClienteVenda.Text = livraria_DTO.getCliente().ToString();

                }
            }
        }

        public void checaValoresNegativos()
        {
            foreach (DataGridViewRow row in dtgVenda.Rows)
            {
                if (Convert.ToInt32(row.Cells[6].Value) == 0)
                {

                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void btnBuscarClientes_Click(object sender, EventArgs e)
        {

            frmBuscaClientes objFrmClientes = new frmBuscaClientes();
            objFrmClientes.ShowDialog();

            if (livraria_DTO.getCliente() == null)
            {
                txtClienteVenda.Text = "";
                txtClienteVenda.Select();
            }
            else
            {
                txtClienteVenda.Text = livraria_DTO.getCliente().ToString();

            }
        }

        private void frmPai_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            frmLogin objRetornaLogin = new frmLogin();
            objRetornaLogin.ShowDialog();

        }
    }
}
