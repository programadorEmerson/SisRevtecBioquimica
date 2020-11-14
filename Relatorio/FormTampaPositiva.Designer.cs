namespace Revtec_Bioquimica.Relatorio
{
    partial class FormTampaPositiva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTampaPositiva));
            this.tbl_tampaPositivasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_estoqueDataSetTodas = new Revtec_Bioquimica.db_estoqueDataSetTodas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbltampaPositivasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_tampaPositivasTableAdapter = new Revtec_Bioquimica.db_estoqueDataSetTodasTableAdapters.tbl_tampaPositivasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_tampaPositivasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltampaPositivasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_tampaPositivasBindingSource
            // 
            this.tbl_tampaPositivasBindingSource.DataMember = "tbl_tampaPositivas";
            this.tbl_tampaPositivasBindingSource.DataSource = this.db_estoqueDataSetTodas;
            // 
            // db_estoqueDataSetTodas
            // 
            this.db_estoqueDataSetTodas.DataSetName = "db_estoqueDataSetTodas";
            this.db_estoqueDataSetTodas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPositiva";
            reportDataSource1.Value = this.tbl_tampaPositivasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Revtec_Bioquimica.Relatorio.ReportTampasPositiva.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(791, 602);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbltampaPositivasBindingSource
            // 
            this.tbltampaPositivasBindingSource.DataMember = "tbl_tampaPositivas";
            this.tbltampaPositivasBindingSource.DataSource = this.db_estoqueDataSetTodas;
            // 
            // tbl_tampaPositivasTableAdapter
            // 
            this.tbl_tampaPositivasTableAdapter.ClearBeforeFill = true;
            // 
            // FormTampaPositiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 602);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTampaPositiva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programando Soluções - Relatório de tampas e válvulas com saldo em estoque";
            this.Load += new System.EventHandler(this.FormTampaPositiva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_tampaPositivasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltampaPositivasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private db_estoqueDataSetTodas db_estoqueDataSetTodas;
        private System.Windows.Forms.BindingSource tbltampaPositivasBindingSource;
        private db_estoqueDataSetTodasTableAdapters.tbl_tampaPositivasTableAdapter tbl_tampaPositivasTableAdapter;
        private System.Windows.Forms.BindingSource tbl_tampaPositivasBindingSource;
    }
}