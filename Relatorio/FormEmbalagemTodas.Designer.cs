namespace Revtec_Bioquimica.Relatorio
{
    partial class FormEmbalagemTodas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmbalagemTodas));
            this.tbl_embalagensTodasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_estoqueDataSetTodas = new Revtec_Bioquimica.db_estoqueDataSetTodas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblembalagensTodasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_embalagensTodasTableAdapter = new Revtec_Bioquimica.db_estoqueDataSetTodasTableAdapters.tbl_embalagensTodasTableAdapter();
            this.prog7279_producaoDataSet = new Revtec_Bioquimica.prog7279_producaoDataSet();
            this.tblembalagensTodasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_embalagensTodasTableAdapter1 = new Revtec_Bioquimica.prog7279_producaoDataSetTableAdapters.tbl_embalagensTodasTableAdapter();
            this.tblembalagensTodasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_embalagensTodasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblembalagensTodasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prog7279_producaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblembalagensTodasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblembalagensTodasBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_embalagensTodasBindingSource
            // 
            this.tbl_embalagensTodasBindingSource.DataMember = "tbl_embalagensTodas";
            this.tbl_embalagensTodasBindingSource.DataSource = this.db_estoqueDataSetTodas;
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
            reportDataSource1.Value = this.tbl_embalagensTodasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Revtec_Bioquimica.Relatorio.ReportEmbalagensTodas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(791, 602);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblembalagensTodasBindingSource
            // 
            this.tblembalagensTodasBindingSource.DataMember = "tbl_embalagensTodas";
            this.tblembalagensTodasBindingSource.DataSource = this.db_estoqueDataSetTodas;
            // 
            // tbl_embalagensTodasTableAdapter
            // 
            this.tbl_embalagensTodasTableAdapter.ClearBeforeFill = true;
            // 
            // prog7279_producaoDataSet
            // 
            this.prog7279_producaoDataSet.DataSetName = "prog7279_producaoDataSet";
            this.prog7279_producaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblembalagensTodasBindingSource1
            // 
            this.tblembalagensTodasBindingSource1.DataMember = "tbl_embalagensTodas";
            this.tblembalagensTodasBindingSource1.DataSource = this.prog7279_producaoDataSet;
            // 
            // tbl_embalagensTodasTableAdapter1
            // 
            this.tbl_embalagensTodasTableAdapter1.ClearBeforeFill = true;
            // 
            // tblembalagensTodasBindingSource2
            // 
            this.tblembalagensTodasBindingSource2.DataMember = "tbl_embalagensTodas";
            this.tblembalagensTodasBindingSource2.DataSource = this.db_estoqueDataSetTodas;
            // 
            // FormEmbalagemTodas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 602);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEmbalagemTodas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programando Soluções - Relatório de todas as embalagens";
            this.Load += new System.EventHandler(this.FormEmbalagemTodas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_embalagensTodasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblembalagensTodasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prog7279_producaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblembalagensTodasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblembalagensTodasBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private db_estoqueDataSetTodas db_estoqueDataSetTodas;
        private System.Windows.Forms.BindingSource tblembalagensTodasBindingSource;
        private db_estoqueDataSetTodasTableAdapters.tbl_embalagensTodasTableAdapter tbl_embalagensTodasTableAdapter;
        private System.Windows.Forms.BindingSource tbl_embalagensTodasBindingSource;
        private prog7279_producaoDataSet prog7279_producaoDataSet;
        private System.Windows.Forms.BindingSource tblembalagensTodasBindingSource1;
        private prog7279_producaoDataSetTableAdapters.tbl_embalagensTodasTableAdapter tbl_embalagensTodasTableAdapter1;
        private System.Windows.Forms.BindingSource tblembalagensTodasBindingSource2;
    }
}