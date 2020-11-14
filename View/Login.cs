using Revtec_Bioquimica.Controller;
using Revtec_Bioquimica.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Revtec_Bioquimica.View {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
            buttonLogin.BackColor = Color.FromArgb(0, Color.Transparent);
        }

        private void buttonLogin_Click(object sender, EventArgs e) {
            fazerLogin();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e) {

        }

        private void textBoxLogin_Enter(object sender, EventArgs e) {

        }

        void fazerLogin() {
            if (!textBoxLogin.Text.Equals("")) {
                if (!textBoxSenha.Text.Equals("")) {

                    ModelUsuarios usuario = new ModelUsuarios();
                    ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
                    usuario = controllerUsuarios.verificarLoginRetornandoUsuario(textBoxLogin.Text, textBoxSenha.Text);

                    if (usuario.Usuarios_id > 0) {
                        Form f = new Principal(usuario.Usuarios_nome, usuario.Usuarios_nivel, usuario.Usuarios_id, usuario.Usuarios_setor, usuario.Usuario_empresa);
                        f.Show();
                        this.Visible = false;
                    } else {
                        MessageBox.Show("Usuário e/ou senha inválido.");
                        textBoxLogin.Focus();
                        textBoxLogin.Text = "";
                        textBoxSenha.Text = "";
                    }

                } else {
                    MessageBox.Show("Informe a senha.");
                    textBoxSenha.Focus();
                }
            } else {
                MessageBox.Show("Informe o nome de usuário.");
                textBoxLogin.Focus();
            }
        }

        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                if (!textBoxLogin.Text.Equals("")) {
                    textBoxSenha.Focus();
                }else {
                    MessageBox.Show("Informe seu nome de usuário");
                    textBoxLogin.Focus();
                }   
            }
        }

        private void textBoxSenha_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                fazerLogin();
            }
        }
    }
}
