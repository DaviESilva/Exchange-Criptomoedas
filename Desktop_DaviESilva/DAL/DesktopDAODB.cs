using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop_DaviESilva_F0450H6.BLL;

namespace Desktop_DaviESilva_F0450H6.DAL
{
    class DesktopDAODB : IDesktopDAO
    {
        private ConnectionDB conexao;

        public DesktopDAODB()
        {
            conexao = new ConnectionDB();
        }

        public bool Inserir(User user)
        {
            SqlConnection conn = conexao.AbrirConexao();
            if (conn != null)
            {
                // cria um objeto SqlCommand para executar a instrução no banco de dados
                SqlCommand cmd = conn.CreateCommand();
                // adiciona o comando SQL a ser executado
                cmd.CommandText = "INSERT INTO [USER] (USERNAME, EMAIL, PASSWORD, BIRTHDAY, DOCUMENT, BTCVALUE, ETHVALUE, DOGEVALUE, XRPVALUE, USDTVALUE) " +
                    "VALUES (@username, @email, @password, @birthday, @document, @btc, @eth, @doge, @xrp, @usdt)";
                // adiciona o valor do parametro
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@birthday", user.Birthday);
                cmd.Parameters.AddWithValue("@document", user.Document);
                cmd.Parameters.AddWithValue("@btc", 0.00000000);
                cmd.Parameters.AddWithValue("@eth", 0.00000000);
                cmd.Parameters.AddWithValue("@doge", 0.00000000);
                cmd.Parameters.AddWithValue("@xrp", 0.00000000);
                cmd.Parameters.AddWithValue("@usdt", 0.00000000);

                // executa o comando e fecha a conexao
                cmd.ExecuteNonQuery();
                conexao.FecharConexao();
                return true;
            }
            return false;
        }

        public bool Atualizar(User user)
        {
            SqlConnection conn = conexao.AbrirConexao();
            if (conn != null)
            {
                // cria um objeto SqlCommand para executar a instrução no banco de dados
                SqlCommand cmd = conn.CreateCommand();
                // adiciona o comando SQL a ser executado
                cmd.CommandText = "UPDATE USERS SET " +
                    "USERNAME =  @username, " +
                    "EMAIL = @email, " +
                    "PASSWORD = @password, " +
                    "BIRTHDAY = @birthday, " +
                    "DOCUMENT = @document " +
                    "btcValue = 0.00" +
                    "ethValue = 0.00" +
                    "dogeValue = 0.00" +
                    "xrpValue = 0.00" +
                    "usdtValue = 0.00" +
                    "WHERE IDUSER = @iduser";
                // adiciona valor aos parametros
                cmd.Parameters.AddWithValue("@iduser", user.IdUser);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@birthday", user.Birthday);
                cmd.Parameters.AddWithValue("@document", user.Document);

                // executa o comando e fecha a conexao
                cmd.ExecuteNonQuery();
                conexao.FecharConexao();
                return true;
            }
            return false;
        }

        public bool Excluir(int iduser)
        {
            SqlConnection conn = conexao.AbrirConexao();
            if (conn != null)
            {
                // cria um objeto SqlCommand para executar a instrução no banco de dados
                SqlCommand cmd = conn.CreateCommand();
                // adiciona o comando SQL a ser executado
                cmd.CommandText = "DELETE FROM [USER] WHERE IDUSER = @iduser";
                // adiciona o valor do parametro
                cmd.Parameters.AddWithValue("@iduser", iduser);
                // executa o comando e fecha a conexao
                cmd.ExecuteNonQuery();
                conexao.FecharConexao();
                return true;
            }
            return false;
        }

        public DataSet ListarTodos()
        {
            string consulta = "SELECT * FROM [USER]";
            SqlConnection conn = conexao.AbrirConexao();
            if (conn != null)
            {
                // cria um objeto DataAdapter para obter os dados do banco e carregar em um DataSet
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conn);
                DataSet users = new DataSet();
                // preenche o DataSet com os dados obtidos pelo DataAdapter
                adapter.Fill(users, "USER");
                return users;
            }
            return null;
        }
    }
}