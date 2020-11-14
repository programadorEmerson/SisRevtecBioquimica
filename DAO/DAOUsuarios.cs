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
    class DAOUsuarios : Conexao
    {

        public bool salvarUsuariosDAO(ModelUsuarios modelUsuarios)
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
                MySqlCommand salvar = new MySqlCommand("insert into tbl_usuarios (usuarios_id, usuarios_nome, usuarios_setor, usuarios_nivel, usuarios_login, usuarios_senha, usuario_empresa) values (null, ?, ?, ?, ?, ?, ?)", conexaoSql);
                salvar.Parameters.Add("@usuarios_nome", MySqlDbType.VarChar, 100).Value = modelUsuarios.Usuarios_nome;
                salvar.Parameters.Add("@usuarios_setor", MySqlDbType.VarChar, 100).Value = modelUsuarios.Usuarios_setor;
                salvar.Parameters.Add("@usuarios_nivel", MySqlDbType.VarChar, 100).Value = modelUsuarios.Usuarios_nivel;
                salvar.Parameters.Add("@usuarios_login", MySqlDbType.VarChar, 100).Value = modelUsuarios.Usuarios_login;
                salvar.Parameters.Add("@usuarios_senha", MySqlDbType.VarChar, 100).Value = modelUsuarios.Usuarios_senha;
                salvar.Parameters.Add("@usuario_empresa", MySqlDbType.VarChar, 100).Value = modelUsuarios.Usuario_empresa;
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

        public bool deletarUsuariosDAO(String id)
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
                MySqlCommand salvar = new MySqlCommand("DELETE FROM tbl_Usuarios WHERE Usuarios_id = " + id, conexaoSql);
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

        public bool atualizarUsuariosDAO(ModelUsuarios modelUsuarios)
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
                MySqlCommand salvar = new MySqlCommand("UPDATE tbl_usuarios SET usuarios_id=@usuarios_id, usuarios_nome=@usuarios_nome, usuarios_setor=@usuarios_setor, usuarios_nivel=@usuarios_nivel, usuarios_login=@usuarios_login, usuarios_senha=@usuarios_senha, usuario_empresa=@usuario_empresa WHERE usuarios_id = " + modelUsuarios.Usuarios_id, conexaoSql);
                salvar.Parameters.Add("@usuarios_id", MySqlDbType.Int64).Value = modelUsuarios.Usuarios_id;
                salvar.Parameters.Add("@usuarios_nome", MySqlDbType.VarChar, 100).Value = modelUsuarios.Usuarios_nome;
                salvar.Parameters.Add("@usuarios_setor", MySqlDbType.VarChar, 100).Value = modelUsuarios.Usuarios_setor;
                salvar.Parameters.Add("@usuarios_nivel", MySqlDbType.VarChar, 100).Value = modelUsuarios.Usuarios_nivel;
                salvar.Parameters.Add("@usuarios_login", MySqlDbType.VarChar, 100).Value = modelUsuarios.Usuarios_login;
                salvar.Parameters.Add("@usuarios_senha", MySqlDbType.VarChar, 100).Value = modelUsuarios.Usuarios_senha;
                salvar.Parameters.Add("@usuario_empresa", MySqlDbType.VarChar, 100).Value = modelUsuarios.Usuario_empresa;
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

        public ModelUsuarios recuperarUsuario(String login, String senha) {
            ModelUsuarios usuario = new ModelUsuarios();
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_usuarios", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {

                    if (login.Equals(reader["usuarios_login"].ToString()) && senha.Equals(reader["usuarios_senha"].ToString())) {
                        usuario.Usuarios_id = int.Parse(reader["usuarios_id"].ToString());
                        usuario.Usuarios_nome = reader["usuarios_nome"].ToString();
                        usuario.Usuarios_setor = reader["usuarios_setor"].ToString();
                        usuario.Usuarios_nivel = reader["usuarios_nivel"].ToString();
                        usuario.Usuarios_login = reader["usuarios_login"].ToString();
                        usuario.Usuarios_senha = reader["usuarios_senha"].ToString();
                        usuario.Usuario_empresa = reader["usuario_empresa"].ToString();
                        break;
                    }
                    
                }
                conexaoSql.Close();
                return usuario;
            } catch (Exception e) {
                MessageBox.Show(e.Message);
                conexaoSql.Close();
            }
            return usuario;
        }

        public ModelUsuarios verificarSeExiste(String login) {
            ModelUsuarios usuario = new ModelUsuarios();
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_usuarios", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {

                    if (login.Equals(reader["usuarios_login"].ToString())) {
                        usuario.Usuarios_id = int.Parse(reader["usuarios_id"].ToString());
                        usuario.Usuarios_nome = reader["usuarios_nome"].ToString();
                        usuario.Usuarios_setor = reader["usuarios_setor"].ToString();
                        usuario.Usuarios_nivel = reader["usuarios_nivel"].ToString();
                        usuario.Usuarios_login = reader["usuarios_login"].ToString();
                        usuario.Usuarios_senha = reader["usuarios_senha"].ToString();
                        usuario.Usuario_empresa = reader["usuario_empresa"].ToString();
                        break;
                    }

                }
                conexaoSql.Close();
                return usuario;
            } catch (Exception) {
                conexaoSql.Close();
            }
            return usuario;
        }

        public String nivelAcessoUsuario(int id) {
            String usuarioNivel = "";
            try {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT usuarios_setor FROM tbl_usuarios WHERE usuarios_id = " + "'" + id + "'", conexaoSql);
                MySqlDataReader reader = buscar.ExecuteReader();
                while (reader.Read()) {
                    usuarioNivel = reader["usuarios_setor"].ToString();
                conexaoSql.Close();
                return usuarioNivel;
                }
                
            } catch (Exception) {
                conexaoSql.Close();
            }
            return usuarioNivel;
        }

        public DataTable pesquisarUsuarios(String pesquisa)
        {

            try
            {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_usuarios WHERE usuarios_nome = " + "'" +pesquisa+ "'", conexaoSql);
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

        

        public DataTable exibirUsuarios(int idUsuario)
        {

            try
            {
                try {
                    conexaoSql.Open();
                } catch (Exception) {
                    conexaoSql.Close();
                    conexaoSql.Open();
                }
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM tbl_usuarios WHERE usuarios_id = " + "'" + idUsuario + "'", conexaoSql);
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
