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
    class DAOExpedicao : Conexao
    {

        public DataTable exibirClientes() {

            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_expedicao", conexaoSql);
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

        public DataTable recuperarExpedicao(String condicao, DateTime entrega)
        {
            DataTable dt = new DataTable();
            try {
                conexaoSql.Open();
            } catch (Exception) {
                conexaoSql.Close();
                conexaoSql.Open();
            }

            if (condicao.Equals("Todos")) {
                MySqlCommand consultar = new MySqlCommand {
                    Connection = conexaoSql,
                    CommandText = "select * from tbl_expedicao ORDER BY expedicao_guia DESC"
                };
                MySqlDataReader dr = consultar.ExecuteReader();
                dt.Load(dr);
                conexaoSql.Close();                
            } else if (condicao.Equals("Em produção") || condicao.Equals("Concluído") || condicao.Equals("Entregue")) {
                MySqlCommand consultar = new MySqlCommand {
                    Connection = conexaoSql,
                    CommandText = "select * from tbl_expedicao WHERE expedicao_status = " + "'" + condicao + "' ORDER BY expedicao_guia DESC"
                };
                MySqlDataReader dr = consultar.ExecuteReader();
                dt.Load(dr);
                conexaoSql.Close();
            } else if (condicao.Equals("Hoje")) {
                String dataBr = DateTime.Now.AddDays(0).ToString("dd/MM/yyyy").Substring(0, 2) + "/" + DateTime.Now.AddDays(0).ToString("dd/MM/yyyy").Substring(3, 2) + "/" + DateTime.Now.AddDays(0).ToString("dd/MM/yyyy").Substring(6);
                MySqlCommand consultar = new MySqlCommand {
                    Connection = conexaoSql,
                    CommandText = "select * from tbl_expedicao WHERE expedicao_dataEntrega = " + "'" + dataBr + "' ORDER BY expedicao_guia DESC"
                };
                MySqlDataReader dr = consultar.ExecuteReader();
                dt.Load(dr);
                conexaoSql.Close();
            } else if (condicao.Equals("Atrazada")) {

                String dataHojeSql = DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy").Substring(6)+"-"+ DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy").Substring(3, 2)+"-"+ DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy").Substring(0, 2);

                MySqlCommand consultar = new MySqlCommand {
                    Connection = conexaoSql,
                    CommandText = "select * from tbl_expedicao WHERE expedicao_status != 'Entregue' AND expedicao_entregaDate between '1984-10-16' and '" + dataHojeSql + "' ORDER BY expedicao_guia DESC"
                };
                MySqlDataReader dr = consultar.ExecuteReader();
                dt.Load(dr);
                conexaoSql.Close();
            }
            return dt;
        }

        public bool salvarExpedicaoDAO(ModelExpedicao modelExpedicao)
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
                MySqlCommand salvar = new MySqlCommand("insert into tbl_expedicao (	expedicao_id, expedicao_guia, expedicao_cliente, expedicao_dataEntrada, expedicao_dataEntrega, expedicao_volume, expedicao_peso, expedicao_cubagem, expedicao_status, expedicao_entregaDate) values (null, ?, ?, ?, ?, ?, ?, ?, ?, ?)", conexaoSql);
                salvar.Parameters.Add("@expedicao_guia", MySqlDbType.Int64).Value = modelExpedicao.Expedicao_guia;
                salvar.Parameters.Add("@expedicao_cliente", MySqlDbType.VarChar, 100).Value = modelExpedicao.Expedicao_cliente;
                salvar.Parameters.Add("@expedicao_dataEntrada", MySqlDbType.VarChar, 10).Value = modelExpedicao.Expedicao_dataEntrada;
                salvar.Parameters.Add("@expedicao_dataEntrega", MySqlDbType.VarChar, 10).Value = modelExpedicao.Expedicao_dataEntrega;
                salvar.Parameters.Add("@expedicao_volume", MySqlDbType.Int64).Value = modelExpedicao.Expedicao_volume;
                salvar.Parameters.Add("@expedicao_peso", MySqlDbType.Double).Value = modelExpedicao.Expedicao_peso;
                salvar.Parameters.Add("@expedicao_cubagem", MySqlDbType.Double).Value = modelExpedicao.Expedicao_cubagem;
                salvar.Parameters.Add("@expedicao_status", MySqlDbType.VarChar, 10).Value = modelExpedicao.Expedicao_status;
                salvar.Parameters.Add("@expedicao_entregaDate", MySqlDbType.DateTime).Value = modelExpedicao.Expedicao_entregaDate;
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

        public bool deletarExpedicaoDAO(int id)
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
                MySqlCommand salvar = new MySqlCommand("DELETE FROM tbl_expedicao WHERE expedicao_guia = " + id, conexaoSql);
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

        public bool atualizarExpedicaoDAO(ModelExpedicao modelExpedicao)
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
                MySqlCommand salvar = new MySqlCommand("UPDATE tbl_expedicao SET expedicao_id=@expedicao_id, expedicao_cliente=@expedicao_cliente, expedicao_dataEntrada=@expedicao_dataEntrada, expedicao_dataEntrega=@expedicao_dataEntrega, expedicao_volume=@expedicao_volume, expedicao_peso=@expedicao_peso, expedicao_cubagem=@expedicao_cubagem, expedicao_status=@expedicao_status, expedicao_entregaDate=@expedicao_entregaDate WHERE expedicao_id = " + modelExpedicao.Expedicao_id, conexaoSql);
                salvar.Parameters.Add("@expedicao_id", MySqlDbType.Int64).Value = modelExpedicao.Expedicao_id;
                salvar.Parameters.Add("@expedicao_cliente", MySqlDbType.VarChar, 100).Value = modelExpedicao.Expedicao_cliente;
                salvar.Parameters.Add("@expedicao_dataEntrada", MySqlDbType.VarChar, 10).Value = modelExpedicao.Expedicao_dataEntrada;
                salvar.Parameters.Add("@expedicao_dataEntrega", MySqlDbType.VarChar, 10).Value = modelExpedicao.Expedicao_dataEntrega;
                salvar.Parameters.Add("@expedicao_volume", MySqlDbType.Int64).Value = modelExpedicao.Expedicao_volume;
                salvar.Parameters.Add("@expedicao_peso", MySqlDbType.Double).Value = modelExpedicao.Expedicao_peso;
                salvar.Parameters.Add("@expedicao_cubagem", MySqlDbType.Double).Value = modelExpedicao.Expedicao_cubagem;
                salvar.Parameters.Add("@expedicao_status", MySqlDbType.VarChar, 10).Value = modelExpedicao.Expedicao_status;
                salvar.Parameters.Add("@expedicao_entregaDate", MySqlDbType.DateTime).Value = modelExpedicao.Expedicao_entregaDate;
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

        public ModelExpedicao recuperarExpedicaoPeloId(int id) {
            ModelExpedicao cliente = new ModelExpedicao();
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_expedicao WHERE expedicao_guia = " + "'" + id + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {
                    cliente.Expedicao_id = int.Parse(reader["expedicao_id"].ToString());
                    cliente.Expedicao_guia = int.Parse(reader["expedicao_guia"].ToString());
                    cliente.Expedicao_cliente = reader["expedicao_cliente"].ToString();
                    cliente.Expedicao_dataEntrada = reader["expedicao_dataEntrada"].ToString();
                    cliente.Expedicao_dataEntrega = reader["expedicao_dataEntrega"].ToString();
                    cliente.Expedicao_volume = int.Parse(reader["expedicao_volume"].ToString());
                    cliente.Expedicao_peso = double.Parse(reader["expedicao_peso"].ToString());
                    cliente.Expedicao_cubagem = double.Parse(reader["expedicao_cubagem"].ToString()); 
                    cliente.Expedicao_status = reader["expedicao_status"].ToString();
                    cliente.Expedicao_entregaDate = DateTime.Parse(reader["expedicao_entregaDate"].ToString());
                    return cliente;
                }
                conexaoSql.Close();
            } catch (Exception) {
                conexaoSql.Close();
                throw;
            }
            return cliente;
        }

        public int contrarPedidosAtrasados()
        {
            String dataHojeSql = DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy").Substring(6) + "-" + DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy").Substring(3, 2) + "-" + DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy").Substring(0, 2);
            int numAtrasos = 0;
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
                MySqlCommand buscar = new MySqlCommand("select * from tbl_expedicao WHERE expedicao_status != 'Entregue' AND expedicao_entregaDate between '1984-10-16' and '" + dataHojeSql + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read())
                {
                    numAtrasos++;
                }
                conexaoSql.Close();
            }
            catch (Exception)
            {
                conexaoSql.Close();
                throw;
            }
            return numAtrasos;
        }

        public ModelExpedicao recuperarExpedicaoPeloIdPrimaryKey(int id) {
            ModelExpedicao cliente = new ModelExpedicao();
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_expedicao WHERE expedicao_id = " + "'" + id + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {
                    cliente.Expedicao_id = int.Parse(reader["expedicao_id"].ToString());
                    cliente.Expedicao_guia = int.Parse(reader["expedicao_guia"].ToString());
                    cliente.Expedicao_cliente = reader["expedicao_cliente"].ToString();
                    cliente.Expedicao_dataEntrada = reader["expedicao_dataEntrada"].ToString();
                    cliente.Expedicao_dataEntrega = reader["expedicao_dataEntrega"].ToString();
                    cliente.Expedicao_volume = int.Parse(reader["expedicao_volume"].ToString());
                    cliente.Expedicao_peso = double.Parse(reader["expedicao_peso"].ToString());
                    cliente.Expedicao_cubagem = double.Parse(reader["expedicao_cubagem"].ToString());
                    cliente.Expedicao_status = reader["expedicao_status"].ToString();
                    cliente.Expedicao_entregaDate = DateTime.Parse(reader["expedicao_entregaDate"].ToString());
                    return cliente;
                }
                conexaoSql.Close();
            } catch (Exception) {
                conexaoSql.Close();
                throw;
            }
            return cliente;
        }

        public DataTable exibirExpedicao()
        {

            try
            {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_expedicao", conexaoSql);
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
