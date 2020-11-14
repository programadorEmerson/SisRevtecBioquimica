using MySql.Data.MySqlClient;
using Revtec_Bioquimica.Controller;
using Revtec_Bioquimica.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revtec_Bioquimica.DAO {
    class DAOLote : Conexao {

        public DataTable recuperarLote() {
            DataTable dt = new DataTable();
            try {
                conexaoSql.Open();
            } catch (Exception) {
                conexaoSql.Close();
                conexaoSql.Open();
            }
            MySqlCommand consultar = new MySqlCommand();
            consultar.Connection = conexaoSql;
            consultar.CommandText = "select lote_produto from tbl_lotes";
            MySqlDataReader dr = consultar.ExecuteReader();
            dt.Load(dr);
            conexaoSql.Close();
            return dt;
        }

        public double litragemLotePeloLote(String lote) {
            double retorno = 0;
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_lotes WHERE lote_numero = " + "'" + lote + "' ORDER BY lote_id DESC", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) { retorno = double.Parse(reader["lote_litragem"].ToString()); }
                conexaoSql.Close();
            } catch (Exception) {
                conexaoSql.Close();
                throw;
            }
            return retorno;
        }

        public int idLotePeloLote(String lote) {
            int retorno = 0;
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_lotes WHERE lote_numero = " + "'" + lote + "' ORDER BY lote_id DESC", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) { retorno = int.Parse(reader["lote_id"].ToString()); }
                conexaoSql.Close();
            } catch (Exception) {
                conexaoSql.Close();
                throw;
            }
            return retorno;
        }

        

        public bool salvarLoteDAO(ModelLote modelLote) {
            bool salvou = true;
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand salvar = new MySqlCommand("insert into tbl_lotes (lote_id, lote_numero, lote_produto, lote_fabricacao, lote_validade, lote_litragem, lote_observacao, lote_status, lote_litragemFeita, lote_idAmostra) values (null, ?, ?, ?, ?, ?, ?, ?, ?, ?)", conexaoSql);
                salvar.Parameters.Add("@lote_numero", MySqlDbType.VarChar, 10).Value = modelLote.Lote_numero;
                salvar.Parameters.Add("@lote_produto", MySqlDbType.VarChar, 100).Value = modelLote.Lote_produto;
                salvar.Parameters.Add("@lote_fabricacao", MySqlDbType.VarChar, 10).Value = modelLote.Lote_fabricacao;
                salvar.Parameters.Add("@lote_validade", MySqlDbType.VarChar, 10).Value = modelLote.Lote_validade;
                salvar.Parameters.Add("@lote_litragem", MySqlDbType.Double).Value = modelLote.Lote_litragem;
                salvar.Parameters.Add("@lote_observacao", MySqlDbType.VarChar, 500).Value = modelLote.Lote_observacao;
                salvar.Parameters.Add("@lote_status", MySqlDbType.VarChar, 10).Value = modelLote.Lote_status;
                salvar.Parameters.Add("@lote_litragemFeita", MySqlDbType.Double).Value = modelLote.Lote_litragemFeita;
                salvar.Parameters.Add("@lote_idAmostra", MySqlDbType.Int64).Value = modelLote.Lote_idAmostra;
                salvar.ExecuteNonQuery();
                conexaoSql.Close();
            } catch {
                conexaoSql.Close();
                salvou = false;
            }
            return salvou;
        }

        public bool salvarOrdemProducao(ModelOrdemDeProducao ordemDeProducao)
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
                MySqlCommand salvar = new MySqlCommand("insert into tbl_ordemdeproducao (ordemId, ordemProduto, ordemQuantidade, ordemDataSaida, ordemLoteNumero, ordemDataSolicitacao) values (null, ?, ?, ?, ?, ?)", conexaoSql);
                salvar.Parameters.Add("@ordemProduto", MySqlDbType.VarChar, 100).Value = ordemDeProducao.OrdemProduto;
                salvar.Parameters.Add("@ordemQuantidade", MySqlDbType.Double).Value = ordemDeProducao.OrdemQuantidade;
                salvar.Parameters.Add("@ordemDataSaida", MySqlDbType.VarChar, 100).Value = ordemDeProducao.OrdemDataSaida;
                salvar.Parameters.Add("@ordemLoteNumero", MySqlDbType.VarChar, 100).Value = ordemDeProducao.OrdemLoteNumero;
                salvar.Parameters.Add("@ordemDataSolicitacao", MySqlDbType.VarChar, 100).Value = ordemDeProducao.OrdemDataSolicitacao;
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

        public bool deletarLoteDAO(String numeroLote)
        {
            bool salvou = true;
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand salvar = new MySqlCommand("DELETE FROM `db_estoque`.`tbl_lotes` WHERE (`lote_numero` = '" + numeroLote + "');", conexaoSql);
                salvar.ExecuteNonQuery();
                conexaoSql.Close();
            } catch {
                conexaoSql.Close();
                salvou = false;
            }
            return salvou;
        }

        public bool deletarItemOP(ModelOrdemDeProducao ordemProducao)
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
                MySqlCommand salvar = new MySqlCommand("DELETE FROM tbl_ordemdeproducao WHERE ordemId = " + ordemProducao.OrdemId, conexaoSql);
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

        public bool atualizarLoteDAO(ModelLote modelLote) {
            bool salvou = true;
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand salvar = new MySqlCommand("UPDATE tbl_lotes SET lote_id=@lote_id, lote_numero=@lote_numero, lote_produto=@lote_produto, lote_fabricacao=@lote_fabricacao, lote_validade=@lote_validade, lote_litragem=@lote_litragem, lote_observacao=@lote_observacao, lote_status=@lote_status, lote_litragemFeita=@lote_litragemFeita, lote_idAmostra=@lote_idAmostra WHERE lote_id = " + modelLote.Lote_id, conexaoSql);
                salvar.Parameters.Add("@lote_id", MySqlDbType.Int64).Value = modelLote.Lote_id;
                salvar.Parameters.Add("@lote_numero", MySqlDbType.VarChar, 10).Value = modelLote.Lote_numero;
                salvar.Parameters.Add("@lote_produto", MySqlDbType.VarChar, 100).Value = modelLote.Lote_produto;
                salvar.Parameters.Add("@lote_fabricacao", MySqlDbType.VarChar, 10).Value = modelLote.Lote_fabricacao;
                salvar.Parameters.Add("@lote_validade", MySqlDbType.VarChar, 10).Value = modelLote.Lote_validade;
                salvar.Parameters.Add("@lote_litragem", MySqlDbType.Double).Value = modelLote.Lote_litragem;
                salvar.Parameters.Add("@lote_observacao", MySqlDbType.VarChar, 500).Value = modelLote.Lote_observacao;
                salvar.Parameters.Add("@lote_status", MySqlDbType.VarChar, 10).Value = modelLote.Lote_status;
                salvar.Parameters.Add("@lote_litragemFeita", MySqlDbType.Double).Value = modelLote.Lote_litragemFeita;
                salvar.Parameters.Add("@lote_idAmostra", MySqlDbType.Int64).Value = modelLote.Lote_idAmostra;
                salvar.ExecuteNonQuery();
                conexaoSql.Close();
            } catch (Exception erro) {
                conexaoSql.Close();
                MessageBox.Show(erro.Message);
            }
            return salvou;
        }

        public bool atualizarOrdemDeProducao(ModelOrdemDeProducao modelLote)
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
                MySqlCommand salvar = new MySqlCommand("UPDATE tbl_ordemdeproducao SET ordemId=@ordemId, ordemProduto=@ordemProduto, ordemQuantidade=@ordemQuantidade, ordemDataSaida=@ordemDataSaida, ordemLoteNumero=@ordemLoteNumero, ordemDataSolicitacao=@ordemDataSolicitacao WHERE ordemId = " + modelLote.OrdemId, conexaoSql);
                salvar.Parameters.Add("@ordemId", MySqlDbType.Int64).Value = modelLote.OrdemId;
                salvar.Parameters.Add("@ordemProduto", MySqlDbType.VarChar, 10).Value = modelLote.OrdemProduto;
                salvar.Parameters.Add("@ordemQuantidade", MySqlDbType.Double).Value = modelLote.OrdemQuantidade;
                salvar.Parameters.Add("@ordemDataSaida", MySqlDbType.VarChar, 10).Value = modelLote.OrdemDataSaida;
                salvar.Parameters.Add("@ordemLoteNumero", MySqlDbType.VarChar, 10).Value = modelLote.OrdemLoteNumero;
                salvar.Parameters.Add("@ordemDataSolicitacao", MySqlDbType.VarChar, 10).Value = modelLote.OrdemDataSolicitacao;
                
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

        public DataTable pesquisarLote(String pesquisa) {
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_lotes WHERE lote_numero = " + "'" + pesquisa + "' ORDER BY lote_id DESC", conexaoSql);
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

        public ModelLote dadosDoloLote(String lote)
        {
            ModelLote dadosDoLote = new ModelLote();
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
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_lotes WHERE lote_numero = " + "'" + lote + "' ORDER BY pro_nome DESC", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read())
                {
                    dadosDoLote.Lote_id = int.Parse(reader["lote_id"].ToString());
                    dadosDoLote.Lote_numero = reader["lote_numero"].ToString();
                    dadosDoLote.Lote_produto = reader["lote_produto"].ToString();
                    dadosDoLote.Lote_fabricacao = reader["lote_fabricacao"].ToString();
                    dadosDoLote.Lote_validade = reader["lote_validade"].ToString();
                    dadosDoLote.Lote_litragem = double.Parse(reader["lote_litragem"].ToString());
                    dadosDoLote.Lote_observacao = reader["lote_observacao"].ToString();
                    dadosDoLote.Lote_status = reader["lote_status"].ToString();
                    dadosDoLote.Lote_litragemFeita = double.Parse(reader["lote_litragemFeita"].ToString());
                    dadosDoLote.Lote_idAmostra = int.Parse(reader["lote_idAmostra"].ToString());
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

        public ModelOrdemDeProducao dadosOrdemProducaoPeloloLote(String lote)
        {
            ModelOrdemDeProducao modelOrdemDeProducao = new ModelOrdemDeProducao();
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
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_ordemdeproducao WHERE ordemLoteNumero = " + "'" + lote + "' ORDER BY ordemId DESC", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read())
                {
                    modelOrdemDeProducao.OrdemId = int.Parse(reader["ordemId"].ToString());
                    modelOrdemDeProducao.OrdemProduto = reader["ordemProduto"].ToString();
                    modelOrdemDeProducao.OrdemQuantidade = double.Parse(reader["ordemQuantidade"].ToString());
                    modelOrdemDeProducao.OrdemDataSaida = reader["ordemDataSaida"].ToString();
                    modelOrdemDeProducao.OrdemLoteNumero = reader["ordemLoteNumero"].ToString();
                    modelOrdemDeProducao.OrdemDataSolicitacao = reader["ordemDataSolicitacao"].ToString();
                    conexaoSql.Close();
                    return modelOrdemDeProducao;
                }
            }
            catch (Exception)
            {
                conexaoSql.Close();
                throw;
            }
            return modelOrdemDeProducao;
        }

        public ModelLote dadosDaLotePeloId(String lote) {
            ModelLote loteRecuperaado = new ModelLote();
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_lotes WHERE lote_numero = " + "'" + lote + "' ORDER BY lote_id DESC", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {
                    loteRecuperaado.Lote_id = int.Parse(reader["lote_id"].ToString());
                    loteRecuperaado.Lote_numero = reader["lote_numero"].ToString();
                    loteRecuperaado.Lote_produto = reader["lote_produto"].ToString();
                    loteRecuperaado.Lote_fabricacao = reader["lote_fabricacao"].ToString();
                    loteRecuperaado.Lote_validade = reader["lote_validade"].ToString();
                    loteRecuperaado.Lote_litragem = double.Parse(reader["lote_litragem"].ToString());
                    loteRecuperaado.Lote_observacao = reader["lote_observacao"].ToString();
                    loteRecuperaado.Lote_status = reader["lote_status"].ToString();
                    loteRecuperaado.Lote_litragemFeita = double.Parse(reader["lote_litragemFeita"].ToString());
                    loteRecuperaado.Lote_idAmostra = int.Parse(reader["lote_idAmostra"].ToString());
                    conexaoSql.Close();
                    return loteRecuperaado;
                }
            } catch (Exception) {
                conexaoSql.Close();
                throw;
            }
            return loteRecuperaado;
        }

        public ModelLote recuperarUltimoLote(String produto) {
            ModelLote loteRecuperaado = new ModelLote();
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_lotes WHERE lote_numero = " + "'" + produto + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {
                    loteRecuperaado.Lote_id = int.Parse(reader["lote_id"].ToString());
                    loteRecuperaado.Lote_numero = reader["lote_numero"].ToString();
                    loteRecuperaado.Lote_produto = reader["lote_produto"].ToString();
                    loteRecuperaado.Lote_fabricacao = reader["lote_fabricacao"].ToString();
                    loteRecuperaado.Lote_validade = reader["lote_validade"].ToString();
                    loteRecuperaado.Lote_litragem = double.Parse(reader["lote_litragem"].ToString());
                    loteRecuperaado.Lote_observacao = reader["lote_observacao"].ToString();
                    loteRecuperaado.Lote_status = reader["lote_status"].ToString();
                    loteRecuperaado.Lote_litragemFeita = double.Parse(reader["lote_litragemFeita"].ToString());
                    loteRecuperaado.Lote_idAmostra = int.Parse(reader["lote_idAmostra"].ToString());
                }
                conexaoSql.Close();
                return loteRecuperaado;
            } catch (Exception) {
                conexaoSql.Close();
                return loteRecuperaado;
            }
        }

        public ModelLote dadosDaLotePeloProduto(String produto) {
            ModelLote loteRecuperaado = new ModelLote();
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_lotes WHERE lote_produto = " + "'" + produto + "' AND lote_status = " + "'" + "Aguardando" + "' ORDER BY lote_id DESC", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {
                    loteRecuperaado.Lote_id = int.Parse(reader["lote_id"].ToString());
                    loteRecuperaado.Lote_numero = reader["lote_numero"].ToString();
                    loteRecuperaado.Lote_produto = reader["lote_produto"].ToString();
                    loteRecuperaado.Lote_fabricacao = reader["lote_fabricacao"].ToString();
                    loteRecuperaado.Lote_validade = reader["lote_validade"].ToString();
                    loteRecuperaado.Lote_litragem = double.Parse(reader["lote_litragem"].ToString());
                    loteRecuperaado.Lote_observacao = reader["lote_observacao"].ToString();
                    loteRecuperaado.Lote_status = reader["lote_status"].ToString();
                    loteRecuperaado.Lote_litragemFeita = double.Parse(reader["lote_litragemFeita"].ToString());
                    loteRecuperaado.Lote_idAmostra = int.Parse(reader["lote_idAmostra"].ToString());
                }
                conexaoSql.Close();
                return loteRecuperaado;
            } catch (Exception) {
                conexaoSql.Close();
                return loteRecuperaado;
            }
        }

        public ModelLote dadosDaLotePeloProdutoConcluido(String produto) {
            ModelLote loteRecuperaado = new ModelLote();
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_lotes WHERE lote_produto = " + "'" + produto + "' AND lote_status = " + "'" + "Concluído" + "' ORDER BY lote_id DESC", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {
                    loteRecuperaado.Lote_id = int.Parse(reader["lote_id"].ToString());
                    loteRecuperaado.Lote_numero = reader["lote_numero"].ToString();
                    loteRecuperaado.Lote_produto = reader["lote_produto"].ToString();
                    loteRecuperaado.Lote_fabricacao = reader["lote_fabricacao"].ToString();
                    loteRecuperaado.Lote_validade = reader["lote_validade"].ToString();
                    loteRecuperaado.Lote_litragem = double.Parse(reader["lote_litragem"].ToString());
                    loteRecuperaado.Lote_observacao = reader["lote_observacao"].ToString();
                    loteRecuperaado.Lote_status = reader["lote_status"].ToString();
                    loteRecuperaado.Lote_litragemFeita = double.Parse(reader["lote_litragemFeita"].ToString());
                    loteRecuperaado.Lote_idAmostra = int.Parse(reader["lote_idAmostra"].ToString());
                }
                conexaoSql.Close();
                return loteRecuperaado;
            } catch (Exception) {
                conexaoSql.Close();
                return loteRecuperaado;
            }
        }

        public ModelLote dadosDaLotePeloLote(String produto, String lote) {
            ModelLote loteRecuperaado = new ModelLote();
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_lotes WHERE lote_produto = " + "'" + produto + "' AND lote_numero = " + "'" + lote + "' ORDER BY lote_id DESC", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {
                    loteRecuperaado.Lote_id = int.Parse(reader["lote_id"].ToString());
                    loteRecuperaado.Lote_numero = reader["lote_numero"].ToString();
                    loteRecuperaado.Lote_produto = reader["lote_produto"].ToString();
                    loteRecuperaado.Lote_fabricacao = reader["lote_fabricacao"].ToString();
                    loteRecuperaado.Lote_validade = reader["lote_validade"].ToString();
                    loteRecuperaado.Lote_litragem = double.Parse(reader["lote_litragem"].ToString());
                    loteRecuperaado.Lote_observacao = reader["lote_observacao"].ToString();
                    loteRecuperaado.Lote_status = reader["lote_status"].ToString();
                    loteRecuperaado.Lote_litragemFeita = double.Parse(reader["lote_litragemFeita"].ToString());
                    loteRecuperaado.Lote_idAmostra = int.Parse(reader["lote_idAmostra"].ToString());
                    conexaoSql.Close();
                    return loteRecuperaado;
                }
            } catch (Exception) {
                conexaoSql.Close();
                throw;
            }
            return loteRecuperaado;
        }

        public ModelLote dadosDaLotePeloProduto(String produto, string statusLote) {
            ModelLote loteRecuperaado = new ModelLote();
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_lotes WHERE lote_produto = " + "'" + produto + "' AND lote_status = " + "'" + statusLote + "' ORDER BY lote_id DESC", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {

                    if (double.Parse(reader["lote_litragem"].ToString()) > 0) {
                        // Initializes the variables to pass to the MessageBox.Show method.
                        string message = "Deseja utilizar este lote?\n\nLote: " + reader["lote_numero"].ToString() + "" +
                            "\nValidade: " + reader["lote_validade"].ToString() + "" +
                            "\nLitragem disponível: " + reader["lote_litragem"].ToString();
                        string caption = "Cancelar Item do pedido";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result;
                        // Displays the MessageBox.
                        result = MessageBox.Show(message, caption, buttons);
                        if (result == DialogResult.Yes) {
                            loteRecuperaado.Lote_id = int.Parse(reader["lote_id"].ToString());
                            loteRecuperaado.Lote_numero = reader["lote_numero"].ToString();
                            loteRecuperaado.Lote_produto = reader["lote_produto"].ToString();
                            loteRecuperaado.Lote_fabricacao = reader["lote_fabricacao"].ToString();
                            loteRecuperaado.Lote_validade = reader["lote_validade"].ToString();
                            loteRecuperaado.Lote_litragem = double.Parse(reader["lote_litragem"].ToString());
                            loteRecuperaado.Lote_observacao = reader["lote_observacao"].ToString();
                            loteRecuperaado.Lote_status = reader["lote_status"].ToString();
                            loteRecuperaado.Lote_litragemFeita = double.Parse(reader["lote_litragemFeita"].ToString());
                            loteRecuperaado.Lote_idAmostra = int.Parse(reader["lote_idAmostra"].ToString());
                            break;
                        }
                    }
                }
                conexaoSql.Close();
                return loteRecuperaado;
            } catch (Exception) {
                conexaoSql.Close();
                throw;
            }
        }

        public ModelLote dadosLotePeloProduto(String produto, string statusLote) {
            ModelLote loteRecuperaado = new ModelLote();
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_lotes WHERE lote_produto = " + "'" + produto + "' AND lote_status = " + "'" + statusLote + "' ORDER BY lote_id DESC", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {
                    loteRecuperaado.Lote_id = int.Parse(reader["lote_id"].ToString());
                    loteRecuperaado.Lote_numero = reader["lote_numero"].ToString();
                    loteRecuperaado.Lote_produto = reader["lote_produto"].ToString();
                    loteRecuperaado.Lote_fabricacao = reader["lote_fabricacao"].ToString();
                    loteRecuperaado.Lote_validade = reader["lote_validade"].ToString();
                    loteRecuperaado.Lote_litragem = double.Parse(reader["lote_litragem"].ToString());
                    loteRecuperaado.Lote_observacao = reader["lote_observacao"].ToString();
                    loteRecuperaado.Lote_status = reader["lote_status"].ToString();
                    loteRecuperaado.Lote_litragemFeita = double.Parse(reader["lote_litragemFeita"].ToString());
                    loteRecuperaado.Lote_idAmostra = int.Parse(reader["lote_idAmostra"].ToString());
                    conexaoSql.Close();
                    return loteRecuperaado;
                }
                conexaoSql.Close();
                return loteRecuperaado;
            } catch (Exception) {
                return loteRecuperaado;
                conexaoSql.Close();
                throw;
            }
        }

        public bool finalizaLoteZerado() {
            bool terminou = false;
            ModelLote lote = new ModelLote();
            
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_lotes", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {
                    
                    if (double.Parse(reader["lote_litragem"].ToString()) == 0 && reader["lote_status"].ToString().Equals("Concluído")) {

                        lote = dadosDaLotePeloId(reader["lote_numero"].ToString());
                        lote.Lote_status = "Finalizado";
                        atualizarLoteDAO(lote);
                    }                    
                }
                terminou = true;
                conexaoSql.Close();
            } catch (Exception e) {
                MessageBox.Show("Este é o erro: "+e.Message);
                conexaoSql.Close();
            }
            return terminou;
        }


        public String retornarUltimoLote() {
            String loteRecuperaado = "0";
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT lote_numero FROM tbl_lotes ORDER BY lote_numero ASC", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {
                    loteRecuperaado = reader["lote_numero"].ToString();
                }
                conexaoSql.Close();
                return loteRecuperaado;
            } catch (Exception) {
                conexaoSql.Close();
                return loteRecuperaado;
            }
        }

        public bool finalizarLoteZerado() {
            bool existe = false;
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_lotes", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {

                    if (reader["lote_status"].ToString().Equals("Concluído") && double.Parse(reader["lote_litragem"].ToString()) == 0 || reader["lote_status"].ToString().Equals("Aguardando") && double.Parse(reader["lote_litragem"].ToString()) == 0) {
                        ModelLote modelLote = new ModelLote();
                        ControllerLote controllerLote = new ControllerLote();
                        modelLote = controllerLote.dadosDaLotePeloId(reader["lote_numero"].ToString());
                        modelLote.Lote_status = "Finalizado";
                        modelLote.Lote_observacao = "Lote finalizado dia, "+DateTime.Now.AddDays(0).ToString("dd/MM/yyyy");
                        if (controllerLote.atualizarLoteController(modelLote)) {
                            existe = true;
                        }
                    }
                    
                }
                conexaoSql.Close();
                return existe;
            } catch (Exception) {
                conexaoSql.Close();
                return existe;
            }
        }

        public bool verSeLoteExiste(String produto, String statusLote) {
            bool existe = false;
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_lotes WHERE lote_produto = " + "'" + produto + "' AND lote_status = " + "'" + statusLote + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {
                    existe = true;
                }
                conexaoSql.Close();
                return existe;
            } catch (Exception) {
                conexaoSql.Close();
                return existe;
            }
        }

        public ModelLote verSeLoteExisteAtendendoDemanda(String produto, String statusLote, String statusLote2, double demanda) {
            ModelLote dadosDoLote = new ModelLote();
            int verificaSeExisteLoteParaOProduto = 1;
            dadosDoLote.Lote_id = 0;
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }

                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_lotes WHERE lote_produto = " + "'" + produto + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {

                    if (reader["lote_status"].ToString().Equals(statusLote) && double.Parse(reader["lote_litragem"].ToString()) >= demanda && reader["lote_litragem"].ToString() != "0") {
                        
                        // Initializes the variables to pass to the MessageBox.Show method.
                        string message = "Deseja utilizar este lote?\n\nLote: " + reader["lote_numero"].ToString() + "" +
                            "\nProduto: " + reader["lote_produto"].ToString() + "\nValidade: " + reader["lote_validade"].ToString() + "" +
                            "\nLitragem disponível: " + reader["lote_litragem"].ToString();
                        string caption = "Cancelar Item do pedido";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result;
                        // Displays the MessageBox.
                        result = MessageBox.Show(message, caption, buttons);
                        if (result == DialogResult.Yes) {
                            dadosDoLote.Lote_id = int.Parse(reader["lote_id"].ToString());
                            dadosDoLote.Lote_numero = reader["lote_numero"].ToString();
                            dadosDoLote.Lote_produto = reader["lote_produto"].ToString();
                            dadosDoLote.Lote_fabricacao = reader["lote_fabricacao"].ToString();
                            dadosDoLote.Lote_validade = reader["lote_validade"].ToString();
                            dadosDoLote.Lote_litragem = double.Parse(reader["lote_litragem"].ToString());
                            dadosDoLote.Lote_observacao = reader["lote_observacao"].ToString();
                            dadosDoLote.Lote_status = reader["lote_status"].ToString();
                            dadosDoLote.Lote_litragemFeita = double.Parse(reader["lote_litragemFeita"].ToString());
                            dadosDoLote.Lote_idAmostra = int.Parse(reader["lote_idAmostra"].ToString());
                            verificaSeExisteLoteParaOProduto = 0;
                            conexaoSql.Close();
                            break;
                        } else if (result == DialogResult.No) {
                            dadosDoLote.Lote_id = -1;
                        }

                    } else if (reader["lote_status"].ToString().Equals(statusLote2) && double.Parse(reader["lote_litragem"].ToString()) < 0) {

                        // Initializes the variables to pass to the MessageBox.Show method.
                        string message = "Incluir pedido ao lote já solicitado?\n\nLote: " + reader["lote_numero"].ToString() + "" +
                            "\nProduto: "+ reader["lote_produto"].ToString() + "\nStatus: " + "Aguardando ordem de produção";
                        string caption = "Incluir solicitação ao lote";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result;
                        // Displays the MessageBox.
                        result = MessageBox.Show(message, caption, buttons);
                        if (result == DialogResult.Yes) {
                            dadosDoLote.Lote_id = int.Parse(reader["lote_id"].ToString());
                            dadosDoLote.Lote_numero = reader["lote_numero"].ToString();
                            dadosDoLote.Lote_produto = reader["lote_produto"].ToString();
                            dadosDoLote.Lote_fabricacao = reader["lote_fabricacao"].ToString();
                            dadosDoLote.Lote_validade = reader["lote_validade"].ToString();
                            dadosDoLote.Lote_litragem = double.Parse(reader["lote_litragem"].ToString());
                            dadosDoLote.Lote_observacao = reader["lote_observacao"].ToString();
                            dadosDoLote.Lote_status = reader["lote_status"].ToString();
                            dadosDoLote.Lote_litragemFeita = double.Parse(reader["lote_litragemFeita"].ToString());
                            dadosDoLote.Lote_idAmostra = int.Parse(reader["lote_idAmostra"].ToString());
                            verificaSeExisteLoteParaOProduto = 0;
                            conexaoSql.Close();
                            break;
                        } else if (result == DialogResult.No) {
                            dadosDoLote.Lote_id = -1;
                        }
                    } else if (reader["lote_status"].ToString().Equals(statusLote) && double.Parse(reader["lote_litragem"].ToString()) < demanda && reader["lote_status"].ToString() != "Concluído") {

                        // Initializes the variables to pass to the MessageBox.Show method.
                        string messages = "Deseja criar uma nova solicitação de lote ?\n\n" +
                            "Produto: " + reader["lote_produto"].ToString() + "\n" +
                            "Em estoque: "+ double.Parse(reader["lote_litragem"].ToString()).ToString("F0") + "\n" +
                            "Demanda: " + demanda.ToString("F0") + "\n" +
                            "Motivo: " + "Quantidade em estoque insuficiente";
                        string captions = "Solicitar novo lote";
                        MessageBoxButtons buttonss = MessageBoxButtons.YesNo;
                        DialogResult results;
                        // Displays the MessageBox.

                        results = MessageBox.Show(messages, captions, buttonss);
                        if (results == DialogResult.Yes) {
                            dadosDoLote.Lote_id = 0;
                            verificaSeExisteLoteParaOProduto = 0;
                            conexaoSql.Close();
                            break;
                        } else if (results == DialogResult.No) {
                            verificaSeExisteLoteParaOProduto = 0;
                            dadosDoLote.Lote_id = -1;
                        }
                    }
                }

                if (verificaSeExisteLoteParaOProduto == 1) {

                    // Initializes the variables to pass to the MessageBox.Show method.
                    string messages = "Deseja criar uma nova solicitação de lote ?\n\n" +
                        "Produto: " + produto + "\n" +
                        "Em estoque: 0\n" +
                        "Demanda: " + demanda + "\n" +
                        "Motivo: " + "Quantidade em estoque insuficiente";
                    string captions = "Solicitar novo lote";
                    MessageBoxButtons buttonss = MessageBoxButtons.YesNo;
                    DialogResult results;
                    // Displays the MessageBox.

                    results = MessageBox.Show(messages, captions, buttonss);
                    if (results == DialogResult.Yes) {
                        dadosDoLote.Lote_id = 0;
                        verificaSeExisteLoteParaOProduto = 0;
                        conexaoSql.Close();
                    } else if (results == DialogResult.No) {
                        verificaSeExisteLoteParaOProduto = 0;
                        dadosDoLote.Lote_id = -1;
                    }

                }

                return dadosDoLote;

            } catch (Exception) {
                dadosDoLote.Lote_id = 0;
                conexaoSql.Close();
                return dadosDoLote;
            }
        }

        public ModelLote verSeLoteLiberou(String produto, String statusLote, String statusLote2, double demanda) {
            ModelLote dadosDoLote = new ModelLote();
            dadosDoLote.Lote_id = 0;
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_lotes WHERE lote_produto = " + "'" + produto + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {

                    if (reader["lote_status"].ToString().Equals(statusLote) && double.Parse(reader["lote_litragem"].ToString()) >= demanda) {
                        // Initializes the variables to pass to the MessageBox.Show method.
                        string message = "Deseja utilizar este lote?\n\nLote: " + reader["lote_numero"].ToString() + "" +
                            "\nProduto: " + reader["lote_produto"].ToString() + "\nValidade: " + reader["lote_validade"].ToString() + "" +
                            "\nLitragem disponível: " + reader["lote_litragem"].ToString();
                        string caption = "Cancelar Item do pedido";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result;
                        // Displays the MessageBox.
                        result = MessageBox.Show(message, caption, buttons);
                        if (result == DialogResult.Yes) {
                            dadosDoLote.Lote_id = int.Parse(reader["lote_id"].ToString());
                            dadosDoLote.Lote_numero = reader["lote_numero"].ToString();
                            dadosDoLote.Lote_produto = reader["lote_produto"].ToString();
                            dadosDoLote.Lote_fabricacao = reader["lote_fabricacao"].ToString();
                            dadosDoLote.Lote_validade = reader["lote_validade"].ToString();
                            dadosDoLote.Lote_litragem = double.Parse(reader["lote_litragem"].ToString());
                            dadosDoLote.Lote_observacao = reader["lote_observacao"].ToString();
                            dadosDoLote.Lote_status = reader["lote_status"].ToString();
                            dadosDoLote.Lote_litragemFeita = double.Parse(reader["lote_litragemFeita"].ToString());
                            dadosDoLote.Lote_idAmostra = int.Parse(reader["lote_idAmostra"].ToString());
                            conexaoSql.Close();
                            break;
                        } 
                    } 
                }
                return dadosDoLote;

            } catch (Exception) {
                dadosDoLote.Lote_id = 0;
                conexaoSql.Close();
                return dadosDoLote;
            }
        }

        public DataTable exibirLoteComFiltro(String filtro) {
            DataTable tabela = new DataTable();
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }

                if (filtro.Equals("Todos")) {
                    //MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_lotes WHERE lote_produto = " + "'" + filtro + "' ORDER BY lote_id DESC", conexaoSql);
                    MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_lotes ORDER BY lote_numero DESC", conexaoSql);
                    MySqlDataAdapter acessar = new MySqlDataAdapter();
                    acessar.SelectCommand = buscar;                    
                    acessar.Fill(tabela);
                } else if (filtro.Equals("estoque")) {
                    //MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_lotes WHERE lote_produto = " + "'" + filtro + "' ORDER BY lote_id DESC", conexaoSql);
                    MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_lotes WHERE lote_litragem > 0 ORDER BY lote_numero DESC", conexaoSql);
                    MySqlDataAdapter acessar = new MySqlDataAdapter();
                    acessar.SelectCommand = buscar;
                    acessar.Fill(tabela);
                } else {
                    MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_lotes WHERE lote_status = " + "'" + filtro + "' ORDER BY lote_numero DESC", conexaoSql);
                    //MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_lotes ORDER BY lote_id DESC", conexaoSql);
                    MySqlDataAdapter acessar = new MySqlDataAdapter();
                    acessar.SelectCommand = buscar;
                    acessar.Fill(tabela);
                }

            } catch {
                conexaoSql.Close();
                return null;
            }
            conexaoSql.Close();
            return tabela;
        }

        public DataTable exibirLoteConcluídos(String status) {
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_lotes WHERE lote_status = " + "'" + status + "' ORDER BY lote_id DESC", conexaoSql);
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
