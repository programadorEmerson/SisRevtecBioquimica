namespace Revtec_Bioquimica.View
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(15, 143);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacoes.Size = new System.Drawing.Size(535, 91);
            this.txtObservacoes.TabIndex = 3;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(286, 89);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(264, 20);
            this.txtCidade.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(18, 89);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(262, 20);
            this.txtNome.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewClientes);
            this.panel2.Location = new System.Drawing.Point(12, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 137);
            this.panel2.TabIndex = 2;
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToAddRows = false;
            this.dataGridViewClientes.AllowUserToDeleteRows = false;
            this.dataGridViewClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClientes.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            this.dataGridViewClientes.Size = new System.Drawing.Size(535, 137);
            this.dataGridViewClientes.TabIndex = 0;
            this.dataGridViewClientes.CellBorderStyleChanged += new System.EventHandler(this.dataGridViewClientes_CellBorderStyleChanged);
            this.dataGridViewClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientes_CellClick);
            this.dataGridViewClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientes_CellContentClick);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Transparent;
            this.btnNovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovo.BackgroundImage")));
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(45, 246);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(94, 24);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(425, 246);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(94, 24);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlterar.BackgroundImage")));
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(140, 246);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(94, 24);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(330, 246);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(94, 24);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(235, 246);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 24);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(562, 429);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programando Soluções - Cadastro de Clientes";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
    }
}