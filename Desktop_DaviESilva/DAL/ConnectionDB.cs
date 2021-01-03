using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop_DaviESilva_F0450H6.BLL;

namespace Desktop_DaviESilva_F0450H6.DAL
{
    class ConnectionDB
    {
        private static SqlConnection conexao;

        public ConnectionDB()
        {
            if (conexao == null)
            {
                conexao = new SqlConnection();
                // string de conexao com o banco de dados
                // obtem o dado do App.config
                conexao.ConnectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            }
        }

        // método responsável por abrir a conexao com o banco de dados
        public SqlConnection AbrirConexao()
        {
            try
            {
                if (conexao.State != System.Data.ConnectionState.Open)
                {
                    conexao.Open();
                }
                return conexao;
            }
            catch (SqlException e)
            {
                Console.WriteLine("Erro de conexao: " + e.Message);
            }
            return null;
        }

        // método responsável por fechar a conexao com o banco de dados
        public bool FecharConexao()
        {
            try
            {
                conexao.Close();
                return true;
            }
            catch (SqlException e)
            {
                Console.WriteLine("Erro ao fechar a conexao: " + e.Message);
            }
            return false;
        }
    }
}
