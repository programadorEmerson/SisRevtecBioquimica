using Revtec_Bioquimica.Controller;
using Revtec_Bioquimica.DAO;
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
    public partial class Fornecedor : Form {

        bool trueSalvarfalseAlterar = true;
        ModelFornecedores modelFornecedores = new ModelFornecedores();
        int codigoFornecedores;
        int idUsuario;
        String observacao;
        String quemPode = "Produção";

        public Fornecedor(int id) {
            InitializeComponent();
            idUsuario = id;
            limparCampos(false, false);
        }

        public void habilitarBotoes(bool novo, bool alterar, bool cancelar, bool excluir, bool salvar) {
            btnNovo.Enabled = novo;
            btnAlterar.Enabled = alterar;
            btnCancelar.Enabled = cancelar;
            btnExcluir.Enabled = excluir;
            btnSalvar.Enabled = salvar;
        }

        public void limparCampos(bool nome, bool observacao) {
            txtNome.Text = "";
            txtNome.Enabled = nome;

            txtTelefone.Text = "";
            txtTelefone.Enabled = nome;

            txtObservacoes.Text = "";
            txtObservacoes.Enabled = nome;

            carrgarFornecedores();

        }

        public void habilitarCampos() {
            txtNome.Enabled = true;
            txtTelefone.Enabled = true;
            txtObservacoes.Enabled = true;
        }

        public void carrgarFornecedores() {

            try {
                dataGridViewFornecedor.DataSource = modelFornecedores.exibirTabelaFornecedores();

                dataGridViewFornecedor.Columns[0].HeaderText = "ID";
                DataGridViewColumn coluna1 = dataGridViewFornecedor.Columns[0];
                coluna1.Width = 40;

                dataGridViewFornecedor.Columns[1].HeaderText = "NOME";
                DataGridViewColumn coluna2 = dataGridViewFornecedor.Columns[1];
                coluna2.Width = 220;

                dataGridViewFornecedor.Columns[2].HeaderText = "TELEFONE";
                DataGridViewColumn coluna3 = dataGridViewFornecedor.Columns[2];
                coluna3.Width = 140;

                dataGridViewFornecedor.Columns[3].HeaderText = "OBSERVAÇÃO";
                DataGridViewColumn coluna4 = dataGridViewFornecedor.Columns[3];
                coluna4.Width = 92;

            } catch {
                MessageBox.Show("Erro ao buscar os produtos.");
            }
        }

        public void gravarDados(bool acao) {
            if (acao) {
                modelFornecedores.Fornecedores_nome = txtNome.Text;
                modelFornecedores.Fornecedores_telefone = txtTelefone.Text;
                modelFornecedores.Fornecedores_observacao = observacao;

                int codigoFornecedorSalvo = modelFornecedores.salvarFornecedoresController(modelFornecedores);

                if (codigoFornecedorSalvo > 0) {
                    carrgarFornecedores();
                    trueSalvarfalseAlterar = true;
                    habilitarBotoes(true, false, false, false, false);
                    MessageBox.Show("Fornecedor salvo com sucesso!");
                    dataGridViewFornecedor.Enabled = true;
                    limparCampos(false, false);
                } else {
                    trueSalvarfalseAlterar = true;
                    habilitarBotoes(true, false, false, false, false);
                    MessageBox.Show("Erro ao salvar o fornecedors");
                    dataGridViewFornecedor.Enabled = true;
                }
            } else {
                modelFornecedores.Fornecedores_id = codigoFornecedores;
                modelFornecedores.Fornecedores_nome = txtNome.Text;
                modelFornecedores.Fornecedores_telefone = txtTelefone.Text;
                modelFornecedores.Fornecedores_observacao = observacao;

                if (modelFornecedores.atualizarFornecedoresController(modelFornecedores)) {
                    trueSalvarfalseAlterar = true;
                    habilitarBotoes(true, false, false, false, false);
                    limparCampos(false, false);
                    carrgarFornecedores();
                    MessageBox.Show("Usuario atualizado com sucesso!");
                    dataGridViewFornecedor.Enabled = true;
                    txtNome.Focus();
                } else {
                    trueSalvarfalseAlterar = true;
                    habilitarBotoes(true, false, false, false, false);
                    MessageBox.Show("Erro ao atualizar o usuario");
                    dataGridViewFornecedor.Enabled = true;
                }
            }
        }

        public void carregarGrid() {
            codigoFornecedores = int.Parse(dataGridViewFornecedor.CurrentRow.Cells[0].Value.ToString());
            txtNome.Text = dataGridViewFornecedor.CurrentRow.Cells[1].Value.ToString();
            txtTelefone.Text = dataGridViewFornecedor.CurrentRow.Cells[2].Value.ToString();
            txtObservacoes.Text = dataGridViewFornecedor.CurrentRow.Cells[3].Value.ToString();
            txtNome.Enabled = false;
            txtTelefone.Enabled = false;
            txtObservacoes.Enabled = false;
            habilitarBotoes(false, true, false, true, false);
            btnCancelar.Enabled = true;

        }

        private void btnNovo_Click(object sender, EventArgs e) {

            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
            if (quemPode.Equals(setor) || setor.Equals("Desenvolvimento")) {
                trueSalvarfalseAlterar = true;
                dataGridViewFornecedor.Enabled = false;
                limparCampos(true, true);
                txtNome.Focus();
                habilitarBotoes(false, false, true, false, true);
            } else {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de " + quemPode);
            }



        }

        private void btnAlterar_Click(object sender, EventArgs e) {

            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
            if (quemPode.Equals(setor) || setor.Equals("Desenvolvimento")) {
            habilitarBotoes(false, false, true, false, true);
            habilitarCampos();
            trueSalvarfalseAlterar = false;
            dataGridViewFornecedor.Enabled = false;
            } else {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de " + quemPode);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            trueSalvarfalseAlterar = true;
            limparCampos(false, false);
            habilitarBotoes(true, false, false, false, false);
            dataGridViewFornecedor.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e) {

            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
            if (quemPode.Equals(setor) || setor.Equals("Desenvolvimento")) {
            // Initializes the variables to pass to the MessageBox.Show method.
            string message = "Deseja excluir o fornecedor (" + dataGridViewFornecedor.CurrentRow.Cells[1].Value.ToString() + ")\n\nImpossível reverter";
            string caption = "EXCLUIR CLIENTE";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes) {
                if (modelFornecedores.deletarFornecedoresController(dataGridViewFornecedor.CurrentRow.Cells[0].Value.ToString())) {
                    carrgarFornecedores();
                    trueSalvarfalseAlterar = true;
                    habilitarBotoes(true, false, false, false, false);
                    limparCampos(false, false);
                    MessageBox.Show("Fornecedore deletado com sucesso!");
                    txtNome.Text = "";
                    codigoFornecedores = -1;
                    txtNome.Focus();
                } else {
                    MessageBox.Show("Erro ao deletar o usuario.");
                }
            }
            } else {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de " + quemPode);
            }


        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            if (!txtNome.Text.Trim().Equals("") || txtNome.Text.Trim().Length > 4) {
                if (!txtTelefone.Text.Trim().Equals("") || txtNome.Text.Trim().Length > 4) {
                    if (txtObservacoes.Text.Equals("")) {
                        observacao = "Sem informações adicionais";
                    } else {
                        observacao = txtObservacoes.Text;
                    }
                    gravarDados(trueSalvarfalseAlterar);
                } else {
                    MessageBox.Show("A cidade inserido é inválida");
                    txtNome.Focus();
                }
            } else {
                MessageBox.Show("O nome inserido é inválido");
                txtNome.Focus();
            }
        }

        private void dataGridViewFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            habilitarBotoes(false, true, false, true, false);
            carregarGrid();
        }

        private void dataGridViewFornecedor_CellClick(object sender, DataGridViewCellEventArgs e) {
            habilitarBotoes(false, true, false, true, false);
            carregarGrid();
        }
    }
}
