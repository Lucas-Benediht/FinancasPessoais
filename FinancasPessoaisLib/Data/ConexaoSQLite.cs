using System.Data.SQLite;

public class ConexaoSQLite
{
    private static SQLiteConnection conexao;

    public static SQLiteConnection ObterConexao()
    {
        if (conexao == null)
        {
            string caminhoBancoDados = @"Data Source=C:\Users\Benee\Desktop\ControleFinanceiro\FinancasPessoais.db";
            conexao = new SQLiteConnection(caminhoBancoDados);
        }

        if (conexao.State == System.Data.ConnectionState.Closed)
        {
            conexao.Open();
        }

        return conexao;
    }

    public static void FecharConexao()
    {
        if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
        {
            conexao.Close();
        }
    }
}
