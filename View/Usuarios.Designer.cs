namespace Revtec_Bioquimica.View
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.btnNovoUsuario = new System.Windows.Forms.Button();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.btnSalvarUsuario = new System.Windows.Forms.Button();
            this.comboBoxSetor = new System.Windows.Forms.ComboBox();
            this.btnAlterarUsuario = new System.Windows.Forms.Button();
            this.btnExcluirUsuario = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnCancelarUsuario = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.comboBoxNivel = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnNovoUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovoUsuario.BackgroundImage")));
            this.btnNovoUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNovoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoUsuario.FlatAppearance.BorderSize = 0;
            this.btnNovoUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNovoUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNovoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoUsuario.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoUsuario.Location = new System.Drawing.Point(32, 177);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(93, 23);
            this.btnNovoUsuario.TabIndex = 6;
            this.btnNovoUsuario.UseVisualStyleBackColor = false;
            this.btnNovoUsuario.Click += new System.EventHandler(this.btnNovoRegistroProduto_Click);
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.AllowUserToAddRows = false;
            this.dataGridViewUsuarios.AllowUserToDeleteRows = false;
            this.dataGridViewUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(13, 209);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.ReadOnly = true;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(513, 231);
            this.dataGridViewUsuarios.TabIndex = 0;
            this.dataGridViewUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellClick);
            this.dataGridViewUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellContentClick);
            // 
            // btnSalvarUsuario
            // 
            this.btnSalvarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvarUsuario.BackgroundImage = global::Revtec_Bioquimica.Properties.Resources.btn_salvar;
            this.btnSalvarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalvarUsuario.FlatAppearance.BorderSize = 0;
            this.btnSalvarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarUsuario.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarUsuario.Location = new System.Drawing.Point(412, 177);
            this.btnSalvarUsuario.Name = "btnSalvarUsuario";
            this.btnSalvarUsuario.Size = new System.Drawing.Size(93, 23);
            this.btnSalvarUsuario.TabIndex = 10;
            this.btnSalvarUsuario.UseVisualStyleBackColor = false;
            this.btnSalvarUsuario.Click += new System.EventHandler(this.btnSalvarUsuario_Click);
            // 
            // comboBoxSetor
            // 
            this.comboBoxSetor.FormattingEnabled = true;
            this.comboBoxSetor.Items.AddRange(new object[] {
            "Selecione",
            "Recepção",
            "Desenvolvimento",
            "Expedição",
            "Produção",
            "Rotulagem",
            "Química",
            "Gerência"});
            this.comboBoxSetor.Location = new System.Drawing.Point(346, 87);
            this.comboBoxSetor.Name = "comboBoxSetor";
            this.comboBoxSetor.Size = new System.Drawing.Size(179, 21);
            this.comboBoxSetor.TabIndex = 2;
            this.comboBoxSetor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxSetor_KeyPress);
            // 
            // btnAlterarUsuario
            // 
            this.btnAlterarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterarUsuario.BackgroundImage = global::Revtec_Bioquimica.Properties.Resources.btn_alterar;
            this.btnAlterarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAlterarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarUsuario.FlatAppearance.BorderSize = 0;
            this.btnAlterarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarUsuario.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarUsuario.Location = new System.Drawing.Point(127, 177);
            this.btnAlterarUsuario.Name = "btnAlterarUsuario";
            this.btnAlterarUsuario.Size = new System.Drawing.Size(93, 23);
            this.btnAlterarUsuario.TabIndex = 7;
            this.btnAlterarUsuario.UseVisualStyleBackColor = false;
            this.btnAlterarUsuario.Click += new System.EventHandler(this.btnAlterarUsuario_Click);
            // 
            // btnExcluirUsuario
            // 
            this.btnExcluirUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirUsuario.BackgroundImage = global::Revtec_Bioquimica.Properties.Resources.btn_excluir;
            this.btnExcluirUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcluirUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirUsuario.FlatAppearance.BorderSize = 0;
            this.btnExcluirUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirUsuario.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirUsuario.Location = new System.Drawing.Point(317, 177);
            this.btnExcluirUsuario.Name = "btnExcluirUsuario";
            this.btnExcluirUsuario.Size = new System.Drawing.Size(93, 23);
            this.btnExcluirUsuario.TabIndex = 9;
            this.btnExcluirUsuario.UseVisualStyleBackColor = false;
            this.btnExcluirUsuario.Click += new System.EventHandler(this.btnExcluirUsuario_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(357, 140);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(168, 20);
            this.txtSenha.TabIndex = 5;
            // 
            // btnCancelarUsuario
            // 
            this.btnCancelarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarUsuario.BackgroundImage = global::Revtec_Bioquimica.Properties.Resources.btn_cancelar;
            this.btnCancelarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarUsuario.FlatAppearance.BorderSize = 0;
            this.btnCancelarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarUsuario.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarUsuario.Location = new System.Drawing.Point(222, 177);
            this.btnCancelarUsuario.Name = "btnCancelarUsuario";
            this.btnCancelarUsuario.Size = new System.Drawing.Size(93, 23);
            this.btnCancelarUsuario.TabIndex = 8;
            this.btnCancelarUsuario.UseVisualStyleBackColor = false;
            this.btnCancelarUsuario.Click += new System.EventHandler(this.btnCancelarUsuario_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(180, 140);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(169, 20);
            this.txtLogin.TabIndex = 4;
            // 
            // comboBoxNivel
            // 
            this.comboBoxNivel.FormattingEnabled = true;
            this.comboBoxNivel.Items.AddRange(new object[] {
            "Selecione",
            "Responsável pelo Setor",
            "Operador"});
            this.comboBoxNivel.Location = new System.Drawing.Point(12, 139);
            this.comboBoxNivel.Name = "comboBoxNivel";
            this.comboBoxNivel.Size = new System.Drawing.Size(162, 21);
            this.comboBoxNivel.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtNome.Location = new System.Drawing.Point(12, 87);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(328, 21);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Controls.Add(this.btnNovoUsuario);
            this.Controls.Add(this.btnSalvarUsuario);
            this.Controls.Add(this.btnAlterarUsuario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnExcluirUsuario);
            this.Controls.Add(this.comboBoxSetor);
            this.Controls.Add(this.btnCancelarUsuario);
            this.Controls.Add(this.comboBoxNivel);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programando Soluções - Configuração de Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxSetor;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.ComboBox comboBoxNivel;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.Button btnNovoUsuario;
        private System.Windows.Forms.Button btnSalvarUsuario;
        private System.Windows.Forms.Button btnAlterarUsuario;
        private System.Windows.Forms.Button btnExcluirUsuario;
        private System.Windows.Forms.Button btnCancelarUsuario;
    }
}