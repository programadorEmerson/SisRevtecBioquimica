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
    class ControllerEmbalagens : DAOEmbalagens
    {

        public bool salvarEmbalagensController(ModelEmbalagens produto)
        {
            return salvarEmbalagensDAO(produto);
        }

        public ModelEmbalagens recuperarDadosEmbalagensPeloId(int id) {
            return dadosDoFrascoPeloId(id);
        }

        public bool deletarEmbalagensController(String id)
        {
            return deletarEmbalagensDAO(id);
        }

        public bool atualizarEmbalagensController(ModelEmbalagens produto)
        {
            return atualizarEmbalagensDAO(produto);
        }

        public DataTable exibirTabelaEmbalagens()
        {
            try
            {
                DataTable tabela = new DataTable();
                new DAOProduto();
                tabela = exibirEmbalagens();
                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return null;
            }
        }

        public DataTable pesquisarTabelaEmbalagens(String pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                new DAOProduto();
                tabela = pesquisarEmbalagens(pesquisa);
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
