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
    public partial class FormMateriaPrimaEmFalta : Form
    {
        public FormMateriaPrimaEmFalta()
        {
            InitializeComponent();
        }

        private void FormMateriaPrimaEmFalta_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_estoqueDataSetTodas.tbl_materiaprimaEmFalta'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_materiaprimaEmFaltaTableAdapter.MateriaPrimaEmFalta(this.db_estoqueDataSetTodas.tbl_materiaprimaEmFalta);
            this.reportViewer1.RefreshReport();
        }
    }
}
