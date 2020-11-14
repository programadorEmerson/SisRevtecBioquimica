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
    public partial class FormOrdemDeProducao : Form
    {
        String data;
        public FormOrdemDeProducao(String pData)
        {
            InitializeComponent();
            data = pData;
        }

        private void FormOrdemDeProducao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_estoqueDataSet.tbl_ordemdeproducao'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_ordemdeproducaoTableAdapter.Fill(this.db_estoqueDataSet.tbl_ordemdeproducao, data);
            this.reportViewer1.RefreshReport();
        }
    }
}
