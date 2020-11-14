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
    class ControllerPedidoLista : DAOPedidoLista {

        public int salvarPedidoListaController(ModelPedidoLista produto)
        {
            return salvarPedidoListaDAO(produto);
        }        
        
        public ModelPedidoLista dadosDoPedidoLista(int idGuia)
        {
            return dadosDoProdutoAcabadoPeloId(idGuia);
        }

        public int verificarPedidoEmAberto(int idGuia) {
            return verificaPedidoEmAberto(idGuia);
        }

        public bool deletarPedidoListaController(String id)
        {
            return deletarPedidoListaDAO(id);
        }        
        
        
        public bool deletarPedidoListaController(int id)
        {
            return deletarPedidoListaGuia(id);
        }



        public bool deletarPedidoListaPelaGuiaController(int id) {
            return deletarPedidoListaPelaGuiaEmmaDAO(id);
        }

        public bool atualizarPedidoListaController(ModelPedidoLista produto)
        {
            return atualizarPedidoListaDAO(produto);
        }

        public ModelPedidoLista verificaIdExistente(int idPedidoLista) {
            return verificaId(idPedidoLista);
        }
        
        public bool verSeIdExite(int idPedidoLista) {
            return verificaIdExixtente(idPedidoLista);
        }

        public DataTable exibirTabelaPedidoListas(int idPedidoListaEmma)
        {
            try
            {
                DataTable tabela = new DataTable();
                new DAOPedidoLista();
                tabela = exibirPedidoLista(idPedidoListaEmma);
                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return null;
            }
        }

        public DataTable pesquisarTabelaPedidoListas(int pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                new DAOPedidoLista();
                tabela = pesquisarPedidoLista(pesquisa);
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
