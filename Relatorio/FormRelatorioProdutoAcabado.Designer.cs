namespace Revtec_Bioquimica.Relatorio
{
    partial class FormRelatorioProdutoAcabado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorioProdutoAcabado));
            this.tbl_produtos_acabados_todosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_estoqueDataSetTodas = new Revtec_Bioquimica.db_estoqueDataSetTodas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblprodutosacabadostodosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_produtos_acabados_todosTableAdapter = new Revtec_Bioquimica.db_estoqueDataSetTodasTableAdapters.tbl_produtos_acabados_todosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_produtos_acabados_todosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblprodutosacabadostodosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_produtos_acabados_todosBindingSource
            // 
            this.tbl_produtos_acabados_todosBindingSource.DataMember = "tbl_produtos_acabados_todos";
            this.tbl_produtos_acabados_todosBindingSource.DataSource = this.db_estoqueDataSetTodas;
            // 
            // db_estoqueDataSetTodas
            // 
            this.db_estoqueDataSetTodas.DataSetName = "db_estoqueDataSetTodas";
            this.db_estoqueDataSetTodas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_produtos_acabados_todosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Revtec_Bioquimica.Relatorio.ReportProdutoAcabado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(791, 602);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblprodutosacabadostodosBindingSource
            // 
            this.tblprodutosacabadostodosBindingSource.DataMember = "tbl_produtos_acabados_todos";
            this.tblprodutosacabadostodosBindingSource.DataSource = this.db_estoqueDataSetTodas;
            // 
            // tbl_produtos_acabados_todosTableAdapter
            // 
            this.tbl_produtos_acabados_todosTableAdapter.ClearBeforeFill = true;
            // 
            // FormRelatorioProdutoAcabado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 602);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRelatorioProdutoAcabado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programando Soluções - Relatório produtos acabado em estoque";
            this.Load += new System.EventHandler(this.FormRelatorioProdutoAcabado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_produtos_acabados_todosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblprodutosacabadostodosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private db_estoqueDataSetTodas db_estoqueDataSetTodas;
        private System.Windows.Forms.BindingSource tblprodutosacabadostodosBindingSource;
        private db_estoqueDataSetTodasTableAdapters.tbl_produtos_acabados_todosTableAdapter tbl_produtos_acabados_todosTableAdapter;
        private System.Windows.Forms.BindingSource tbl_produtos_acabados_todosBindingSource;
    }
}