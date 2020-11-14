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
    class DAOTampa : Conexao
    {

        public DataTable recuperarCaixa()
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
            consultar.CommandText = "select tampa_nome from tbl_tampa";
            MySqlDataReader dr = consultar.ExecuteReader();
            dt.Load(dr);
            conexaoSql.Close();
            return dt;
        }
        public DataTable recuperarTampa() {
            DataTable dt = new DataTable();
            try {
                conexaoSql.Open();
            } catch (Exception) {
                conexaoSql.Close();
                conexaoSql.Open();
            }
            MySqlCommand consultar = new MySqlCommand();
            consultar.Connection = conexaoSql;
            consultar.CommandText = "select tampa_nome from tbl_tampa ORDER BY tampa_nome ASC";
            MySqlDataReader dr = consultar.ExecuteReader();
            dt.Load(dr);
            conexaoSql.Close();
            return dt;
        }


        public double pesoCaixaPeloId(int id)
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
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_tampa WHERE tampa_id = " + "'" + id + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read())
                { retorno = double.Parse(reader["clientes_peso"].ToString()); }
                conexaoSql.Close();
            }
            catch (Exception)
            {
                conexaoSql.Close();
                throw;
            }
            return retorno;
        }

        public double pesoTampaPeloNome(String nome) {
            double retorno = 0;
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_tampa WHERE tampa_nome = " + "'" + nome + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) { retorno = double.Parse(reader["tampa_peso"].ToString()); }
                conexaoSql.Close();
            } catch (Exception) {
                conexaoSql.Close();
                throw;
            }
            return retorno;
        }

        public int idTampaPeloNome(String nome)
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
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_tampa WHERE tampa_nome = " + "'" + nome + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read())
                { retorno = int.Parse(reader["tampa_id"].ToString()); }
                conexaoSql.Close();
            }
            catch (Exception)
            {
                conexaoSql.Close();
                throw;
            }
            return retorno;
        }

        public bool salvarTampaDAO(ModelTampa modelTampa)
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
                MySqlCommand salvar = new MySqlCommand("insert into tbl_tampa (tampa_id, tampa_nome, tampa_estoque, tampa_observacao, tampa_peso) values (null, ?, ?, ?, ?)", conexaoSql);
                salvar.Parameters.Add("@tampa_nome", MySqlDbType.VarChar, 100).Value = modelTampa.Tampa_nome;
                salvar.Parameters.Add("@tampa_estoque", MySqlDbType.Int64).Value = modelTampa.Tampa_estoque;
                salvar.Parameters.Add("@tampa_observacao", MySqlDbType.VarChar, 500).Value = modelTampa.Tampa_observacao;
                salvar.Parameters.Add("@tampa_peso", MySqlDbType.Double).Value = modelTampa.Tampa_peso;
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

        public bool deletarTampaDAO(String id)
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
                MySqlCommand salvar = new MySqlCommand("DELETE FROM tbl_Tampa WHERE Tampa_id = " + id, conexaoSql);
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

        public bool atualizarTampaDAO(ModelTampa modelTampa)
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
                MySqlCommand salvar = new MySqlCommand("UPDATE tbl_tampa SET tampa_id=@tampa_id, tampa_nome=@tampa_nome, tampa_estoque=@tampa_estoque, tampa_observacao=@tampa_observacao, tampa_peso=@tampa_peso WHERE tampa_id = " + modelTampa.Tampa_id, conexaoSql);
                salvar.Parameters.Add("@tampa_id", MySqlDbType.Int64).Value = modelTampa.Tampa_id;
                salvar.Parameters.Add("@tampa_nome", MySqlDbType.VarChar, 100).Value = modelTampa.Tampa_nome;               
                salvar.Parameters.Add("@tampa_estoque", MySqlDbType.Int64).Value = modelTampa.Tampa_estoque;
                salvar.Parameters.Add("@tampa_observacao", MySqlDbType.VarChar, 500).Value = modelTampa.Tampa_observacao;
                salvar.Parameters.Add("@tampa_peso", MySqlDbType.Double).Value = modelTampa.Tampa_peso;
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

        public DataTable pesquisarTampa(String pesquisa)
        {

            try
            {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_tampa WHERE tampa_nome = " + "'" +pesquisa+ "'", conexaoSql);
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

        public ModelTampa dadosDaTampaPeloId(int id) {
            ModelTampa tampa = new ModelTampa();
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_tampa WHERE tampa_id = " + "'" + id + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {
                    tampa.Tampa_id = int.Parse(reader["tampa_id"].ToString());
                    tampa.Tampa_nome = reader["tampa_nome"].ToString();
                    tampa.Tampa_estoque = int.Parse(reader["tampa_estoque"].ToString());
                    tampa.Tampa_observacao = reader["tampa_observacao"].ToString();
                    tampa.Tampa_peso = double.Parse(reader["tampa_peso"].ToString());
                    conexaoSql.Close();
                    return tampa;

                }

            } catch (Exception) {
                conexaoSql.Close();
                throw;
            }
            return tampa;
        }

        public DataTable exibirTampa()
        {

            try
            {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_tampa", conexaoSql);
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
