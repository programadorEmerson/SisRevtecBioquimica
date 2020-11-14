namespace Revtec_Bioquimica.Relatorio
{
    partial class FormRelatorioVendasPorClienteComData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorioVendasPorClienteComData));
            this.tbl_expedicao1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_estoqueDataSetTodas = new Revtec_Bioquimica.db_estoqueDataSetTodas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblexpedicao1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_expedicao1TableAdapter = new Revtec_Bioquimica.db_estoqueDataSetTodasTableAdapters.tbl_expedicao1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_expedicao1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblexpedicao1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_expedicao1BindingSource
            // 
            this.tbl_expedicao1BindingSource.DataMember = "tbl_expedicao1";
            this.tbl_expedicao1BindingSource.DataSource = this.db_estoqueDataSetTodas;
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
            reportDataSource1.Value = this.tbl_expedicao1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Revtec_Bioquimica.Relatorio.ReportVendasPorCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(791, 602);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblexpedicao1BindingSource
            // 
            this.tblexpedicao1BindingSource.DataMember = "tbl_expedicao1";
            this.tblexpedicao1BindingSource.DataSource = this.db_estoqueDataSetTodas;
            // 
            // tbl_expedicao1TableAdapter
            // 
            this.tbl_expedicao1TableAdapter.ClearBeforeFill = true;
            // 
            // FormRelatorioVendasPorClienteComData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 602);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRelatorioVendasPorClienteComData";
            this.Text = "Programando Soluções - Relatório de vendas por cliente por data";
            this.Load += new System.EventHandler(this.FormRelatorioVendasPorClienteComData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_expedicao1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblexpedicao1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_expedicao1BindingSource;
        private db_estoqueDataSetTodas db_estoqueDataSetTodas;
        private System.Windows.Forms.BindingSource tblexpedicao1BindingSource;
        private db_estoqueDataSetTodasTableAdapters.tbl_expedicao1TableAdapter tbl_expedicao1TableAdapter;
    }
}