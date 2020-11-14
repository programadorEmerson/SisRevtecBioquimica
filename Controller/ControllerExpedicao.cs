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
    class ControllerExpedicao : DAOExpedicao
        {

        public bool salvarClientesController(ModelExpedicao produto)
        {
            return salvarExpedicaoDAO(produto);
        }

        public int verificarAtrsos()
        {
            return contrarPedidosAtrasados();
        }

        public bool deletarExpedicaoController(int id)
        {
            return deletarExpedicaoDAO(id);
        }

        public bool atualizarClientesController(ModelExpedicao produto)
        {
            return atualizarExpedicaoDAO(produto);
        }         
        
        public bool checarItemParaConcluirExpedicao(int guia)
        {
            DAOPedido dAOPedido = new DAOPedido();
            return dAOPedido.ConcluirExpedicao(guia);
        }        
        
        public ModelExpedicao recuperarDadosDaExpedicaoPeloId(int produto)
        {
            return recuperarExpedicaoPeloId(produto);
        }

        public ModelExpedicao recuperarDadosDaExpedicaoKey(int produto) {
            return recuperarExpedicaoPeloIdPrimaryKey(produto);
        }

        public DataTable exibirTabelaClientes() {
            try {
                DataTable tabela = new DataTable();
                new DAOClientes();
                tabela = exibirClientes();
                return tabela;
            } catch (Exception erro) {
                MessageBox.Show(erro.Message);
                return null;
            }
        }

        public DataTable exibirCarregamentosExpedicao(String condicao, DateTime data)
        {
            try
            {
                DataTable tabela = new DataTable();
                new DAOClientes();
                tabela = recuperarExpedicao(condicao, data);
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
