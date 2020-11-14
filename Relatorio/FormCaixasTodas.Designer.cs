namespace Revtec_Bioquimica.Relatorio
{
    partial class FormCaixasTodas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCaixasTodas));
            this.tbl_caixasTodasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_estoqueDataSetTodas = new Revtec_Bioquimica.db_estoqueDataSetTodas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblcaixasTodasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_caixasTodasTableAdapter = new Revtec_Bioquimica.db_estoqueDataSetTodasTableAdapters.tbl_caixasTodasTableAdapter();
            this.prog7279_producaoDataSet = new Revtec_Bioquimica.prog7279_producaoDataSet();
            this.tblcaixasTodasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_caixasTodasTableAdapter1 = new Revtec_Bioquimica.prog7279_producaoDataSetTableAdapters.tbl_caixasTodasTableAdapter();
            this.tblcaixasTodasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_caixasTodasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcaixasTodasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prog7279_producaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcaixasTodasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcaixasTodasBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_caixasTodasBindingSource
            // 
            this.tbl_caixasTodasBindingSource.DataMember = "tbl_caixasTodas";
            this.tbl_caixasTodasBindingSource.DataSource = this.db_estoqueDataSetTodas;
            // 
            // db_estoqueDataSetTodas
            // 
            this.db_estoqueDataSetTodas.DataSetName = "db_estoqueDataSetTodas";
            this.db_estoqueDataSetTodas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetTodas";
            reportDataSource1.Value = this.tbl_caixasTodasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Revtec_Bioquimica.Relatorio.ReportCaixasTodas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(791, 602);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblcaixasTodasBindingSource
            // 
            this.tblcaixasTodasBindingSource.DataMember = "tbl_caixasTodas";
            this.tblcaixasTodasBindingSource.DataSource = this.db_estoqueDataSetTodas;
            // 
            // tbl_caixasTodasTableAdapter
            // 
            this.tbl_caixasTodasTableAdapter.ClearBeforeFill = true;
            // 
            // prog7279_producaoDataSet
            // 
            this.prog7279_producaoDataSet.DataSetName = "prog7279_producaoDataSet";
            this.prog7279_producaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblcaixasTodasBindingSource1
            // 
            this.tblcaixasTodasBindingSource1.DataMember = "tbl_caixasTodas";
            this.tblcaixasTodasBindingSource1.DataSource = this.prog7279_producaoDataSet;
            // 
            // tbl_caixasTodasTableAdapter1
            // 
            this.tbl_caixasTodasTableAdapter1.ClearBeforeFill = true;
            // 
            // tblcaixasTodasBindingSource2
            // 
            this.tblcaixasTodasBindingSource2.DataMember = "tbl_caixasTodas";
            this.tblcaixasTodasBindingSource2.DataSource = this.db_estoqueDataSetTodas;
            // 
            // FormCaixasTodas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 602);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCaixasTodas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programando Soluções - Relatório de todas as caixas";
            this.Load += new System.EventHandler(this.FormCaixasTodas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_caixasTodasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcaixasTodasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prog7279_producaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcaixasTodasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcaixasTodasBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private db_estoqueDataSetTodas db_estoqueDataSetTodas;
        private System.Windows.Forms.BindingSource tblcaixasTodasBindingSource;
        private db_estoqueDataSetTodasTableAdapters.tbl_caixasTodasTableAdapter tbl_caixasTodasTableAdapter;
        private System.Windows.Forms.BindingSource tbl_caixasTodasBindingSource;
        private prog7279_producaoDataSet prog7279_producaoDataSet;
        private System.Windows.Forms.BindingSource tblcaixasTodasBindingSource1;
        private prog7279_producaoDataSetTableAdapters.tbl_caixasTodasTableAdapter tbl_caixasTodasTableAdapter1;
        private System.Windows.Forms.BindingSource tblcaixasTodasBindingSource2;
    }
}