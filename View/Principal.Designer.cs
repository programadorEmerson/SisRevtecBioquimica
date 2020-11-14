namespace Revtec_Bioquimica.View
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.labelNivelDeAcesso = new System.Windows.Forms.Label();
            this.labelTipoUsuário = new System.Windows.Forms.Label();
            this.labelUsuarioLogado = new System.Windows.Forms.Label();
            this.textBoxChave = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnExpedicao = new System.Windows.Forms.Button();
            this.btnRotulos = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.btnLote = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelAtrasos = new System.Windows.Forms.Panel();
            this.labelAtrasos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panelAtrasos.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNivelDeAcesso
            // 
            this.labelNivelDeAcesso.AutoSize = true;
            this.labelNivelDeAcesso.BackColor = System.Drawing.Color.Transparent;
            this.labelNivelDeAcesso.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNivelDeAcesso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNivelDeAcesso.Location = new System.Drawing.Point(13, 519);
            this.labelNivelDeAcesso.Name = "labelNivelDeAcesso";
            this.labelNivelDeAcesso.Size = new System.Drawing.Size(223, 15);
            this.labelNivelDeAcesso.TabIndex = 5;
            this.labelNivelDeAcesso.Text = "Nível de acesso: Responsável pelo setor";
            // 
            // labelTipoUsuário
            // 
            this.labelTipoUsuário.AutoSize = true;
            this.labelTipoUsuário.BackColor = System.Drawing.Color.Transparent;
            this.labelTipoUsuário.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoUsuário.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTipoUsuário.Location = new System.Drawing.Point(13, 500);
            this.labelTipoUsuário.Name = "labelTipoUsuário";
            this.labelTipoUsuário.Size = new System.Drawing.Size(180, 15);
            this.labelTipoUsuário.TabIndex = 4;
            this.labelTipoUsuário.Text = "Tipo de Usuário: Desenvolvedor";
            // 
            // labelUsuarioLogado
            // 
            this.labelUsuarioLogado.AutoSize = true;
            this.labelUsuarioLogado.BackColor = System.Drawing.Color.Transparent;
            this.labelUsuarioLogado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarioLogado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUsuarioLogado.Location = new System.Drawing.Point(13, 480);
            this.labelUsuarioLogado.Name = "labelUsuarioLogado";
            this.labelUsuarioLogado.Size = new System.Drawing.Size(210, 15);
            this.labelUsuarioLogado.TabIndex = 3;
            this.labelUsuarioLogado.Text = "Usuário Logado: Emerson L Saturnino";
            // 
            // textBoxChave
            // 
            this.textBoxChave.BackColor = System.Drawing.Color.White;
            this.textBoxChave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxChave.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxChave.Location = new System.Drawing.Point(462, 520);
            this.textBoxChave.Name = "textBoxChave";
            this.textBoxChave.Size = new System.Drawing.Size(156, 13);
            this.textBoxChave.TabIndex = 3;
            this.textBoxChave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxChave_KeyPress);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(862, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(812, 109);
            this.panel3.TabIndex = 0;
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BackColor = System.Drawing.Color.Transparent;
            this.btnRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorios.FlatAppearance.BorderSize = 0;
            this.btnRelatorios.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnRelatorios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRelatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Location = new System.Drawing.Point(754, 30);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(63, 54);
            this.btnRelatorios.TabIndex = 10;
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnExpedicao
            // 
            this.btnExpedicao.BackColor = System.Drawing.Color.Transparent;
            this.btnExpedicao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpedicao.FlatAppearance.BorderSize = 0;
            this.btnExpedicao.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnExpedicao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExpedicao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExpedicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpedicao.Location = new System.Drawing.Point(672, 27);
            this.btnExpedicao.Name = "btnExpedicao";
            this.btnExpedicao.Size = new System.Drawing.Size(62, 62);
            this.btnExpedicao.TabIndex = 8;
            this.btnExpedicao.UseVisualStyleBackColor = false;
            this.btnExpedicao.Click += new System.EventHandler(this.btnExpedicao_Click);
            // 
            // btnRotulos
            // 
            this.btnRotulos.BackColor = System.Drawing.Color.Transparent;
            this.btnRotulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRotulos.FlatAppearance.BorderSize = 0;
            this.btnRotulos.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnRotulos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRotulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRotulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotulos.Location = new System.Drawing.Point(592, 24);
            this.btnRotulos.Name = "btnRotulos";
            this.btnRotulos.Size = new System.Drawing.Size(64, 64);
            this.btnRotulos.TabIndex = 7;
            this.btnRotulos.UseVisualStyleBackColor = false;
            this.btnRotulos.Click += new System.EventHandler(this.btnRotulos_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.Transparent;
            this.btnEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnEstoque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Location = new System.Drawing.Point(513, 25);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(65, 65);
            this.btnEstoque.TabIndex = 6;
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnPedido
            // 
            this.btnPedido.BackColor = System.Drawing.Color.Transparent;
            this.btnPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedido.FlatAppearance.BorderSize = 0;
            this.btnPedido.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedido.Location = new System.Drawing.Point(431, 25);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(64, 60);
            this.btnPedido.TabIndex = 5;
            this.btnPedido.UseVisualStyleBackColor = false;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // btnLote
            // 
            this.btnLote.BackColor = System.Drawing.Color.Transparent;
            this.btnLote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLote.FlatAppearance.BorderSize = 0;
            this.btnLote.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnLote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLote.Location = new System.Drawing.Point(353, 25);
            this.btnLote.Name = "btnLote";
            this.btnLote.Size = new System.Drawing.Size(63, 63);
            this.btnLote.TabIndex = 4;
            this.btnLote.UseVisualStyleBackColor = false;
            this.btnLote.Click += new System.EventHandler(this.btnLote_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduto.FlatAppearance.BorderSize = 0;
            this.btnProduto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduto.Location = new System.Drawing.Point(272, 25);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(64, 64);
            this.btnProduto.TabIndex = 3;
            this.btnProduto.UseVisualStyleBackColor = false;
            this.btnProduto.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.BackColor = System.Drawing.Color.Transparent;
            this.btnFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFornecedor.FlatAppearance.BorderSize = 0;
            this.btnFornecedor.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnFornecedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedor.Location = new System.Drawing.Point(193, 27);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(62, 63);
            this.btnFornecedor.TabIndex = 2;
            this.btnFornecedor.UseVisualStyleBackColor = false;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Location = new System.Drawing.Point(110, 29);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(67, 63);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Location = new System.Drawing.Point(31, 24);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(64, 62);
            this.btnUsuario.TabIndex = 0;
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(638, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 23);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(110, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(624, 120);
            this.button2.TabIndex = 23;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelAtrasos
            // 
            this.panelAtrasos.BackColor = System.Drawing.Color.Transparent;
            this.panelAtrasos.BackgroundImage = global::Revtec_Bioquimica.Properties.Resources.atencao5;
            this.panelAtrasos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelAtrasos.Controls.Add(this.label2);
            this.panelAtrasos.Controls.Add(this.labelAtrasos);
            this.panelAtrasos.Controls.Add(this.button3);
            this.panelAtrasos.Location = new System.Drawing.Point(279, 395);
            this.panelAtrasos.Name = "panelAtrasos";
            this.panelAtrasos.Size = new System.Drawing.Size(137, 141);
            this.panelAtrasos.TabIndex = 24;
            // 
            // labelAtrasos
            // 
            this.labelAtrasos.AutoSize = true;
            this.labelAtrasos.BackColor = System.Drawing.Color.Yellow;
            this.labelAtrasos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAtrasos.Location = new System.Drawing.Point(25, 103);
            this.labelAtrasos.Name = "labelAtrasos";
            this.labelAtrasos.Size = new System.Drawing.Size(89, 15);
            this.labelAtrasos.TabIndex = 0;
            this.labelAtrasos.Text = "10 ATRASOS";
            this.labelAtrasos.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "NA EXPEDIÇÃO";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(21, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 119);
            this.button3.TabIndex = 25;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = global::Revtec_Bioquimica.Properties.Resources.fundoTelaNovo12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(846, 599);
            this.Controls.Add(this.panelAtrasos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelNivelDeAcesso);
            this.Controls.Add(this.labelTipoUsuário);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelUsuarioLogado);
            this.Controls.Add(this.textBoxChave);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnFornecedor);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.btnLote);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.btnExpedicao);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnRotulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programando Soluções - Controle de produção";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.panelAtrasos.ResumeLayout(false);
            this.panelAtrasos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnExpedicao;
        private System.Windows.Forms.Button btnRotulos;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnLote;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label labelNivelDeAcesso;
        private System.Windows.Forms.Label labelTipoUsuário;
        private System.Windows.Forms.Label labelUsuarioLogado;
        private System.Windows.Forms.TextBox textBoxChave;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelAtrasos;
        private System.Windows.Forms.Label labelAtrasos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
    }
}