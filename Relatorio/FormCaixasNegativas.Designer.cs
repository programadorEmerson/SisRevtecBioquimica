namespace Revtec_Bioquimica.Relatorio
{
    partial class FormCaixasNegativas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCaixasNegativas));
            this.tbl_caixasNegativasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_estoqueDataSetTodas = new Revtec_Bioquimica.db_estoqueDataSetTodas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblcaixasNegativasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_caixasNegativasTableAdapter = new Revtec_Bioquimica.db_estoqueDataSetTodasTableAdapters.tbl_caixasNegativasTableAdapter();
            this.prog7279_producaoDataSet = new Revtec_Bioquimica.prog7279_producaoDataSet();
            this.tblcaixasNegativasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_caixasNegativasTableAdapter1 = new Revtec_Bioquimica.prog7279_producaoDataSetTableAdapters.tbl_caixasNegativasTableAdapter();
            this.tblcaixasNegativasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_caixasNegativasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcaixasNegativasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prog7279_producaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcaixasNegativasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcaixasNegativasBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_caixasNegativasBindingSource
            // 
            this.tbl_caixasNegativasBindingSource.DataMember = "tbl_caixasNegativas";
            this.tbl_caixasNegativasBindingSource.DataSource = this.db_estoqueDataSetTodas;
            // 
            // db_estoqueDataSetTodas
            // 
            this.db_estoqueDataSetTodas.DataSetName = "db_estoqueDataSetTodas";
            this.db_estoqueDataSetTodas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetNegativas";
            reportDataSource1.Value = this.tbl_caixasNegativasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Revtec_Bioquimica.Relatorio.ReportCaixasNegativas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(791, 602);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblcaixasNegativasBindingSource
            // 
            this.tblcaixasNegativasBindingSource.DataMember = "tbl_caixasNegativas";
            this.tblcaixasNegativasBindingSource.DataSource = this.db_estoqueDataSetTodas;
            // 
            // tbl_caixasNegativasTableAdapter
            // 
            this.tbl_caixasNegativasTableAdapter.ClearBeforeFill = true;
            // 
            // prog7279_producaoDataSet
            // 
            this.prog7279_producaoDataSet.DataSetName = "prog7279_producaoDataSet";
            this.prog7279_producaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblcaixasNegativasBindingSource1
            // 
            this.tblcaixasNegativasBindingSource1.DataMember = "tbl_caixasNegativas";
            this.tblcaixasNegativasBindingSource1.DataSource = this.prog7279_producaoDataSet;
            // 
            // tbl_caixasNegativasTableAdapter1
            // 
            this.tbl_caixasNegativasTableAdapter1.ClearBeforeFill = true;
            // 
            // tblcaixasNegativasBindingSource2
            // 
            this.tblcaixasNegativasBindingSource2.DataMember = "tbl_caixasNegativas";
            this.tblcaixasNegativasBindingSource2.DataSource = this.db_estoqueDataSetTodas;
            // 
            // FormCaixasNegativas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 602);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCaixasNegativas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programando Soluções - Relatório de caixas com saldo zerado";
            this.Load += new System.EventHandler(this.FormCaixasNegativas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_caixasNegativasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcaixasNegativasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prog7279_producaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcaixasNegativasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcaixasNegativasBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private db_estoqueDataSetTodas db_estoqueDataSetTodas;
        private System.Windows.Forms.BindingSource tblcaixasNegativasBindingSource;
        private db_estoqueDataSetTodasTableAdapters.tbl_caixasNegativasTableAdapter tbl_caixasNegativasTableAdapter;
        private System.Windows.Forms.BindingSource tbl_caixasNegativasBindingSource;
        private prog7279_producaoDataSet prog7279_producaoDataSet;
        private System.Windows.Forms.BindingSource tblcaixasNegativasBindingSource1;
        private prog7279_producaoDataSetTableAdapters.tbl_caixasNegativasTableAdapter tbl_caixasNegativasTableAdapter1;
        private System.Windows.Forms.BindingSource tblcaixasNegativasBindingSource2;
    }
}