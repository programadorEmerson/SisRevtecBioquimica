
using System;
using MySql.Data.MySqlClient;

public class ConexaoWeb
{

    public string mErro = "";

    // Variaveis de configuração de acesso ao banco de dados
    private string Server = "162.241.203.162";
    private string Database = "prog7279_producao";
    private string Usuario = "prog7279_emerson";
    private string Senha = "13572468@#";
    private MySqlConnection con = new MySqlConnection("server=162.241.203.162;port=3306;User Id=prog7279_emerson;database=prog7279_producao;password=13572468@#");

    public MySqlConnection conn;

    public MySqlConnection conexaoSql
    {
        get { return con; }
    }   

    public ConexaoWeb(TipoConexao.Conexao TConexao)
    {
        GetConexao(TConexao);
    }
    public ConexaoWeb()
    {
        GetConexao(TipoConexao.Conexao.Classe);
    }

    // Verifica se existe erro
    public Boolean ExisteErro()
    {
        if (mErro.Length > 0)
        {
            return true;
        }
        return false;
    }

    // Faz a Conexao com o Banco de Dados
    private void GetConexao(TipoConexao.Conexao TConexao)
    {
        try
        {
            string connectionStrings = "";
            if (TConexao == TipoConexao.Conexao.Classe)
            {
                connectionStrings = string.Format("server={0} ;user id={2};pwd='{3}';database={1};Connect Timeout=28800;Command Timeout=2880", this.Server, this.Database, this.Usuario, this.Senha);
            }

            this.conn = new MySqlConnection(connectionStrings);
        }
        catch (Exception erro)
        {
            this.mErro = erro.Message;
            this.conn = null;
        }
    }

    // Abre conexao com o Banco de Dados
    public Boolean OpenConexao()
    {
        Boolean _return = true;
        try
        {
            conn.Open();
        }
        catch (Exception erro)
        {
            this.mErro = erro.Message;
            _return = false;
        }

        return _return;
    }

    // Fecha conexao com o Banco de Dados
    public void CloseConexao()
    {
        conn.Close();
        conn.Dispose();
    }

}

/// <summary>
/// Definição de tipos de Conexão 
/// </summary>
//public class TipoConexao
//{
//    public enum ConexaoWeb { WebConfig = 1, Classe = 2 };
//}