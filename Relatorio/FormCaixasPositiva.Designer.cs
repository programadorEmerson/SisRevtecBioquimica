namespace Revtec_Bioquimica.Relatorio
{
    partial class FormCaixasPositiva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCaixasPositiva));
            this.tbl_caixasPositivasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_estoqueDataSetTodas = new Revtec_Bioquimica.db_estoqueDataSetTodas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblcaixasPositivasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_caixasPositivasTableAdapter = new Revtec_Bioquimica.db_estoqueDataSetTodasTableAdapters.tbl_caixasPositivasTableAdapter();
            this.prog7279_producaoDataSet = new Revtec_Bioquimica.prog7279_producaoDataSet();
            this.tblcaixasPositivasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_caixasPositivasTableAdapter1 = new Revtec_Bioquimica.prog7279_producaoDataSetTableAdapters.tbl_caixasPositivasTableAdapter();
            this.tblcaixasPositivasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_caixasPositivasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcaixasPositivasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prog7279_producaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcaixasPositivasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcaixasPositivasBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_caixasPositivasBindingSource
            // 
            this.tbl_caixasPositivasBindingSource.DataMember = "tbl_caixasPositivas";
            this.tbl_caixasPositivasBindingSource.DataSource = this.db_estoqueDataSetTodas;
            // 
            // db_estoqueDataSetTodas
            // 
            this.db_estoqueDataSetTodas.DataSetName = "db_estoqueDataSetTodas";
            this.db_estoqueDataSetTodas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPositivas";
            reportDataSource1.Value = this.tbl_caixasPositivasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Revtec_Bioquimica.Relatorio.ReportCaixasPositivas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(791, 602);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblcaixasPositivasBindingSource
            // 
            this.tblcaixasPositivasBindingSource.DataMember = "tbl_caixasPositivas";
            this.tblcaixasPositivasBindingSource.DataSource = this.db_estoqueDataSetTodas;
            // 
            // tbl_caixasPositivasTableAdapter
            // 
            this.tbl_caixasPositivasTableAdapter.ClearBeforeFill = true;
            // 
            // prog7279_producaoDataSet
            // 
            this.prog7279_producaoDataSet.DataSetName = "prog7279_producaoDataSet";
            this.prog7279_producaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblcaixasPositivasBindingSource1
            // 
            this.tblcaixasPositivasBindingSource1.DataMember = "tbl_caixasPositivas";
            this.tblcaixasPositivasBindingSource1.DataSource = this.prog7279_producaoDataSet;
            // 
            // tbl_caixasPositivasTableAdapter1
            // 
            this.tbl_caixasPositivasTableAdapter1.ClearBeforeFill = true;
            // 
            // tblcaixasPositivasBindingSource2
            // 
            this.tblcaixasPositivasBindingSource2.DataMember = "tbl_caixasPositivas";
            this.tblcaixasPositivasBindingSource2.DataSource = this.db_estoqueDataSetTodas;
            // 
            // FormCaixasPositiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 602);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCaixasPositiva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programando Soluções - Relatório de caixas com saldo positivo";
            this.Load += new System.EventHandler(this.FormCaixasPositiva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_caixasPositivasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcaixasPositivasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prog7279_producaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcaixasPositivasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcaixasPositivasBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private db_estoqueDataSetTodas db_estoqueDataSetTodas;
        private System.Windows.Forms.BindingSource tblcaixasPositivasBindingSource;
        private db_estoqueDataSetTodasTableAdapters.tbl_caixasPositivasTableAdapter tbl_caixasPositivasTableAdapter;
        private System.Windows.Forms.BindingSource tbl_caixasPositivasBindingSource;
        private prog7279_producaoDataSet prog7279_producaoDataSet;
        private System.Windows.Forms.BindingSource tblcaixasPositivasBindingSource1;
        private prog7279_producaoDataSetTableAdapters.tbl_caixasPositivasTableAdapter tbl_caixasPositivasTableAdapter1;
        private System.Windows.Forms.BindingSource tblcaixasPositivasBindingSource2;
    }
}