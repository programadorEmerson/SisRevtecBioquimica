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
    class DAOCaixas : Conexao
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
            consultar.CommandText = "select caixas_nome from tbl_caixas ORDER BY caixas_nome ASC";
            MySqlDataReader dr = consultar.ExecuteReader();
            dt.Load(dr);
            conexaoSql.Close();
            return dt;
        }

        public ModelCaixas dadosDaCaixaPeloId(int id) {
            ModelCaixas caixa = new ModelCaixas();
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_caixas WHERE caixas_id = " + "'" + id + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {
                    caixa.Caixas_id = int.Parse(reader["caixas_id"].ToString());
                    caixa.Caixas_nome = reader["caixas_nome"].ToString();
                    caixa.Caixas_estoque = int.Parse(reader["caixas_estoque"].ToString());
                    caixa.Caixas_observacao = reader["caixas_observacao"].ToString();
                    caixa.Caixas_peso = double.Parse(reader["caixas_peso"].ToString());
                    caixa.Caixas_altura = double.Parse(reader["caixas_altura"].ToString());
                    caixa.Caixas_largura = double.Parse(reader["caixas_largura"].ToString());
                    caixa.Caixas_comprimento = double.Parse(reader["caixas_comprimento"].ToString());
                    conexaoSql.Close();
                    return caixa;
                    
                }
                
            } catch (Exception) {
                conexaoSql.Close();
                throw;
            }            
            return caixa;
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
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_caixas WHERE caixas_id = " + "'" + id + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read())
                { retorno = double.Parse(reader["caixas_peso"].ToString()); }
                conexaoSql.Close();
            }
            catch (Exception)
            {
                conexaoSql.Close();
                throw;
            }
            return retorno;
        }

        public int idCaixaPeloNome(String nome)
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
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_caixas WHERE caixas_nome = " + "'" + nome + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read())
                { retorno = int.Parse(reader["caixas_id"].ToString()); }
                conexaoSql.Close();
            }
            catch (Exception)
            {
                conexaoSql.Close();
                throw;
            }
            return retorno;
        }

        public bool salvarCaixasDAO(ModelCaixas modelCaixas)
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
                MySqlCommand salvar = new MySqlCommand("insert into tbl_caixas (caixas_id, caixas_nome, caixas_estoque, caixas_observacao, caixas_peso, caixas_altura, caixas_largura, caixas_comprimento) values (null, ?, ?, ?, ?, ?, ?, ?)", conexaoSql);
                salvar.Parameters.Add("@caixas_nome", MySqlDbType.VarChar, 100).Value = modelCaixas.Caixas_nome;
                salvar.Parameters.Add("@caixas_estoque", MySqlDbType.Int64).Value = modelCaixas.Caixas_estoque;
                salvar.Parameters.Add("@caixas_observacao", MySqlDbType.VarChar, 500).Value = modelCaixas.Caixas_observacao;
                salvar.Parameters.Add("@caixas_peso", MySqlDbType.Double).Value = modelCaixas.Caixas_peso;
                salvar.Parameters.Add("@caixas_altura", MySqlDbType.Double).Value = modelCaixas.Caixas_altura;
                salvar.Parameters.Add("@caixas_largura", MySqlDbType.Double).Value = modelCaixas.Caixas_largura;
                salvar.Parameters.Add("@caixas_comprimento", MySqlDbType.Double).Value = modelCaixas.Caixas_comprimento;
                salvar.ExecuteNonQuery();
                conexaoSql.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conexaoSql.Close();
                salvou = false;
            }
            return salvou;
        }

        public bool deletarCaixasDAO(String id)
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
                MySqlCommand salvar = new MySqlCommand("DELETE FROM tbl_Caixas WHERE Caixas_id = " + id, conexaoSql);
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

        public bool atualizarCaixasDAO(ModelCaixas modelCaixas)
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
                MySqlCommand salvar = new MySqlCommand("UPDATE tbl_caixas SET caixas_id=@caixas_id, caixas_nome=@caixas_nome, caixas_estoque=@caixas_estoque, caixas_observacao=@caixas_observacao, caixas_peso=@caixas_peso, caixas_altura=@caixas_altura, caixas_largura=@caixas_largura, caixas_comprimento=@caixas_comprimento WHERE caixas_id = " + modelCaixas.Caixas_id, conexaoSql);
                salvar.Parameters.Add("@caixas_id", MySqlDbType.Int64).Value = modelCaixas.Caixas_id;
                salvar.Parameters.Add("@caixas_nome", MySqlDbType.VarChar, 100).Value = modelCaixas.Caixas_nome;               
                salvar.Parameters.Add("@caixas_estoque", MySqlDbType.Int64).Value = modelCaixas.Caixas_estoque;
                salvar.Parameters.Add("@caixas_observacao", MySqlDbType.VarChar, 500).Value = modelCaixas.Caixas_observacao;
                salvar.Parameters.Add("@caixas_peso", MySqlDbType.Double).Value = modelCaixas.Caixas_peso;
                salvar.Parameters.Add("@caixas_altura", MySqlDbType.Double).Value = modelCaixas.Caixas_altura;
                salvar.Parameters.Add("@caixas_largura", MySqlDbType.Double).Value = modelCaixas.Caixas_largura;
                salvar.Parameters.Add("@caixas_comprimento", MySqlDbType.Double).Value = modelCaixas.Caixas_comprimento;
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

        public DataTable pesquisarCaixas(String pesquisa)
        {

            try
            {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_caixas WHERE caixas_nome = " + "'" +pesquisa+ "'", conexaoSql);
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

        public DataTable exibirCaixas()
        {
            String condicao = "ITEM SEM CAIXA";
            try
            {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_caixas WHERE caixas_nome <> " + "'" + condicao + "'", conexaoSql);
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
