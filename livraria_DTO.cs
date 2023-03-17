using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livraria
{
    public partial class livraria_DTO
    {
        private static string usuario;
  

        public static void setUsuario(string variavelUsuario)
        {
            usuario = variavelUsuario;
        }

        public static string getUsuario()
        {
            return usuario;
        }

        private int vendidos;

        public int Vendidos
        {
            get { return vendidos; }
            set { vendidos = value; }
        }


        private int valor;

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        private int resultados;

        public int Resultados
        {
            get { return resultados; }
            set { resultados = value; }
        }
        private int venda;

        public int Venda
        {
            get { return venda; }
            set { venda = value; }
        }
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string senha;

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        private int quantidade;

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        private string cod_obra;

        public string Cod_obra
        {
            get { return cod_obra; }
            set { cod_obra = value; }

        }     
       private string isbn;

        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        private string autor;

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        private string editora;

        public string Editora
        {
            get { return editora; }
            set { editora = value; }
        }
        private string nacionalidade;

        public string Nacionalidade
        {
            get { return nacionalidade; }
            set { nacionalidade = value; }
        }
        private string classificacao;

        public string Classificacao
        {
            get { return classificacao; }
            set { classificacao = value; }
        }
        private string data;

        public string Data
        {
            get { return data; }
            set { data = value; }
        }
        private string sexo;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        private int matriculla;

        public int Matriculla
        {
            get { return matriculla; }
            set { matriculla = value; }
        }
        private string image;

        public string Image
        {
            get { return image; }
            set { image = value; }
        }

        private string logradouro;

        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }
        private string cep;

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        private string bairro;

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        private string cidade;

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        private string uf;

        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }
        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        private string telefone;

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        private string rg;

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        private string complemento;

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        private string numero;

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string endereco;

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        //private string teste;

        //public string Teste
        //{
        //    get { return teste; }
        //    set { teste = value; }
        //}

        private static string teste;


        public static void setTeste(string varTeste)
        {
            teste = varTeste;
        }

        public static string getTeste()
        {
            return teste;
        }


    }
}
