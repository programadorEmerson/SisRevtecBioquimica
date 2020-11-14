namespace Revtec_Bioquimica.View {
    partial class Login {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLogin.BackgroundImage")));
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.ForeColor = System.Drawing.Color.Transparent;
            this.buttonLogin.Location = new System.Drawing.Point(203, 171);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(126, 36);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.ForeColor = System.Drawing.Color.DarkBlue;
            this.textBoxSenha.Location = new System.Drawing.Point(172, 139);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(182, 20);
            this.textBoxSenha.TabIndex = 2;
            this.textBoxSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSenha.UseSystemPasswordChar = true;
            this.textBoxSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSenha_KeyPress);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.ForeColor = System.Drawing.Color.DarkBlue;
            this.textBoxLogin.Location = new System.Drawing.Point(172, 89);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(182, 22);
            this.textBoxLogin.TabIndex = 1;
            this.textBoxLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            this.textBoxLogin.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            this.textBoxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLogin_KeyPress);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.buttonLogin);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programando Soluções - Login de acesso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxLogin;
    }
}