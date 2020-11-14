using Revtec_Bioquimica.DAO;
using Revtec_Bioquimica.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace Revtec_Bioquimica.Controller
{
    class ControllerLoteLaboratorio
    {
        public bool salvarLoteDeLaboratorio(ModelLoteLaboratorio lote)
        {
            DAOLoteLaboratorio loteLaboratorio = new DAOLoteLaboratorio();
            return loteLaboratorio.salvarLoteDAO(lote);
        }

        public ModelLoteLaboratorio recuperarUltimoLote()
        {
            DAOLoteLaboratorio loteLaboratorio = new DAOLoteLaboratorio();
            return loteLaboratorio.dadosDoloLote();
        }

        public DataTable exibirLotesLaboratorio()
        {
            DAOLoteLaboratorio dAOLoteLaboratorio = new DAOLoteLaboratorio();
            try
            {
                DataTable tabela = new DataTable();
                new DAOProduto();
                tabela = dAOLoteLaboratorio.exibirLotes();
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
