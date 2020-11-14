using Revtec_Bioquimica.Controller;
using Revtec_Bioquimica.Model;
using Microsoft.VisualBasic;
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
    public partial class Estoque : Form {
        String nomeProduto = "", nomeProdutoParaEnvase = "";
        int nomeEmabalagem, nomeTampa, nomeCaixa, nomeMateriaPrima;
        int idUsuario;
        public Estoque(int id) {
            InitializeComponent();
            idUsuario = id;
            exibirEstoque();
            carrgarGridLotes("estoque");
            carrgarEmbalagens();
            carrgarTampa();
            carrgarCaixas();
            carrgarMateriaPrima();
        }

        public void carrgarMateriaPrima() {
            ModelMateriaPrima modelMateriaPrima = new ModelMateriaPrima();
            try {
                dataGridViewMateriaPrima.DataSource = modelMateriaPrima.exibirTabelaMateriaPrima();

                dataGridViewMateriaPrima.Columns[1].HeaderText = "Nome do item";
                DataGridViewColumn coluna1 = dataGridViewMateriaPrima.Columns[1];
                coluna1.Width = 288;

                dataGridViewMateriaPrima.Columns[2].HeaderText = "Quantidade em estoque";
                DataGridViewColumn coluna2 = dataGridViewMateriaPrima.Columns[2];
                coluna2.Width = 148;

                dataGridViewMateriaPrima.Columns[3].Visible = false; // materiaprima_estoque

                dataGridViewMateriaPrima.Columns[0].Visible = false; // materiaprima_estoque
            } catch {
                MessageBox.Show("Erro ao buscar os produtos.");
            }
        }

        public void carrgarCaixas() {
            ModelCaixas modelCaixas = new ModelCaixas();
            try {
                dataGridViewCaixas.DataSource = modelCaixas.exibirTabelaCaixas();

                dataGridViewCaixas.Columns[1].HeaderText = "Nome do item";
                DataGridViewColumn coluna1 = dataGridViewCaixas.Columns[1];
                coluna1.Width = 288;

                dataGridViewCaixas.Columns[2].HeaderText = "Quantidade em estoque";
                DataGridViewColumn coluna2 = dataGridViewCaixas.Columns[2];
                coluna2.Width = 148;

                dataGridViewCaixas.Columns[0].Visible = false; // caixas_estoque

                dataGridViewCaixas.Columns[3].Visible = false; // caixas_estoque

                dataGridViewCaixas.Columns[4].Visible = false; // caixas_estoque

                dataGridViewCaixas.Columns[5].Visible = false; // altura
                dataGridViewCaixas.Columns[6].Visible = false; // largura
                dataGridViewCaixas.Columns[7].Visible = false; // comprimento
            } catch {
                MessageBox.Show("Erro ao buscar os produtos.");
            }
        }

        public void carrgarTampa() {
            ModelTampa modelTampa = new ModelTampa();
            try {
                dataGridViewTampa.DataSource = modelTampa.exibirTabelaTampa();

                dataGridViewTampa.Columns[1].HeaderText = "Nome do item";
                DataGridViewColumn coluna1 = dataGridViewTampa.Columns[1];
                coluna1.Width = 288;

                dataGridViewTampa.Columns[2].HeaderText = "Quantidade em estoque";
                DataGridViewColumn coluna2 = dataGridViewTampa.Columns[2];
                coluna2.Width = 148;

                dataGridViewTampa.Columns[0].Visible = false; // tampa_estoque

                dataGridViewTampa.Columns[3].Visible = false; // tampa_estoque

                dataGridViewTampa.Columns[4].Visible = false; // tampa_estoque
            } catch {
                MessageBox.Show("Erro ao buscar os produtos.");
            }
        }

        public void carrgarEmbalagens() {
            ModelEmbalagens modelEmbalagens = new ModelEmbalagens();
            try {
                dataGridViewEmbalagens.DataSource = modelEmbalagens.exibirTabelaEmbalagens();

                dataGridViewEmbalagens.Columns[1].HeaderText = "Embalagem";
                DataGridViewColumn coluna1 = dataGridViewEmbalagens.Columns[1];
                coluna1.Width = 288;

                dataGridViewEmbalagens.Columns[2].HeaderText = "Quantidade em estoque";
                DataGridViewColumn coluna2 = dataGridViewEmbalagens.Columns[2];
                coluna2.Width = 148;

                dataGridViewEmbalagens.Columns[0].Visible = false; // embalagens_estoque

                dataGridViewEmbalagens.Columns[3].Visible = false; // embalagens_estoqu

                dataGridViewEmbalagens.Columns[4].Visible = false; // embalagens_estoqu

            } catch {
                MessageBox.Show("Erro ao buscar os intens.");
            }
        }

        private void dataGridViewLotes_CellClick(object sender, DataGridViewCellEventArgs e) {
            nomeProduto = dataGridViewLotes.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridViewLotesParaEnvase_CellClick(object sender, DataGridViewCellEventArgs e) {
            nomeProdutoParaEnvase = dataGridViewLotesParaEnvase.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridViewEmbalagens_CellClick(object sender, DataGridViewCellEventArgs e) {
            nomeEmabalagem = int.Parse(dataGridViewEmbalagens.CurrentRow.Cells[0].Value.ToString());
        }

        private void dataGridViewTampa_CellClick(object sender, DataGridViewCellEventArgs e) {
            nomeTampa = int.Parse(dataGridViewTampa.CurrentRow.Cells[0].Value.ToString());
        }

        private void dataGridViewCaixas_CellClick(object sender, DataGridViewCellEventArgs e) {
            nomeCaixa = int.Parse(dataGridViewCaixas.CurrentRow.Cells[0].Value.ToString());
        }

        private void dataGridViewMateriaPrima_CellClick(object sender, DataGridViewCellEventArgs e) {
            nomeMateriaPrima = int.Parse(dataGridViewMateriaPrima.CurrentRow.Cells[0].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e) {

            


        }

        private void button2_Click(object sender, EventArgs e) {

            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
            if (setor.Equals("Produção") || setor.Equals("Desenvolvimento")) {

                if (nomeEmabalagem > 0) {
                    ModelEmbalagens modelEmbalagens = new ModelEmbalagens();
                    ControllerEmbalagens controllerEmbalagens = new ControllerEmbalagens();
                    modelEmbalagens = controllerEmbalagens.recuperarDadosEmbalagensPeloId(nomeEmabalagem);
                    try {
                        int novaQuantidade = int.Parse(Interaction.InputBox("Informe a nova quantidade", "Informe a quantidade", string.Empty, -1, -1).Replace(".", ","));
                        if (novaQuantidade < 0) {
                            MessageBox.Show("Você não pode informar um valor negativo.");
                        } else {
                            modelEmbalagens.Embalagens_estoque = novaQuantidade;
                            if (controllerEmbalagens.atualizarEmbalagensController(modelEmbalagens)) {
                                carrgarEmbalagens();
                                nomeEmabalagem = 0;
                                MessageBox.Show("A quantidade de embalagens foi atualizada com sucesso.");
                            }
                        }
                    } catch {
                        MessageBox.Show("Ops!!! você inseriu um valor inválido.");
                    }
                } else {
                    MessageBox.Show("Selecione uma embalagem para alterar.");
                }

            } else {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de Produção");
            }


        }

        public void carrgarGridLotes(String situacao) {

            ModelLote modelLote = new ModelLote();
            dataGridViewLotesParaEnvase.DataSource = modelLote.pesquisarTabelaLote(situacao);

            try {

                dataGridViewLotesParaEnvase.Columns[2].HeaderText = "Produto";
                dataGridViewLotesParaEnvase.Columns["lote_produto"].DisplayIndex = 0;
                DataGridViewColumn coluna1 = dataGridViewLotesParaEnvase.Columns[2];
                coluna1.Width = 298;

                dataGridViewLotesParaEnvase.Columns[5].HeaderText = "Litragem em estoque";
                dataGridViewLotesParaEnvase.Columns["lote_litragem"].DisplayIndex = 1;
                DataGridViewColumn coluna2 = dataGridViewLotesParaEnvase.Columns[5];
                coluna2.Width = 138;

                dataGridViewLotesParaEnvase.Columns[0].Visible = false; // lote_id
                dataGridViewLotesParaEnvase.Columns[1].Visible = false; // lote_numero
                //dataGridViewLotesParaEnvase.Columns[2].Visible = false; // lote_produto
                dataGridViewLotesParaEnvase.Columns[3].Visible = false; // lote_fabricacao
                dataGridViewLotesParaEnvase.Columns[4].Visible = false; // lote_validade
                //dataGridViewLotesParaEnvase.Columns[5].Visible = false; // lote_litragem
                dataGridViewLotesParaEnvase.Columns[6].Visible = false; // lote_observacao
                dataGridViewLotesParaEnvase.Columns[7].Visible = false; // lote_status
                dataGridViewLotesParaEnvase.Columns[8].Visible = false; // lote_status
                dataGridViewLotesParaEnvase.Columns[9].Visible = false; // lote_status

            } catch (Exception e) {
                MessageBox.Show("Erro ao buscar os produtos." + e.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e) {

            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
            if (setor.Equals("Produção") || setor.Equals("Desenvolvimento")) {

                if (nomeTampa > 0) {
                    ModelTampa modelTampa = new ModelTampa();
                    ControllerTampa controllerTampa = new ControllerTampa();
                    modelTampa = controllerTampa.recuperarDadosDaTampa(nomeTampa);
                    try {
                        int novaQuantidade = int.Parse(Interaction.InputBox("Informe a nova quantidade", "Informe a quantidade", string.Empty, -1, -1).Replace(".", ","));
                        if (novaQuantidade < 0) {
                            MessageBox.Show("Você não pode informar um valor negativo.");
                        } else {
                            modelTampa.Tampa_estoque = novaQuantidade;
                            if (controllerTampa.atualizarTampaController(modelTampa)) {
                                carrgarTampa();
                                nomeTampa = 0;
                                MessageBox.Show("A quantidade de tampa foi atualizada com sucesso.");
                            }
                        }
                    } catch {
                        MessageBox.Show("Ops!!! você inseriu um valor inválido.");
                    }
                } else {
                    MessageBox.Show("Selecione um item para alterar.");
                }

            } else {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de Produção");
            }


        }

        private void button4_Click(object sender, EventArgs e) {

            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
            if (setor.Equals("Produção") || setor.Equals("Desenvolvimento")) {

                if (nomeCaixa > 0) {
                    ModelCaixas modelCaixas = new ModelCaixas();
                    ControllerCaixas controllerCaixas = new ControllerCaixas();
                    modelCaixas = controllerCaixas.recuperarCaixaPeloId(nomeCaixa);
                    try {
                        int novaQuantidade = int.Parse(Interaction.InputBox("Informe a nova quantidade", "Informe a quantidade", string.Empty, -1, -1).Replace(".", ","));
                        if (novaQuantidade < 0) {
                            MessageBox.Show("Você não pode informar um valor negativo.");
                        } else {
                            modelCaixas.Caixas_estoque = novaQuantidade;
                            if (controllerCaixas.atualizarCaixasController(modelCaixas)) {
                                carrgarCaixas();
                                nomeCaixa = 0;
                                MessageBox.Show("A quantidade de caixa foi atualizada com sucesso.");
                            }
                        }
                    } catch {
                        MessageBox.Show("Ops!!! você inseriu um valor inválido.");
                    }
                } else {
                    MessageBox.Show("Selecione um item para alterar.");
                }

            } else {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de Produção");
            }


        }

        private void button5_Click(object sender, EventArgs e) {

            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
            if (setor.Equals("Química") || setor.Equals("Desenvolvimento")) {

                if (nomeMateriaPrima > 0) {
                    ModelMateriaPrima modelMateriaPrima = new ModelMateriaPrima();
                    ControllerMateriaPrima controllerMateriaPrima = new ControllerMateriaPrima();
                    modelMateriaPrima = controllerMateriaPrima.recuperarMateriaPrima(nomeMateriaPrima);
                    try {
                        double novaQuantidade = double.Parse(Interaction.InputBox("Informe a nova quantidade", "Informe a quantidade", string.Empty, -1, -1).Replace(".", ","));
                        if (novaQuantidade < 0) {
                            MessageBox.Show("Você não pode informar um valor negativo.");
                        } else {
                            modelMateriaPrima.MateriaPrima_estoque = novaQuantidade;
                            if (controllerMateriaPrima.atualizarMateriaPrimaController(modelMateriaPrima)) {
                                carrgarMateriaPrima();
                                nomeMateriaPrima = 0;
                                MessageBox.Show("A quantidade de matéria prima foi atualizada com sucesso.");
                            }
                        }
                    } catch {
                        MessageBox.Show("Ops!!! você inseriu um valor inválido.");
                    }
                } else {
                    MessageBox.Show("Selecione um item para alterar.");
                }

            } else {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de Química");
            }



        }

        private void button7_Click(object sender, EventArgs e)
        {
            carrgarGridLotes("Todos");
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            carrgarGridLotes("Todos");
        }

        private void exibirEstoque() {
            ModelProdutoAcabado modelLote = new ModelProdutoAcabado();
            ControllerProdutoAcabado controllerLote = new ControllerProdutoAcabado();

            dataGridViewLotes.DataSource = modelLote.exibirTabelaProdutos();

            try {

                dataGridViewLotes.Columns[1].HeaderText = "Produto";
                dataGridViewLotes.Columns["pro_nome"].DisplayIndex = 0;
                DataGridViewColumn coluna1 = dataGridViewLotes.Columns[1];
                coluna1.Width = 288;

                dataGridViewLotes.Columns[2].HeaderText = "Quantidade";
                dataGridViewLotes.Columns["prod_estoque"].DisplayIndex = 1;
                DataGridViewColumn coluna2 = dataGridViewLotes.Columns[2];
                coluna2.Width = 148;

                dataGridViewLotes.Columns[4].Visible = false; // pro_id

                dataGridViewLotes.Columns[0].Visible = false; // pro_id
                //dataGridViewLotes.Columns[1].Visible = false; // pro_nome
                //dataGridViewLotes.Columns[2].Visible = false; // prod_estoque
                dataGridViewLotes.Columns[3].Visible = false; // pro_observacao
                //dataGridViewLotes.Columns[4].Visible = false; // pro_peso


            } catch (Exception e) {
                MessageBox.Show("Erro ao buscar os produtos." + e.Message);
            }
        }

        private void dataGridViewLotes_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void dataGridViewLotes_CellContentClick_1(object sender, DataGridViewCellEventArgs e) {

        }

        private void button6_Click(object sender, EventArgs e) {

            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
            if (setor.Equals("Produção") || setor.Equals("Desenvolvimento")) {

                if (!nomeProduto.Equals("")) {
                    ModelProdutoAcabado modelProdutoAcabado = new ModelProdutoAcabado();
                    ControllerProdutoAcabado controllerProdutoAcabado = new ControllerProdutoAcabado();
                    modelProdutoAcabado = controllerProdutoAcabado.recuperarDadosProdutoAcabado(nomeProduto);
                    try {
                        int novaQuantidade = int.Parse(Interaction.InputBox("Informe a nova quantidade", "Informe a quantidade", string.Empty, -1, -1).Replace(".", ","));
                        if (novaQuantidade < 0) {
                            MessageBox.Show("Você não pode informar um valor negativo.");
                        } else {
                            modelProdutoAcabado.Pro_estoque = novaQuantidade;
                            if (controllerProdutoAcabado.atualizarProdutoController(modelProdutoAcabado)) {
                                exibirEstoque();
                                nomeProduto = "";
                                MessageBox.Show("A quantidade de produto envasado atualizada com sucesso.");
                            }
                        }
                    } catch {
                        MessageBox.Show("Ops!!! você inseriu um valor inválido.");
                    }
                } else {
                    MessageBox.Show("Selecione um produto para alterar.");
                }

            } else {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de Produção");
            }




        }
    }
}
