using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;


namespace livraria
{
    public partial class frmLogin : Form
    {
        livraria_DTO dto = new livraria_DTO();
        Livraria_BLL bll = new Livraria_BLL();
        public frmLogin()
        {
            InitializeComponent();
            InitWeb();
        }

        private async Task initialized()
        {
            await wbvPage.EnsureCoreWebView2Async(null);
            await wbvLinkedin.EnsureCoreWebView2Async(null);
        }

        private async void InitWeb()
        {
            await initialized();
            wbvPage.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;
            wbvPage.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
            wbvPage.CoreWebView2.Navigate("https://www.google.com.br/");

            wbvLinkedin.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;
            wbvLinkedin.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
            wbvLinkedin.CoreWebView2.Navigate("https://www.linkedin.com/");
        }

       public int retorna_perfil()
       {
           BLL_Login entra = new BLL_Login();
           entra.Nome1 = txtNome.Text;
           entra.Senha1 = txtSenha.Text;
           
            return entra.Busca_Perfil_Login();
       }


       private void btnEntrar_Click(object sender, EventArgs e)
       {
            
            this.Hide();
            BLL_Login entra = new BLL_Login();
            entra.Nome1 = txtNome.Text;
            entra.Senha1 = txtSenha.Text;
            livraria_DTO.setUsuario(entra.Nome1);
            livraria_DTO.setTeste(entra.Nome1);



            if (entra.Valida_Login())
            {
                
                MessageBox.Show("Bem Vindo(a) " + "\"" + entra.Nome1 + "\"", "Bem Vindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmPai objPrincipal = new frmPai();
                objPrincipal.ShowDialog();


            }

            else
            {
  
                MessageBox.Show("Nao foi efetuado o login verifique seu Nome e sua Senha", "Informaçao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Show();

                txtNome.Clear();
                txtSenha.Clear();
                txtNome.Focus();
            }
    }
       

       private void timcarrega_Tick(object sender, EventArgs e)
       {
           //pgbCarrega.Increment(1);
       }

       private void btnCancela_Click(object sender, EventArgs e)
       {
           txtNome.Clear();
           txtSenha.Clear();
           txtNome.Focus();
       }

       private void txtSenha_KeyDown(object sender, KeyEventArgs e)
       {
            
            if (e.KeyCode==Keys.Enter)
          {
            this.Hide();
           BLL_Login entra = new BLL_Login();
           entra.Nome1 = txtNome.Text;
           entra.Senha1 = txtSenha.Text;
           livraria_DTO.setUsuario(entra.Nome1);
           livraria_DTO.setTeste(entra.Nome1);




                if (entra.Valida_Login())
                {


                    MessageBox.Show("Bem Vindo(a) " + "\"" + entra.Nome1 + "\"", "Bem Vindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               frmPai objPrincipal = new frmPai();
               objPrincipal.ShowDialog();
              


                } else {

                    MessageBox.Show("Nao foi efetuado o login verifique seu Nome e sua Senha", "Informaçao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Show();

                    txtNome.Clear();
                    txtSenha.Clear();
                    txtNome.Focus();
                }
            }
          }

    }
    }

