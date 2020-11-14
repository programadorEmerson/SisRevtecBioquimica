namespace Revtec_Bioquimica.View
{
    partial class Pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedidos));
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.textBoxDataAtual = new System.Windows.Forms.TextBox();
            this.textBoxPrevisaoDeEntrega = new System.Windows.Forms.TextBox();
            this.textBoxGuia = new System.Windows.Forms.TextBox();
            this.textBoxObservacao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxProduto = new System.Windows.Forms.ComboBox();
            this.comboBoxLitragem = new System.Windows.Forms.ComboBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxEmbalagens = new System.Windows.Forms.ComboBox();
            this.comboBoxCaixa = new System.Windows.Forms.ComboBox();
            this.comboBoxTampa = new System.Windows.Forms.ComboBox();
            this.textBoxQtdadePorCaixa = new System.Windows.Forms.TextBox();
            this.dataGridViewPedidosAdd = new System.Windows.Forms.DataGridView();
            this.btnStatusLancado = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonLoteSolicitado = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonIRotuloSolicitado = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonItemConcluido = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelPeso = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonCancelarItem = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidosAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(17, 72);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(377, 21);
            this.comboBoxCliente.TabIndex = 1;
            // 
            // textBoxDataAtual
            // 
            this.textBoxDataAtual.Enabled = false;
            this.textBoxDataAtual.Location = new System.Drawing.Point(401, 73);
            this.textBoxDataAtual.Name = "textBoxDataAtual";
            this.textBoxDataAtual.Size = new System.Drawing.Size(118, 20);
            this.textBoxDataAtual.TabIndex = 2;
            // 
            // textBoxPrevisaoDeEntrega
            // 
            this.textBoxPrevisaoDeEntrega.Location = new System.Drawing.Point(527, 73);
            this.textBoxPrevisaoDeEntrega.Name = "textBoxPrevisaoDeEntrega";
            this.textBoxPrevisaoDeEntrega.Size = new System.Drawing.Size(118, 20);
            this.textBoxPrevisaoDeEntrega.TabIndex = 3;
            // 
            // textBoxGuia
            // 
            this.textBoxGuia.Location = new System.Drawing.Point(653, 73);
            this.textBoxGuia.Name = "textBoxGuia";
            this.textBoxGuia.Size = new System.Drawing.Size(87, 20);
            this.textBoxGuia.TabIndex = 4;
            this.textBoxGuia.Text = "0000";
            this.textBoxGuia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGuia_KeyPress);
            // 
            // textBoxObservacao
            // 
            this.textBoxObservacao.Location = new System.Drawing.Point(17, 117);
            this.textBoxObservacao.Multiline = true;
            this.textBoxObservacao.Name = "textBoxObservacao";
            this.textBoxObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxObservacao.Size = new System.Drawing.Size(652, 74);
            this.textBoxObservacao.TabIndex = 5;
            this.textBoxObservacao.TextChanged += new System.EventHandler(this.textBoxObservacao_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Revtec_Bioquimica.Properties.Resources.btn_iniciar_pedido3;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(675, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 77);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxProduto
            // 
            this.comboBoxProduto.FormattingEnabled = true;
            this.comboBoxProduto.Location = new System.Drawing.Point(17, 224);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(404, 21);
            this.comboBoxProduto.TabIndex = 7;
            // 
            // comboBoxLitragem
            // 
            this.comboBoxLitragem.FormattingEnabled = true;
            this.comboBoxLitragem.Location = new System.Drawing.Point(427, 223);
            this.comboBoxLitragem.Name = "comboBoxLitragem";
            this.comboBoxLitragem.Size = new System.Drawing.Size(118, 21);
            this.comboBoxLitragem.TabIndex = 8;
            this.comboBoxLitragem.SelectedValueChanged += new System.EventHandler(this.comboBoxLitragem_SelectedValueChanged);
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(554, 223);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(90, 20);
            this.textBoxQuantidade.TabIndex = 9;
            this.textBoxQuantidade.Text = "1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Revtec_Bioquimica.Properties.Resources.btn_adc_item;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(667, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 47);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxEmbalagens
            // 
            this.comboBoxEmbalagens.FormattingEnabled = true;
            this.comboBoxEmbalagens.Location = new System.Drawing.Point(17, 271);
            this.comboBoxEmbalagens.Name = "comboBoxEmbalagens";
            this.comboBoxEmbalagens.Size = new System.Drawing.Size(218, 21);
            this.comboBoxEmbalagens.TabIndex = 11;
            // 
            // comboBoxCaixa
            // 
            this.comboBoxCaixa.FormattingEnabled = true;
            this.comboBoxCaixa.Location = new System.Drawing.Point(241, 271);
            this.comboBoxCaixa.Name = "comboBoxCaixa";
            this.comboBoxCaixa.Size = new System.Drawing.Size(194, 21);
            this.comboBoxCaixa.TabIndex = 12;
            // 
            // comboBoxTampa
            // 
            this.comboBoxTampa.FormattingEnabled = true;
            this.comboBoxTampa.Location = new System.Drawing.Point(440, 271);
            this.comboBoxTampa.Name = "comboBoxTampa";
            this.comboBoxTampa.Size = new System.Drawing.Size(223, 21);
            this.comboBoxTampa.TabIndex = 13;
            // 
            // textBoxQtdadePorCaixa
            // 
            this.textBoxQtdadePorCaixa.Location = new System.Drawing.Point(650, 223);
            this.textBoxQtdadePorCaixa.Name = "textBoxQtdadePorCaixa";
            this.textBoxQtdadePorCaixa.Size = new System.Drawing.Size(90, 20);
            this.textBoxQtdadePorCaixa.TabIndex = 10;
            this.textBoxQtdadePorCaixa.Text = "1";
            this.textBoxQtdadePorCaixa.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxQtdadePorCaixa_Validating);
            // 
            // dataGridViewPedidosAdd
            // 
            this.dataGridViewPedidosAdd.AllowUserToAddRows = false;
            this.dataGridViewPedidosAdd.AllowUserToDeleteRows = false;
            this.dataGridViewPedidosAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPedidosAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidosAdd.Enabled = false;
            this.dataGridViewPedidosAdd.Location = new System.Drawing.Point(15, 345);
            this.dataGridViewPedidosAdd.Name = "dataGridViewPedidosAdd";
            this.dataGridViewPedidosAdd.ReadOnly = true;
            this.dataGridViewPedidosAdd.Size = new System.Drawing.Size(726, 171);
            this.dataGridViewPedidosAdd.TabIndex = 0;
            this.dataGridViewPedidosAdd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPedidosAdd_CellClick);
            this.dataGridViewPedidosAdd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPedidosAdd_CellContentClick);
            // 
            // btnStatusLancado
            // 
            this.btnStatusLancado.Location = new System.Drawing.Point(17, 315);
            this.btnStatusLancado.Name = "btnStatusLancado";
            this.btnStatusLancado.Size = new System.Drawing.Size(35, 24);
            this.btnStatusLancado.TabIndex = 15;
            this.btnStatusLancado.UseVisualStyleBackColor = true;
            this.btnStatusLancado.Click += new System.EventHandler(this.btnStatusLancado_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(50, 321);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Lançado";
            // 
            // buttonLoteSolicitado
            // 
            this.buttonLoteSolicitado.Location = new System.Drawing.Point(113, 315);
            this.buttonLoteSolicitado.Name = "buttonLoteSolicitado";
            this.buttonLoteSolicitado.Size = new System.Drawing.Size(35, 24);
            this.buttonLoteSolicitado.TabIndex = 16;
            this.buttonLoteSolicitado.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(146, 321);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Lote solicitado";
            // 
            // buttonIRotuloSolicitado
            // 
            this.buttonIRotuloSolicitado.Location = new System.Drawing.Point(238, 315);
            this.buttonIRotuloSolicitado.Name = "buttonIRotuloSolicitado";
            this.buttonIRotuloSolicitado.Size = new System.Drawing.Size(35, 24);
            this.buttonIRotuloSolicitado.TabIndex = 17;
            this.buttonIRotuloSolicitado.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(271, 321);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Rótulo Solicitado";
            // 
            // buttonItemConcluido
            // 
            this.buttonItemConcluido.Location = new System.Drawing.Point(375, 315);
            this.buttonItemConcluido.Name = "buttonItemConcluido";
            this.buttonItemConcluido.Size = new System.Drawing.Size(35, 24);
            this.buttonItemConcluido.TabIndex = 18;
            this.buttonItemConcluido.UseVisualStyleBackColor = true;
            this.buttonItemConcluido.Click += new System.EventHandler(this.buttonItemConcluido_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(408, 321);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Item Concluído";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStatus.Location = new System.Drawing.Point(508, 321);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(119, 12);
            this.labelStatus.TabIndex = 12;
            this.labelStatus.Text = "|   Status: 100% pronto";
            this.labelStatus.Click += new System.EventHandler(this.labelStatus_Click);
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.BackColor = System.Drawing.Color.Transparent;
            this.labelPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPeso.Location = new System.Drawing.Point(629, 321);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(92, 12);
            this.labelPeso.TabIndex = 13;
            this.labelPeso.Text = "|    Peso: 1500 Kg";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = global::Revtec_Bioquimica.Properties.Resources.cancelar_pedido;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(15, 522);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 28);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.BackgroundImage = global::Revtec_Bioquimica.Properties.Resources.excluir_item;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(223, 522);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(102, 28);
            this.btnExcluir.TabIndex = 19;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::Revtec_Bioquimica.Properties.Resources.itemconcluido;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(327, 522);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 28);
            this.button3.TabIndex = 20;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::Revtec_Bioquimica.Properties.Resources.solicitarlote;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Enabled = false;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(431, 522);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 28);
            this.button4.TabIndex = 21;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonCancelarItem
            // 
            this.buttonCancelarItem.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancelarItem.BackgroundImage = global::Revtec_Bioquimica.Properties.Resources.cancelar_item;
            this.buttonCancelarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCancelarItem.Enabled = false;
            this.buttonCancelarItem.FlatAppearance.BorderSize = 0;
            this.buttonCancelarItem.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonCancelarItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonCancelarItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonCancelarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelarItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarItem.Location = new System.Drawing.Point(119, 522);
            this.buttonCancelarItem.Name = "buttonCancelarItem";
            this.buttonCancelarItem.Size = new System.Drawing.Size(102, 28);
            this.buttonCancelarItem.TabIndex = 23;
            this.buttonCancelarItem.UseVisualStyleBackColor = false;
            this.buttonCancelarItem.Click += new System.EventHandler(this.buttonCancelarItem_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = global::Revtec_Bioquimica.Properties.Resources.romaneio;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(535, 522);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 28);
            this.button6.TabIndex = 24;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::Revtec_Bioquimica.Properties.Resources.lote_laboratorio;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(639, 522);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 28);
            this.button5.TabIndex = 25;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Revtec_Bioquimica.Properties.Resources.cadastrodepedidos22;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(754, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxQtdadePorCaixa);
            this.Controls.Add(this.textBoxObservacao);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBoxGuia);
            this.Controls.Add(this.comboBoxTampa);
            this.Controls.Add(this.dataGridViewPedidosAdd);
            this.Controls.Add(this.textBoxPrevisaoDeEntrega);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.textBoxDataAtual);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.comboBoxCaixa);
            this.Controls.Add(this.buttonCancelarItem);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.comboBoxEmbalagens);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.comboBoxLitragem);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBoxProduto);
            this.Controls.Add(this.buttonItemConcluido);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.buttonIRotuloSolicitado);
            this.Controls.Add(this.btnStatusLancado);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.buttonLoteSolicitado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programando Soluções - Cadastro de Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidosAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonCancelarItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonItemConcluido;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonIRotuloSolicitado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonLoteSolicitado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnStatusLancado;
        private System.Windows.Forms.DataGridView dataGridViewPedidosAdd;
        private System.Windows.Forms.TextBox textBoxQtdadePorCaixa;
        private System.Windows.Forms.ComboBox comboBoxTampa;
        private System.Windows.Forms.ComboBox comboBoxCaixa;
        private System.Windows.Forms.ComboBox comboBoxEmbalagens;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.ComboBox comboBoxLitragem;
        private System.Windows.Forms.ComboBox comboBoxProduto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxObservacao;
        private System.Windows.Forms.TextBox textBoxGuia;
        private System.Windows.Forms.TextBox textBoxPrevisaoDeEntrega;
        private System.Windows.Forms.TextBox textBoxDataAtual;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
    }
}