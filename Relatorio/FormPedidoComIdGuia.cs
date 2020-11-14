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
    public partial class FormPedidoComIdGuia : Form
    {
        int idGuia;
        public FormPedidoComIdGuia(int id)
        {
            InitializeComponent();
            idGuia = id;
        }

        private void FormPedidoComIdGuia_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_estoqueDataSetTodas.tbl_pedidos'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_pedidosTableAdapter.Fill(this.db_estoqueDataSetTodas.tbl_pedidos, idGuia);
            this.reportViewer1.RefreshReport();
        }
    }
}
