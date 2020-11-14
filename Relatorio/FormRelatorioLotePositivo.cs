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
    public partial class FormRelatorioLotePositivo : Form
    {
        public FormRelatorioLotePositivo()
        {
            InitializeComponent();
        }

        private void FormRelatorioLotePositivo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_estoqueDataSetTodas.tbl_lotes_com_saldo'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_lotes_com_saldoTableAdapter.LoteComSaldo(this.db_estoqueDataSetTodas.tbl_lotes_com_saldo);
            this.reportViewer1.RefreshReport();
        }
    }
}
