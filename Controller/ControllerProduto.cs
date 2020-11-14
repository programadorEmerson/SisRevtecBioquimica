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
    class ControllerProduto : DAOProduto
    {

        public bool salvarProdutoController(ModelProduto produto)
        {
            return salvarProdutoDAO(produto);
        }
        
        public ModelProduto retornarProdutoPeloId(int id)
        {
            return dadosDoProdutoPeloId(id);
        }

        public bool deletarProdutoController(String id)
        {
            return deletarProdutoDAO(id);
        }

        public bool atualizarProdutoController(ModelProduto produto)
        {
            return atualizarProdutoDAO(produto);
        }

        public DataTable exibirTabelaProdutos()
        {
            try
            {
                DataTable tabela = new DataTable();
                new DAOProduto();
                tabela = exibirProdutos();
                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return null;
            }
        }

        public DataTable pesquisarTabelaProdutos(String pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                new DAOProduto();
                tabela = pesquisarProdutos(pesquisa);
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
