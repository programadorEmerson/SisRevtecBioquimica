namespace Revtec_Bioquimica.Relatorio
{
    partial class FormLotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLotes));
            this.tbl_lotesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_estoqueDataSetTodas = new Revtec_Bioquimica.db_estoqueDataSetTodas();
            this.tbllotestodosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prog7279_producaoDataSet = new Revtec_Bioquimica.prog7279_producaoDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_lotes_todosTableAdapter = new Revtec_Bioquimica.prog7279_producaoDataSetTableAdapters.tbl_lotes_todosTableAdapter();
            this.tbllotestodosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_lotes_todosTableAdapter1 = new Revtec_Bioquimica.db_estoqueDataSetTodasTableAdapters.tbl_lotes_todosTableAdapter();
            this.tbllotesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_lotesTableAdapter = new Revtec_Bioquimica.db_estoqueDataSetTodasTableAdapters.tbl_lotesTableAdapter();
            this.tbllotesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_lotesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllotestodosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prog7279_producaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllotestodosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllotesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllotesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_lotesBindingSource
            // 
            this.tbl_lotesBindingSource.DataMember = "tbl_lotes";
            this.tbl_lotesBindingSource.DataSource = this.db_estoqueDataSetTodas;
            // 
            // db_estoqueDataSetTodas
            // 
            this.db_estoqueDataSetTodas.DataSetName = "db_estoqueDataSetTodas";
            this.db_estoqueDataSetTodas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbllotestodosBindingSource
            // 
            this.tbllotestodosBindingSource.DataMember = "tbl_lotes_todos";
            this.tbllotestodosBindingSource.DataSource = this.prog7279_producaoDataSet;
            // 
            // prog7279_producaoDataSet
            // 
            this.prog7279_producaoDataSet.DataSetName = "prog7279_producaoDataSet";
            this.prog7279_producaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetLotes";
            reportDataSource1.Value = this.tbl_lotesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Revtec_Bioquimica.Relatorio.ReportLotes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(791, 602);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbl_lotes_todosTableAdapter
            // 
            this.tbl_lotes_todosTableAdapter.ClearBeforeFill = true;
            // 
            // tbllotestodosBindingSource1
            // 
            this.tbllotestodosBindingSource1.DataMember = "tbl_lotes_todos";
            this.tbllotestodosBindingSource1.DataSource = this.db_estoqueDataSetTodas;
            // 
            // tbl_lotes_todosTableAdapter1
            // 
            this.tbl_lotes_todosTableAdapter1.ClearBeforeFill = true;
            // 
            // tbllotesBindingSource
            // 
            this.tbllotesBindingSource.DataMember = "tbl_lotes";
            this.tbllotesBindingSource.DataSource = this.db_estoqueDataSetTodas;
            // 
            // tbl_lotesTableAdapter
            // 
            this.tbl_lotesTableAdapter.ClearBeforeFill = true;
            // 
            // tbllotesBindingSource1
            // 
            this.tbllotesBindingSource1.DataMember = "tbl_lotes";
            this.tbllotesBindingSource1.DataSource = this.db_estoqueDataSetTodas;
            // 
            // FormLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 602);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programando Soluções - Lotes";
            this.Load += new System.EventHandler(this.FormLotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_lotesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllotestodosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prog7279_producaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllotestodosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllotesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllotesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbllotestodosBindingSource;
        private prog7279_producaoDataSet prog7279_producaoDataSet;
        private prog7279_producaoDataSetTableAdapters.tbl_lotes_todosTableAdapter tbl_lotes_todosTableAdapter;
        private db_estoqueDataSetTodas db_estoqueDataSetTodas;
        private System.Windows.Forms.BindingSource tbllotestodosBindingSource1;
        private db_estoqueDataSetTodasTableAdapters.tbl_lotes_todosTableAdapter tbl_lotes_todosTableAdapter1;
        private System.Windows.Forms.BindingSource tbl_lotesBindingSource;
        private System.Windows.Forms.BindingSource tbllotesBindingSource;
        private db_estoqueDataSetTodasTableAdapters.tbl_lotesTableAdapter tbl_lotesTableAdapter;
        private System.Windows.Forms.BindingSource tbllotesBindingSource1;
    }
}