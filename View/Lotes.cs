using Microsoft.VisualBasic;
using Revtec_Bioquimica.Controller;
using Revtec_Bioquimica.DAO;
using Revtec_Bioquimica.Model;
using Revtec_Bioquimica.Relatorio;
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
    public partial class Lotes : Form {

        String numeroLote = "0";
        String quemPode = "Química";
        int idUsuario;
        int idDoLote, loteIdAmostra;
        String loteNumero, loteProduto, loteFabricacao, loteValidade, loteObservacao, loteStatus;
        double loteLitragem, loteLitragemFeita;

        public Lotes(int id) {
            InitializeComponent();
            idUsuario = id;
            carrgarGridLotes("Todos");
            exibirLoteLaboratorio();
            btnStatusLancado.BackColor = Color.FloralWhite;
            buttonItemConcluido.BackColor = Color.LightGreen;
            button6.BackColor = Color.LightSkyBlue;


        }

        private void exibirLoteLaboratorio()
        {
            ControllerLoteLaboratorio controllerLoteLaboratorio = new ControllerLoteLaboratorio();
            dataGridViewLoteLaboratorio.DataSource = controllerLoteLaboratorio.exibirLotesLaboratorio();

            try
            {

                dataGridViewLoteLaboratorio.Columns[0].HeaderText = "ID";
                dataGridViewLoteLaboratorio.Columns["id_lote"].DisplayIndex = 0;
                DataGridViewColumn coluna0 = dataGridViewLoteLaboratorio.Columns[0];
                coluna0.Width = 50;

                dataGridViewLoteLaboratorio.Columns[1].HeaderText = "LOTE";
                dataGridViewLoteLaboratorio.Columns["numero_lote"].DisplayIndex = 1;
                DataGridViewColumn coluna1 = dataGridViewLoteLaboratorio.Columns[1];
                coluna1.Width = 90;

                dataGridViewLoteLaboratorio.Columns[2].HeaderText = "DATA";
                dataGridViewLoteLaboratorio.Columns["data_lote"].DisplayIndex = 2;
                DataGridViewColumn coluna2 = dataGridViewLoteLaboratorio.Columns[2];
                coluna2.Width = 90;

                dataGridViewLoteLaboratorio.Columns[3].HeaderText = "PRODUTO";
                dataGridViewLoteLaboratorio.Columns["produto_lote"].DisplayIndex = 3;
                DataGridViewColumn coluna3 = dataGridViewLoteLaboratorio.Columns[3];
                coluna3.Width = 200;

                dataGridViewLoteLaboratorio.Columns[4].HeaderText = "LITRAGEM";
                dataGridViewLoteLaboratorio.Columns["litragem_lote"].DisplayIndex = 4;
                DataGridViewColumn coluna4 = dataGridViewLoteLaboratorio.Columns[4];
                coluna4.Width = 80;

                dataGridViewLoteLaboratorio.Columns[5].HeaderText = "CLIENTE";
                dataGridViewLoteLaboratorio.Columns["cliente_lote"].DisplayIndex = 5;
                DataGridViewColumn coluna5 = dataGridViewLoteLaboratorio.Columns[5];
                coluna5.Width = 200;


            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao buscar os produtos." + e.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e) {

            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
            if (quemPode.Equals(setor) || setor.Equals("Desenvolvimento") || setor.Equals("Produção")) {
                if (numeroLote.Equals("0")) {
                    MessageBox.Show("Selecione um lote no grid");
                } else {

                    ModelLote modelLote = new ModelLote();
                    ControllerLote controllerLote = new ControllerLote();
                    modelLote = controllerLote.recuperarDadosDaLote(numeroLote);

                    if (modelLote.Lote_status.Equals("Concluído")) {
                        MessageBox.Show("Este lote já foi concluído");
                    } else if (modelLote.Lote_status.Equals("Finalizado")) {
                        MessageBox.Show("Este lote já foi finalizado");
                    }
                    if (modelLote.Lote_status.Equals("Aguardando")) {

                        // Initializes the variables to pass to the MessageBox.Show method.
                        string message = "Confirma a produção somente para a litragem de " + modelLote.Lote_litragem.ToString().Replace("-", "") + " ?";
                        string caption = "Confirmação de litragem produzida";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result;

                        // Displays the MessageBox.
                        result = MessageBox.Show(message, caption, buttons);
                        if (result == DialogResult.Yes) {                           
                            try {
                                int validadeEmMes = int.Parse(Interaction.InputBox("Qual a validade em meses do produto?", "Validade em meses", string.Empty, -1, -1).Replace(".", ","));
                                modelLote.Lote_fabricacao = DateTime.Now.AddDays(0).ToString("dd/MM/yyyy");
                                modelLote.Lote_validade = DateTime.Now.AddMonths(validadeEmMes).ToString("dd/MM/yyyy");
                                modelLote.Lote_status = "Concluído";
                                modelLote.Lote_litragem = double.Parse(modelLote.Lote_litragem.ToString().Replace("-", ""));
                                modelLote.Lote_litragemFeita = double.Parse(modelLote.Lote_litragem.ToString().Replace("-", ""));
                                if (controllerLote.atualizarLoteController(modelLote)) {
                                    carrgarGridLotes("Todos");
                                    MessageBox.Show("Lote concluído com sucesso, comunique ao setor de produção dos rótulos");
                                    numeroLote = "0";
                                }

                            } catch (Exception) {
                                MessageBox.Show("A validade informada é inválida");
                            }
                            
                        } else {
                            try {
                                double novaLitragem = double.Parse(Interaction.InputBox("Informe a litragem produzida", "Informe a litragem", string.Empty, -1, -1).Replace(".", ","));
                                try {
                                    int validadeEmMes = int.Parse(Interaction.InputBox("Qual a validade em meses do produto?", "Validade em meses", string.Empty, -1, -1).Replace(".", ","));
                                    modelLote.Lote_fabricacao = DateTime.Now.AddDays(0).ToString("dd/MM/yyyy");
                                    modelLote.Lote_validade = DateTime.Now.AddMonths(validadeEmMes).ToString("dd/MM/yyyy");
                                    modelLote.Lote_status = "Concluído";
                                    modelLote.Lote_litragem = novaLitragem;
                                    modelLote.Lote_litragemFeita = novaLitragem;
                                    if (controllerLote.atualizarLoteController(modelLote)) {
                                        carrgarGridLotes("Todos");
                                        MessageBox.Show("Lote concluído com a nova litragem de " + novaLitragem.ToString() + " litros com sucesso, comunique ao setor de produção dos rótulos");
                                        numeroLote = "0";
                                    }
                                } catch (Exception) {
                                    MessageBox.Show("A validade informada é inválida");
                                }

                            } catch (Exception) {
                                MessageBox.Show("Nova litragem informada inválida");
                            }

                        }
                    }
                }
            } else {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de " + quemPode);
            }



        }

        public void carrgarGridLotes(String situacao) {

            ModelLote modelLote = new ModelLote();
            dataGridViewLotes.DataSource = modelLote.pesquisarTabelaLote(situacao);

            try {

                dataGridViewLotes.Columns[1].HeaderText = "Nro. Lote.";
                dataGridViewLotes.Columns["lote_numero"].DisplayIndex = 0;
                DataGridViewColumn coluna1 = dataGridViewLotes.Columns[1];
                coluna1.Width = 90;

                dataGridViewLotes.Columns[2].HeaderText = "Produto";
                dataGridViewLotes.Columns["lote_produto"].DisplayIndex = 1;
                DataGridViewColumn coluna2 = dataGridViewLotes.Columns[2];
                coluna2.Width = 150;

                dataGridViewLotes.Columns[5].HeaderText = "Litragem";
                dataGridViewLotes.Columns["lote_litragem"].DisplayIndex = 3;
                DataGridViewColumn coluna3 = dataGridViewLotes.Columns[5];
                coluna3.Width = 90;

                dataGridViewLotes.Columns[7].HeaderText = "Situação";
                dataGridViewLotes.Columns["lote_status"].DisplayIndex = 4;
                DataGridViewColumn coluna4 = dataGridViewLotes.Columns[7];
                coluna4.Width = 93;

                dataGridViewLotes.Columns[3].HeaderText = "Fabricação";
                dataGridViewLotes.Columns["lote_fabricacao"].DisplayIndex = 2;
                DataGridViewColumn coluna5 = dataGridViewLotes.Columns[3];
                coluna5.Width = 93;


                dataGridViewLotes.Columns[0].Visible = false; // lote_id
                //dataGridViewLotes.Columns[1].Visible = false; // lote_numero
                //dataGridViewLotes.Columns[2].Visible = false; // lote_produto
                //dataGridViewLotes.Columns[3].Visible = false; // lote_fabricacao
                dataGridViewLotes.Columns[4].Visible = false; // lote_validade
                //dataGridViewLotes.Columns[5].Visible = false; // lote_litragem
                dataGridViewLotes.Columns[6].Visible = false; // lote_observacao
                //dataGridViewLotes.Columns[7].Visible = false; // lote_status
                dataGridViewLotes.Columns[8].Visible = false; // lote_status
                dataGridViewLotes.Columns[9].Visible = false; // lote_status
                CorNaLinha();

            }
            catch (Exception e) {
                MessageBox.Show("Erro ao buscar os produtos." + e.Message);
            }
        }

        private void CorNaLinha() {

            foreach (DataGridViewRow row in dataGridViewLotes.Rows) {
                if (row.Cells[7].Value.ToString().Equals("Aguardando")) {
                    row.DefaultCellStyle.BackColor = Color.FloralWhite;
                } else if (row.Cells[7].Value.ToString().Equals("Concluído")) {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                } else if (row.Cells[7].Value.ToString().Equals("Finalizado")) {
                    row.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                }
            }

        }

        private void button5_Click(object sender, EventArgs e) {
            CorNaLinha();
        }

        private void button4_Click(object sender, EventArgs e) {
            carrgarGridLotes("Finalizado");
        }

        private void button3_Click(object sender, EventArgs e) {
            carrgarGridLotes("Concluído");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
            if (setor.Equals("Química") || setor.Equals("Desenvolvimento") || setor.Equals("Produção"))
            {

                if (!loteNumero.Equals(""))
                {
                    ModelLote modelLote = new ModelLote();
                    ControllerLote controllerLote = new ControllerLote();

                    modelLote.Lote_id = idDoLote;
                    modelLote.Lote_idAmostra = loteIdAmostra;
                    modelLote.Lote_litragem = loteLitragem;
                    modelLote.Lote_litragemFeita = loteLitragemFeita;
                    modelLote.Lote_numero = loteNumero;
                    modelLote.Lote_produto = loteProduto;
                    modelLote.Lote_fabricacao = loteFabricacao;
                    modelLote.Lote_validade = loteValidade;
                    modelLote.Lote_observacao = loteObservacao;
                    modelLote.Lote_status = loteStatus;

                    try
                    {
                        double novaQuantidade = double.Parse(Interaction.InputBox("Informe a nova litragem", "Informe a litragem", string.Empty, -1, -1).Replace(".", ","));
                        if (novaQuantidade < 0)
                        {
                            MessageBox.Show("Você não pode informar um valor negativo.");
                        }
                        else
                        {
                            modelLote.Lote_status = "Concluído";
                            modelLote.Lote_litragem = novaQuantidade;
                            if (controllerLote.atualizarLoteController(modelLote))
                            {

                                ModelOrdemDeProducao ordemDeProducao = new ModelOrdemDeProducao();
                                ordemDeProducao = controllerLote.dadosOP(dataGridViewLotes.CurrentRow.Cells[1].Value.ToString());
                                ordemDeProducao.OrdemQuantidade = novaQuantidade;
                                controllerLote.atualizarOP(ordemDeProducao);

                                carrgarGridLotes("estoque");
                                loteNumero = "";
                                MessageBox.Show("A quantidade de produto para envase atualizada com sucesso.");
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ops!!! você inseriu um valor inválido.");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um produto para alterar.");
                }

            }
            else
            {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de Química");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
            if (quemPode.Equals(setor) || setor.Equals("Desenvolvimento") || setor.Equals("Produção"))
            {
                if (numeroLote.Equals("0"))
                {
                    MessageBox.Show("Selecione um lote no grid");
                }
                else
                {
                    ModelLote modelLote = new ModelLote();
                    ControllerLote controllerLote = new ControllerLote();
                    modelLote = controllerLote.recuperarDadosDaLote(numeroLote);                    
                    // Initializes the variables to pass to the MessageBox.Show method.
                    string message = "Confirma a exclusão do lote " + modelLote.Lote_numero + " ?";
                    string caption = "Confirmação a exclusão?";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    // Displays the MessageBox.
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            DAOLote dAO = new DAOLote();
                            if (dAO.deletarLoteDAO(numeroLote))
                            {
                                try
                                {
                                    ModelOrdemDeProducao ordemDeProducao = new ModelOrdemDeProducao();
                                    ordemDeProducao = controllerLote.dadosOP(numeroLote);
                                    controllerLote.deletarOP(ordemDeProducao);
                                }
                                catch (Exception)
                                {
                                }
                                carrgarGridLotes("Todos");
                                MessageBox.Show("Lote excluído com sucesso");
                            }else
                            {
                                MessageBox.Show("Erro ao excluir o lote");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao excluir o lote "+ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de " + quemPode);
            }
        }

        private void Lotes_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) {
            carrgarGridLotes("Aguardando");
        }

        private void dataGridViewLotes_CellClick(object sender, DataGridViewCellEventArgs e) {
            numeroLote = dataGridViewLotes.CurrentRow.Cells[1].Value.ToString();
            idDoLote = int.Parse(dataGridViewLotes.CurrentRow.Cells[0].Value.ToString());            
            loteNumero = dataGridViewLotes.CurrentRow.Cells[1].Value.ToString();
            loteProduto = dataGridViewLotes.CurrentRow.Cells[2].Value.ToString();
            loteFabricacao = dataGridViewLotes.CurrentRow.Cells[3].Value.ToString();
            loteValidade = dataGridViewLotes.CurrentRow.Cells[4].Value.ToString();
            loteLitragem = double.Parse(dataGridViewLotes.CurrentRow.Cells[5].Value.ToString());
            loteObservacao = dataGridViewLotes.CurrentRow.Cells[6].Value.ToString();
            loteStatus = dataGridViewLotes.CurrentRow.Cells[7].Value.ToString();
            loteLitragemFeita = double.Parse(dataGridViewLotes.CurrentRow.Cells[8].Value.ToString());
            loteIdAmostra = int.Parse(dataGridViewLotes.CurrentRow.Cells[9].Value.ToString());
        }

        private void button6_Click(object sender, EventArgs e) {
            carrgarGridLotes("Finalizado");
        }

        private void buttonItemConcluido_Click(object sender, EventArgs e) {
            carrgarGridLotes("Concluído");
        }

        private void btnStatusLancado_Click(object sender, EventArgs e) {
            carrgarGridLotes("Aguardando");
        }

        private void button7_Click(object sender, EventArgs e) {
            carrgarGridLotes("Todos");
            CorNaLinha();
        }

        private void button8_Click(object sender, EventArgs e) {

            if (numeroLote.Equals("0")) {
                MessageBox.Show("Selecione um lote no grid");
            } else {
                Form f = new FormLotes(idDoLote);
                f.Show();
            }
        }
    }
}
