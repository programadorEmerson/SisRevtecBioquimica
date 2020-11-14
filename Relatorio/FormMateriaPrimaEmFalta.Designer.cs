namespace Revtec_Bioquimica.Relatorio
{
    partial class FormMateriaPrimaEmFalta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMateriaPrimaEmFalta));
            this.tbl_materiaprimaEmFaltaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_estoqueDataSetTodas = new Revtec_Bioquimica.db_estoqueDataSetTodas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblmateriaprimaEmFaltaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_materiaprimaEmFaltaTableAdapter = new Revtec_Bioquimica.db_estoqueDataSetTodasTableAdapters.tbl_materiaprimaEmFaltaTableAdapter();
            this.prog7279_producaoDataSet = new Revtec_Bioquimica.prog7279_producaoDataSet();
            this.tblmateriaprimaEmFaltaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_materiaprimaEmFaltaTableAdapter1 = new Revtec_Bioquimica.prog7279_producaoDataSetTableAdapters.tbl_materiaprimaEmFaltaTableAdapter();
            this.tblmateriaprimaEmFaltaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_materiaprimaEmFaltaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmateriaprimaEmFaltaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prog7279_producaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmateriaprimaEmFaltaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmateriaprimaEmFaltaBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_materiaprimaEmFaltaBindingSource
            // 
            this.tbl_materiaprimaEmFaltaBindingSource.DataMember = "tbl_materiaprimaEmFalta";
            this.tbl_materiaprimaEmFaltaBindingSource.DataSource = this.db_estoqueDataSetTodas;
            // 
            // db_estoqueDataSetTodas
            // 
            this.db_estoqueDataSetTodas.DataSetName = "db_estoqueDataSetTodas";
            this.db_estoqueDataSetTodas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetMateriaPrimaEmFalta";
            reportDataSource1.Value = this.tbl_materiaprimaEmFaltaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Revtec_Bioquimica.Relatorio.ReportMateriaPrimaEmFalta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(791, 602);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblmateriaprimaEmFaltaBindingSource
            // 
            this.tblmateriaprimaEmFaltaBindingSource.DataMember = "tbl_materiaprimaEmFalta";
            this.tblmateriaprimaEmFaltaBindingSource.DataSource = this.db_estoqueDataSetTodas;
            // 
            // tbl_materiaprimaEmFaltaTableAdapter
            // 
            this.tbl_materiaprimaEmFaltaTableAdapter.ClearBeforeFill = true;
            // 
            // prog7279_producaoDataSet
            // 
            this.prog7279_producaoDataSet.DataSetName = "prog7279_producaoDataSet";
            this.prog7279_producaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblmateriaprimaEmFaltaBindingSource1
            // 
            this.tblmateriaprimaEmFaltaBindingSource1.DataMember = "tbl_materiaprimaEmFalta";
            this.tblmateriaprimaEmFaltaBindingSource1.DataSource = this.prog7279_producaoDataSet;
            // 
            // tbl_materiaprimaEmFaltaTableAdapter1
            // 
            this.tbl_materiaprimaEmFaltaTableAdapter1.ClearBeforeFill = true;
            // 
            // tblmateriaprimaEmFaltaBindingSource2
            // 
            this.tblmateriaprimaEmFaltaBindingSource2.DataMember = "tbl_materiaprimaEmFalta";
            this.tblmateriaprimaEmFaltaBindingSource2.DataSource = this.db_estoqueDataSetTodas;
            // 
            // FormMateriaPrimaEmFalta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 602);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMateriaPrimaEmFalta";
            this.Text = "Programando Soluções - Relatório de materia prima com saldo zerado em estoque";
            this.Load += new System.EventHandler(this.FormMateriaPrimaEmFalta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_materiaprimaEmFaltaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_estoqueDataSetTodas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmateriaprimaEmFaltaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prog7279_producaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmateriaprimaEmFaltaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmateriaprimaEmFaltaBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private db_estoqueDataSetTodas db_estoqueDataSetTodas;
        private System.Windows.Forms.BindingSource tblmateriaprimaEmFaltaBindingSource;
        private db_estoqueDataSetTodasTableAdapters.tbl_materiaprimaEmFaltaTableAdapter tbl_materiaprimaEmFaltaTableAdapter;
        private System.Windows.Forms.BindingSource tbl_materiaprimaEmFaltaBindingSource;
        private prog7279_producaoDataSet prog7279_producaoDataSet;
        private System.Windows.Forms.BindingSource tblmateriaprimaEmFaltaBindingSource1;
        private prog7279_producaoDataSetTableAdapters.tbl_materiaprimaEmFaltaTableAdapter tbl_materiaprimaEmFaltaTableAdapter1;
        private System.Windows.Forms.BindingSource tblmateriaprimaEmFaltaBindingSource2;
    }
}