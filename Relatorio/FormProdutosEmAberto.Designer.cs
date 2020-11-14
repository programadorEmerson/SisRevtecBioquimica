namespace Revtec_Bioquimica.Relatorio
{
    partial class FormProdutosEmAberto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutosEmAberto));
            this.tbl_pedidosEmAbertoItensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_estoqueDataSetTodas = new Revtec_Bioquimica.db_estoqueDataSetTodas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblpedidosEmAbertoItensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_pedidosEmAbertoItensTableAdapter = new Revtec_Bioquimica.db_estoqueDataSetTodasTableAdapters.tbl_pedidosEmAbertoItensTableAdapter();
            this.tblpedidosEmAbertoItensBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pedidosEmAbertoItensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpedidosEmAbertoItensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpedidosEmAbertoItensBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_pedidosEmAbertoItensBindingSource
            // 
            this.tbl_pedidosEmAbertoItensBindingSource.DataMember = "tbl_pedidosEmAbertoItens";
            this.tbl_pedidosEmAbertoItensBindingSource.DataSource = this.db_estoqueDataSetTodas;
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
            reportDataSource1.Value = this.tbl_pedidosEmAbertoItensBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Revtec_Bioquimica.Relatorio.RelatorioProdutosEmAberto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(791, 602);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblpedidosEmAbertoItensBindingSource
            // 
            this.tblpedidosEmAbertoItensBindingSource.DataMember = "tbl_pedidosEmAbertoItens";
            this.tblpedidosEmAbertoItensBindingSource.DataSource = this.db_estoqueDataSetTodas;
            // 
            // tbl_pedidosEmAbertoItensTableAdapter
            // 
            this.tbl_pedidosEmAbertoItensTableAdapter.ClearBeforeFill = true;
            // 
            // tblpedidosEmAbertoItensBindingSource1
            // 
            this.tblpedidosEmAbertoItensBindingSource1.DataMember = "tbl_pedidosEmAbertoItens";
            this.tblpedidosEmAbertoItensBindingSource1.DataSource = this.db_estoqueDataSetTodas;
            // 
            // FormProdutosEmAberto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 602);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProdutosEmAberto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programando Soluções - Relatório de produtos em aberto";
            this.Load += new System.EventHandler(this.FormProdutosEmAberto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pedidosEmAbertoItensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpedidosEmAbertoItensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpedidosEmAbertoItensBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_pedidosEmAbertoItensBindingSource;
        private db_estoqueDataSetTodas db_estoqueDataSetTodas;
        private System.Windows.Forms.BindingSource tblpedidosEmAbertoItensBindingSource;
        private db_estoqueDataSetTodasTableAdapters.tbl_pedidosEmAbertoItensTableAdapter tbl_pedidosEmAbertoItensTableAdapter;
        private System.Windows.Forms.BindingSource tblpedidosEmAbertoItensBindingSource1;
    }
}