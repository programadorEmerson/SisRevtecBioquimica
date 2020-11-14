namespace Revtec_Bioquimica.Relatorio
{
    partial class FormMateriaPrimaEmEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMateriaPrimaEmEstoque));
            this.tbl_materiaprimaEmEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_estoqueDataSetTodas = new Revtec_Bioquimica.db_estoqueDataSetTodas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblmateriaprimaEmEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_materiaprimaEmEstoqueTableAdapter = new Revtec_Bioquimica.db_estoqueDataSetTodasTableAdapters.tbl_materiaprimaEmEstoqueTableAdapter();
            this.prog7279_producaoDataSet = new Revtec_Bioquimica.prog7279_producaoDataSet();
            this.tblmateriaprimaEmEstoqueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_materiaprimaEmEstoqueTableAdapter1 = new Revtec_Bioquimica.prog7279_producaoDataSetTableAdapters.tbl_materiaprimaEmEstoqueTableAdapter();
            this.tblmateriaprimaEmEstoqueBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_materiaprimaEmEstoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmateriaprimaEmEstoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prog7279_producaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmateriaprimaEmEstoqueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmateriaprimaEmEstoqueBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_materiaprimaEmEstoqueBindingSource
            // 
            this.tbl_materiaprimaEmEstoqueBindingSource.DataMember = "tbl_materiaprimaEmEstoque";
            this.tbl_materiaprimaEmEstoqueBindingSource.DataSource = this.db_estoqueDataSetTodas;
            // 
            // db_estoqueDataSetTodas
            // 
            this.db_estoqueDataSetTodas.DataSetName = "db_estoqueDataSetTodas";
            this.db_estoqueDataSetTodas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPositivo";
            reportDataSource1.Value = this.tbl_materiaprimaEmEstoqueBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Revtec_Bioquimica.Relatorio.ReportMateriaPrimaComSaldoEmEstoque.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(791, 602);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblmateriaprimaEmEstoqueBindingSource
            // 
            this.tblmateriaprimaEmEstoqueBindingSource.DataMember = "tbl_materiaprimaEmEstoque";
            this.tblmateriaprimaEmEstoqueBindingSource.DataSource = this.db_estoqueDataSetTodas;
            // 
            // tbl_materiaprimaEmEstoqueTableAdapter
            // 
            this.tbl_materiaprimaEmEstoqueTableAdapter.ClearBeforeFill = true;
            // 
            // prog7279_producaoDataSet
            // 
            this.prog7279_producaoDataSet.DataSetName = "prog7279_producaoDataSet";
            this.prog7279_producaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblmateriaprimaEmEstoqueBindingSource1
            // 
            this.tblmateriaprimaEmEstoqueBindingSource1.DataMember = "tbl_materiaprimaEmEstoque";
            this.tblmateriaprimaEmEstoqueBindingSource1.DataSource = this.prog7279_producaoDataSet;
            // 
            // tbl_materiaprimaEmEstoqueTableAdapter1
            // 
            this.tbl_materiaprimaEmEstoqueTableAdapter1.ClearBeforeFill = true;
            // 
            // tblmateriaprimaEmEstoqueBindingSource2
            // 
            this.tblmateriaprimaEmEstoqueBindingSource2.DataMember = "tbl_materiaprimaEmEstoque";
            this.tblmateriaprimaEmEstoqueBindingSource2.DataSource = this.db_estoqueDataSetTodas;
            // 
            // FormMateriaPrimaEmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 602);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMateriaPrimaEmEstoque";
            this.Text = "Programando Soluções - Relatório de materia prima com saldo em estoque";
            this.Load += new System.EventHandler(this.FormMateriaPrimaEmEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_materiaprimaEmEstoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmateriaprimaEmEstoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prog7279_producaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmateriaprimaEmEstoqueBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmateriaprimaEmEstoqueBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private db_estoqueDataSetTodas db_estoqueDataSetTodas;
        private System.Windows.Forms.BindingSource tblmateriaprimaEmEstoqueBindingSource;
        private db_estoqueDataSetTodasTableAdapters.tbl_materiaprimaEmEstoqueTableAdapter tbl_materiaprimaEmEstoqueTableAdapter;
        private System.Windows.Forms.BindingSource tbl_materiaprimaEmEstoqueBindingSource;
        private prog7279_producaoDataSet prog7279_producaoDataSet;
        private System.Windows.Forms.BindingSource tblmateriaprimaEmEstoqueBindingSource1;
        private prog7279_producaoDataSetTableAdapters.tbl_materiaprimaEmEstoqueTableAdapter tbl_materiaprimaEmEstoqueTableAdapter1;
        private System.Windows.Forms.BindingSource tblmateriaprimaEmEstoqueBindingSource2;
    }
}