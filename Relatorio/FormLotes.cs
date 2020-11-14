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
    public partial class FormLotes : Form
    {
        int idLote;
        public FormLotes(int id)
        {
            InitializeComponent();
            idLote = id;
        }

        private void FormLotes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_estoqueDataSetTodas.tbl_lotes'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_lotesTableAdapter.ConsultarPeloId(this.db_estoqueDataSetTodas.tbl_lotes, idLote);
            this.reportViewer1.RefreshReport();
        }
    }
}
