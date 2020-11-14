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
    public partial class FormProdutoAcabadoEmFalta : Form
    {
        public FormProdutoAcabadoEmFalta()
        {
            InitializeComponent();
        }

        private void FormProdutoAcabadoEmFalta_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_estoqueDataSetTodas.tbl_produtos_acabados_sem_saldo'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_produtos_acabados_sem_saldoTableAdapter.SemSaldo(this.db_estoqueDataSetTodas.tbl_produtos_acabados_sem_saldo);
            this.reportViewer1.RefreshReport();
        }
    }
}
