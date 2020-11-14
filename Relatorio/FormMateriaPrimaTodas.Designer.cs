namespace Revtec_Bioquimica.Relatorio
{
    partial class FormMateriaPrimaTodas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMateriaPrimaTodas));
            this.tbl_materiaprimaTodasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_estoqueDataSetTodas = new Revtec_Bioquimica.db_estoqueDataSetTodas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblmateriaprimaTodasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_materiaprimaTodasTableAdapter = new Revtec_Bioquimica.db_estoqueDataSetTodasTableAdapters.tbl_materiaprimaTodasTableAdapter();
            this.prog7279_producaoDataSet = new Revtec_Bioquimica.prog7279_producaoDataSet();
            this.tblmateriaprimaTodasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_materiaprimaTodasTableAdapter1 = new Revtec_Bioquimica.prog7279_producaoDataSetTableAdapters.tbl_materiaprimaTodasTableAdapter();
            this.tblmateriaprimaTodasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_materiaprimaTodasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmateriaprimaTodasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prog7279_producaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmateriaprimaTodasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmateriaprimaTodasBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_materiaprimaTodasBindingSource
            // 
            this.tbl_materiaprimaTodasBindingSource.DataMember = "tbl_materiaprimaTodas";
            this.tbl_materiaprimaTodasBindingSource.DataSource = this.db_estoqueDataSetTodas;
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
            reportDataSource1.Value = this.tbl_materiaprimaTodasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Revtec_Bioquimica.Relatorio.ReportRelatorioMateriaPrimaTodas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(791, 602);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblmateriaprimaTodasBindingSource
            // 
            this.tblmateriaprimaTodasBindingSource.DataMember = "tbl_materiaprimaTodas";
            this.tblmateriaprimaTodasBindingSource.DataSource = this.db_estoqueDataSetTodas;
            // 
            // tbl_materiaprimaTodasTableAdapter
            // 
            this.tbl_materiaprimaTodasTableAdapter.ClearBeforeFill = true;
            // 
            // prog7279_producaoDataSet
            // 
            this.prog7279_producaoDataSet.DataSetName = "prog7279_producaoDataSet";
            this.prog7279_producaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblmateriaprimaTodasBindingSource1
            // 
            this.tblmateriaprimaTodasBindingSource1.DataMember = "tbl_materiaprimaTodas";
            this.tblmateriaprimaTodasBindingSource1.DataSource = this.prog7279_producaoDataSet;
            // 
            // tbl_materiaprimaTodasTableAdapter1
            // 
            this.tbl_materiaprimaTodasTableAdapter1.ClearBeforeFill = true;
            // 
            // tblmateriaprimaTodasBindingSource2
            // 
            this.tblmateriaprimaTodasBindingSource2.DataMember = "tbl_materiaprimaTodas";
            this.tblmateriaprimaTodasBindingSource2.DataSource = this.db_estoqueDataSetTodas;
            // 
            // FormMateriaPrimaTodas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 602);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMateriaPrimaTodas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programando Soluções - Relatório Materia Prima em estoque";
            this.Load += new System.EventHandler(this.FormMateriaPrimaTodas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_materiaprimaTodasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmateriaprimaTodasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prog7279_producaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmateriaprimaTodasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmateriaprimaTodasBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private db_estoqueDataSetTodas db_estoqueDataSetTodas;
        private System.Windows.Forms.BindingSource tblmateriaprimaTodasBindingSource;
        private db_estoqueDataSetTodasTableAdapters.tbl_materiaprimaTodasTableAdapter tbl_materiaprimaTodasTableAdapter;
        private System.Windows.Forms.BindingSource tbl_materiaprimaTodasBindingSource;
        private prog7279_producaoDataSet prog7279_producaoDataSet;
        private System.Windows.Forms.BindingSource tblmateriaprimaTodasBindingSource1;
        private prog7279_producaoDataSetTableAdapters.tbl_materiaprimaTodasTableAdapter tbl_materiaprimaTodasTableAdapter1;
        private System.Windows.Forms.BindingSource tblmateriaprimaTodasBindingSource2;
    }
}