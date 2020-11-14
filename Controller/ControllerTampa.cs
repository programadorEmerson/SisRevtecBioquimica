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
    class ControllerTampa : DAOTampa
    {

        public bool salvarTampaController(ModelTampa produto)
        {
            return salvarTampaDAO(produto);
        }        
        
        public ModelTampa recuperarDadosDaTampa(int id)
        {
            return dadosDaTampaPeloId(id);
        }

        public bool deletarTampaController(String id)
        {
            return deletarTampaDAO(id);
        }

        public bool atualizarTampaController(ModelTampa produto)
        {
            return atualizarTampaDAO(produto);
        }

        public DataTable exibirTabelaTampa()
        {
            try
            {
                DataTable tabela = new DataTable();
                new DAOTampa();
                tabela = exibirTampa();
                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return null;
            }
        }

        public DataTable pesquisarTabelaTampa(String pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                new DAOTampa();
                tabela = pesquisarTampa(pesquisa);
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
