﻿namespace Revtec_Bioquimica.View {
    partial class Rotulos {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rotulos));
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewLotes = new System.Windows.Forms.DataGridView();
            this.buttonItemConcluido = new System.Windows.Forms.Button();
            this.btnStatusLancado = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLotes)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::Revtec_Bioquimica.Properties.Resources.btn_colorir;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(294, 55);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 29);
            this.button5.TabIndex = 14;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Revtec_Bioquimica.Properties.Resources.btn_concluir;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(382, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 29);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewLotes);
            this.panel1.Location = new System.Drawing.Point(9, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 317);
            this.panel1.TabIndex = 8;
            // 
            // dataGridViewLotes
            // 
            this.dataGridViewLotes.AllowUserToAddRows = false;
            this.dataGridViewLotes.AllowUserToDeleteRows = false;
            this.dataGridViewLotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLotes.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewLotes.Name = "dataGridViewLotes";
            this.dataGridViewLotes.ReadOnly = true;
            this.dataGridViewLotes.Size = new System.Drawing.Size(459, 317);
            this.dataGridViewLotes.TabIndex = 0;
            this.dataGridViewLotes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLotes_CellClick);
            this.dataGridViewLotes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLotes_CellContentClick);
            // 
            // buttonItemConcluido
            // 
            this.buttonItemConcluido.Location = new System.Drawing.Point(158, 54);
            this.buttonItemConcluido.Name = "buttonItemConcluido";
            this.buttonItemConcluido.Size = new System.Drawing.Size(38, 24);
            this.buttonItemConcluido.TabIndex = 17;
            this.buttonItemConcluido.UseVisualStyleBackColor = true;
            this.buttonItemConcluido.Click += new System.EventHandler(this.buttonItemConcluido_Click);
            // 
            // btnStatusLancado
            // 
            this.btnStatusLancado.Location = new System.Drawing.Point(10, 54);
            this.btnStatusLancado.Name = "btnStatusLancado";
            this.btnStatusLancado.Size = new System.Drawing.Size(38, 24);
            this.btnStatusLancado.TabIndex = 15;
            this.btnStatusLancado.UseVisualStyleBackColor = true;
            this.btnStatusLancado.Click += new System.EventHandler(this.btnStatusLancado_Click);
            // 
            // Rotulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Revtec_Bioquimica.Properties.Resources.gerenciadorDeRotulos6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(478, 416);
            this.Controls.Add(this.buttonItemConcluido);
            this.Controls.Add(this.btnStatusLancado);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Rotulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programando Soluções - Gerenciador de Rotulos";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewLotes;
        private System.Windows.Forms.Button buttonItemConcluido;
        private System.Windows.Forms.Button btnStatusLancado;
    }
}