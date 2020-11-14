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
    public partial class FormProdutosEmAberto : Form
    {
        String item;
        public FormProdutosEmAberto(String pItem)
        {
            InitializeComponent();
            item = pItem;
        }

        private void FormProdutosEmAberto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_estoqueDataSetTodas.tbl_pedidosEmAbertoItens'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_pedidosEmAbertoItensTableAdapter.Fill(this.db_estoqueDataSetTodas.tbl_pedidosEmAbertoItens, item);

            this.reportViewer1.RefreshReport();
        }
    }
}
