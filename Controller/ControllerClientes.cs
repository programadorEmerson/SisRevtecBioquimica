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
    class ControllerClientes : DAOClientes
    {

        public bool salvarClientesController(ModelClientes produto)
        {
            return salvarClientesDAO(produto);
        }

        public bool deletarClientesController(String id)
        {
            return deletarClientesDAO(id);
        }

        public bool atualizarClientesController(ModelClientes produto)
        {
            return atualizarClientesDAO(produto);
        }

        public DataTable exibirTabelaClientes()
        {
            try
            {
                DataTable tabela = new DataTable();
                new DAOClientes();
                tabela = exibirClientes();
                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return null;
            }
        }

        public DataTable pesquisarTabelaClientes(String pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                new DAOClientes();
                tabela = pesquisarClientes(pesquisa);
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
