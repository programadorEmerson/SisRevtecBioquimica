namespace Revtec_Bioquimica.Relatorio
{
    partial class FormPedidoComIdGuia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedidoComIdGuia));
            this.tbl_pedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_estoqueDataSetTodas = new Revtec_Bioquimica.db_estoqueDataSetTodas();
            this.tblpedidosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.prog7279_producaoDataSet = new Revtec_Bioquimica.prog7279_producaoDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblpedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblpedidosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_pedidosTableAdapter1 = new Revtec_Bioquimica.prog7279_producaoDataSetTableAdapters.tbl_pedidosTableAdapter();
            this.tblpedidosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_pedidosTableAdapter = new Revtec_Bioquimica.db_estoqueDataSetTodasTableAdapters.tbl_pedidosTableAdapter();
            this.tblpedidosPelaGuiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_pedidosPelaGuiaTableAdapter = new Revtec_Bioquimica.db_estoqueDataSetTodasTableAdapters.tbl_pedidosPelaGuiaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pedidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpedidosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prog7279_producaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpedidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpedidosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpedidosBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpedidosPelaGuiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_pedidosBindingSource
            // 
            this.tbl_pedidosBindingSource.DataMember = "tbl_pedidos";
            this.tbl_pedidosBindingSource.DataSource = this.db_estoqueDataSetTodas;
            // 
            // db_estoqueDataSetTodas
            // 
            this.db_estoqueDataSetTodas.DataSetName = "db_estoqueDataSetTodas";
            this.db_estoqueDataSetTodas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblpedidosBindingSource2
            // 
            this.tblpedidosBindingSource2.DataMember = "tbl_pedidos";
            this.tblpedidosBindingSource2.DataSource = this.prog7279_producaoDataSet;
            // 
            // prog7279_producaoDataSet
            // 
            this.prog7279_producaoDataSet.DataSetName = "prog7279_producaoDataSet";
            this.prog7279_producaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPedidos";
            reportDataSource1.Value = this.tbl_pedidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Revtec_Bioquimica.Relatorio.ReportPedidoReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(791, 602);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblpedidosBindingSource
            // 
            this.tblpedidosBindingSource.DataMember = "tbl_pedidos";
            this.tblpedidosBindingSource.DataSource = this.prog7279_producaoDataSet;
            // 
            // tblpedidosBindingSource1
            // 
            this.tblpedidosBindingSource1.DataMember = "tbl_pedidos";
            this.tblpedidosBindingSource1.DataSource = this.prog7279_producaoDataSet;
            // 
            // tbl_pedidosTableAdapter1
            // 
            this.tbl_pedidosTableAdapter1.ClearBeforeFill = true;
            // 
            // tblpedidosBindingSource3
            // 
            this.tblpedidosBindingSource3.DataMember = "tbl_pedidos";
            this.tblpedidosBindingSource3.DataSource = this.db_estoqueDataSetTodas;
            // 
            // tbl_pedidosTableAdapter
            // 
            this.tbl_pedidosTableAdapter.ClearBeforeFill = true;
            // 
            // tblpedidosPelaGuiaBindingSource
            // 
            this.tblpedidosPelaGuiaBindingSource.DataMember = "tbl_pedidosPelaGuia";
            this.tblpedidosPelaGuiaBindingSource.DataSource = this.db_estoqueDataSetTodas;
            // 
            // tbl_pedidosPelaGuiaTableAdapter
            // 
            this.tbl_pedidosPelaGuiaTableAdapter.ClearBeforeFill = true;
            // 
            // FormPedidoComIdGuia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 602);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPedidoComIdGuia";
            this.Text = "Programando Soluções - Romaneio de Expedição";
            this.Load += new System.EventHandler(this.FormPedidoComIdGuia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pedidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpedidosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prog7279_producaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpedidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpedidosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpedidosBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpedidosPelaGuiaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private prog7279_producaoDataSet prog7279_producaoDataSet;
        private System.Windows.Forms.BindingSource tblpedidosBindingSource1;
        private prog7279_producaoDataSetTableAdapters.tbl_pedidosTableAdapter tbl_pedidosTableAdapter1;
        private System.Windows.Forms.BindingSource tblpedidosBindingSource;
        private System.Windows.Forms.BindingSource tblpedidosBindingSource2;
        private System.Windows.Forms.BindingSource tbl_pedidosBindingSource;
        private db_estoqueDataSetTodas db_estoqueDataSetTodas;
        private System.Windows.Forms.BindingSource tblpedidosBindingSource3;
        private db_estoqueDataSetTodasTableAdapters.tbl_pedidosTableAdapter tbl_pedidosTableAdapter;
        private System.Windows.Forms.BindingSource tblpedidosPelaGuiaBindingSource;
        private db_estoqueDataSetTodasTableAdapters.tbl_pedidosPelaGuiaTableAdapter tbl_pedidosPelaGuiaTableAdapter;
    }
}