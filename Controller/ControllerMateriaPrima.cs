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
    class ControllerMateriaPrima : DAOMateriaPrima
    {

        public bool salvarMateriaPrimaController(ModelMateriaPrima produto)
        {
            return salvarMateriaPrimaDAO(produto);
        }        
        
        public ModelMateriaPrima recuperarMateriaPrima(int id)
        {
            return dadosDaMateriaPrimaPeloId(id);
        }

        public bool deletarMateriaPrimaController(String id)
        {
            return deletarMateriaPrimaDAO(id);
        }

        public bool atualizarMateriaPrimaController(ModelMateriaPrima produto)
        {
            return atualizarMateriaPrimaDAO(produto);
        }

        public DataTable exibirTabelaMateriaPrima()
        {
            try
            {
                DataTable tabela = new DataTable();
                new DAOMateriaPrima();
                tabela = exibirMateriaPrima();
                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return null;
            }
        }

        public DataTable pesquisarTabelaMateriaPrima(String pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                new DAOMateriaPrima();
                tabela = pesquisarMateriaPrima(pesquisa);
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
