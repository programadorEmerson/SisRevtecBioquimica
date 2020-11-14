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
    public partial class Clientes : Form {

        bool trueSalvarfalseAlterar = true;
        ModelClientes modelClientes = new ModelClientes();
        int codigoClientes;
        int idUsuario;
        String observacao;
        String quemPode = "Produção";

        public Clientes(int id) {
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

            txtCidade.Text = "";
            txtCidade.Enabled = nome;

            txtObservacoes.Text = "";
            txtObservacoes.Enabled = nome;

            carrgarClientes();

        }

        private void btnNovo_Click(object sender, EventArgs e) {
            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
            if (quemPode.Equals(setor) || setor.Equals("Desenvolvimento")) {
                trueSalvarfalseAlterar = true;
                dataGridViewClientes.Enabled = false;
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
            dataGridViewClientes.Enabled = false;
            } else {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de " + quemPode);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            trueSalvarfalseAlterar = true;
            limparCampos(false, false);
            habilitarBotoes(true, false, false, false, false);
            dataGridViewClientes.Enabled = true;
        }

        public void habilitarCampos() {
            txtNome.Enabled = true;
            txtCidade.Enabled = true;
            txtObservacoes.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e) {

            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
            if (quemPode.Equals(setor) || setor.Equals("Desenvolvimento")) {
            // Initializes the variables to pass to the MessageBox.Show method.
            string message = "Deseja excluir o cliente (" + dataGridViewClientes.CurrentRow.Cells[1].Value.ToString() + ")\n\nImpossível reverter";
            string caption = "EXCLUIR CLIENTE";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes) {
                if (modelClientes.deletarClientesController(dataGridViewClientes.CurrentRow.Cells[0].Value.ToString())) {
                    carrgarClientes();
                    trueSalvarfalseAlterar = true;
                    habilitarBotoes(true, false, false, false, false);
                    limparCampos(false, false);
                    MessageBox.Show("Clientes deletado com sucesso!");
                    txtNome.Text = "";
                    codigoClientes = -1;
                    txtNome.Focus();
                } else {
                    MessageBox.Show("Erro ao deletar o usuario.");
                }
            }
            } else {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de " + quemPode);
            }


        }

        public void carrgarClientes() {

            try {
                dataGridViewClientes.DataSource = modelClientes.exibirTabelaClientes();

                dataGridViewClientes.Columns[0].HeaderText = "ID";
                DataGridViewColumn coluna1 = dataGridViewClientes.Columns[0];
                coluna1.Width = 40;

                dataGridViewClientes.Columns[1].HeaderText = "NOME";
                DataGridViewColumn coluna2 = dataGridViewClientes.Columns[1];
                coluna2.Width = 220;

                dataGridViewClientes.Columns[2].HeaderText = "CIDADE";
                DataGridViewColumn coluna3 = dataGridViewClientes.Columns[2];
                coluna3.Width = 140;

                dataGridViewClientes.Columns[3].HeaderText = "OBSERVAÇÃO";
                DataGridViewColumn coluna4 = dataGridViewClientes.Columns[3];
                coluna4.Width = 92;

            } catch {
                MessageBox.Show("Erro ao buscar os produtos.");
            }
        }

        public void gravarDados(bool acao) {
            if (acao) {
                modelClientes.Clientes_nome = txtNome.Text;
                modelClientes.Clientes_cidade = txtCidade.Text;
                modelClientes.Clientes_observacao = observacao;


                if (modelClientes.salvarClientesController(modelClientes)) {
                    carrgarClientes();
                    trueSalvarfalseAlterar = true;
                    habilitarBotoes(true, false, false, false, false);
                    MessageBox.Show("Cliente salvo com sucesso!");
                    dataGridViewClientes.Enabled = true;
                    limparCampos(false, false);
                } else {
                    trueSalvarfalseAlterar = true;
                    habilitarBotoes(true, false, false, false, false);
                    MessageBox.Show("Erro ao salvar o cliente");
                    dataGridViewClientes.Enabled = true;
                }
            } else {
                modelClientes.Clientes_id = codigoClientes;
                modelClientes.Clientes_nome = txtNome.Text;
                modelClientes.Clientes_cidade = txtCidade.Text;
                modelClientes.Clientes_observacao = observacao;

                if (modelClientes.atualizarClientesController(modelClientes)) {
                    trueSalvarfalseAlterar = true;
                    habilitarBotoes(true, false, false, false, false);
                    limparCampos(false, false);
                    carrgarClientes();
                    MessageBox.Show("Usuario atualizado com sucesso!");
                    dataGridViewClientes.Enabled = true;
                    txtNome.Focus();
                } else {
                    trueSalvarfalseAlterar = true;
                    habilitarBotoes(true, false, false, false, false);
                    MessageBox.Show("Erro ao atualizar o usuario");
                    dataGridViewClientes.Enabled = true;
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            if (!txtNome.Text.Trim().Equals("") || txtNome.Text.Trim().Length > 4) {
                if (!txtCidade.Text.Trim().Equals("") || txtNome.Text.Trim().Length > 4) {
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

        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e) {

            habilitarBotoes(false, true, false, true, false);
            carregarGrid();

        }

        private void dataGridViewClientes_CellBorderStyleChanged(object sender, EventArgs e) {

        }

        public void carregarGrid() {
            codigoClientes = int.Parse(dataGridViewClientes.CurrentRow.Cells[0].Value.ToString());
            txtNome.Text = dataGridViewClientes.CurrentRow.Cells[1].Value.ToString();
            txtCidade.Text = dataGridViewClientes.CurrentRow.Cells[2].Value.ToString();
            txtObservacoes.Text = dataGridViewClientes.CurrentRow.Cells[3].Value.ToString();
            txtNome.Enabled = false;
            txtCidade.Enabled = false;
            txtObservacoes.Enabled = false;
            habilitarBotoes(false, true, false, true, false);
            btnCancelar.Enabled = true;

        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
