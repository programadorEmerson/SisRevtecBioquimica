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
    public partial class FormRelatorioExpedicaoDataInicialDataFinal : Form
    {
        DateTime inicial;
        DateTime final;
        public FormRelatorioExpedicaoDataInicialDataFinal(DateTime dataInicial, DateTime dataFinal)
        {
            InitializeComponent();
            inicial = dataInicial;
            final = dataFinal;
        }

        private void FormRelatorioExpedicaoDataInicialDataFinal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_estoqueDataSetTodas.tbl_expedicao'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_expedicaoTableAdapter.RelDataIniDataFin(this.db_estoqueDataSetTodas.tbl_expedicao, inicial, final);

            this.reportViewer1.RefreshReport();
        }
    }
}
