using MySql.Data.MySqlClient;
using Revtec_Bioquimica.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revtec_Bioquimica.DAO
{
    class DAOEmbalagens : Conexao
    {

        public DataTable recuperarEmbalagem()
        {
            DataTable dt = new DataTable();
            try {
                conexaoSql.Open();
            } catch (Exception) {
                conexaoSql.Close();
                conexaoSql.Open();
            }
            MySqlCommand consultar = new MySqlCommand();
            consultar.Connection = conexaoSql;
            consultar.CommandText = "select embalagens_nome from tbl_embalagens ORDER BY embalagens_nome ASC";
            MySqlDataReader dr = consultar.ExecuteReader();
            dt.Load(dr);
            conexaoSql.Close();
            return dt;
        }

        public ModelEmbalagens dadosDoFrascoPeloId(int id) {
            ModelEmbalagens frasco = new ModelEmbalagens();
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_embalagens WHERE embalagens_id = " + "'" + id + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {
                    frasco.Embalagens_id = int.Parse(reader["embalagens_id"].ToString());
                    frasco.Embalagens_nome = reader["embalagens_nome"].ToString();
                    frasco.Embalagens_estoque = int.Parse(reader["embalagens_estoque"].ToString());
                    frasco.Embalagens_observacao = reader["embalagens_observacao"].ToString();
                    frasco.Embalagens_peso = double.Parse(reader["embalagens_peso"].ToString());
                    conexaoSql.Close();
                    return frasco;

                }

            } catch (Exception) {
                conexaoSql.Close();
                throw;
            }
            return frasco;
        }

        public double pesoEmbalagemPeloId(int id)
        {
            double retorno = 0;
            try
            {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_embalagens WHERE embalagens_id = " + "'" + id + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read())
                { retorno = double.Parse(reader["embalagens_peso"].ToString()); }
                conexaoSql.Close();
            }
            catch (Exception)
            {
                conexaoSql.Close();
                throw;
            }
            return retorno;
        }

        public int idEmbalagemPeloNome(String nome)
        {
            int retorno = 0;
            try
            {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_embalagens WHERE embalagens_nome = " + "'" + nome + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read())
                { retorno = int.Parse(reader["embalagens_id"].ToString()); }
                conexaoSql.Close();
            }
            catch (Exception)
            {
                conexaoSql.Close();
                throw;
            }
            return retorno;
        }

        public bool salvarEmbalagensDAO(ModelEmbalagens modelEmbalagens)
        {
            bool salvou = true;
            try
            {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand salvar = new MySqlCommand("insert into tbl_embalagens (embalagens_id, embalagens_nome, embalagens_estoque, embalagens_observacao, embalagens_peso) values (null, ?, ?, ?, ?)", conexaoSql);
                salvar.Parameters.Add("@embalagens_nome", MySqlDbType.VarChar, 100).Value = modelEmbalagens.Embalagens_nome;
                salvar.Parameters.Add("@embalagens_estoque", MySqlDbType.Int64).Value = modelEmbalagens.Embalagens_estoque;
                salvar.Parameters.Add("@embalagens_observacao", MySqlDbType.VarChar, 500).Value = modelEmbalagens.Embalagens_observacao;
                salvar.Parameters.Add("@embalagens_peso", MySqlDbType.Double).Value = modelEmbalagens.Embalagens_peso;
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

        public bool deletarEmbalagensDAO(String id)
        {
            bool salvou = true;
            try
            {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand salvar = new MySqlCommand("DELETE FROM tbl_embalagens WHERE embalagens_id = " + id, conexaoSql);
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

        public bool atualizarEmbalagensDAO(ModelEmbalagens modelEmbalagens)
        {
            bool salvou = true;
            try
            {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand salvar = new MySqlCommand("UPDATE tbl_embalagens SET embalagens_id=@embalagens_id, embalagens_nome=@embalagens_nome, embalagens_estoque=@embalagens_estoque, embalagens_observacao=@embalagens_observacao,  embalagens_peso=@embalagens_peso WHERE embalagens_id = " + modelEmbalagens.Embalagens_id, conexaoSql);
                salvar.Parameters.Add("@embalagens_id", MySqlDbType.Int64).Value = modelEmbalagens.Embalagens_id;
                salvar.Parameters.Add("@embalagens_nome", MySqlDbType.VarChar, 100).Value = modelEmbalagens.Embalagens_nome;               
                salvar.Parameters.Add("@embalagens_estoque", MySqlDbType.Int64).Value = modelEmbalagens.Embalagens_estoque;
                salvar.Parameters.Add("@embalagens_observacao", MySqlDbType.VarChar, 500).Value = modelEmbalagens.Embalagens_observacao;
                salvar.Parameters.Add("@embalagens_peso", MySqlDbType.Double).Value = modelEmbalagens.Embalagens_peso;
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

        public DataTable pesquisarEmbalagens(String pesquisa)
        {

            try
            {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_embalagens WHERE embalagens_nome = " + "'" +pesquisa+ "'", conexaoSql);
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

        public DataTable exibirEmbalagens()
        {

            try
            {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_embalagens", conexaoSql);
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

    }
}
