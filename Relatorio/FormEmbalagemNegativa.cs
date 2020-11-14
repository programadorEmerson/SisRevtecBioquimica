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
    public partial class FormEmbalagemNegativa : Form
    {
        public FormEmbalagemNegativa()
        {
            InitializeComponent();
        }

        private void FormEmbalagemNegativa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_estoqueDataSetTodas.tbl_embalagensNegativa'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_embalagensNegativaTableAdapter.EmbalagemNegativa(this.db_estoqueDataSetTodas.tbl_embalagensNegativa);
            this.reportViewer1.RefreshReport();
        }
    }
}
