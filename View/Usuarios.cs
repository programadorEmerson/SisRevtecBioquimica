using Revtec_Bioquimica.Controller;
using Revtec_Bioquimica.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revtec_Bioquimica.View {
    public partial class Usuarios : Form {
        bool trueSalvarfalseAlterar = true;
        ModelUsuarios modelUsuarios = new ModelUsuarios();
        int codigoUsuario;
        String quemPode = "Desenvolvimento";
        int idUsuario;
        int idUsuarioAtual;

        public Usuarios(int id) {
            InitializeComponent();
            btnNovoUsuario.BackColor = Color.FromArgb(0, Color.Transparent);
            idUsuario = id;
            limparCampos(false, false);
            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);

            habilitarBotoes(false, false, false, false, false);
        }

        private void btnNovoRegistroProduto_Click(object sender, EventArgs e) {
            trueSalvarfalseAlterar = true;
            dataGridViewUsuarios.Enabled = false;
            limparCampos(true, true);
            txtNome.Focus();
            habilitarBotoes(false, false, true, false, true);
        }

        public void habilitarBotoes(bool novo, bool alterar, bool cancelar, bool excluir, bool salvar) {
            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);

            if (setor.Equals("Desenvolvimento")) {
                btnNovoUsuario.Enabled = true;
                btnExcluirUsuario.Enabled = excluir;
            } else {
                btnNovoUsuario.Enabled = false;
                btnExcluirUsuario.Enabled = false;
            }

            btnAlterarUsuario.Enabled = alterar;
            btnCancelarUsuario.Enabled = cancelar;            
            btnSalvarUsuario.Enabled = salvar;
        }

        public void limparCampos(bool nome, bool observacao) {
            txtNome.Text = "";
            txtNome.Enabled = nome;
            comboBoxSetor.Enabled = nome;
            comboBoxSetor.SelectedItem = "Selecione";
            comboBoxNivel.Enabled = nome;
            comboBoxNivel.SelectedItem = "Selecione";

            txtLogin.Text = "";
            txtLogin.Enabled = nome;

            txtSenha.Text = "";
            txtSenha.Enabled = nome;

            carrgarUsuarios();
            txtSenha.PasswordChar = '*';

        }

        private void btnSalvarUsuario_Click(object sender, EventArgs e) {
            if (!txtNome.Text.Trim().Equals("") || txtNome.Text.Trim().Length > 4) {
                try {
                    if (!comboBoxSetor.SelectedItem.ToString().Equals("Selecione") || comboBoxSetor.SelectedItem.ToString().Equals(null)) {
                        try {
                            if (!comboBoxNivel.SelectedItem.ToString().Equals("Selecione")) {
                                if (!txtLogin.Text.Trim().Equals("") || txtNome.Text.Trim().Length > 4) {
                                    if (!txtSenha.Text.Trim().Equals("") || txtNome.Text.Trim().Length > 4) {
                                        gravarDados(trueSalvarfalseAlterar);
                                    } else {
                                        MessageBox.Show("Insira uma senha maior que 4 caracteres");
                                        txtNome.Focus();
                                    }
                                } else {
                                    MessageBox.Show("Insira um login maior que 4 caracteres");
                                    txtNome.Focus();
                                }
                            } else {
                                MessageBox.Show("Selecione um nivel de acesso");
                                comboBoxNivel.Focus();
                            }
                        } catch (NullReferenceException) {

                            MessageBox.Show("Selecione um nivel de acesso");
                            comboBoxNivel.Focus();
                        }
                    } else {
                        MessageBox.Show("Selecione um setor");
                        comboBoxSetor.Focus();
                    }
                } catch (NullReferenceException) {

                    MessageBox.Show("Selecione um setor");
                    comboBoxSetor.Focus();
                }
            } else {
                MessageBox.Show("O nome inserido é inválido");
                txtNome.Focus();
            }
        }

        public void gravarDados(bool acao) {

            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            ModelUsuarios modelUsuariosNovo = new ModelUsuarios();

            modelUsuariosNovo = controllerUsuarios.verificarSeLoginJaExiste(txtLogin.Text);

            if (idUsuarioAtual == modelUsuariosNovo.Usuarios_id || modelUsuariosNovo.Usuarios_id < 1) {
                if (acao) {
                    modelUsuarios.Usuarios_nome = txtNome.Text;
                    modelUsuarios.Usuarios_setor = comboBoxSetor.SelectedItem.ToString();
                    modelUsuarios.Usuarios_nivel = comboBoxNivel.SelectedItem.ToString();
                    modelUsuarios.Usuarios_login = txtLogin.Text;
                    modelUsuarios.Usuarios_senha = txtSenha.Text;


                    if (modelUsuarios.salvarUsuariosController(modelUsuarios)) {
                        carrgarUsuarios();
                        trueSalvarfalseAlterar = true;
                        habilitarBotoes(true, false, false, false, false);
                        MessageBox.Show("Usuario salvo com sucesso!");
                        dataGridViewUsuarios.Enabled = true;
                        limparCampos(false, false);
                    } else {
                        trueSalvarfalseAlterar = true;
                        habilitarBotoes(true, false, false, false, false);
                        MessageBox.Show("Erro ao salvar o usuario");
                        dataGridViewUsuarios.Enabled = true;
                    }
                } else {
                    modelUsuarios.Usuarios_id = codigoUsuario;
                    modelUsuarios.Usuarios_nome = txtNome.Text;
                    modelUsuarios.Usuarios_setor = comboBoxSetor.SelectedItem.ToString();
                    modelUsuarios.Usuarios_nivel = comboBoxNivel.SelectedItem.ToString();
                    modelUsuarios.Usuarios_login = txtLogin.Text;
                    modelUsuarios.Usuarios_senha = txtSenha.Text;

                    if (modelUsuarios.atualizarUsuariosController(modelUsuarios)) {
                        trueSalvarfalseAlterar = true;
                        habilitarBotoes(true, false, false, false, false);
                        limparCampos(false, false);
                        carrgarUsuarios();
                        MessageBox.Show("Usuario atualizado com sucesso!");
                        dataGridViewUsuarios.Enabled = true;
                        txtNome.Focus();
                    } else {
                        trueSalvarfalseAlterar = true;
                        habilitarBotoes(true, false, false, false, false);
                        MessageBox.Show("Erro ao atualizar o usuario");
                        dataGridViewUsuarios.Enabled = true;
                    }
                }
            } else {
                MessageBox.Show("Este nome de usuário já esta em uso, escolha outro.");
            }

        }

        public void carrgarUsuarios() {

            try {
                dataGridViewUsuarios.DataSource = modelUsuarios.exibirTabelaUsuarios(idUsuario);

                dataGridViewUsuarios.Columns[0].HeaderText = "ID";
                DataGridViewColumn coluna1 = dataGridViewUsuarios.Columns[0];
                coluna1.Width = 40;

                dataGridViewUsuarios.Columns[1].HeaderText = "NOME";
                DataGridViewColumn coluna2 = dataGridViewUsuarios.Columns[1];
                coluna2.Width = 190;

                dataGridViewUsuarios.Columns[2].HeaderText = "SETOR";
                DataGridViewColumn coluna3 = dataGridViewUsuarios.Columns[2];
                coluna3.Width = 80;

                dataGridViewUsuarios.Columns[3].HeaderText = "NIVEL";
                DataGridViewColumn coluna4 = dataGridViewUsuarios.Columns[3];
                coluna4.Width = 80;

                dataGridViewUsuarios.Columns[4].HeaderText = "LOGIN";
                DataGridViewColumn coluna5 = dataGridViewUsuarios.Columns[4];
                coluna5.Width = 80;

                dataGridViewUsuarios.Columns[5].Visible = false;
                DataGridViewColumn coluna6 = dataGridViewUsuarios.Columns[5];
                coluna6.Width = 0;
            } catch {
                MessageBox.Show("Erro ao buscar os produtos.");
            }
        }

        private void btnAlterarUsuario_Click(object sender, EventArgs e) {
            habilitarBotoes(false, false, true, false, true);
            habilitarCampos();
            trueSalvarfalseAlterar = false;
            dataGridViewUsuarios.Enabled = false;
        }

        public void habilitarCampos() {
            txtNome.Enabled = true;
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;

            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);

            if (setor.Equals("Desenvolvimento")) {
                comboBoxSetor.Enabled = true;
                comboBoxNivel.Enabled = true;
            }

        }

        private void btnCancelarUsuario_Click(object sender, EventArgs e) {
            trueSalvarfalseAlterar = true;
            limparCampos(false, false);
            habilitarBotoes(true, false, false, false, false);
            dataGridViewUsuarios.Enabled = true;
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e) {

            // Initializes the variables to pass to the MessageBox.Show method.
            string message = "Deseja excluir o usuário (" + dataGridViewUsuarios.CurrentRow.Cells[1].Value.ToString() + ")\n\nImpossível reverter";
            string caption = "EXCLUIR USUÁRIO";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes) {
                if (modelUsuarios.deletarUsuariosController(dataGridViewUsuarios.CurrentRow.Cells[0].Value.ToString())) {
                    carrgarUsuarios();
                    trueSalvarfalseAlterar = true;
                    habilitarBotoes(true, false, false, false, false);
                    limparCampos(false, false);
                    MessageBox.Show("Usuario deletado com sucesso!");
                    txtNome.Text = "";
                    codigoUsuario = -1;
                    comboBoxNivel.SelectedItem = "Selecione";
                    comboBoxNivel.Enabled = false;
                    comboBoxSetor.SelectedItem = "Selecione";
                    comboBoxSetor.Enabled = false;
                    txtNome.Focus();
                } else {
                    MessageBox.Show("Erro ao deletar o usuario.");
                }
            }
        }

        private void dataGridViewUsuarios_CellClick(object sender, DataGridViewCellEventArgs e) {
            habilitarBotoes(false, true, false, true, false);
            idUsuarioAtual = int.Parse(dataGridViewUsuarios.CurrentRow.Cells[0].Value.ToString());
            carregarGrid();
        }

        public void carregarGrid() {
            codigoUsuario = int.Parse(dataGridViewUsuarios.CurrentRow.Cells[0].Value.ToString());
            txtNome.Text = dataGridViewUsuarios.CurrentRow.Cells[1].Value.ToString();
            comboBoxSetor.SelectedItem = dataGridViewUsuarios.CurrentRow.Cells[2].Value.ToString();
            comboBoxNivel.SelectedItem = dataGridViewUsuarios.CurrentRow.Cells[3].Value.ToString();
            txtLogin.Text = dataGridViewUsuarios.CurrentRow.Cells[4].Value.ToString();
            txtSenha.Text = dataGridViewUsuarios.CurrentRow.Cells[5].Value.ToString();
            txtNome.Enabled = false;
            habilitarBotoes(false, true, false, true, false);
            btnCancelarUsuario.Enabled = true;

        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            habilitarBotoes(false, true, false, true, false);
            carregarGrid();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e) {

        }

        private void comboBoxSetor_KeyPress(object sender, KeyPressEventArgs e) {

        }
    }
}
