namespace Revtec_Bioquimica.Relatorio
{
    partial class FormProdutoAcabadoEmFalta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutoAcabadoEmFalta));
            this.tbl_produtos_acabados_sem_saldoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_estoqueDataSetTodas = new Revtec_Bioquimica.db_estoqueDataSetTodas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblprodutosacabadossemsaldoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_produtos_acabados_sem_saldoTableAdapter = new Revtec_Bioquimica.db_estoqueDataSetTodasTableAdapters.tbl_produtos_acabados_sem_saldoTableAdapter();
            this.prog7279_producaoDataSet = new Revtec_Bioquimica.prog7279_producaoDataSet();
            this.tblprodutosacabadossemsaldoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_produtos_acabados_sem_saldoTableAdapter1 = new Revtec_Bioquimica.prog7279_producaoDataSetTableAdapters.tbl_produtos_acabados_sem_saldoTableAdapter();
            this.tblprodutosacabadossemsaldoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_produtos_acabados_sem_saldoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblprodutosacabadossemsaldoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prog7279_producaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblprodutosacabadossemsaldoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblprodutosacabadossemsaldoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_produtos_acabados_sem_saldoBindingSource
            // 
            this.tbl_produtos_acabados_sem_saldoBindingSource.DataMember = "tbl_produtos_acabados_sem_saldo";
            this.tbl_produtos_acabados_sem_saldoBindingSource.DataSource = this.db_estoqueDataSetTodas;
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
            reportDataSource1.Value = this.tbl_produtos_acabados_sem_saldoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Revtec_Bioquimica.Relatorio.ReportProdutoAcabadoEmFalta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(791, 602);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblprodutosacabadossemsaldoBindingSource
            // 
            this.tblprodutosacabadossemsaldoBindingSource.DataMember = "tbl_produtos_acabados_sem_saldo";
            this.tblprodutosacabadossemsaldoBindingSource.DataSource = this.db_estoqueDataSetTodas;
            // 
            // tbl_produtos_acabados_sem_saldoTableAdapter
            // 
            this.tbl_produtos_acabados_sem_saldoTableAdapter.ClearBeforeFill = true;
            // 
            // prog7279_producaoDataSet
            // 
            this.prog7279_producaoDataSet.DataSetName = "prog7279_producaoDataSet";
            this.prog7279_producaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblprodutosacabadossemsaldoBindingSource1
            // 
            this.tblprodutosacabadossemsaldoBindingSource1.DataMember = "tbl_produtos_acabados_sem_saldo";
            this.tblprodutosacabadossemsaldoBindingSource1.DataSource = this.prog7279_producaoDataSet;
            // 
            // tbl_produtos_acabados_sem_saldoTableAdapter1
            // 
            this.tbl_produtos_acabados_sem_saldoTableAdapter1.ClearBeforeFill = true;
            // 
            // tblprodutosacabadossemsaldoBindingSource2
            // 
            this.tblprodutosacabadossemsaldoBindingSource2.DataMember = "tbl_produtos_acabados_sem_saldo";
            this.tblprodutosacabadossemsaldoBindingSource2.DataSource = this.db_estoqueDataSetTodas;
            // 
            // FormProdutoAcabadoEmFalta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 602);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProdutoAcabadoEmFalta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programando Soluções - Relatório de produto em falta";
            this.Load += new System.EventHandler(this.FormProdutoAcabadoEmFalta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_produtos_acabados_sem_saldoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblprodutosacabadossemsaldoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prog7279_producaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblprodutosacabadossemsaldoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblprodutosacabadossemsaldoBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private db_estoqueDataSetTodas db_estoqueDataSetTodas;
        private System.Windows.Forms.BindingSource tblprodutosacabadossemsaldoBindingSource;
        private db_estoqueDataSetTodasTableAdapters.tbl_produtos_acabados_sem_saldoTableAdapter tbl_produtos_acabados_sem_saldoTableAdapter;
        private System.Windows.Forms.BindingSource tbl_produtos_acabados_sem_saldoBindingSource;
        private prog7279_producaoDataSet prog7279_producaoDataSet;
        private System.Windows.Forms.BindingSource tblprodutosacabadossemsaldoBindingSource1;
        private prog7279_producaoDataSetTableAdapters.tbl_produtos_acabados_sem_saldoTableAdapter tbl_produtos_acabados_sem_saldoTableAdapter1;
        private System.Windows.Forms.BindingSource tblprodutosacabadossemsaldoBindingSource2;
    }
}