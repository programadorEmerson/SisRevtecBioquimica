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
    class DAOClientes : Conexao
    {

        public ModelClientes recuperarClientePeloId(int id) {
            ModelClientes cliente = new ModelClientes();
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_clientes WHERE clientes_id = " + "'" + id + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {
                    cliente.Clientes_id = int.Parse(reader["clientes_id"].ToString());
                    cliente.Clientes_nome = reader["clientes_nome"].ToString();
                    cliente.Clientes_cidade = reader["clientes_cidade"].ToString();
                    cliente.Clientes_observacao = reader["clientes_observacao"].ToString();
                    return cliente;
                }
                conexaoSql.Close();
            } catch (Exception) {
                conexaoSql.Close();
                throw;
            }
            return cliente;
        }

        public int idClientePeloNome(String nome)
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
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_clientes WHERE clientes_id = " + "'" + nome + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read())
                { retorno = int.Parse(reader["clientes_id"].ToString()); }
                conexaoSql.Close();
            }
            catch (Exception)
            {
                conexaoSql.Close();
                throw;
            }
            return retorno;
        }

        public int idFrascoPeloNome(String nome)
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

        public double pesoCaixaPeloNome(String nome)
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
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_caixas WHERE caixas_nome = " + "'" + nome + "'", conexaoSql);
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

        public double pesoEmbalagemPeloNome(String nome)
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
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_embalagens WHERE embalagens_nome = " + "'" + nome + "'", conexaoSql);
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

        public double pesoProPeloNome(String nome)
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
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_produtos WHERE pro_nome = " + "'" + nome + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read())
                { retorno = double.Parse(reader["pro_peso"].ToString()); }
                conexaoSql.Close();

            }
            catch (Exception)
            {
                conexaoSql.Close();
                throw;
            }
            return retorno;
        }

        public int idCliPeloNome(String nome)
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
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_clientes WHERE clientes_nome = " + "'" + nome + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read())
                { retorno = int.Parse(reader["clientes_id"].ToString()); }
                conexaoSql.Close();
            }
            catch (Exception)
            {
                conexaoSql.Close();
                throw;
            }
            return retorno;
        }

        public DataTable recuperarClientes()
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
            consultar.CommandText = "select clientes_nome from tbl_clientes ORDER BY clientes_nome ASC";
            MySqlDataReader dr = consultar.ExecuteReader();
            dt.Load(dr);
            conexaoSql.Close();
            return dt;
        }

        public DataTable recuperarLitragem()
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
            consultar.CommandText = "select litragem from tbl_litragens";
            MySqlDataReader dr = consultar.ExecuteReader();
            dt.Load(dr);
            conexaoSql.Close();
            return dt;
        }


        public bool salvarClientesDAO(ModelClientes modelClientes)
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
                MySqlCommand salvar = new MySqlCommand("insert into tbl_clientes (clientes_id, clientes_nome, clientes_cidade, clientes_observacao) values (null, ?, ?, ?)", conexaoSql);
                salvar.Parameters.Add("@clientes_nome", MySqlDbType.VarChar, 100).Value = modelClientes.Clientes_nome;
                salvar.Parameters.Add("@clientes_cidade", MySqlDbType.VarChar).Value = modelClientes.Clientes_cidade;
                salvar.Parameters.Add("@clientes_observacao", MySqlDbType.VarChar, 500).Value = modelClientes.Clientes_observacao;
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

        public bool deletarClientesDAO(String id)
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
                MySqlCommand salvar = new MySqlCommand("DELETE FROM tbl_clientes WHERE Clientes_id = " + id, conexaoSql);
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

        public bool atualizarClientesDAO(ModelClientes modelClientes)
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
                MySqlCommand salvar = new MySqlCommand("UPDATE tbl_clientes SET clientes_id=@clientes_id, clientes_nome=@clientes_nome, clientes_cidade=@clientes_cidade, clientes_observacao=@clientes_observacao WHERE clientes_id = " + modelClientes.Clientes_id, conexaoSql);
                salvar.Parameters.Add("@clientes_id", MySqlDbType.Int64).Value = modelClientes.Clientes_id;
                salvar.Parameters.Add("@clientes_nome", MySqlDbType.VarChar, 100).Value = modelClientes.Clientes_nome;               
                salvar.Parameters.Add("@clientes_cidade", MySqlDbType.VarChar).Value = modelClientes.Clientes_cidade;
                salvar.Parameters.Add("@clientes_observacao", MySqlDbType.VarChar, 500).Value = modelClientes.Clientes_observacao;
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

        public DataTable pesquisarClientes(String pesquisa)
        {

            try
            {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_clientes WHERE clientes_nome = " + "'" +pesquisa+ "'", conexaoSql);
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

        public DataTable exibirClientes()
        {

            try
            {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_clientes", conexaoSql);
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
