using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using livraria;
using DAL;

namespace livraria
{
    class Livraria_BLL
    {

        livraria_DTO dto = new livraria_DTO();
        DAO_Mysql dao = new DAO_Mysql();

        public bool Valida_Login(livraria_DTO dto)
        {
            try
            {
                string condicao = string.Format(" Nome = '{0}' and senha = '{1}'", dto.Login, dto.Senha);
                DataTable dt = dao.Visualizar_Dados("Funcionarios", "Senha", condicao);
                if ((dt.Rows.Count == 1))
                {
                    return true;

                }

                else
                {
                    return false;

                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Inserir_clientes(livraria_DTO dto)
        {

            try
            {
                string nome = dto.Nome.Replace("'", "''");
                string cep = dto.Cep.Replace("-", "-");
                dao.Conectar();
                string comando = "INSERT INTO Cliente (CPF,Nome,Telefone,RG,Endereco,UF,Complemento,Numero,Cidade,Bairro,CEP,logradouro) VALUES('" + dto.Cpf + "','" + nome + "','" + dto.Telefone + "','" + dto.Rg + "','" + dto.Endereco + "','" + dto.Uf + "','" + dto.Complemento + "','" + dto.Numero + "','" + dto.Cidade + "','" + dto.Bairro + "','" + cep + "','" + dto.Logradouro + "')";
                dao.ExecutarComandoSQL(comando);
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

        public void Atualizar_cliente(livraria_DTO dto) //Metodo
        {
            try
            {
                string nome = dto.Nome.Replace("'", "''");
                string cep = dto.Cep.Replace("-", "-");
                dao.Conectar();
                string comando = "UPDATE Cliente set Nome = '" + nome + "', Telefone = '" + dto.Telefone + "', RG = '" + dto.Rg + "', Endereco = '" + dto.Endereco + "', UF = '" + dto.Uf + "', Complemento = '" + dto.Complemento + "', Numero = '" + dto.Numero + "', Cidade = '" + dto.Cidade + "', Bairro = '" + dto.Bairro + "', CEP = '" + cep + "', Logradouro = '" + dto.Logradouro + "', CPF = '" + dto.Cpf + "' where Codigo_Cliente = " + dto.Codigo;
                dao.ExecutarComandoSQL(comando);
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar: " + ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
        public DataTable Seleciona_clientes()
        {
            try
            {
                DataTable dt = new DataTable();
                dao.Conectar();
                dt = dao.RetDataTable("SELECT * from Cliente");
                return dt;
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
        public void excluir_cliente(string codigo)
        {
            try
            {
                dao.Conectar();
                string comando = "DELETE FROM Cliente where Codigo_Cliente = " + codigo;
                dao.ExecutarComandoSQL(comando);
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar o cliente: " + ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
        public DataTable Seleciona_Funcionarios()
        {
            try
            {
                DataTable dt = new DataTable();
                dao.Conectar();
                dt = dao.RetDataTable("SELECT * from Funcionarios");
                return dt;
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


        public DataTable Pesquisa_Funcionarios(livraria_DTO dto)
        {
            try
            {
                DataTable dt = new DataTable();
                dao.Conectar();
                dt = dao.RetDataTable("SELECT * from Funcionarios WHERE Matricula LIKE '%" + dto.Matriculla + "%'");
                return dt;
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

        public void Inserir_Funcionarios(livraria_DTO dto)
        {

            try
            {
                string nome = dto.Nome.Replace("'", "''");
                string cep = dto.Cep.Replace("-", "-");

                dao.Conectar();
                string comando = "INSERT INTO Funcionarios (Nome,senha, RG, cpf, telefone, sexo, Data_nascimento, Endereco, Bairro, Cidade, Complemento, UF, Numero, Logradouro, CEP) VALUES('" + nome + "','" + dto.Senha + "','" + dto.Rg + "','" + dto.Cpf + "','" + dto.Telefone + "','" + dto.Sexo + "','" + dto.Data + "','" + dto.Endereco + "','" + dto.Bairro + "','" + dto.Cidade + "','" + dto.Complemento + "','" + dto.Uf + "','" + dto.Numero + "', '" + dto.Logradouro + "','" + cep + "')";
                dao.ExecutarComandoSQL(comando);
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
        public void Atualizar_Funcionario(livraria_DTO dto) //Metodo
        {
            try
            {
                string nome = dto.Nome.Replace("'", "''");
                string cep = dto.Cep.Replace("-", "-");
                dao.Conectar();
                string comando = "UPDATE Funcionarios set Nome = '" + nome + "', RG = '" + dto.Rg + "', cpf = '" + dto.Cpf + "', telefone = '" + dto.Telefone + "', sexo = '" + dto.Sexo + "', Data_nascimento = '" + dto.Data + "', Endereco = '" + dto.Endereco + "', Bairro = '" + dto.Bairro + "', Cidade = '" + dto.Cidade + "', Complemento = '" + dto.Complemento + "', uf = '" + dto.Uf + "', numero = '" + dto.Numero + "', logradouro = '" + dto.Logradouro + "', CEP = '" + cep + "' where Matricula = " + dto.Matriculla;
                dao.ExecutarComandoSQL(comando);
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar: " + ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
        public void Excluir_Funcionario(string Matricula) //Metodo
        {
            try
            {
                dao.Conectar();
                string comando = "DELETE FROM Funcionarios where Matricula = " + Matricula;
                dao.ExecutarComandoSQL(comando);
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar o Funcionario: " + ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
        public void Inserir_Livros(livraria_DTO dto)
        {

            try
            {
                string nome = dto.Nome.Replace("'", "''");
                string autor = dto.Autor.Replace("'", "''");
                string editora = dto.Editora.Replace("'", "''");
                dao.Conectar();
                string comando = "INSERT INTO Obras (ISBN, nome, Autor, Editora, Nacionalidade, Classificacao, quantidade, valor) VALUES ('" + dto.Isbn + "','" + dto.Nome + "','" + dto.Autor + "','" + dto.Editora + "','" + dto.Nacionalidade + "','" + dto.Classificacao + "','" + dto.Quantidade + "','" + dto.Valor + "')";
                dao.ExecutarComandoSQL(comando);
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

        public void VenderLivros(livraria_DTO dto)
        {

            try
            {
                dao.Conectar();
                string comando = "INSERT INTO venda (funcionarios_Matricula,obras_ISBN,Qtde_Venda) VALUES ('" + dto.Matriculla + "','" + dto.Isbn + "','" + dto.Vendidos + "')";
                dao.ExecutarComandoSQL(comando);
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


        public DataTable Seleciona_Livros()
        {
            try
            {
                DataTable dt = new DataTable();
                dao.Conectar();
                dt = dao.RetDataTable("SELECT * from Obras");
                return dt;
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
        public void Atualizar_Livros(livraria_DTO dto) //Metodo
        {
            try
            {

                string nome = dto.Nome.Replace("'", "''");
                string autor = dto.Autor.Replace("'", "''");
                string editora = dto.Editora.Replace("'", "''");
                dao.Conectar();
                string comando = "UPDATE Obras set nome = '" + nome + "', Autor = '" + autor + "', Editora = '" + editora + "', Nacionalidade = '" + dto.Nacionalidade + "', Classificacao = '" + dto.Classificacao + "', Quantidade = '" + dto.Quantidade + "', valor = '" + dto.Valor + "'  where ISBN = " + dto.Isbn;
                dao.ExecutarComandoSQL(comando);
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar: " + ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
        public void Excluir_Livro(string Isbn) //Metodo
        {
            try
            {
                dao.Conectar();
                string comando = "DELETE FROM Obras where ISBN = " + Isbn;
                dao.ExecutarComandoSQL(comando);
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar o cliente: " + ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }

        public DataTable Pesquisa_livroNome(livraria_DTO dto)
        {
            try
            {
                DataTable dt = new DataTable();
                dao.Conectar();
                string nome = dto.Nome.Replace("'", "''");
                dt = dao.RetDataTable("SELECT * from Obras WHERE nome LIKE '%" + nome + "%'");
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Pesquisa_livroAutor(livraria_DTO dto)
        {
            try
            {

                DataTable dt = new DataTable();
                string autor = dto.Autor.Replace("'", "''");
                dao.Conectar();
                dt = dao.RetDataTable("SELECT * from Obras WHERE Autor LIKE '%" + autor + "%'");
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Pesquisa_livroEditora(livraria_DTO dto)
        {
            try
            {
                DataTable dt = new DataTable();
                string editora = dto.Editora.Replace("'", "''");
                dao.Conectar();
                dt = dao.RetDataTable("SELECT * from Obras WHERE Editora LIKE '%" + editora + "%'");
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Pesquisa_livroNacionalidade(livraria_DTO dto)
        {
            try
            {
                DataTable dt = new DataTable();
                dao.Conectar();
                dt = dao.RetDataTable("SELECT * from Obras WHERE Nacionalidade LIKE '%" + dto.Nacionalidade + "%'");
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public DataTable Pesquisa_livroClassificacao(livraria_DTO dto)
        {
            try
            {
                DataTable dt = new DataTable();
                dao.Conectar();
                dt = dao.RetDataTable("SELECT * from Obras WHERE Classificacao LIKE '%" + dto.Classificacao + "%'");
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Busca_Livros()
        {
            try
            {
                DataTable dt = new DataTable();
                dao.Conectar();
                //dt = dao.RetDataTable("SELECT * FROM Obras WHERE Quantidade != 0");
                dt = dao.RetDataTable("SELECT * FROM Obras");
                return dt;
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

        public bool checaLivros(string Isbn)
        {
            try
            {

                dao.Conectar();
                DataTable dt = new DataTable();
                dt = dao.RetDataTable("SELECT * FROM obras WHERE ISBN = '" + Isbn + "'");


                if (dt.Rows.Count == 1 || dt.Rows.Count >= 1) { return true; }

                else
                {
                    return false;
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

        public bool checaFuncionarios(string Nome)
        {
            try
            {

                dao.Conectar();
                DataTable dt = new DataTable();
                dt = dao.RetDataTable("SELECT * FROM Funcionarios WHERE Nome = '" + Nome + "'");


                if (dt.Rows.Count == 1 || dt.Rows.Count >= 1) { return true; }

                else
                {
                    return false;
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

        public bool checaClientes(string Nome)
        {
            try
            {

                dao.Conectar();
                DataTable dt = new DataTable();
                dt = dao.RetDataTable("SELECT Nome FROM Cliente WHERE Nome = '" + Nome + "'");


                if (dt.Rows.Count == 1 || dt.Rows.Count >= 1) { return true; }

                else
                {
                    return false;
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
}
