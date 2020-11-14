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
    class ControllerFornecedores : DAOFornecedores
    {

        public int salvarFornecedoresController(ModelFornecedores produto)
        {
            return salvarFornecedoresDAO(produto);
        }

        public bool deletarFornecedoresController(String id)
        {
            return deletarFornecedoresDAO(id);
        }

        public bool atualizarFornecedoresController(ModelFornecedores produto)
        {
            return atualizarFornecedoresDAO(produto);
        }

        public DataTable exibirTabelaFornecedores()
        {
            try
            {
                DataTable tabela = new DataTable();
                new DAOFornecedores();
                tabela = exibirFornecedores();
                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return null;
            }
        }

        public DataTable pesquisarTabelaFornecedores(String pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                new DAOFornecedores();
                tabela = pesquisarFornecedores(pesquisa);
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
