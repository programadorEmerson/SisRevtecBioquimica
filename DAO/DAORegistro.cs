using MySql.Data.MySqlClient;
using Revtec_Bioquimica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revtec_Bioquimica.DAO
{
    class DAORegistro : Conexao
    {

        public bool atualizarUsuariosDAO(Registro registro)
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
                MySqlCommand salvar = new MySqlCommand("UPDATE tbl_registro SET registro_id=@registro_id, registro_serial=@registro_serial, registro_dataRegistro=@registro_dataRegistro, registro_dataExpira=@registro_dataExpira WHERE registro_id = " + registro.Registro_id, conexaoSql);
                salvar.Parameters.Add("@registro_id", MySqlDbType.Int64).Value = registro.Registro_id;
                salvar.Parameters.Add("@registro_serial", MySqlDbType.VarChar, 100).Value = registro.Registro_serial;
                salvar.Parameters.Add("@registro_dataRegistro", MySqlDbType.DateTime).Value = registro.Registro_dataRegistro;
                salvar.Parameters.Add("@registro_dataExpira", MySqlDbType.DateTime).Value = registro.Registro_dataExpira;

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

        public Registro recuperarRegistro()
        {
            Registro registro = new Registro();
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
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_registro", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read())
                {
                    registro.Registro_id = int.Parse(reader["registro_id"].ToString());
                    registro.Registro_serial = reader["registro_serial"].ToString();
                    registro.Registro_dataRegistro = DateTime.Parse(reader["registro_dataRegistro"].ToString());
                    registro.Registro_dataExpira = DateTime.Parse(reader["registro_dataExpira"].ToString());
                    break;
                }
                conexaoSql.Close();
                return registro;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conexaoSql.Close();
            }
            return registro;
        }
    }
}
