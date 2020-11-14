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
    public partial class FormEmbalagemPositiva : Form
    {
        public FormEmbalagemPositiva()
        {
            InitializeComponent();
        }

        private void FormEmbalagemPositiva_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_estoqueDataSetTodas.tbl_embalagensPositiva'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_embalagensPositivaTableAdapter.EmbalagemPositiva(this.db_estoqueDataSetTodas.tbl_embalagensPositiva);
            this.reportViewer1.RefreshReport();
        }
    }
}
