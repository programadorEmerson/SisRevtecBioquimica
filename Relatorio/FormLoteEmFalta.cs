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
    public partial class FormLoteEmFalta : Form
    {
        public FormLoteEmFalta()
        {
            InitializeComponent();
        }

        private void FormLoteEmFalta_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_estoqueDataSetTodas.tbl_lotes_sem_saldo'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_lotes_sem_saldoTableAdapter.LoteSemSaldo(this.db_estoqueDataSetTodas.tbl_lotes_sem_saldo);
            this.reportViewer1.RefreshReport();
        }
    }
}
