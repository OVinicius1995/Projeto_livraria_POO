using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging;


namespace livraria
{
    public partial class frmClientes : Form
    {
        livraria_DTO dto = new livraria_DTO();
        Livraria_BLL bll = new Livraria_BLL();
 
        public frmClientes()
        {
            InitializeComponent();
        }


        private void frmClientes_Load(object sender, EventArgs e)
        {
            
            carrega();
        }

        public void carrega()
        {
            dtgCliente.DataSource = bll.Seleciona_clientes();
        }

        public void limpa()
        {
            mtbCpf.Clear();
            mtbNumero.Clear();
            txtNome.Clear();
            mtbTelefone.Clear();
            mktRg.Clear();
            txtEndereco.Clear();
            txtComplemento.Clear();
            mtbNumero.Clear();
            txtUf.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            mtbCep.Clear();
            txtLogradouro.Clear();
            

        }

        public void dtgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mtbCodigo.Text = dtgCliente.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dtgCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
            mtbCpf.Text = dtgCliente.Rows[e.RowIndex].Cells[2].Value.ToString();
            mtbTelefone.Text = dtgCliente.Rows[e.RowIndex].Cells[3].Value.ToString();
            mktRg.Text = dtgCliente.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtEndereco.Text = dtgCliente.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtUf.Text = dtgCliente.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtComplemento.Text = dtgCliente.Rows[e.RowIndex].Cells[7].Value.ToString();
            mtbNumero.Text = dtgCliente.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtCidade.Text = dtgCliente.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtBairro.Text = dtgCliente.Rows[e.RowIndex].Cells[10].Value.ToString();
            mtbCep.Text = dtgCliente.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtLogradouro.Text = dtgCliente.Rows[e.RowIndex].Cells[12].Value.ToString();

            livraria_DTO.setCliente(dtgCliente.Rows[e.RowIndex].Cells[1].Value.ToString());
        }


        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (mtbCpf.Text == "" || txtNome.Text == "")
            {
                MessageBox.Show("Existem campo de preenchimento obrigatório vazios.", "Verifique!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbCpf.Focus();
            }
             else { 
            try
            {               
                dto.Cpf = mtbCpf.Text;
                dto.Nome = txtNome.Text;
                dto.Telefone = mtbTelefone.Text;
                dto.Rg = mktRg.Text;
                dto.Endereco = txtEndereco.Text;
                dto.Complemento = txtComplemento.Text;
                dto.Numero = mtbNumero.Text;
                dto.Uf = txtUf.Text;
                dto.Cidade = txtCidade.Text;
                dto.Bairro = txtBairro.Text;
                dto.Cep = mtbCep.Text;
                dto.Logradouro = txtLogradouro.Text;

                string checaNome = dto.Nome;

                    if (bll.checaClientes(checaNome))
                    {

                      var opcoes = MessageBox.Show("Este nome de cliente já existe na base de dados deseja prosseguir?", "Cliente já existente.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                        if (opcoes == System.Windows.Forms.DialogResult.Yes)
                        {

                            bll.Inserir_clientes(dto);

                            MessageBox.Show("O cliente: \" " + txtNome.Text + " \" foi cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpa();
                            carrega();
                        }
                        else if (opcoes == System.Windows.Forms.DialogResult.No || opcoes == System.Windows.Forms.DialogResult.Cancel)
                        {
                            //MessageBox.Show("Eu apertei NO OU CANCEL!!!");
                        }
                    }


                    else {

                        bll.Inserir_clientes(dto);

                        MessageBox.Show("O cliente: \" " + txtNome.Text + " \" foi cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        limpa();
                        carrega();
                    }

            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {

            if (mtbCpf.Text != "")
                try
                {

                    dto.Codigo = int.Parse(mtbCodigo.Text);
                    dto.Cpf = mtbCpf.Text;
                    dto.Nome = txtNome.Text;
                    dto.Telefone = mtbTelefone.Text;
                    dto.Rg = mktRg.Text;
                    dto.Endereco = txtEndereco.Text;
                    dto.Complemento = txtComplemento.Text;
                    dto.Numero = mtbNumero.Text;
                    dto.Uf = txtUf.Text;
                    dto.Cidade = txtCidade.Text;
                    dto.Bairro = txtBairro.Text;
                    dto.Cep = mtbCep.Text;
                    dto.Logradouro = txtLogradouro.Text;
                    

                    MessageBox.Show("O cliente: \" " + txtNome.Text + " \" foi atualizado com sucesso !", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpa();
                    bll.Atualizar_cliente(dto);
                    carrega();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    Console.ReadLine();
                }
            else if (mtbCpf.Text == "")
            {
                MessageBox.Show("O campo CPF é um campo obrigatorio !","Campo Obrigatorio", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (mtbCodigo.Text != "")
                {
                    var result = MessageBox.Show("Deseja realmente excluir o registro " + "\" " + txtNome.Text + " \"" + " que selecionado ?", "Exclusao", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {

                        bll.excluir_cliente(mtbCodigo.Text);

                        MessageBox.Show("O cliente: " + "\" " + txtNome.Text + " \"" + " foi excluido com sucesso!", "Exclusao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpa();
                        carrega();
                    }

                    else if (result == System.Windows.Forms.DialogResult.Cancel)
                    {
                        limpa();
                        carrega();
                    }

                }
                else if (mtbCodigo.Text == "") 
                {
                    MessageBox.Show("O CPF é um campo obrigatorio para a exclusao! por favor preencha e tente novamente", "Campo CPF em branco", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNome.Focus();
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpa(); 
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
     }
  }

