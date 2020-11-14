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
    class ControllerPedido : DAOPedido
    {

        public bool salvarPedidoController(ModelPedido produto)
        {
            return salvarPedidoDAO(produto);
        }

        public bool deletarPedidoController(int id)
        {
            return deletarPedidoDAO(id);
        }

        public bool atualizarPedidoController(ModelPedido produto)
        {
            return atualizarItem(produto);
        }

        public ModelPedido verificaIdExistente(int idPedido) {
            return verificaId(idPedido);
        }

        public ModelPedido recuperarDadosDoItemPeloId(int idPedido) {
            return dadosDoPedidoPeloId(idPedido);
        }

        public DataTable exibirTabelaPedidos(int idPedidoEmma)
        {
            try
            {
                DataTable tabela = new DataTable();
                new DAOPedido();
                tabela = exibirPedido(idPedidoEmma);
                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return null;
            }
        }

        public DataTable pesquisarTabelaPedidos(int pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                new DAOPedido();
                tabela = pesquisarPedido(pesquisa);
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
