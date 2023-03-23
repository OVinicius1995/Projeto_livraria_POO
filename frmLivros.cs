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
    public partial class frmLivros : Form
    {
        livraria_DTO dto = new livraria_DTO();
        Livraria_BLL bll = new Livraria_BLL();
        
        
        public frmLivros()
        {
            InitializeComponent();
            
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            try
            {

                //dto.Cod_obra = 0;
                dto.Isbn = mtbIsbn.Text;
                dto.Autor = txtAutor.Text;
                dto.Editora = txtEditora.Text;
                dto.Nacionalidade = txtNacionalidade.Text;
                dto.Classificacao = txtClassificacao.Text;
                dto.Nome = txtNomeLivro.Text;
                dto.Quantidade = int.Parse(mtbQtde.Text);
                dto.Valor = int.Parse(mskValor.Text);

                string mat = dto.Isbn;
                if (bll.carreganovo(mat)) { MessageBox.Show("Já existe"); } else { MessageBox.Show("Não!"); }

                bll.Inserir_Livros(dto);
                MessageBox.Show("O Livro : " + "\" " + txtNomeLivro.Text + " \" " +" foi  cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                carrega_livros();
                limpa_livros();
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
        public void carrega_livros()
        {
            dtgLivros.DataSource = bll.Seleciona_Livros();
            
        }

        private void frmLivros_Load(object sender, EventArgs e)
        {
            txtNomeLivro.Focus();
            carrega_livros();
        }

        private void dtgLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mtbIsbn.Text = dtgLivros.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNomeLivro.Text = dtgLivros.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAutor.Text = dtgLivros.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEditora.Text = dtgLivros.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNacionalidade.Text = dtgLivros.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtClassificacao.Text = dtgLivros.Rows[e.RowIndex].Cells[5].Value.ToString();
            mtbQtde.Text = dtgLivros.Rows[e.RowIndex].Cells[6].Value.ToString();
            mskValor.Text = dtgLivros.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (mtbIsbn.Text != "")
                {
                    dto.Isbn = mtbIsbn.Text;
                    dto.Nome = txtNomeLivro.Text;
                    dto.Autor = txtAutor.Text;
                    dto.Editora = txtEditora.Text;
                    dto.Nacionalidade = txtNacionalidade.Text;
                    dto.Classificacao = txtClassificacao.Text;
                    dto.Quantidade = int.Parse(mtbQtde.Text);
                    dto.Valor = int.Parse(mskValor.Text);

                    bll.Atualizar_Livros(dto);
                    MessageBox.Show("O Livro : " + " \" " + txtNomeLivro.Text + " \" " + " foi  atualizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    carrega_livros();
                    limpa_livros();
                }
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

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (mtbIsbn.Text != "")
                {
                    var result = MessageBox.Show("Deseja realmente excluir o registro " + " \"" + mtbIsbn.Text + " \" " + " de nome " + " \"" +txtNomeLivro.Text + " \""+ " que foi selecionado ?", "Exclusao", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        bll.Excluir_Livro(mtbIsbn.Text);

                        MessageBox.Show("O livro: " + " \"" + txtNomeLivro.Text + " \"" + " foi excluido com sucesso!", "Exclusao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpa_livros();
                        carrega_livros();
                    }

                    else if (result == System.Windows.Forms.DialogResult.Cancel)
                    {
                        limpa_livros();
                        carrega_livros();
                    }

                }
                else if (mtbIsbn.Text == "")
                {
                    MessageBox.Show("O ISBN é um campo obrigatorio para a exclusao! por favor preencha e tente novamente", "Campo ISBN em branco", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mtbIsbn.Focus();
                }
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
        public void limpa_livros()
        {
            mtbIsbn.Clear();
            txtNomeLivro.Clear();
            txtAutor.Clear();
            txtEditora.Clear();
            txtNacionalidade.Clear();
            txtClassificacao.Clear();
            mtbQtde.Clear();
            mskValor.Clear();
            mtbIsbn.Focus();
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
           
            Close();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            if (cmbPesquisa.Text == "Nome")
            {
               
                
                dto.Nome = txtNomeLivro.Text;
                dtgLivros.DataSource = bll.Pesquisa_livroNome(dto);
                
            }
            if (cmbPesquisa.Text == "Autor")
            {
                
                dto.Autor = txtAutor.Text;
               var result = dtgLivros.DataSource = bll.Pesquisa_livroAutor(dto);
               result = dtgLivros.Rows.ToString();
               
            }
            if (cmbPesquisa.Text == "Editora")
            {
                dto.Editora = txtEditora.Text;
                dtgLivros.DataSource = bll.Pesquisa_livroEditora(dto);
            }

            if (cmbPesquisa.Text == "Nacionalidade")
            {
                
                dto.Nacionalidade = txtNacionalidade.Text;
                dtgLivros.DataSource = bll.Pesquisa_livroNacionalidade(dto);
            }
                if(cmbPesquisa.Text == "Classificacao")
                {
                    dto.Classificacao = txtClassificacao.Text;
                    dtgLivros.DataSource = bll.Pesquisa_livroClassificacao(dto);
                }
  }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            mtbIsbn.Focus();
            mtbIsbn.Enabled = true;
            txtAutor.Enabled = true;
            txtEditora.Enabled = true;
            txtNomeLivro.Enabled = true;
            txtClassificacao.Enabled = true;
            txtNacionalidade.Enabled = true;

            limpa_livros();
            carrega_livros();
        }

        private void cmbPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPesquisa.Text == "Nome")
            {
                
                txtNomeLivro.Focus();
                mtbIsbn.Enabled = false;
                txtAutor.Enabled = false;
                txtEditora.Enabled = false;
                txtNomeLivro.Enabled = true;
                txtClassificacao.Enabled = false;
                txtNacionalidade.Enabled = false;
            }
            if (cmbPesquisa.Text == "Autor")
            {
                
                txtAutor.Focus();
                mtbIsbn.Enabled = false;
                txtAutor.Enabled = true;
                txtEditora.Enabled = false;
                txtNomeLivro.Enabled = false;
                txtClassificacao.Enabled = false;
                txtNacionalidade.Enabled = false;
            }

            if (cmbPesquisa.Text == "Editora")
            {
                
                txtEditora.Focus();
                mtbIsbn.Enabled = false;
                txtAutor.Enabled = false;
                txtEditora.Enabled = true;
                txtNomeLivro.Enabled = false;
                txtClassificacao.Enabled = false;
                txtNacionalidade.Enabled = false;
            }

            if (cmbPesquisa.Text == "Nacionalidade")
            {
                
                txtNacionalidade.Focus();
                mtbIsbn.Enabled = false;
                txtAutor.Enabled = false;
                txtEditora.Enabled = false;
                txtNomeLivro.Enabled = false;
                txtClassificacao.Enabled = false;
                txtNacionalidade.Enabled = true;
            }

            if (cmbPesquisa.Text == "Classificacoes")
            {

                txtClassificacao.Focus();
                mtbIsbn.Enabled = false;
                txtAutor.Enabled = false;
                txtEditora.Enabled = false;
                txtNomeLivro.Enabled = false;
                txtNacionalidade.Enabled = false;
                txtClassificacao.Enabled = true;                
            }
        }
    }
}

