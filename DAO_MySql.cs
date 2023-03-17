using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;


namespace DAL
{
    public class DAO_Mysql
    {
        private MySqlConnection con;
        private MySqlCommand comando;
        private MySqlDataAdapter da;

        public DAO_Mysql(string servidor, string usuario, string senha, string banco)
        {
            try
            {
                con = new MySqlConnection();
                con.ConnectionString = string.Format("server={0};uid={1};pwd={2};database={3}", "localhost", "root", "", "livraria");

                comando = new MySqlCommand();
                comando.Connection = con;

                da = new MySqlDataAdapter();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Abrir_Conexao()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object Query_com_Retorno(string tabela, string campos)
        {
            try
            {
                comando.CommandText = string.Format("select {0} from {1}", campos, tabela);

                Abrir_Conexao();
                return comando.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable Visualizar_Dados(string tabela)
        {
            DataTable dt = new DataTable();
            try
            {
                comando.CommandText = string.Format("select * from {0}", tabela);

                da.SelectCommand = comando;
                Abrir_Conexao();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable Visualizar(string tabela, string campos)
        {
            DataTable dt = new DataTable();
            try
            {
                comando.CommandText = string.Format("select {0} from {1}", campos, tabela);

                da.SelectCommand = comando;
                Abrir_Conexao();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable Visualizar_Dados(string tabela, string campos, string condicao)
        {
            DataTable dt = new DataTable();
            try
            {
                comando.CommandText = string.Format("select {0} from {1} where {2}", campos, tabela, condicao);

                da.SelectCommand = comando;
                Abrir_Conexao();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public void Inserir_dados(string tabela, string valores)
        {
            try
            {
                comando.CommandText = string.Format("insert into {0} values({1})", tabela, valores);

                Abrir_Conexao();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public void Inserir_dados(string tabela, string campos, string valores)
        {
            try
            {
                comando.CommandText = string.Format("insert into {0}({1}) values({2})", tabela, campos, valores);

                Abrir_Conexao();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public void Excluir_dados(string tabela, string condicao)
        {
            try
            {
                comando.CommandText = string.Format("delete from {0} where {1}", tabela, condicao);

                Abrir_Conexao();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public void Alterar_dados(string tabela, string valores, string condicao)
        {
            try
            {
                comando.CommandText = string.Format("Update {0} set {1} where {2}", tabela, valores, condicao);

                Abrir_Conexao();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

    }
}
