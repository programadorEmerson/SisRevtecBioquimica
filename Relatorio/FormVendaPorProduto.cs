using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revtec_Bioquimica.Relatorio
{
    public partial class FormVendaPorProduto : Form
    {
        String produto, litragem, inicial, final;
        public FormVendaPorProduto(String pProduto, String pLitragem, String pInicial, String pFinal)
        {
            InitializeComponent();
            produto = pProduto;
            litragem = pLitragem;
            inicial = pInicial;
            final = pFinal;
        }

        private void FormVendaPorProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_estoqueDataSetTodas.tbl_pedidos_por_produto'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_pedidos_por_produtoTableAdapter.PedidoPorProduto(this.db_estoqueDataSetTodas.tbl_pedidos_por_produto, produto, litragem, inicial, final);
            this.reportViewer1.RefreshReport();
        }
    }
}
