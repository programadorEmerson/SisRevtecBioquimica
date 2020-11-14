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
    public partial class Rotulos : Form {

        int idRotulo = 0;
        int idUsuario;
        String quemPode = "Rotulagem";

        public Rotulos(int id) {
            InitializeComponent();
            carrgarGridRotulos("Todos");
            btnStatusLancado.BackColor = Color.FloralWhite;
            buttonItemConcluido.BackColor = Color.LightGreen;
            idUsuario = id;
            button5.BackColor = Color.FromArgb(0, Color.Transparent);
            button1.BackColor = Color.FromArgb(0, Color.Transparent);
        }

        private void carrgarGridRotulos(string v) {
            ModelRotulos modelLote = new ModelRotulos();
            ControllerRotulos controllerLote = new ControllerRotulos();

            dataGridViewLotes.DataSource = modelLote.exibirTabelaRotulos(v);

            try {

                dataGridViewLotes.Columns[8].HeaderText = "Quantidade";
                dataGridViewLotes.Columns["rotulo_quantidade"].DisplayIndex = 4;
                DataGridViewColumn coluna1 = dataGridViewLotes.Columns[8];
                coluna1.Width = 90;

                dataGridViewLotes.Columns[1].HeaderText = "Produto";
                dataGridViewLotes.Columns["rotulo_produto"].DisplayIndex = 3;
                DataGridViewColumn coluna2 = dataGridViewLotes.Columns[1];
                coluna2.Width = 200;

                dataGridViewLotes.Columns[9].HeaderText = "Litragem";
                dataGridViewLotes.Columns["rotulo_litragem"].DisplayIndex = 5;
                DataGridViewColumn coluna3 = dataGridViewLotes.Columns[9];
                coluna3.Width = 90;

                dataGridViewLotes.Columns[5].HeaderText = "Lote Nro.";
                dataGridViewLotes.Columns["rotulo_lote"].DisplayIndex = 2;
                DataGridViewColumn coluna4 = dataGridViewLotes.Columns[5];
                coluna4.Width = 90;

                dataGridViewLotes.Columns[6].HeaderText = "Fabricação";
                dataGridViewLotes.Columns["rotulo_fabricacao"].DisplayIndex = 6;
                DataGridViewColumn coluna5 = dataGridViewLotes.Columns[7];
                coluna5.Width = 90;

                dataGridViewLotes.Columns[2].HeaderText = "Pedido";
                dataGridViewLotes.Columns["rotulo_guia"].DisplayIndex = 1;
                DataGridViewColumn coluna6 = dataGridViewLotes.Columns[2];
                coluna6.Width = 90;

                dataGridViewLotes.Columns[4].HeaderText = "Cliente";
                dataGridViewLotes.Columns["rotulo_cliente"].DisplayIndex = 7;
                DataGridViewColumn coluna7 = dataGridViewLotes.Columns[4];
                coluna7.Width = 200;

                dataGridViewLotes.Columns[10].HeaderText = "Situação";
                dataGridViewLotes.Columns["rotulo_status"].DisplayIndex = 8;
                DataGridViewColumn coluna8 = dataGridViewLotes.Columns[10];
                coluna8.Width = 90;

                dataGridViewLotes.Columns[0].Visible = false;
                dataGridViewLotes.Columns[3].Visible = false;
                dataGridViewLotes.Columns[7].Visible = false;
                dataGridViewLotes.Columns[11].Visible = false;

                foreach (DataGridViewRow row in dataGridViewLotes.Rows) {
                    if (row.Cells[10].Value.ToString().Equals("Aguardando")) {
                        row.DefaultCellStyle.BackColor = Color.Gold;
                    } else if (row.Cells[10].Value.ToString().Equals("Concluído")) {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                }


            } catch (Exception e) {
                MessageBox.Show("Erro ao buscar os produtos." + e.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e) {

            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
            if (quemPode.Equals(setor) || setor.Equals("Desenvolvimento") || setor.Equals("Produção")) {
                if (idRotulo == 0) {
                    MessageBox.Show("Selecione um rótulo no grid");
                } else {
                    ControllerRotulos controllerRotulos = new ControllerRotulos();
                    ModelRotulos modelRotulos = new ModelRotulos();
                    modelRotulos = controllerRotulos.recuperarRotuloPeloId(idRotulo);
                    if (modelRotulos.Rotulo_status.Equals("Concluído")) {
                        MessageBox.Show("Este rótulo já foi concluído");
                    } else {
                        modelRotulos.Rotulo_status = "Concluído";
                        if (controllerRotulos.atualizarRotulo(modelRotulos)) {
                            carrgarGridRotulos("Todos");
                            idRotulo = 0;
                            MessageBox.Show("Rótulo concluído com sucesso, notifique o setor de rotulagem.");
                        }
                    }
                }
            } else {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de " + quemPode);
            }
        }

        private void button5_Click(object sender, EventArgs e) {
            carrgarGridRotulos("Todos");
        }

        private void button3_Click(object sender, EventArgs e) {
            carrgarGridRotulos("Concluído");
        }

        private void button2_Click(object sender, EventArgs e) {
            carrgarGridRotulos("Aguardando");
        }

        private void dataGridViewLotes_CellClick(object sender, DataGridViewCellEventArgs e) {
            idRotulo = int.Parse(dataGridViewLotes.CurrentRow.Cells[0].Value.ToString());
        }

        private void label17_Click(object sender, EventArgs e) {

        }

        private void label14_Click(object sender, EventArgs e) {

        }

        private void buttonItemConcluido_Click(object sender, EventArgs e) {
            carrgarGridRotulos("Concluído");
        }

        private void btnStatusLancado_Click(object sender, EventArgs e) {
            carrgarGridRotulos("Em produção");
        }

        private void dataGridViewLotes_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
