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
    class DAOProdutoAcabado : Conexao
    {

        public double pesoProdutoPeloId(int id)
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
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_produtos_acabados WHERE pro_id = " + "'" + id + "' ORDER BY pro_nome DESC", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read())
                { 
                    retorno = double.Parse(reader["pro_peso"].ToString()); 
                }
                conexaoSql.Close();
            }
            catch (Exception)
            {
                conexaoSql.Close();
                throw;
            }
            return retorno;
        }

        public double verificaEstoquePositivo(String produto) {
            double retorno = 0;
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_produtos_acabados WHERE pro_nome = " + "'" + produto + "' ORDER BY pro_nome DESC", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {
                    if (reader["pro_nome"].ToString().Equals(produto) && double.Parse(reader["prod_estoque"].ToString()) > 0) {
                        retorno = double.Parse(reader["pro_id"].ToString());
                        break;
                    }                    
                }
                conexaoSql.Close();
            } catch (Exception) {
                conexaoSql.Close();
                throw;
            }
            return retorno;
        }

        public ModelProdutoAcabado dadosDoProdutoAcabadoPeloId(String nomeProduto) {
            ModelProdutoAcabado produtoAcabado = new ModelProdutoAcabado();
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_produtos_acabados WHERE pro_nome = " + "'" + nomeProduto + "' ORDER BY pro_nome DESC", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {
                    produtoAcabado.Pro_id = int.Parse(reader["pro_id"].ToString());
                    produtoAcabado.Pro_nome = reader["pro_nome"].ToString();
                    produtoAcabado.Pro_estoque = double.Parse(reader["prod_estoque"].ToString());
                    produtoAcabado.Pro_observacao = reader["pro_observacao"].ToString();
                    produtoAcabado.Pro_peso = double.Parse(reader["pro_peso"].ToString());
                    conexaoSql.Close();
                    return produtoAcabado;

                }

            } catch (Exception) {
                conexaoSql.Close();
                throw;
            }
            return produtoAcabado;
        }

        public DataTable recuperarProdutos()
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
            consultar.CommandText = "select pro_nome from tbl_produtos_acabados ORDER BY pro_nome DESC";
            MySqlDataReader dr = consultar.ExecuteReader();
            dt.Load(dr);
            conexaoSql.Close();
            return dt;
        }

        public bool salvarProdutoDAO(ModelProdutoAcabado modelProduto)
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
                MySqlCommand salvar = new MySqlCommand("insert into tbl_produtos_acabados (pro_id, pro_nome, prod_estoque, pro_observacao, pro_peso) values (null, ?, ?, ?, ?)", conexaoSql);
                salvar.Parameters.Add("@pro_nome", MySqlDbType.VarChar, 100).Value = modelProduto.Pro_nome;
                salvar.Parameters.Add("@prod_estoque", MySqlDbType.Double).Value = modelProduto.Pro_estoque;
                salvar.Parameters.Add("@pro_observacao", MySqlDbType.VarChar, 500).Value = modelProduto.Pro_observacao;
                salvar.Parameters.Add("@pro_peso", MySqlDbType.Double).Value = modelProduto.Pro_peso;
                salvar.ExecuteNonQuery();
                conexaoSql.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Erro: "+ee.Message);
                conexaoSql.Close();
                salvou = false;
            }
            return salvou;
        }

        public bool deletarProdutoDAO(String id)
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
                MySqlCommand salvar = new MySqlCommand("DELETE FROM tbl_produtos_acabados WHERE pro_id = "+ id, conexaoSql);
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

        public bool atualizarProdutoDAO(ModelProdutoAcabado modelProduto)
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
                MySqlCommand salvar = new MySqlCommand("UPDATE tbl_produtos_acabados SET pro_id=@pro_id, pro_nome=@pro_nome, prod_estoque=@prod_estoque, pro_observacao=@pro_observacao, pro_peso=@pro_peso WHERE pro_id = " + modelProduto.Pro_id, conexaoSql);
                salvar.Parameters.Add("@pro_id", MySqlDbType.Int64).Value = modelProduto.Pro_id;
                salvar.Parameters.Add("@pro_nome", MySqlDbType.VarChar, 100).Value = modelProduto.Pro_nome;               
                salvar.Parameters.Add("@prod_estoque", MySqlDbType.Double).Value = modelProduto.Pro_estoque;
                salvar.Parameters.Add("@pro_observacao", MySqlDbType.VarChar, 500).Value = modelProduto.Pro_observacao;
                salvar.Parameters.Add("@pro_peso", MySqlDbType.Double).Value = modelProduto.Pro_peso;
                salvar.ExecuteNonQuery();
                conexaoSql.Close();
            }
            catch (Exception erro)
            {
                conexaoSql.Close();
                MessageBox.Show("Aqui>"+erro.Message);
            }
            return salvou;
        }

        public String nomeProdutoPeloId(int idProduto)
        {
            String retorno = "";
            try
            {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_produtos_acabados WHERE pro_id = " + "'" + idProduto + "' ORDER BY pro_nome DESC", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read())
                { retorno = reader["pro_nome"].ToString(); }
                conexaoSql.Close();
            }
            catch (Exception)
            {
                conexaoSql.Close();
                throw;
            }
            return retorno;
        }

        public int idProdutoPeloNome(String nome)
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
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_produtos_acabados WHERE pro_nome = " + "'" + nome + "' ORDER BY pro_nome DESC", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read())
                { retorno = int.Parse(reader["pro_id"].ToString()); }
                conexaoSql.Close();

            }
            catch (Exception)
            {
                conexaoSql.Close();
                throw;
            }
            
            return retorno;
        }

        public int litragemProdutoPeloId(int id)
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
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_produtos_acabados WHERE pro_id = " + "'" + id + "' ORDER BY pro_nome DESC", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read())
                { retorno = int.Parse(reader["pro_id"].ToString()); }
                conexaoSql.Close();
            }
            catch (Exception)
            {
                conexaoSql.Close();
                throw;
            }
            return retorno;
        }

        public DataTable pesquisarProdutos(String pesquisa)
        {

            try
            {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_produtos_acabados WHERE pro_nome = " + "'" +pesquisa+ "' ORDER BY pro_nome DESC", conexaoSql);
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

        public DataTable exibirProdutos()
        {

            try
            {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_produtos_acabados ORDER BY pro_nome ASC", conexaoSql);
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