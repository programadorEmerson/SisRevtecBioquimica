using Revtec_Bioquimica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revtec_Bioquimica.DAO
{
    class DAOchecarKey : ConexaoWeb
    {

        public bool atualizarChaveDAO(ChecarKey dadosAtivacao)
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
                MySqlCommand salvar = new MySqlCommand("UPDATE tbl_clientesPrograma SET cliente_id=@cliente_id, cliente_nome=@cliente_nome, cliente_dataCadastro=@cliente_dataCadastro, cliente_dataExpira=@cliente_dataExpira, cliente_serial=@cliente_serial WHERE cliente_id = " + dadosAtivacao.Cliente_id, conexaoSql);
                salvar.Parameters.Add("@cliente_id", MySqlDbType.Int64).Value = dadosAtivacao.Cliente_id;
                salvar.Parameters.Add("@cliente_nome", MySqlDbType.VarChar, 100).Value = dadosAtivacao.Cliente_nome;
                salvar.Parameters.Add("@cliente_dataCadastro", MySqlDbType.DateTime).Value = dadosAtivacao.Cliente_dataCadastro;
                salvar.Parameters.Add("@cliente_dataExpira", MySqlDbType.DateTime).Value = dadosAtivacao.Cliente_dataExpira;
                salvar.Parameters.Add("@cliente_serial", MySqlDbType.VarChar, 100).Value = dadosAtivacao.Cliente_serial;

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

        public ChecarKey recuperarDAdosPeloCliente(String cliente)
        {
            ChecarKey key = new ChecarKey();
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
                
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_clientesPrograma WHERE cliente_nome = " + "'" + cliente + "'", conexaoSql);

                

                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read())
                {
                    key.Cliente_id = int.Parse(reader["cliente_id"].ToString());
                    key.Cliente_nome = reader["cliente_nome"].ToString();
                    key.Cliente_dataCadastro = DateTime.Parse(reader["cliente_dataCadastro"].ToString());
                    key.Cliente_dataExpira = DateTime.Parse(reader["cliente_dataExpira"].ToString());
                    key.Cliente_serial = reader["cliente_serial"].ToString();                    
                    conexaoSql.Close();
                    
                }
                return key;
            }
            catch (Exception)
            {
                conexaoSql.Close();
                return key;
            }
        }

    }
}
