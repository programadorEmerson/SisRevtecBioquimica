namespace Revtec_Bioquimica.Relatorio
{
    partial class FormRelatorioProdutoAcabadoPositivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorioProdutoAcabadoPositivo));
            this.tbl_produtos_acabados_com_saldoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_estoqueDataSetTodas = new Revtec_Bioquimica.db_estoqueDataSetTodas();
            this.tblprodutosacabadoscomsaldoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblprodutosacabadoscomsaldoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_produtos_acabados_com_saldoTableAdapter = new Revtec_Bioquimica.db_estoqueDataSetTodasTableAdapters.tbl_produtos_acabados_com_saldoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_produtos_acabados_com_saldoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblprodutosacabadoscomsaldoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblprodutosacabadoscomsaldoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_produtos_acabados_com_saldoBindingSource
            // 
            this.tbl_produtos_acabados_com_saldoBindingSource.DataMember = "tbl_produtos_acabados_com_saldo";
            this.tbl_produtos_acabados_com_saldoBindingSource.DataSource = this.db_estoqueDataSetTodas;
            // 
            // db_estoqueDataSetTodas
            // 
            this.db_estoqueDataSetTodas.DataSetName = "db_estoqueDataSetTodas";
            this.db_estoqueDataSetTodas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_produtos_acabados_com_saldoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Revtec_Bioquimica.Relatorio.ReportProdutoAcabadoPositivo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(716, 602);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblprodutosacabadoscomsaldoBindingSource
            // 
            this.tblprodutosacabadoscomsaldoBindingSource.DataMember = "tbl_produtos_acabados_com_saldo";
            this.tblprodutosacabadoscomsaldoBindingSource.DataSource = this.db_estoqueDataSetTodas;
            // 
            // tbl_produtos_acabados_com_saldoTableAdapter
            // 
            this.tbl_produtos_acabados_com_saldoTableAdapter.ClearBeforeFill = true;
            // 
            // FormRelatorioProdutoAcabadoPositivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 602);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRelatorioProdutoAcabadoPositivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programando Soluções - Relatório de produto acabado com saldo em estoque";
            this.Load += new System.EventHandler(this.FormRelatorioProdutoAcabadoPositivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_produtos_acabados_com_saldoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblprodutosacabadoscomsaldoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblprodutosacabadoscomsaldoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource tblprodutosacabadoscomsaldoBindingSource2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private db_estoqueDataSetTodas db_estoqueDataSetTodas;
        private System.Windows.Forms.BindingSource tblprodutosacabadoscomsaldoBindingSource;
        private db_estoqueDataSetTodasTableAdapters.tbl_produtos_acabados_com_saldoTableAdapter tbl_produtos_acabados_com_saldoTableAdapter;
        private System.Windows.Forms.BindingSource tbl_produtos_acabados_com_saldoBindingSource;
    }
}