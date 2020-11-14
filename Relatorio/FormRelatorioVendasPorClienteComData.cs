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
    public partial class FormRelatorioVendasPorClienteComData : Form
    {
        DateTime inicial, final;
        String cliente;
        public FormRelatorioVendasPorClienteComData(String pCliente, DateTime dInicial, DateTime dFinal)
        {
            InitializeComponent();
            inicial = dInicial;
            final = dFinal;
            cliente = pCliente;
        }

        private void FormRelatorioVendasPorClienteComData_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_estoqueDataSetTodas.tbl_expedicao1'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_expedicao1TableAdapter.RelatorioVendasPorCliente(this.db_estoqueDataSetTodas.tbl_expedicao1, cliente, inicial, final);
            this.reportViewer1.RefreshReport();
        }
    }
}
