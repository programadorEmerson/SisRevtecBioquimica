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
    class ControllerCaixas : DAOCaixas
    {

        public bool salvarCaixasController(ModelCaixas produto)
        {
            return salvarCaixasDAO(produto);
        }

        public bool deletarCaixasController(String id)
        {
            return deletarCaixasDAO(id);
        }        
        
        public ModelCaixas recuperarCaixaPeloId(int id)
        {
            return dadosDaCaixaPeloId(id);
        }

        public bool atualizarCaixasController(ModelCaixas produto)
        {
            return atualizarCaixasDAO(produto);
        }

        public DataTable exibirTabelaCaixas()
        {
            try
            {
                DataTable tabela = new DataTable();
                new DAOCaixas();
                tabela = exibirCaixas();
                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return null;
            }
        }

        public DataTable pesquisarTabelaCaixas(String pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                new DAOCaixas();
                tabela = pesquisarCaixas(pesquisa);
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
