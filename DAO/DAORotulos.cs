using MySql.Data.MySqlClient;
using Revtec_Bioquimica.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revtec_Bioquimica.DAO {
    class DAORotulos : Conexao {

        public ModelRotulos recuperarRotuloPeloIdProdutoNoPedido(int idProduto) {
            ModelRotulos dadosDoRotulo = new ModelRotulos();
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_rotulos WHERE rotulo_idProduto = " + "'" + idProduto + "' ORDER BY rotulo_id ASC", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {
                    dadosDoRotulo.Rotulo_id = int.Parse(reader["rotulo_id"].ToString());
                    dadosDoRotulo.Rotulo_produto = reader["rotulo_produto"].ToString();
                    dadosDoRotulo.Rotulo_guia = int.Parse(reader["rotulo_guia"].ToString());
                    dadosDoRotulo.Rotulo_idProduto = int.Parse(reader["rotulo_idProduto"].ToString());
                    dadosDoRotulo.Rotulo_cliente = reader["rotulo_cliente"].ToString();
                    dadosDoRotulo.Rotulo_lote = reader["rotulo_lote"].ToString();
                    dadosDoRotulo.Rotulo_fabricacao = reader["rotulo_fabricacao"].ToString();
                    dadosDoRotulo.Rotulo_validade = reader["rotulo_validade"].ToString();
                    dadosDoRotulo.Rotulo_quantidade = int.Parse(reader["rotulo_quantidade"].ToString());
                    dadosDoRotulo.Rotulo_litragem = reader["rotulo_litragem"].ToString();
                    dadosDoRotulo.Rotulo_status = reader["rotulo_status"].ToString();
                    dadosDoRotulo.Rotulo_observacao = reader["rotulo_observacao"].ToString();
                    return dadosDoRotulo;
                }
                conexaoSql.Close();
            } catch (Exception) {
                conexaoSql.Close();
                throw;
            }
            return dadosDoRotulo;
        }

        public ModelRotulos recuperarRotuloPeloId(int idProduto) {
            ModelRotulos dadosDoRotulo = new ModelRotulos();
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_rotulos WHERE rotulo_id = " + "'" + idProduto + "' ORDER BY rotulo_id DESC", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {
                    dadosDoRotulo.Rotulo_id = int.Parse(reader["rotulo_id"].ToString());
                    dadosDoRotulo.Rotulo_produto = reader["rotulo_produto"].ToString();
                    dadosDoRotulo.Rotulo_guia = int.Parse(reader["rotulo_guia"].ToString());
                    dadosDoRotulo.Rotulo_idProduto = int.Parse(reader["rotulo_idProduto"].ToString());
                    dadosDoRotulo.Rotulo_cliente = reader["rotulo_cliente"].ToString();
                    dadosDoRotulo.Rotulo_lote = reader["rotulo_lote"].ToString();
                    dadosDoRotulo.Rotulo_fabricacao = reader["rotulo_fabricacao"].ToString();
                    dadosDoRotulo.Rotulo_validade = reader["rotulo_validade"].ToString();
                    dadosDoRotulo.Rotulo_quantidade = int.Parse(reader["rotulo_quantidade"].ToString());
                    dadosDoRotulo.Rotulo_litragem = reader["rotulo_litragem"].ToString();
                    dadosDoRotulo.Rotulo_status = reader["rotulo_status"].ToString();
                    dadosDoRotulo.Rotulo_observacao = reader["rotulo_observacao"].ToString();
                    return dadosDoRotulo;
                }
                conexaoSql.Close();
            } catch (Exception ee) {
                conexaoSql.Close();
                MessageBox.Show("Erro: " + ee.Message);
            }
            return dadosDoRotulo;
        }

        public bool percorreRotulosParaExcluir(String nome, String litragem, string situacao) {
            bool excluiu = false;
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_rotulos", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {
                    
                    if (reader["rotulo_produto"].ToString().Equals(nome) && reader["rotulo_litragem"].ToString().Equals(litragem) && reader["rotulo_status"].ToString().Equals(situacao)) {
                        if (deletarRotuloPeloId(int.Parse(reader["rotulo_id"].ToString()))) {
                            excluiu = true;                            
                            break;
                        }                        
                    }                    
                }
                conexaoSql.Close();
            } catch (Exception ee) {
                conexaoSql.Close();
                MessageBox.Show("Erro: " + ee.Message);
            }
            return excluiu;
        }

        public DataTable recuperarTodosOsRotulos() {
            DataTable dt = new DataTable();
            try {
                conexaoSql.Open();
            } catch (Exception) {
                conexaoSql.Close();
                conexaoSql.Open();
            }
            MySqlCommand consultar = new MySqlCommand();
            consultar.Connection = conexaoSql;
            consultar.CommandText = "select * from tbl_rotulos ORDER BY rotulo_id DESC";
            MySqlDataReader dr = consultar.ExecuteReader();
            dt.Load(dr);
            conexaoSql.Close();
            return dt;
        }

        public int salvarRotuloDAO(ModelRotulos modelRotulos) {
            int salvou = 0;
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand salvar = new MySqlCommand("insert into tbl_rotulos (rotulo_id, rotulo_produto, rotulo_guia, rotulo_idProduto, rotulo_cliente, rotulo_lote, rotulo_fabricacao, rotulo_validade, rotulo_quantidade, rotulo_litragem, rotulo_status, rotulo_observacao) values (null, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", conexaoSql);
                salvar.Parameters.Add("@rotulo_produto", MySqlDbType.VarChar, 100).Value = modelRotulos.Rotulo_produto;
                salvar.Parameters.Add("@rotulo_guia", MySqlDbType.Int64).Value = modelRotulos.Rotulo_guia;
                salvar.Parameters.Add("@rotulo_idProduto", MySqlDbType.Int64).Value = modelRotulos.Rotulo_idProduto;
                salvar.Parameters.Add("@rotulo_cliente", MySqlDbType.VarChar, 100).Value = modelRotulos.Rotulo_cliente;
                salvar.Parameters.Add("@rotulo_lote", MySqlDbType.VarChar, 10).Value = modelRotulos.Rotulo_lote;
                salvar.Parameters.Add("@rotulo_fabricacao", MySqlDbType.VarChar, 10).Value = modelRotulos.Rotulo_fabricacao;
                salvar.Parameters.Add("@rotulo_validade", MySqlDbType.VarChar, 10).Value = modelRotulos.Rotulo_validade;
                salvar.Parameters.Add("@rotulo_quantidade", MySqlDbType.Int64).Value = modelRotulos.Rotulo_quantidade;
                salvar.Parameters.Add("@rotulo_litragem", MySqlDbType.VarChar, 15).Value = modelRotulos.Rotulo_litragem;
                salvar.Parameters.Add("@rotulo_status", MySqlDbType.VarChar, 20).Value = modelRotulos.Rotulo_status;
                salvar.Parameters.Add("@rotulo_observacao", MySqlDbType.VarChar, 500).Value = modelRotulos.Rotulo_observacao;
                salvar.ExecuteNonQuery();

                if (salvar.LastInsertedId != null) salvar.Parameters.Add(new MySqlParameter("newId", salvar.LastInsertedId));
                salvou = Convert.ToInt32(salvar.Parameters["@newId"].Value);
                conexaoSql.Close();
            } catch {
                conexaoSql.Close();
            }

            return salvou;
        }

        public bool deletarRotuloPeloId(int id) {
            bool salvou = true;
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand salvar = new MySqlCommand("DELETE FROM tbl_rotulos WHERE rotulo_idProduto = " + id, conexaoSql);
                salvar.ExecuteNonQuery();
                conexaoSql.Close();
            } catch {
                conexaoSql.Close();
                salvou = false;
            }
            return salvou;
        }

        public bool atualizarRotuloListaDAO(ModelRotulos modelRotulos) {
            bool salvou = true;
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand salvar = new MySqlCommand("UPDATE tbl_rotulos SET rotulo_id=@rotulo_id, rotulo_produto=@rotulo_produto, rotulo_guia=@rotulo_guia, rotulo_idProduto=@rotulo_idProduto, rotulo_cliente=@rotulo_cliente, rotulo_lote=@rotulo_lote, rotulo_fabricacao=@rotulo_fabricacao, rotulo_validade=@rotulo_validade, rotulo_quantidade=@rotulo_quantidade, rotulo_litragem=@rotulo_litragem, rotulo_status=@rotulo_status, rotulo_observacao=@rotulo_observacao WHERE rotulo_id = " + modelRotulos.Rotulo_id, conexaoSql);
                salvar.Parameters.Add("@rotulo_id", MySqlDbType.Int64).Value = modelRotulos.Rotulo_id;
                salvar.Parameters.Add("@rotulo_produto", MySqlDbType.VarChar, 100).Value = modelRotulos.Rotulo_produto;
                salvar.Parameters.Add("@rotulo_guia", MySqlDbType.Int64).Value = modelRotulos.Rotulo_guia;
                salvar.Parameters.Add("@rotulo_idProduto", MySqlDbType.Int64).Value = modelRotulos.Rotulo_idProduto;
                salvar.Parameters.Add("@rotulo_cliente", MySqlDbType.VarChar, 100).Value = modelRotulos.Rotulo_cliente;
                salvar.Parameters.Add("@rotulo_lote", MySqlDbType.VarChar, 10).Value = modelRotulos.Rotulo_lote;
                salvar.Parameters.Add("@rotulo_fabricacao", MySqlDbType.VarChar, 10).Value = modelRotulos.Rotulo_fabricacao;
                salvar.Parameters.Add("@rotulo_validade", MySqlDbType.VarChar, 10).Value = modelRotulos.Rotulo_validade;
                salvar.Parameters.Add("@rotulo_quantidade", MySqlDbType.Int64).Value = modelRotulos.Rotulo_quantidade;
                salvar.Parameters.Add("@rotulo_litragem", MySqlDbType.VarChar, 15).Value = modelRotulos.Rotulo_litragem;
                salvar.Parameters.Add("@rotulo_status", MySqlDbType.VarChar, 20).Value = modelRotulos.Rotulo_status;
                salvar.Parameters.Add("@rotulo_observacao", MySqlDbType.VarChar, 500).Value = modelRotulos.Rotulo_observacao;

                salvar.ExecuteNonQuery();
                conexaoSql.Close();
            } catch (Exception erro) {
                conexaoSql.Close();
                MessageBox.Show(erro.Message);
            }
            return salvou;
        }


        public DataTable pesquisarRotulo(String pesquisa) {
            DataTable tabela = new DataTable();
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }

                if (pesquisa.Equals("Todos")) {
                    MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_rotulos ORDER BY rotulo_id DESC", conexaoSql);
                    MySqlDataAdapter acessar = new MySqlDataAdapter();
                    acessar.SelectCommand = buscar;
                    acessar.Fill(tabela);
                    conexaoSql.Close();
                } else {
                    MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_rotulos WHERE rotulo_status = " + "'" + pesquisa + "' ORDER BY rotulo_id DESC", conexaoSql);
                    MySqlDataAdapter acessar = new MySqlDataAdapter();
                    acessar.SelectCommand = buscar;
                    acessar.Fill(tabela);
                    conexaoSql.Close();
                }
            } catch {
                conexaoSql.Close();
                return null;
            }
            return tabela;
        }

        public DataTable pesquisarRotulo() {

            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_rotulos ORDER BY rotulo_id DESC", conexaoSql);
                MySqlDataAdapter acessar = new MySqlDataAdapter();
                acessar.SelectCommand = buscar;

                DataTable tabela = new DataTable();
                acessar.Fill(tabela);
                conexaoSql.Close();
                return tabela;
            } catch {
                conexaoSql.Close();
                return null;
            }

        }

    }
}
