namespace Revtec_Bioquimica.Relatorio
{
    partial class FormEmbalagemPositiva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmbalagemPositiva));
            this.tbl_embalagensPositivaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_estoqueDataSetTodas = new Revtec_Bioquimica.db_estoqueDataSetTodas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblembalagensPositivaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_embalagensPositivaTableAdapter = new Revtec_Bioquimica.db_estoqueDataSetTodasTableAdapters.tbl_embalagensPositivaTableAdapter();
            this.prog7279_producaoDataSet = new Revtec_Bioquimica.prog7279_producaoDataSet();
            this.tblembalagensPositivaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_embalagensPositivaTableAdapter1 = new Revtec_Bioquimica.prog7279_producaoDataSetTableAdapters.tbl_embalagensPositivaTableAdapter();
            this.tblembalagensPositivaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_embalagensPositivaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblembalagensPositivaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prog7279_producaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblembalagensPositivaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblembalagensPositivaBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_embalagensPositivaBindingSource
            // 
            this.tbl_embalagensPositivaBindingSource.DataMember = "tbl_embalagensPositiva";
            this.tbl_embalagensPositivaBindingSource.DataSource = this.db_estoqueDataSetTodas;
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
            reportDataSource1.Value = this.tbl_embalagensPositivaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Revtec_Bioquimica.Relatorio.ReportEmbalagensPositivo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(791, 602);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblembalagensPositivaBindingSource
            // 
            this.tblembalagensPositivaBindingSource.DataMember = "tbl_embalagensPositiva";
            this.tblembalagensPositivaBindingSource.DataSource = this.db_estoqueDataSetTodas;
            // 
            // tbl_embalagensPositivaTableAdapter
            // 
            this.tbl_embalagensPositivaTableAdapter.ClearBeforeFill = true;
            // 
            // prog7279_producaoDataSet
            // 
            this.prog7279_producaoDataSet.DataSetName = "prog7279_producaoDataSet";
            this.prog7279_producaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblembalagensPositivaBindingSource1
            // 
            this.tblembalagensPositivaBindingSource1.DataMember = "tbl_embalagensPositiva";
            this.tblembalagensPositivaBindingSource1.DataSource = this.prog7279_producaoDataSet;
            // 
            // tbl_embalagensPositivaTableAdapter1
            // 
            this.tbl_embalagensPositivaTableAdapter1.ClearBeforeFill = true;
            // 
            // tblembalagensPositivaBindingSource2
            // 
            this.tblembalagensPositivaBindingSource2.DataMember = "tbl_embalagensPositiva";
            this.tblembalagensPositivaBindingSource2.DataSource = this.db_estoqueDataSetTodas;
            // 
            // FormEmbalagemPositiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 602);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEmbalagemPositiva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programando Soluções - Relatório de embalagem positiva";
            this.Load += new System.EventHandler(this.FormEmbalagemPositiva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_embalagensPositivaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblembalagensPositivaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prog7279_producaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblembalagensPositivaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblembalagensPositivaBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private db_estoqueDataSetTodas db_estoqueDataSetTodas;
        private System.Windows.Forms.BindingSource tblembalagensPositivaBindingSource;
        private db_estoqueDataSetTodasTableAdapters.tbl_embalagensPositivaTableAdapter tbl_embalagensPositivaTableAdapter;
        private System.Windows.Forms.BindingSource tbl_embalagensPositivaBindingSource;
        private prog7279_producaoDataSet prog7279_producaoDataSet;
        private System.Windows.Forms.BindingSource tblembalagensPositivaBindingSource1;
        private prog7279_producaoDataSetTableAdapters.tbl_embalagensPositivaTableAdapter tbl_embalagensPositivaTableAdapter1;
        private System.Windows.Forms.BindingSource tblembalagensPositivaBindingSource2;
    }
}