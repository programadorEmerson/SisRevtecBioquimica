﻿using System;
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
    public partial class FormRelatorioProdutoAcabado : Form
    {
        public FormRelatorioProdutoAcabado()
        {
            InitializeComponent();
        }

        private void FormRelatorioProdutoAcabado_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_estoqueDataSetTodas.tbl_produtos_acabados_todos'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_produtos_acabados_todosTableAdapter.Fill(this.db_estoqueDataSetTodas.tbl_produtos_acabados_todos);
            this.reportViewer1.RefreshReport();
        }
    }
}
