using MySql.Data.MySqlClient;
using Revtec_Bioquimica.Model;
using System;
using System.Windows.Forms;
using System.Data;

namespace Revtec_Bioquimica.DAO
{
    class DAOLoteLaboratorio : Conexao
    {

        public DataTable exibirLotes()
        {

            try
            {
                try
                {
                    conexaoSql.Open();
                }
                catch (Exception)
                {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_loteslaboratorio ORDER BY numero_lote ASC", conexaoSql);
                MySqlDataAdapter acessar = new MySqlDataAdapter();
                acessar.SelectCommand = buscar;

                DataTable tabela = new DataTable();
                acessar.Fill(tabela);
                conexaoSql.Close();
                return tabela;


            }
            catch
            {
                conexaoSql.Close();
                return null;
            }

        }

        public bool atualizarLoteDAO(ModelLoteLaboratorio modelLote)
        {
            bool salvou = true;
            try
            {
                try
                {
                    conexaoSql.Open();
                }
                catch (Exception)
                {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand salvar = new MySqlCommand("UPDATE tbl_lotes SET id_lote=@id_lote, numero_lote=@numero_lote, data_lote=@data_lote, produto_lote=@produto_lote, litragem_lote=@litragem_lote, cliente_lote=@cliente_lote WHERE lote_id = " + modelLote.Id_lote, conexaoSql);
                salvar.Parameters.Add("@id_lote", MySqlDbType.Int64).Value = modelLote.Id_lote;
                salvar.Parameters.Add("@numero_lote", MySqlDbType.VarChar, 45).Value = modelLote.Numero_lote;
                salvar.Parameters.Add("@data_lote", MySqlDbType.VarChar, 45).Value = modelLote.Data_lote;
                salvar.Parameters.Add("@produto_lote", MySqlDbType.VarChar, 100).Value = modelLote.Produto_lote;
                salvar.Parameters.Add("@litragem_lote", MySqlDbType.Double).Value = modelLote.Litragem_lote;
                salvar.Parameters.Add("@cliente_lote", MySqlDbType.VarChar, 100).Value = modelLote.Cliente_lote;
                salvar.ExecuteNonQuery();
                conexaoSql.Close();
            }
            catch (Exception erro)
            {
                conexaoSql.Close();
                MessageBox.Show(erro.Message);
            }
            return salvou;
        }

        public bool salvarLoteDAO(ModelLoteLaboratorio modelLote)
        {
            bool salvou = true;
            try
            {
                try
                {
                    conexaoSql.Open();
                }
                catch (Exception)
                {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand salvar = new MySqlCommand("insert into tbl_loteslaboratorio (id_lote, numero_lote, data_lote, produto_lote, litragem_lote, cliente_lote) values (null, ?, ?, ?, ?, ?)", conexaoSql);
                salvar.Parameters.Add("@numero_lote", MySqlDbType.VarChar, 45).Value = modelLote.Numero_lote;
                salvar.Parameters.Add("@data_lote", MySqlDbType.VarChar, 45).Value = modelLote.Data_lote;
                salvar.Parameters.Add("@produto_lote", MySqlDbType.VarChar, 100).Value = modelLote.Produto_lote;
                salvar.Parameters.Add("@litragem_lote", MySqlDbType.Double).Value = modelLote.Litragem_lote;
                salvar.Parameters.Add("@cliente_lote", MySqlDbType.VarChar, 100).Value = modelLote.Cliente_lote;
                salvar.ExecuteNonQuery();
                conexaoSql.Close();
            }
            catch
            {
                conexaoSql.Close();
                salvou = false;
            }
            return salvou;
        }

        public ModelLoteLaboratorio dadosDoloLote()
        {
            ModelLoteLaboratorio dadosDoLote = new ModelLoteLaboratorio();
            try
            {
                try
                {
                    conexaoSql.Open();
                }
                catch (Exception)
                {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_loteslaboratorio ORDER BY id_lote DESC", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read())
                {                    
                    dadosDoLote.Id_lote = int.Parse(reader["id_lote"].ToString());
                    dadosDoLote.Numero_lote = reader["numero_lote"].ToString();
                    dadosDoLote.Data_lote = reader["data_lote"].ToString();
                    dadosDoLote.Produto_lote = reader["produto_lote"].ToString();
                    dadosDoLote.Litragem_lote = double.Parse(reader["litragem_lote"].ToString());
                    dadosDoLote.Cliente_lote = reader["cliente_lote"].ToString();
                    conexaoSql.Close();
                    return dadosDoLote;
                }
            }
            catch (Exception)
            {
                conexaoSql.Close();
                throw;
            }
            return dadosDoLote;
        }
    }
}
