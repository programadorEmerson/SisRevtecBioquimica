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
    class ControllerLote : DAOLote
    {

        public bool salvarLoteController(ModelLote produto)
        {
            return salvarLoteDAO(produto);
        }           
        
        public bool salvarOrdemParaProducao(ModelOrdemDeProducao ordemDeProducao)
        {
            return salvarOrdemProducao(ordemDeProducao);
        }          
        
        public bool concluirLoteZerado()
        {
            return finalizarLoteZerado();
        }         
        
        public String recuperarUltimoLoteValido()
        {
            return retornarUltimoLote();
        }
        
        public int recuperarIdDoLote(String numeroLote)
        {
            return idLotePeloLote(numeroLote);
        }         
        
        public bool loteExiste(String produto, String statusLote)
        {
            return verSeLoteExiste(produto, statusLote);
        }        
        
        public ModelLote recuperarDadosDaLote(String lote)
        {
            return dadosDaLotePeloId(lote);
        }        
        
        public ModelOrdemDeProducao dadosOP(String lote)
        {
            return dadosOrdemProducaoPeloloLote(lote);
        }
        
        public ModelLote recuperarLote(String lote)
        {
            return dadosDoloLote(lote);
        }                 
        
        public ModelLote verificarLoteSeAtendeADemanda(String produto, String status, String status2, double demanda)
        {
            return verSeLoteExisteAtendendoDemanda(produto, status, status2, demanda);
        }         
        
        public ModelLote verificarSeLoteLiberou(String produto, String status, String status2, double demanda)
        {
            return verSeLoteLiberou(produto, status, status2, demanda);
        }        
        
        public ModelLote recuperarDadosDaNomeDoProduto(String produto)
        {
            return dadosDaLotePeloProduto(produto);
        }         
        
        public ModelLote estornarLote(String produto)
        {
            return recuperarUltimoLote(produto);
        }         
        
        public ModelLote recuperarDadosDaNomeDoProdutoConcluido(String produto)
        {
            return dadosDaLotePeloProdutoConcluido(produto);
        }        
        
        public ModelLote recuperarDadosDoLoteComLote(String produto, String lote)
        {
            return dadosDaLotePeloLote(produto, lote);
        }

        public ModelLote recuperarDadosDoLoteComNomeDoProduto(String produto, String status) {
            return dadosDaLotePeloProduto(produto, status);
        }
        
        public ModelLote recuperarDadosDoLoteComProduto(String produto, String status) {
            return dadosLotePeloProduto(produto, status);
        }

        public bool deletarLoteController(String numeroLote)
        {
            return deletarLoteDAO(numeroLote);
        }        
        public bool deletarOP(ModelOrdemDeProducao ordemProducao)
        {
            return deletarItemOP(ordemProducao);
        }

        public bool atualizarLoteController(ModelLote produto)
        {
            return atualizarLoteDAO(produto);
        }        
        
        public bool atualizarOP(ModelOrdemDeProducao produto)
        {
            return atualizarOrdemDeProducao(produto);
        }

        public DataTable pesquisarTabelaLote(String pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                new DAOLote();
                tabela = exibirLoteComFiltro(pesquisa);
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
