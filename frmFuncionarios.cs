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
    public partial class frmFuncionarios : Form
    {
        Livraria_BLL bll = new Livraria_BLL();
        livraria_DTO dto = new livraria_DTO();

        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            carrega_funcionario();
        }
        public void carrega_funcionario()
        {
            dtgFuncionario.DataSource = bll.Seleciona_Funcionarios();
            
              
        }

        private void limpa_funcionarios()
        {
            txtMatricula.Clear();
            txtNomeFuncionario.Clear();
            mtbRgFuncionario.Clear();
            mtbCpfFuncionario.Clear();
            mtbTelefoneFuncionario.Clear();
            txtSenha.Clear();
            txtEnderecoFuncionario.Clear();
            txtBairroFuncionario.Clear();
            txtCidadeFuncionario.Clear();
            txtComplementoFuncionario.Clear();
            txtUfFuncionario.Clear();
            txtNumeroFuncionario.Clear();
            txtLogradouroFuncionario.Clear();
            mtbCepFuncionario.Clear();
            txtNomeFuncionario.Focus();
            txtVendidos.Clear();
        }
        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (txtNomeFuncionario.Text == "" || mtbCpfFuncionario.Text == "")
            {
                MessageBox.Show("Existem campos de preenchimento obrigatório vazio.", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else { 
            try
            {
                dto.Data = dtData.Text;
                dto.Nome = txtNomeFuncionario.Text;
                dto.Senha = txtSenha.Text;
                dto.Rg = mtbRgFuncionario.Text;
                dto.Cpf = mtbCpfFuncionario.Text;
                dto.Telefone = mtbTelefoneFuncionario.Text;
                dto.Sexo = cmbSexo.Text;
                dto.Endereco = txtEnderecoFuncionario.Text;
                dto.Bairro = txtBairroFuncionario.Text;
                dto.Cidade = txtCidadeFuncionario.Text;
                dto.Complemento = txtComplementoFuncionario.Text;
                dto.Uf = txtUfFuncionario.Text;
                dto.Numero = txtNumeroFuncionario.Text;
                dto.Logradouro = txtLogradouroFuncionario.Text;
                dto.Cep = mtbCepFuncionario.Text;

                string ChecaNome = dto.Nome;
                if (bll.checaFuncionarios(ChecaNome))
                {

                    MessageBox.Show("Este nome de usuário já existe e não pode ser repitido! Escolha outro por favor!", "Nome já existente.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNomeFuncionario.Focus();

                } else { 

                bll.Inserir_Funcionarios(dto);

                MessageBox.Show("O Funcionario(a): \" " + txtNomeFuncionario.Text + " \" foi cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                carrega_funcionario();
                limpa_funcionarios();
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
       }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void dtgFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {  
            txtMatricula.Text              = dtgFuncionario.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNomeFuncionario.Text        = dtgFuncionario.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSenha.Text                  = dtgFuncionario.Rows[e.RowIndex].Cells[2].Value.ToString();
            mtbRgFuncionario.Text          = dtgFuncionario.Rows[e.RowIndex].Cells[3].Value.ToString();
            mtbCpfFuncionario.Text         = dtgFuncionario.Rows[e.RowIndex].Cells[4].Value.ToString();
            mtbTelefoneFuncionario.Text    = dtgFuncionario.Rows[e.RowIndex].Cells[5].Value.ToString();
            cmbSexo.Text                   = dtgFuncionario.Rows[e.RowIndex].Cells[6].Value.ToString();
            dtData.Text                    = dtgFuncionario.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtEnderecoFuncionario.Text    = dtgFuncionario.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtBairroFuncionario.Text      = dtgFuncionario.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtCidadeFuncionario.Text      = dtgFuncionario.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtComplementoFuncionario.Text = dtgFuncionario.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtUfFuncionario.Text          = dtgFuncionario.Rows[e.RowIndex].Cells[12].Value.ToString();
            txtNumeroFuncionario.Text      = dtgFuncionario.Rows[e.RowIndex].Cells[13].Value.ToString();
            txtLogradouroFuncionario.Text  = dtgFuncionario.Rows[e.RowIndex].Cells[14].Value.ToString();
            mtbCepFuncionario.Text         = dtgFuncionario.Rows[e.RowIndex].Cells[15].Value.ToString();
            //txtVendidos.Text = dtgFuncionario.Rows[e.RowIndex].Cells[16].Value.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtMatricula.Text != "")
            {
                dto.Matriculla = int.Parse(txtMatricula.Text);
                dto.Nome = txtNomeFuncionario.Text;
                dto.Rg = mtbRgFuncionario.Text;
                dto.Cpf = mtbCpfFuncionario.Text;
                dto.Telefone = mtbTelefoneFuncionario.Text;
                dto.Sexo = cmbSexo.Text;
                dto.Data = dtData.Text;
                dto.Endereco = txtEnderecoFuncionario.Text;
                dto.Bairro = txtBairroFuncionario.Text;
                dto.Cidade = txtCidadeFuncionario.Text;
                dto.Complemento = txtComplementoFuncionario.Text;
                dto.Uf = txtUfFuncionario.Text;
                dto.Numero = txtNumeroFuncionario.Text;
                dto.Logradouro = txtLogradouroFuncionario.Text;
                dto.Cep = mtbCepFuncionario.Text;

                bll.Atualizar_Funcionario(dto);
                MessageBox.Show("O Funcionario(a): \" " + txtNomeFuncionario.Text + " \" foi atualizado com sucesso !", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpa_funcionarios();
                carrega_funcionario();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            carrega_funcionario();
            limpa_funcionarios();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMatricula.Text != "")
                {
                    var result = MessageBox.Show("Deseja realmente excluir o registro " + "\" " + txtMatricula.Text + "\" " + " Nome \" " + txtNomeFuncionario.Text + "\" que foi selecionado ?", "Exclusao", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        bll.Excluir_Funcionario(txtMatricula.Text);

                        MessageBox.Show("O cliente(a): " + "\"" + txtNomeFuncionario.Text + "\" " + " foi excluido com sucesso!", "Exclusao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       limpa_funcionarios();
                        carrega_funcionario();
                    }

                    else if (result == System.Windows.Forms.DialogResult.Cancel)
                    {
                        limpa_funcionarios();
                        carrega_funcionario();
                    }

                }
                else if (txtMatricula.Text == "")
                {
                    MessageBox.Show("A Matricula é um campo obrigatorio para a exclusao! por favor preencha e tente novamente", "Campo Matricula em branco", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNomeFuncionario.Focus();
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

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            dto.Matriculla = int.Parse(txtMatricula.Text);
            dtgFuncionario.DataSource = bll.Pesquisa_Funcionarios(dto);
        }
        }
    }

