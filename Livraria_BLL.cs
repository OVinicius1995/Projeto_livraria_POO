using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using livraria;

namespace livraria
{
    class Livraria_BLL
    {
        
        AcessoBancoDados bd = new AcessoBancoDados();
        livraria_DTO dto = new livraria_DTO();
        BLL_Login lgo = new BLL_Login();

        public void Inserir_clientes( livraria_DTO dto)
        {

            try
            {
                string nome = dto.Nome.Replace("'", "''");
                string cep = dto.Cep.Replace("-", "-");
                bd.Conectar();
                string comando = "INSERT INTO Cliente (CPF,Nome,Telefone,RG,Endereco,UF,Complemento,Numero,Cidade,Bairro,CEP,logradouro) VALUES('" + dto.Cpf + "','" + nome + "','" + dto.Telefone + "','" + dto.Rg + "','" + dto.Endereco + "','" + dto.Uf + "','" + dto.Complemento + "','" + dto.Numero + "','" + dto.Cidade + "','" + dto.Bairro + "','" + cep + "','" + dto.Logradouro + "')";
                bd.ExecutarComandoSQL(comando);
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
                bd.Conectar();
                string comando = "UPDATE Cliente set Nome = '" + nome + "', Telefone = '" + dto.Telefone + "', RG = '" + dto.Rg + "', Endereco = '" + dto.Endereco + "', UF = '" + dto.Uf + "', Complemento = '" + dto.Complemento + "', Numero = '" + dto.Numero + "', Cidade = '" + dto.Cidade + "', Bairro = '" + dto.Bairro + "', CEP = '" + cep + "', Logradouro = '" + dto.Logradouro + "', CPF = '" + dto.Cpf + "' where Codigo_Cliente = " + dto.Codigo;
                bd.ExecutarComandoSQL(comando);
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
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * from Cliente");
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
                bd.Conectar();
                string comando = "DELETE FROM Cliente where Codigo_Cliente = " + codigo;
                bd.ExecutarComandoSQL(comando);
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
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * from Funcionarios");
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
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * from Funcionarios WHERE Matricula LIKE '%" + dto.Matriculla + "%'");
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

                bd.Conectar();
                string comando = "INSERT INTO Funcionarios (Nome,senha, RG, cpf, telefone, sexo, Data_nascimento, Endereco, Bairro, Cidade, Complemento, UF, Numero, Logradouro, CEP) VALUES('" + nome + "','" + dto.Senha + "','" + dto.Rg + "','" + dto.Cpf + "','" + dto.Telefone + "','" + dto.Sexo + "','" + dto.Data + "','" + dto.Endereco + "','" + dto.Bairro + "','" + dto.Cidade + "','" + dto.Complemento + "','" + dto.Uf + "','" + dto.Numero + "', '" + dto.Logradouro + "','" + cep + "')";
                bd.ExecutarComandoSQL(comando);
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
                bd.Conectar();
                string comando = "UPDATE Funcionarios set Nome = '" + nome + "', RG = '" + dto.Rg + "', cpf = '" + dto.Cpf + "', telefone = '" + dto.Telefone + "', sexo = '" + dto.Sexo + "', Data_nascimento = '" + dto.Data + "', Endereco = '" + dto.Endereco + "', Bairro = '" + dto.Bairro + "', Cidade = '" + dto.Cidade + "', Complemento = '" + dto.Complemento + "', uf = '" + dto.Uf + "', numero = '" + dto.Numero + "', logradouro = '" + dto.Logradouro + "', CEP = '" + cep + "' where Matricula = " + dto.Matriculla;
                bd.ExecutarComandoSQL(comando);
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
                bd.Conectar();
                string comando = "DELETE FROM Funcionarios where Matricula = " + Matricula;
                bd.ExecutarComandoSQL(comando);
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
                bd.Conectar();
                string comando = "INSERT INTO Obras (ISBN, nome, Autor, Editora, Nacionalidade, Classificacao, quantidade, valor) VALUES ('" + dto.Isbn + "','" + dto.Nome + "','" + dto.Autor + "','" + dto.Editora + "','" + dto.Nacionalidade + "','" + dto.Classificacao + "','" + dto.Quantidade + "','" + dto.Valor + "')";
                bd.ExecutarComandoSQL(comando);
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
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * from Obras");
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
                bd.Conectar();
                string comando = "UPDATE Obras set nome = '" + nome + "', Autor = '" + autor + "', Editora = '" + editora + "', Nacionalidade = '" + dto.Nacionalidade + "', Classificacao = '" + dto.Classificacao + "', Quantidade = '" + dto.Quantidade + "', valor = '" + dto.Valor + "'  where ISBN = " + dto.Isbn;
                bd.ExecutarComandoSQL(comando);
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
                bd.Conectar();
                string comando = "DELETE FROM Obras where ISBN = " + Isbn;
                bd.ExecutarComandoSQL(comando);
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
                bd.Conectar();
                string nome = dto.Nome.Replace("'", "''");
                dt = bd.RetDataTable("SELECT * from Obras WHERE nome LIKE '%" + nome + "%'");
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
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * from Obras WHERE Autor LIKE '%" + autor + "%'");
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
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * from Obras WHERE Editora LIKE '%" + editora + "%'");
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
                        bd.Conectar();
                        dt = bd.RetDataTable("SELECT * from Obras WHERE Nacionalidade LIKE '%" + dto.Nacionalidade + "%'");
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
                        bd.Conectar();
                        dt = bd.RetDataTable("SELECT * from Obras WHERE Classificacao LIKE '%" + dto.Classificacao + "%'");
                        return dt;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
        }

                public DataTable Venda_Livros()
                {
                try
                {
                      DataTable dt = new DataTable();
                    bd.Conectar();
                  dt = bd.RetDataTable("SELECT * FROM Obras");
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
                public void vender_livro(livraria_DTO dto)
                {
                    
                    bd.Conectar();
                    string comando = "UPDATE Obras set Quantidade = '" + dto.Resultados + "'  where ISBN = " + dto.Isbn;
                    bd.ExecutarComandoSQL(comando);
         
         }
    }
}