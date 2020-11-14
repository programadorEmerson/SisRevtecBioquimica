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
    class DAOPedido : Conexao
    {

        public ModelPedido verificaId(int id) {
            ModelPedido pedido = new ModelPedido();
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_pedidos WHERE guia_id = " + "'" + id + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {
                    pedido.Pedido_id = int.Parse(reader["pedido_id"].ToString());
                    pedido.Cliente_id = int.Parse(reader["cliente_id"].ToString());
                    pedido.Frasco_id = int.Parse(reader["frasco_id"].ToString());
                    pedido.Caixa_id = int.Parse(reader["caixa_id"].ToString());
                    pedido.Tampa_id = int.Parse(reader["tampa_id"].ToString());
                    pedido.Produto_id = int.Parse(reader["produto_id"].ToString());
                    pedido.Guia_id = int.Parse(reader["guia_id"].ToString());
                    pedido.Pedido_dataCad = reader["pedido_dataCad"].ToString();
                    pedido.Pedido_dataEntrega = reader["pedido_dataEntrega"].ToString();
                    pedido.Pedido_observacao = reader["pedido_observacao"].ToString();
                    pedido.Litragem_escrita = reader["litragem_escrita"].ToString();
                    pedido.Pedido_litragem = double.Parse(reader["pedido_litragem"].ToString());
                    pedido.Pedido_quantidade = int.Parse(reader["pedido_quantidade"].ToString());
                    pedido.Nome_item = reader["nome_item"].ToString();
                    pedido.Caixa_peso = double.Parse(reader["caixa_peso"].ToString());
                    pedido.Tampa_peso = double.Parse(reader["tampa_peso"].ToString());
                    pedido.Frasco_peso = double.Parse(reader["frasco_peso"].ToString());
                    pedido.Produto_peso = double.Parse(reader["produto_peso"].ToString());
                    pedido.Quantidade_caixa = reader["quantidade_caixa"].ToString();
                    pedido.Peso_unidade = double.Parse(reader["peso_unidade"].ToString());
                    pedido.Peso_caixa = double.Parse(reader["peso_caixa"].ToString());
                    pedido.Peso_total = double.Parse(reader["peso_total"].ToString());
                    pedido.Item_status = reader["peso_total"].ToString();
                    pedido.Volume_litros = double.Parse(reader["volume_litros"].ToString());
                    pedido.Cubagem_unidade = double.Parse(reader["cubagem_unidade"].ToString());
                    pedido.Cubagem_total = double.Parse(reader["cubagem_total"].ToString());
                    pedido.Pedido_loteUsado = reader["pedido_loteUsado"].ToString();
                    pedido.Quantidade_int = int.Parse(reader["quantidade_int"].ToString());
                    pedido.Cliente_nome = reader["cliente_nome"].ToString();
                    conexaoSql.Close();
                    return pedido; 
                }
                
            } catch (Exception) {
                conexaoSql.Close();
            }
            return pedido;
        }

        public ModelPedido dadosDoPedidoPeloId(int id) {
            ModelPedido itemPedido = new ModelPedido();
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_pedidos WHERE pedido_id = " + "'" + id + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {

                    itemPedido.Pedido_id = int.Parse(reader["pedido_id"].ToString());
                    itemPedido.Cliente_id = int.Parse(reader["cliente_id"].ToString());
                    itemPedido.Frasco_id = int.Parse(reader["frasco_id"].ToString());
                    itemPedido.Caixa_id = int.Parse(reader["caixa_id"].ToString());
                    itemPedido.Tampa_id = int.Parse(reader["tampa_id"].ToString());
                    itemPedido.Produto_id = int.Parse(reader["produto_id"].ToString());
                    itemPedido.Guia_id = int.Parse(reader["guia_id"].ToString());
                    itemPedido.Pedido_dataCad = reader["pedido_dataCad"].ToString();
                    itemPedido.Pedido_dataEntrega = reader["pedido_dataEntrega"].ToString();
                    itemPedido.Pedido_observacao = reader["pedido_observacao"].ToString();
                    itemPedido.Litragem_escrita = reader["litragem_escrita"].ToString();
                    itemPedido.Pedido_litragem = double.Parse(reader["pedido_litragem"].ToString());
                    itemPedido.Pedido_quantidade = int.Parse(reader["pedido_quantidade"].ToString());
                    itemPedido.Nome_item = reader["nome_item"].ToString();
                    itemPedido.Caixa_peso = double.Parse(reader["caixa_peso"].ToString());
                    itemPedido.Tampa_peso = double.Parse(reader["tampa_peso"].ToString());
                    itemPedido.Frasco_peso = double.Parse(reader["frasco_peso"].ToString());
                    itemPedido.Produto_peso = double.Parse(reader["produto_peso"].ToString());
                    itemPedido.Quantidade_caixa = reader["quantidade_caixa"].ToString();
                    itemPedido.Peso_unidade = double.Parse(reader["peso_unidade"].ToString());
                    itemPedido.Peso_caixa = double.Parse(reader["peso_caixa"].ToString());
                    itemPedido.Peso_total = double.Parse(reader["peso_total"].ToString());
                    itemPedido.Item_status = reader["item_status"].ToString();
                    itemPedido.Volume_litros = double.Parse(reader["volume_litros"].ToString());
                    itemPedido.Cubagem_unidade = double.Parse(reader["cubagem_unidade"].ToString());
                    itemPedido.Cubagem_total = double.Parse(reader["cubagem_total"].ToString());
                    itemPedido.Pedido_loteUsado = reader["pedido_loteUsado"].ToString();
                    itemPedido.Quantidade_int = int.Parse(reader["quantidade_int"].ToString());
                    itemPedido.Cliente_nome = reader["cliente_nome"].ToString();

                    conexaoSql.Close();
                    return itemPedido;
                }
                
            } catch (Exception) {
                conexaoSql.Close();
            }
            return itemPedido;
        }

        public bool ConcluirExpedicao(int id) {

            bool verificacao = false;

            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_pedidos WHERE guia_id = " + "'" + id + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {
                    if (reader["item_status"].ToString().Equals("Em produção") || reader["item_status"].ToString().Equals("Lançado") || reader["item_status"].ToString().Equals("Lote Solicitado") || reader["item_status"].ToString().Equals("Rótulo Solicitado")) {
                        verificacao = true;
                        conexaoSql.Close();
                        break;
                    } 
                }
                conexaoSql.Close();

            } catch (Exception) {
                conexaoSql.Close();
            }

            return verificacao;
        }

        public DataTable recuperarPedido(int idPedidoEmma)
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
            consultar.CommandText = "select tampa_nome from tbl_pedidos WHERE guia_id = " + "'" + idPedidoEmma + "'";
            MySqlDataReader dr = consultar.ExecuteReader();
            dt.Load(dr);
            conexaoSql.Close();
            return dt;
        }

        public bool salvarPedidoDAO(ModelPedido modelPedido)
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
                MySqlCommand salvar = new MySqlCommand("insert into tbl_pedidos (pedido_id, cliente_id, frasco_id, caixa_id, tampa_id, produto_id, guia_id, pedido_dataCad, pedido_dataEntrega, pedido_observacao, litragem_escrita, pedido_litragem, pedido_quantidade, nome_item, caixa_peso, tampa_peso, frasco_peso, produto_peso, quantidade_caixa, peso_unidade, peso_caixa, peso_total, item_status, volume_litros, cubagem_unidade, cubagem_total, pedido_loteUsado, quantidade_int, cliente_nome) values (null, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", conexaoSql);
                salvar.Parameters.Add("@cliente_id", MySqlDbType.Int64).Value = modelPedido.Cliente_id;
                salvar.Parameters.Add("@frasco_id", MySqlDbType.Int64).Value = modelPedido.Frasco_id;
                salvar.Parameters.Add("@caixa_id", MySqlDbType.Int64).Value = modelPedido.Caixa_id;
                salvar.Parameters.Add("@tampa_id", MySqlDbType.Int64).Value = modelPedido.Tampa_id;
                salvar.Parameters.Add("@produto_id", MySqlDbType.Int64).Value = modelPedido.Produto_id;
                salvar.Parameters.Add("@guia_id", MySqlDbType.Int64).Value = modelPedido.Guia_id;
                salvar.Parameters.Add("@pedido_dataCad", MySqlDbType.VarChar, 10).Value = modelPedido.Pedido_dataCad;
                salvar.Parameters.Add("@pedido_dataEntrega", MySqlDbType.VarChar, 10).Value = modelPedido.Pedido_dataEntrega;
                salvar.Parameters.Add("@pedido_observacao", MySqlDbType.VarChar, 500).Value = modelPedido.Pedido_observacao;
                salvar.Parameters.Add("@litragem_escrita", MySqlDbType.VarChar, 15).Value = modelPedido.Litragem_escrita;
                salvar.Parameters.Add("@pedido_litragem", MySqlDbType.Double).Value = modelPedido.Pedido_litragem;
                salvar.Parameters.Add("@pedido_quantidade", MySqlDbType.Int64).Value = modelPedido.Pedido_quantidade;
                salvar.Parameters.Add("@nome_item", MySqlDbType.VarChar, 100).Value = modelPedido.Nome_item;
                salvar.Parameters.Add("@caixa_peso", MySqlDbType.Double).Value = modelPedido.Caixa_peso;
                salvar.Parameters.Add("@tampa_peso", MySqlDbType.Double).Value = modelPedido.Tampa_peso;
                salvar.Parameters.Add("@frasco_peso", MySqlDbType.Double).Value = modelPedido.Frasco_peso;
                salvar.Parameters.Add("@produto_peso", MySqlDbType.Double).Value = modelPedido.Produto_peso;
                salvar.Parameters.Add("@quantidade_caixa", MySqlDbType.VarChar, 15).Value = modelPedido.Quantidade_caixa;
                salvar.Parameters.Add("@peso_unidade", MySqlDbType.Double).Value = modelPedido.Peso_unidade;
                salvar.Parameters.Add("@peso_caixa", MySqlDbType.Double).Value = modelPedido.Peso_caixa;
                salvar.Parameters.Add("@peso_total", MySqlDbType.Double).Value = modelPedido.Peso_total;
                salvar.Parameters.Add("@item_status", MySqlDbType.VarChar, 20).Value = modelPedido.Item_status;
                salvar.Parameters.Add("@volume_litros", MySqlDbType.Double).Value = modelPedido.Volume_litros;
                salvar.Parameters.Add("@cubagem_unidade", MySqlDbType.Double).Value = modelPedido.Cubagem_unidade;
                salvar.Parameters.Add("@cubagem_total", MySqlDbType.Double).Value = modelPedido.Cubagem_total;
                salvar.Parameters.Add("@pedido_loteUsado", MySqlDbType.VarChar, 10).Value = modelPedido.Pedido_loteUsado;
                salvar.Parameters.Add("@quantidade_int", MySqlDbType.Int64).Value = modelPedido.Quantidade_int;
                salvar.Parameters.Add("@cliente_nome", MySqlDbType.VarChar, 100).Value = modelPedido.Cliente_nome;
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

        public bool deletarPedidoDAO(int id)
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
                MySqlCommand salvar = new MySqlCommand("DELETE FROM tbl_pedidos WHERE pedido_id = " + id, conexaoSql);
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
        
        public bool deletarTodoPedidoDAO(int id)
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
                MySqlCommand salvar = new MySqlCommand("DELETE FROM tbl_pedidos WHERE guia_id = " + id, conexaoSql);
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

        public bool atualizarItem(ModelPedido modelPedido) 
            {
            bool salvou = true;
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand salvar = new MySqlCommand("" +
                    "UPDATE tbl_pedidos SET " +
                    "pedido_id=@pedido_id, " +
                    "cliente_id=@cliente_id, " +
                    "frasco_id=@frasco_id, " +
                    "caixa_id=@caixa_id, " +
                    "tampa_id=@tampa_id, " +
                    "produto_id=@produto_id, " +
                    "guia_id=@guia_id, " +
                    "pedido_dataCad=@pedido_dataCad, " +
                    "pedido_dataEntrega=@pedido_dataEntrega, " +
                    "pedido_observacao=@pedido_observacao, " +
                    "litragem_escrita=@litragem_escrita, " +
                    "pedido_litragem=@pedido_litragem, " +
                    "pedido_quantidade=@pedido_quantidade, " +
                    "nome_item=@nome_item, " +
                    "caixa_peso=@caixa_peso, " +
                    "tampa_peso=@tampa_peso, " +
                    "frasco_peso=@frasco_peso, " +
                    "produto_peso=@produto_peso, " +
                    "quantidade_caixa=@quantidade_caixa, " +
                    "peso_unidade=@peso_unidade, " +
                    "peso_caixa=@peso_caixa, " +
                    "peso_total=@peso_total, " +
                    "item_status=@item_status, " +
                    "volume_litros=@volume_litros, " +
                    "cubagem_unidade=@cubagem_unidade, " +
                    "cubagem_total=@cubagem_total, " +
                    "pedido_loteUsado=@pedido_loteUsado, " +
                    "quantidade_int=@quantidade_int, " +
                    "cliente_nome=@cliente_nome " +
                    "WHERE pedido_id = " +
                    modelPedido.Pedido_id, conexaoSql
                    );
                salvar.Parameters.Add("@pedido_id", MySqlDbType.Int64).Value = modelPedido.Pedido_id;
                salvar.Parameters.Add("@cliente_id", MySqlDbType.Int64).Value = modelPedido.Cliente_id;
                salvar.Parameters.Add("@frasco_id", MySqlDbType.Int64).Value = modelPedido.Frasco_id;
                salvar.Parameters.Add("@caixa_id", MySqlDbType.Int64).Value = modelPedido.Caixa_id;
                salvar.Parameters.Add("@tampa_id", MySqlDbType.Int64).Value = modelPedido.Tampa_id;
                salvar.Parameters.Add("@produto_id", MySqlDbType.Int64).Value = modelPedido.Produto_id;
                salvar.Parameters.Add("@guia_id", MySqlDbType.Int64).Value = modelPedido.Guia_id;
                salvar.Parameters.Add("@pedido_dataCad", MySqlDbType.VarChar, 10).Value = modelPedido.Pedido_dataCad;
                salvar.Parameters.Add("@pedido_dataEntrega", MySqlDbType.VarChar, 10).Value = modelPedido.Pedido_dataEntrega;
                salvar.Parameters.Add("@pedido_observacao", MySqlDbType.VarChar, 500).Value = modelPedido.Pedido_observacao;
                salvar.Parameters.Add("@litragem_escrita", MySqlDbType.VarChar, 15).Value = modelPedido.Litragem_escrita;
                salvar.Parameters.Add("@pedido_litragem", MySqlDbType.Double).Value = modelPedido.Pedido_litragem;
                salvar.Parameters.Add("@pedido_quantidade", MySqlDbType.Int64).Value = modelPedido.Pedido_quantidade;
                salvar.Parameters.Add("@nome_item", MySqlDbType.VarChar, 100).Value = modelPedido.Nome_item;
                salvar.Parameters.Add("@caixa_peso", MySqlDbType.Double).Value = modelPedido.Caixa_peso;
                salvar.Parameters.Add("@tampa_peso", MySqlDbType.Double).Value = modelPedido.Tampa_peso;
                salvar.Parameters.Add("@frasco_peso", MySqlDbType.Double).Value = modelPedido.Frasco_peso;
                salvar.Parameters.Add("@produto_peso", MySqlDbType.Double).Value = modelPedido.Produto_peso;
                salvar.Parameters.Add("@quantidade_caixa", MySqlDbType.VarChar, 15).Value = modelPedido.Quantidade_caixa;
                salvar.Parameters.Add("@peso_unidade", MySqlDbType.Double).Value = modelPedido.Peso_unidade;
                salvar.Parameters.Add("@peso_caixa", MySqlDbType.Double).Value = modelPedido.Peso_caixa;
                salvar.Parameters.Add("@peso_total", MySqlDbType.Double).Value = modelPedido.Peso_total;
                salvar.Parameters.Add("@item_status", MySqlDbType.VarChar, 20).Value = modelPedido.Item_status;
                salvar.Parameters.Add("@volume_litros", MySqlDbType.Double).Value = modelPedido.Volume_litros;
                salvar.Parameters.Add("@cubagem_unidade", MySqlDbType.Double).Value = modelPedido.Cubagem_unidade;
                salvar.Parameters.Add("@cubagem_total", MySqlDbType.Double).Value = modelPedido.Cubagem_total;
                salvar.Parameters.Add("@pedido_loteUsado", MySqlDbType.VarChar, 10).Value = modelPedido.Pedido_loteUsado;
                salvar.Parameters.Add("@quantidade_int", MySqlDbType.Int64).Value = modelPedido.Quantidade_int;
                salvar.Parameters.Add("@cliente_nome", MySqlDbType.VarChar, 100).Value = modelPedido.Cliente_nome;
                salvar.ExecuteNonQuery();
                conexaoSql.Close();
            } catch (Exception erro) {
                conexaoSql.Close();
                MessageBox.Show(erro.Message);
            }
            return salvou;
        }

        public bool atualizarPedidoDAO(ModelPedido modelPedido)
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
                MySqlCommand salvar = new MySqlCommand("" +
                    "UPDATE tbl_pedidos SET " +
                    "pedido_id=@pedido_id, " +
                    "cliente_id=@cliente_id, " +
                    "frasco_id=@frasco_id, " +
                    "caixa_id=@caixa_id, " +
                    "tampa_id=@tampa_id, " +
                    "produto_id=@produto_id, " +
                    "guia_id=@guia_id, " +
                    "pedido_dataCad=@pedido_dataCad, " +
                    "pedido_dataEntrega=@pedido_dataEntrega, " +
                    "pedido_observacao=@pedido_observacao, " +
                    "litragem_escrita=@litragem_escrita, " +
                    "pedido_litragem=@pedido_litragem, " +
                    "pedido_quantidade=@pedido_quantidade, " +
                    "nome_item=@nome_item, " +
                    "caixa_peso=@caixa_peso, " +
                    "tampa_peso=@tampa_peso, " +
                    "frasco_peso=@frasco_peso, " +
                    "produto_peso=@produto_peso, " +
                    "quantidade_caixa=@quantidade_caixa, " +
                    "peso_unidade=@peso_unidade, " +
                    "peso_caixa=@peso_caixa, " +
                    "peso_total=@peso_total, " +
                    "item_status=@item_status, " +
                    "volume_litros=@volume_litros, " +
                    "cubagem_unidade=@cubagem_unidade, " +
                    "cubagem_total=@cubagem_total, " +
                    "pedido_loteUsado=@pedido_loteUsado, " +
                    "quantidade_int=@quantidade_int, " +
                    "cliente_nome=@cliente_nome " +
                    "WHERE pedido_id = "
                    + modelPedido.Pedido_id, conexaoSql
                    );
                salvar.Parameters.Add("@pedido_id", MySqlDbType.Int64).Value = modelPedido.Pedido_id;
                salvar.Parameters.Add("@cliente_id", MySqlDbType.Int64).Value = modelPedido.Cliente_id;
                salvar.Parameters.Add("@frasco_id", MySqlDbType.Int64).Value = modelPedido.Frasco_id;
                salvar.Parameters.Add("@caixa_id", MySqlDbType.Int64).Value = modelPedido.Caixa_id;
                salvar.Parameters.Add("@tampa_id", MySqlDbType.Int64).Value = modelPedido.Tampa_id;
                salvar.Parameters.Add("@produto_id", MySqlDbType.Int64).Value = modelPedido.Produto_id;
                salvar.Parameters.Add("@guia_id", MySqlDbType.Int64).Value = modelPedido.Guia_id;
                salvar.Parameters.Add("@pedido_dataCad", MySqlDbType.VarChar, 10).Value = modelPedido.Pedido_dataCad;
                salvar.Parameters.Add("@pedido_dataEntrega", MySqlDbType.VarChar, 10).Value = modelPedido.Pedido_dataEntrega;
                salvar.Parameters.Add("@pedido_observacao", MySqlDbType.VarChar, 500).Value = modelPedido.Pedido_observacao;
                salvar.Parameters.Add("@litragem_escrita", MySqlDbType.VarChar, 15).Value = modelPedido.Litragem_escrita;
                salvar.Parameters.Add("@pedido_litragem", MySqlDbType.Double).Value = modelPedido.Pedido_litragem;
                salvar.Parameters.Add("@pedido_quantidade", MySqlDbType.Int64).Value = modelPedido.Pedido_quantidade;
                salvar.Parameters.Add("@nome_item", MySqlDbType.VarChar, 100).Value = modelPedido.Nome_item;
                salvar.Parameters.Add("@caixa_peso", MySqlDbType.Double).Value = modelPedido.Caixa_peso;
                salvar.Parameters.Add("@tampa_peso", MySqlDbType.Double).Value = modelPedido.Tampa_peso;
                salvar.Parameters.Add("@frasco_peso", MySqlDbType.Double).Value = modelPedido.Frasco_peso;
                salvar.Parameters.Add("@produto_peso", MySqlDbType.Double).Value = modelPedido.Produto_peso;
                salvar.Parameters.Add("@quantidade_caixa", MySqlDbType.Int64).Value = modelPedido.Quantidade_caixa;
                salvar.Parameters.Add("@peso_unidade", MySqlDbType.Double).Value = modelPedido.Peso_unidade;
                salvar.Parameters.Add("@peso_caixa", MySqlDbType.Double).Value = modelPedido.Peso_caixa;
                salvar.Parameters.Add("@peso_total", MySqlDbType.Double).Value = modelPedido.Peso_total;
                salvar.Parameters.Add("@item_status", MySqlDbType.VarChar, 20).Value = modelPedido.Item_status;
                salvar.Parameters.Add("@volume_litros", MySqlDbType.Double).Value = modelPedido.Volume_litros;
                salvar.Parameters.Add("@cubagem_unidade", MySqlDbType.Double).Value = modelPedido.Cubagem_unidade;
                salvar.Parameters.Add("@cubagem_total", MySqlDbType.Double).Value = modelPedido.Cubagem_total;
                salvar.Parameters.Add("@pedido_loteUsado", MySqlDbType.VarChar, 10).Value = modelPedido.Pedido_loteUsado;
                salvar.Parameters.Add("@quantidade_int", MySqlDbType.Int64).Value = modelPedido.Quantidade_int;
                salvar.Parameters.Add("@cliente_nome", MySqlDbType.VarChar, 100).Value = modelPedido.Cliente_nome;
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

        public DataTable pesquisarPedido(int pesquisa)
        {

            try
            {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_pedidos WHERE guia_id = " + "'" +pesquisa+ "'", conexaoSql);
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

        public DataTable exibirPedido(int idPedidoEmma)
        {
            String um = "Em produção", dois = "Concluído";

            try
            {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM `tbl_pedidos` WHERE `guia_id` = '" + idPedidoEmma + "'", conexaoSql);
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
