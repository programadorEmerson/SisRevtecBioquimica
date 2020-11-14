namespace Revtec_Bioquimica.Relatorio
{
    partial class FormEmbalagemNegativa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmbalagemNegativa));
            this.tbl_embalagensNegativaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_estoqueDataSetTodas = new Revtec_Bioquimica.db_estoqueDataSetTodas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblembalagensNegativaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_embalagensNegativaTableAdapter = new Revtec_Bioquimica.db_estoqueDataSetTodasTableAdapters.tbl_embalagensNegativaTableAdapter();
            this.prog7279_producaoDataSet = new Revtec_Bioquimica.prog7279_producaoDataSet();
            this.tblembalagensNegativaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_embalagensNegativaTableAdapter1 = new Revtec_Bioquimica.prog7279_producaoDataSetTableAdapters.tbl_embalagensNegativaTableAdapter();
            this.tblembalagensNegativaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_embalagensNegativaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblembalagensNegativaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prog7279_producaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblembalagensNegativaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblembalagensNegativaBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_embalagensNegativaBindingSource
            // 
            this.tbl_embalagensNegativaBindingSource.DataMember = "tbl_embalagensNegativa";
            this.tbl_embalagensNegativaBindingSource.DataSource = this.db_estoqueDataSetTodas;
            // 
            // db_estoqueDataSetTodas
            // 
            this.db_estoqueDataSetTodas.DataSetName = "db_estoqueDataSetTodas";
            this.db_estoqueDataSetTodas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetNegativo";
            reportDataSource1.Value = this.tbl_embalagensNegativaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Revtec_Bioquimica.Relatorio.ReportEmbalagensNegativo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(791, 602);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblembalagensNegativaBindingSource
            // 
            this.tblembalagensNegativaBindingSource.DataMember = "tbl_embalagensNegativa";
            this.tblembalagensNegativaBindingSource.DataSource = this.db_estoqueDataSetTodas;
            // 
            // tbl_embalagensNegativaTableAdapter
            // 
            this.tbl_embalagensNegativaTableAdapter.ClearBeforeFill = true;
            // 
            // prog7279_producaoDataSet
            // 
            this.prog7279_producaoDataSet.DataSetName = "prog7279_producaoDataSet";
            this.prog7279_producaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblembalagensNegativaBindingSource1
            // 
            this.tblembalagensNegativaBindingSource1.DataMember = "tbl_embalagensNegativa";
            this.tblembalagensNegativaBindingSource1.DataSource = this.prog7279_producaoDataSet;
            // 
            // tbl_embalagensNegativaTableAdapter1
            // 
            this.tbl_embalagensNegativaTableAdapter1.ClearBeforeFill = true;
            // 
            // tblembalagensNegativaBindingSource2
            // 
            this.tblembalagensNegativaBindingSource2.DataMember = "tbl_embalagensNegativa";
            this.tblembalagensNegativaBindingSource2.DataSource = this.db_estoqueDataSetTodas;
            // 
            // FormEmbalagemNegativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 602);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEmbalagemNegativa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programando Soluções - Relatório de embalagens negativas em estoque";
            this.Load += new System.EventHandler(this.FormEmbalagemNegativa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_embalagensNegativaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblembalagensNegativaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prog7279_producaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblembalagensNegativaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblembalagensNegativaBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private db_estoqueDataSetTodas db_estoqueDataSetTodas;
        private System.Windows.Forms.BindingSource tblembalagensNegativaBindingSource;
        private db_estoqueDataSetTodasTableAdapters.tbl_embalagensNegativaTableAdapter tbl_embalagensNegativaTableAdapter;
        private System.Windows.Forms.BindingSource tbl_embalagensNegativaBindingSource;
        private prog7279_producaoDataSet prog7279_producaoDataSet;
        private System.Windows.Forms.BindingSource tblembalagensNegativaBindingSource1;
        private prog7279_producaoDataSetTableAdapters.tbl_embalagensNegativaTableAdapter tbl_embalagensNegativaTableAdapter1;
        private System.Windows.Forms.BindingSource tblembalagensNegativaBindingSource2;
    }
}