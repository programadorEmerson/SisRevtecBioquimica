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
    class DAOFornecedores : Conexao
    {

        public int retornarUltimoId()
        {
            int id = 0;
            try
            {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand cmd = new MySqlCommand("SELECT last_insert_id(fornecedores_id) from tbl_fornecedores ORDER BY fornecedores_id DESC LIMIT 1", conexaoSql);
                id = cmd.ExecuteNonQuery();
                conexaoSql.Close();
            }
            catch
            {
                conexaoSql.Close();
            }
            return id;
        }

        public int salvarFornecedoresDAO(ModelFornecedores modelFornecedores)
        {
            int salvou=0;
            try
            {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand salvar = new MySqlCommand("insert into tbl_fornecedores (fornecedores_id, fornecedores_nome, fornecedores_telefone, fornecedores_observacao) values (null, ?, ?, ?)", conexaoSql);
                salvar.Parameters.Add("@fornecedores_nome", MySqlDbType.VarChar, 100).Value = modelFornecedores.Fornecedores_nome;
                salvar.Parameters.Add("@fornecedores_telefone", MySqlDbType.VarChar).Value = modelFornecedores.Fornecedores_telefone;
                salvar.Parameters.Add("@fornecedores_observacao", MySqlDbType.VarChar, 500).Value = modelFornecedores.Fornecedores_observacao;
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

        public bool deletarFornecedoresDAO(String id)
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
                MySqlCommand salvar = new MySqlCommand("DELETE FROM tbl_fornecedores WHERE Fornecedores_id = " + id, conexaoSql);
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

        public bool atualizarFornecedoresDAO(ModelFornecedores modelFornecedores)
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
                MySqlCommand salvar = new MySqlCommand("UPDATE tbl_fornecedores SET fornecedores_id=@fornecedores_id, fornecedores_nome=@fornecedores_nome, fornecedores_telefone=@fornecedores_telefone, fornecedores_observacao=@fornecedores_observacao WHERE fornecedores_id = " + modelFornecedores.Fornecedores_id, conexaoSql);
                salvar.Parameters.Add("@fornecedores_id", MySqlDbType.Int64).Value = modelFornecedores.Fornecedores_id;
                salvar.Parameters.Add("@fornecedores_nome", MySqlDbType.VarChar, 100).Value = modelFornecedores.Fornecedores_nome;               
                salvar.Parameters.Add("@fornecedores_telefone", MySqlDbType.VarChar).Value = modelFornecedores.Fornecedores_telefone;
                salvar.Parameters.Add("@fornecedores_observacao", MySqlDbType.VarChar, 500).Value = modelFornecedores.Fornecedores_observacao;
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

        public DataTable pesquisarFornecedores(String pesquisa)
        {

            try
            {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_fornecedores WHERE fornecedores_nome = " + "'" +pesquisa+ "'", conexaoSql);
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

        public DataTable exibirFornecedores()
        {

            try
            {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_fornecedores", conexaoSql);
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
