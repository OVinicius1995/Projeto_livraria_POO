using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using livraria;

namespace livraria
{
   public class AcessoBancoDados
    {
       private MySqlConnection conn;
       private MySqlCommand comando;
       private MySqlDataAdapter da;
       private DataTable data;
       
       livraria_DTO dto = new livraria_DTO();

       
       private string servidor = "localhost";
       private string usuario = "root";
       private string senha = "";
       private string bd = "livraria";

       public void Conectar()
       {
           if (conn != null)
               conn.Close();

           string connStr = String.Format("server={0};uid={1};pwd={2};database={3}", servidor, usuario, senha, bd);

           try
           {
               conn = new MySqlConnection();              
               comando = new MySqlCommand();
               comando.Connection = conn;
               da = new MySqlDataAdapter();

               conn = new MySqlConnection(connStr);
               conn.Open();
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
              
               if (conn.State == System.Data.ConnectionState.Closed)
                   conn.Open();
           }
               catch (Exception ex)
               {
                throw ex;
               }
            
       }
       public void ExecutarComandoSQL(string comandoSql)
       {
           MySqlCommand comando = new MySqlCommand(comandoSql, conn);
           comando.ExecuteNonQuery();
           conn.Close();
       }

    public DataTable RetDataTable(string sql)
    {
        data = new DataTable();
        da = new MySqlDataAdapter(sql, conn);
        da.Fill(data);
        return data;
    }

    }
}
  

