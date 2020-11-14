namespace Revtec_Bioquimica.Relatorio
{
    partial class FormOrdemDeProducao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdemDeProducao));
            this.tbl_ordemdeproducaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_estoqueDataSet = new Revtec_Bioquimica.db_estoqueDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblordemdeproducaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ordemdeproducaoTableAdapter = new Revtec_Bioquimica.db_estoqueDataSetTableAdapters.tbl_ordemdeproducaoTableAdapter();
            this.prog7279_producaoDataSet = new Revtec_Bioquimica.prog7279_producaoDataSet();
            this.tblordemdeproducao1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ordemdeproducao1TableAdapter = new Revtec_Bioquimica.prog7279_producaoDataSetTableAdapters.tbl_ordemdeproducao1TableAdapter();
            this.tblordemdeproducao1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbestoqueDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblordemdeproducaoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ordemdeproducaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblordemdeproducaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prog7279_producaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblordemdeproducao1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblordemdeproducao1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbestoqueDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblordemdeproducaoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_ordemdeproducaoBindingSource
            // 
            this.tbl_ordemdeproducaoBindingSource.DataMember = "tbl_ordemdeproducao";
            this.tbl_ordemdeproducaoBindingSource.DataSource = this.db_estoqueDataSet;
            // 
            // db_estoqueDataSet
            // 
            this.db_estoqueDataSet.DataSetName = "db_estoqueDataSet";
            this.db_estoqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_ordemdeproducaoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Revtec_Bioquimica.Relatorio.ReportOrdemProducao.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(791, 602);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblordemdeproducaoBindingSource
            // 
            this.tblordemdeproducaoBindingSource.DataMember = "tbl_ordemdeproducao";
            this.tblordemdeproducaoBindingSource.DataSource = this.db_estoqueDataSet;
            // 
            // tbl_ordemdeproducaoTableAdapter
            // 
            this.tbl_ordemdeproducaoTableAdapter.ClearBeforeFill = true;
            // 
            // prog7279_producaoDataSet
            // 
            this.prog7279_producaoDataSet.DataSetName = "prog7279_producaoDataSet";
            this.prog7279_producaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblordemdeproducao1BindingSource
            // 
            this.tblordemdeproducao1BindingSource.DataMember = "tbl_ordemdeproducao1";
            this.tblordemdeproducao1BindingSource.DataSource = this.prog7279_producaoDataSet;
            // 
            // tbl_ordemdeproducao1TableAdapter
            // 
            this.tbl_ordemdeproducao1TableAdapter.ClearBeforeFill = true;
            // 
            // tblordemdeproducao1BindingSource1
            // 
            this.tblordemdeproducao1BindingSource1.DataMember = "tbl_ordemdeproducao1";
            this.tblordemdeproducao1BindingSource1.DataSource = this.prog7279_producaoDataSet;
            // 
            // dbestoqueDataSetBindingSource
            // 
            this.dbestoqueDataSetBindingSource.DataSource = this.db_estoqueDataSet;
            this.dbestoqueDataSetBindingSource.Position = 0;
            // 
            // tblordemdeproducaoBindingSource1
            // 
            this.tblordemdeproducaoBindingSource1.DataMember = "tbl_ordemdeproducao";
            this.tblordemdeproducaoBindingSource1.DataSource = this.db_estoqueDataSet;
            // 
            // FormOrdemDeProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 602);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOrdemDeProducao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programando Soluções - Relatório de Ordem de Produção por data";
            this.Load += new System.EventHandler(this.FormOrdemDeProducao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ordemdeproducaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblordemdeproducaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prog7279_producaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblordemdeproducao1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblordemdeproducao1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbestoqueDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblordemdeproducaoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_ordemdeproducaoBindingSource;
        private db_estoqueDataSet db_estoqueDataSet;
        private System.Windows.Forms.BindingSource tblordemdeproducaoBindingSource;
        private db_estoqueDataSetTableAdapters.tbl_ordemdeproducaoTableAdapter tbl_ordemdeproducaoTableAdapter;
        private prog7279_producaoDataSet prog7279_producaoDataSet;
        private System.Windows.Forms.BindingSource tblordemdeproducao1BindingSource;
        private prog7279_producaoDataSetTableAdapters.tbl_ordemdeproducao1TableAdapter tbl_ordemdeproducao1TableAdapter;
        private System.Windows.Forms.BindingSource tblordemdeproducao1BindingSource1;
        private System.Windows.Forms.BindingSource dbestoqueDataSetBindingSource;
        private System.Windows.Forms.BindingSource tblordemdeproducaoBindingSource1;
    }
}