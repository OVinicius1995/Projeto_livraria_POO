using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using livraria;
using MySql.Data.MySqlClient;
using DAL;
namespace livraria
{
    class BLL_Login
    {
        private int Perfil;

        public int Perfil1
        {
            get { return Perfil; }
            set { Perfil = value; }
        }


        private string Nome;

        public string Nome1
        {
            get { return Nome; }
            set { Nome = value; }
        }


        private string Senha;

        public string Senha1
        {
            get { return Senha; }
            set { Senha = value; }
        }
        //DAO_Mysql dao = new DAO_Mysql("localhost", "root", "", "livraria");
        
        //DAO_Mysql dao = new DAO_Mysql("localhost", "root", "", "livraria");

        AcessoBancoDados bd = new AcessoBancoDados();
        livraria_DTO dto = new livraria_DTO();

        public DataTable visualizar_todos_Func()
        {
            try
            {
                DAO_Mysql dao = new DAO_Mysql("localhost", "root", "", "livraria");
                return dao.Visualizar_Dados("Funcionarios");
                //return dao.Visualizar_dados("Matricula");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int Busca_Perfil_Login()
        {
            try
            {
                DAO_Mysql dao = new DAO_Mysql("localhost", "root", "", "livraria");
                string condicao = string.Format("Funcionarios = '{0}' and senha = '{1}'", Nome1, Senha1);
                DataTable dt = dao.Visualizar_Dados("Nome", "Senha", condicao);
                return int.Parse(dt.Rows[0].ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Valida_Login()
        {
            try
            {
                DAO_Mysql dao = new DAO_Mysql("localhost", "root", "", "livraria");
                string condicao = string.Format(" Nome = '{0}' and senha = '{1}'", Nome1, Senha1);
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
    }
}
