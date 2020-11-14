using Revtec_Bioquimica.DAO;
using Revtec_Bioquimica.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revtec_Bioquimica.Controller
{
    class ControllerUsuarios : DAOUsuarios
    {

        public bool salvarUsuariosController(ModelUsuarios produto)
        {
            return salvarUsuariosDAO(produto);
        }        
        
        public String recuperarSetorDoUsuario(int id)
        {
            return nivelAcessoUsuario(id);
        }        
        
        public ModelUsuarios verificarLoginRetornandoUsuario (String login, String senha)
        {
            return recuperarUsuario(login, senha);
        }        
        
        public ModelUsuarios verificarSeLoginJaExiste (String login)
        {
            return verificarSeExiste(login);
        }

        public bool deletarUsuariosController(String id)
        {
            return deletarUsuariosDAO(id);
        }

        public bool atualizarUsuariosController(ModelUsuarios produto)
        {
            return atualizarUsuariosDAO(produto);
        }

        public DataTable exibirTabelaUsuarios(int idUsuario)
        {
            try
            {
                DataTable tabela = new DataTable();
                new DAOUsuarios();
                tabela = exibirUsuarios(idUsuario);
                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return null;
            }
        }

        public DataTable pesquisarTabelaUsuarios(String pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                new DAOUsuarios();
                tabela = pesquisarUsuarios(pesquisa);
                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return null;
            }
        }

    }
}
