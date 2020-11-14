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
    class DAOMateriaPrima : Conexao
    {

        public bool salvarMateriaPrimaDAO(ModelMateriaPrima modelMateriaPrima)
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
                MySqlCommand salvar = new MySqlCommand("insert into tbl_materiaprima (materiaprima_id, materiaprima_nome, materiaprima_estoque, materiaprima_observacao) values (null, ?, ?, ?)", conexaoSql);
                salvar.Parameters.Add("@materiaprima_nome", MySqlDbType.VarChar, 100).Value = modelMateriaPrima.MateriaPrima_nome;
                salvar.Parameters.Add("@materiaprima_estoque", MySqlDbType.Double).Value = modelMateriaPrima.MateriaPrima_estoque;
                salvar.Parameters.Add("@materiaprima_observacao", MySqlDbType.VarChar, 500).Value = modelMateriaPrima.MateriaPrima_observacao;
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

        public bool deletarMateriaPrimaDAO(String id)
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
                MySqlCommand salvar = new MySqlCommand("DELETE FROM tbl_materiaprima WHERE materiaprima_id = " + id, conexaoSql);
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

        public bool atualizarMateriaPrimaDAO(ModelMateriaPrima modelMateriaPrima)
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
                MySqlCommand salvar = new MySqlCommand("UPDATE tbl_materiaprima SET materiaprima_id=@materiaprima_id, materiaprima_nome=@materiaprima_nome, materiaprima_estoque=@materiaprima_estoque, materiaprima_observacao=@materiaprima_observacao WHERE materiaprima_id = " + modelMateriaPrima.MateriaPrima_id, conexaoSql);
                salvar.Parameters.Add("@materiaprima_id", MySqlDbType.Int64).Value = modelMateriaPrima.MateriaPrima_id;
                salvar.Parameters.Add("@materiaprima_nome", MySqlDbType.VarChar, 100).Value = modelMateriaPrima.MateriaPrima_nome;               
                salvar.Parameters.Add("@materiaprima_estoque", MySqlDbType.Double).Value = modelMateriaPrima.MateriaPrima_estoque;
                salvar.Parameters.Add("@materiaprima_observacao", MySqlDbType.VarChar, 500).Value = modelMateriaPrima.MateriaPrima_observacao;
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

        public DataTable pesquisarMateriaPrima(String pesquisa)
        {

            try
            {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_materiaprima WHERE materiaprima_nome = " + "'" +pesquisa+ "'", conexaoSql);
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

        public ModelMateriaPrima dadosDaMateriaPrimaPeloId(int id) {
            ModelMateriaPrima materiaPrima = new ModelMateriaPrima();
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_materiaprima WHERE materiaprima_id = " + "'" + id + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {
                    materiaPrima.MateriaPrima_id = int.Parse(reader["materiaprima_id"].ToString());
                    materiaPrima.MateriaPrima_nome = reader["materiaprima_nome"].ToString();
                    materiaPrima.MateriaPrima_estoque = double.Parse(reader["materiaprima_estoque"].ToString());
                    materiaPrima.MateriaPrima_observacao = reader["materiaprima_observacao"].ToString();                    
                    conexaoSql.Close();
                    return materiaPrima;
                }
            } catch (Exception) {
                conexaoSql.Close();
                throw;
            }
            return materiaPrima;
        }

        public DataTable exibirMateriaPrima()
        {

            try
            {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_materiaprima", conexaoSql);
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
