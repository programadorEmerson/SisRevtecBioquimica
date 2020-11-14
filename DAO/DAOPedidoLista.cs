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
    class DAOPedidoLista : Conexao
    {

        public bool verificaIdExixtente(int id) {
            bool tem = false;
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_pedidos_lista WHERE guia_id = " + "'" + id + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {
                    MessageBox.Show(reader["guia_id"].ToString());
                    tem = true;
                }
                conexaoSql.Close();
            } catch (Exception) {
                conexaoSql.Close();
            }
            return tem;
        }


        public ModelPedidoLista verificaId(int id) {
            ModelPedidoLista pedido = new ModelPedidoLista();
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_pedidos_lista WHERE guia_id = " + "'" + id + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {
                    pedido.Pedido_id = int.Parse(reader["pedido_id"].ToString());
                    pedido.Guia_id = int.Parse(reader["guia_id"].ToString());
                    pedido.Cliente_id = int.Parse(reader["cliente_id"].ToString());
                    pedido.Nome_cliente = reader["nome_cliente"].ToString();
                    pedido.Pedido_dataCad = reader["pedido_dataCad"].ToString();
                    pedido.Pedido_dataEntrega = reader["pedido_dataEntrega"].ToString();
                    pedido.Pedido_status = reader["pedido_status"].ToString();
                    pedido.Situacao_pedido = reader["situacao_pedido"].ToString();
                    pedido.Observacao = reader["observacao"].ToString();
                    return pedido; 
                }
                conexaoSql.Close();
            } catch (Exception) {
                conexaoSql.Close();
                throw;
            }
            return pedido;
        }

        public DataTable recuperarPedidoLista(int idPedidoListaEmma)
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
            consultar.CommandText = "select * from tbl_pedidos_lista WHERE guia_id = " + "'" + idPedidoListaEmma + "'";
            MySqlDataReader dr = consultar.ExecuteReader();
            dt.Load(dr);
            conexaoSql.Close();
            return dt;
        }

        public int salvarPedidoListaDAO(ModelPedidoLista modelPedidoLista)
        {
            int salvou = 0;
            try
            {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand salvar = new MySqlCommand("insert into tbl_pedidos_lista (pedido_id, guia_id, cliente_id, nome_cliente, pedido_dataCad, pedido_dataEntrega, pedido_status, situacao_pedido, observacao) values (null, ?, ?, ?, ?, ?, ?, ?, ?)", conexaoSql);
                salvar.Parameters.Add("@guia_id", MySqlDbType.Int64).Value = modelPedidoLista.Guia_id;
                salvar.Parameters.Add("@cliente_id", MySqlDbType.Int64).Value = modelPedidoLista.Cliente_id;
                salvar.Parameters.Add("@nome_cliente", MySqlDbType.VarChar, 100).Value = modelPedidoLista.Nome_cliente;
                salvar.Parameters.Add("@pedido_dataCad", MySqlDbType.VarChar, 10).Value = modelPedidoLista.Pedido_dataCad;
                salvar.Parameters.Add("@pedido_dataEntrega", MySqlDbType.VarChar, 10).Value = modelPedidoLista.Pedido_dataEntrega;
                salvar.Parameters.Add("@pedido_status", MySqlDbType.VarChar, 15).Value = modelPedidoLista.Pedido_status;
                salvar.Parameters.Add("@situacao_pedido", MySqlDbType.VarChar, 15).Value = modelPedidoLista.Situacao_pedido;
                salvar.Parameters.Add("@observacao", MySqlDbType.VarChar, 500).Value = modelPedidoLista.Observacao;
                salvar.ExecuteNonQuery();

                if (salvar.LastInsertedId != null) salvar.Parameters.Add(new MySqlParameter("newId", salvar.LastInsertedId));
                salvou = Convert.ToInt32(salvar.Parameters["@newId"].Value);
                conexaoSql.Close();
            }
            catch
            {
                conexaoSql.Close();
            }
            
            return salvou;
        }

        public String nomeClientePeloId(int id) {
            String retorno = "";
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_clientes WHERE clientes_id = " + "'" + id + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) { retorno = reader["clientes_nome"].ToString(); }
                conexaoSql.Close();
            } catch (Exception) {
                conexaoSql.Close();
                throw;
            }
            
            return retorno;
        }

        public int verificaPedidoEmAberto(int id) {
            int retorno = 0;
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_pedidos_lista WHERE guia_id = " + "'" + id + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) { retorno = int.Parse(reader["pedido_id"].ToString()); }
                conexaoSql.Close();
            } catch (Exception) {
                conexaoSql.Close();
                throw;
            }
            return retorno;
        }

        public bool deletarPedidoListaDAO(String id)
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
                MySqlCommand salvar = new MySqlCommand("DELETE FROM tbl_pedidos_lista WHERE pedido_id = " + id, conexaoSql);
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

        public bool deletarPedidoListaGuia(int id) {
            bool salvou = true;
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand salvar = new MySqlCommand("DELETE FROM tbl_pedidos_lista WHERE guia_id = " + id, conexaoSql);
                salvar.ExecuteNonQuery();
                conexaoSql.Close();
            } catch {
                conexaoSql.Close();
                salvou = false;
            }
            return salvou;
        }

        public bool deletarPedidoListaPelaGuiaEmmaDAO(int id) {
            bool salvou = true;
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand salvar = new MySqlCommand("DELETE FROM tbl_pedidos_lista WHERE guia_id = " + id, conexaoSql);
                salvar.ExecuteNonQuery();
                conexaoSql.Close();
            } catch {
                conexaoSql.Close();
                salvou = false;
            }
            return salvou;
        }

        public bool atualizarPedidoListaDAO(ModelPedidoLista modelPedidoLista)
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
                MySqlCommand salvar = new MySqlCommand("UPDATE tbl_pedidos_lista SET pedido_id=@pedido_id, guia_id=@guia_id, cliente_id=@cliente_id, nome_cliente=@nome_cliente, pedido_dataCad=@pedido_dataCad, pedido_dataEntrega=@pedido_dataEntrega, pedido_status=@pedido_status, situacao_pedido=@situacao_pedido, observacao=@observacao WHERE pedido_id = " + modelPedidoLista.Pedido_id, conexaoSql);
                salvar.Parameters.Add("@pedido_id", MySqlDbType.Int64).Value = modelPedidoLista.Pedido_id;
                salvar.Parameters.Add("@guia_id", MySqlDbType.Int64).Value = modelPedidoLista.Guia_id;
                salvar.Parameters.Add("@cliente_id", MySqlDbType.Int64).Value = modelPedidoLista.Cliente_id;
                salvar.Parameters.Add("@nome_cliente", MySqlDbType.VarChar, 100).Value = modelPedidoLista.Nome_cliente;
                salvar.Parameters.Add("@pedido_dataCad", MySqlDbType.VarChar, 10).Value = modelPedidoLista.Pedido_dataCad;
                salvar.Parameters.Add("@pedido_dataEntrega", MySqlDbType.VarChar, 10).Value = modelPedidoLista.Pedido_dataEntrega;
                salvar.Parameters.Add("@pedido_status", MySqlDbType.VarChar, 15).Value = modelPedidoLista.Pedido_status;
                salvar.Parameters.Add("@situacao_pedido", MySqlDbType.VarChar, 15).Value = modelPedidoLista.Situacao_pedido;
                salvar.Parameters.Add("@observacao", MySqlDbType.VarChar, 500).Value = modelPedidoLista.Observacao;
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

        public ModelPedidoLista dadosDoProdutoAcabadoPeloId(int idGuia) {
            ModelPedidoLista dadosPedidoLista = new ModelPedidoLista();
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_pedidos_lista WHERE guia_id = " + "'" + idGuia + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {
                    dadosPedidoLista.Pedido_id = int.Parse(reader["pedido_id"].ToString());
                    dadosPedidoLista.Guia_id = int.Parse(reader["guia_id"].ToString());
                    dadosPedidoLista.Cliente_id = int.Parse(reader["cliente_id"].ToString());
                    dadosPedidoLista.Nome_cliente = reader["nome_cliente"].ToString();
                    dadosPedidoLista.Pedido_dataCad = reader["pedido_dataCad"].ToString();
                    dadosPedidoLista.Pedido_dataEntrega = reader["pedido_dataEntrega"].ToString();
                    dadosPedidoLista.Pedido_status = reader["pedido_status"].ToString();
                    dadosPedidoLista.Situacao_pedido = reader["situacao_pedido"].ToString();
                    dadosPedidoLista.Observacao = reader["observacao"].ToString();
                    conexaoSql.Close();
                    return dadosPedidoLista;

                }

            } catch (Exception) {
                conexaoSql.Close();
                throw;
            }
            return dadosPedidoLista;
        }

        public DataTable pesquisarPedidoLista(int pesquisa)
        {

            try
            {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_pedidos_lista WHERE guia_id = " + "'" +pesquisa+ "'", conexaoSql);
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

        public DataTable exibirPedidoLista(int idPedidoListaEmma)
        {

            try
            {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_pedidos_lista WHERE guia_id = " + "'" + idPedidoListaEmma + "'", conexaoSql);
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
