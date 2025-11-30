using Microsoft.Data.SqlClient;

namespace GerenciadorDeTarefas.DAO
{
    internal class DataBase
    {
        private readonly string stringConexao;

        public DataBase(string conexao)
        {
            stringConexao = conexao;

        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(stringConexao);
        }
    }
}
