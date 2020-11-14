using Microsoft.VisualBasic;
using Revtec_Bioquimica.Controller;
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

namespace Revtec_Bioquimica.View
{
    public partial class Expedição : Form
    {
        int numeroDaGuia = -1;
        int idUsuario;
        ModelExpedicao modelExpedicao = new ModelExpedicao();
        String quemPode = "Expedição";

        public Expedição(int id, String filtro)
        {
            InitializeComponent();
            idUsuario = id;
            carrgarExpedicao(filtro, DateTime.Parse(DateTime.Now.AddDays(0).ToString("dd/MM/yyyy")));
            buttonProducao.BackColor = Color.Lavender;
            buttonIConcluido.BackColor = Color.MediumTurquoise;
            buttonEntreguaHoje.BackColor = Color.PaleGoldenrod;
            buttonArazado.BackColor = Color.Tomato;
            buttonEntregue.BackColor = Color.LightGreen;
            CorDalinha();
        }

        public void carrgarExpedicao(String condicao, DateTime data)
        {

            try
            {
                dataGridViewExpedicao.DataSource = modelExpedicao.exibirCarregamentosExpedicao(condicao, data);

                dataGridViewExpedicao.Columns[1].HeaderText = "Pedido.";
                dataGridViewExpedicao.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewExpedicao.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridViewExpedicao.Columns["expedicao_guia"].DisplayIndex = 0;
                dataGridViewExpedicao.Columns["expedicao_guia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataGridViewColumn coluna1 = dataGridViewExpedicao.Columns[1];
                coluna1.Width = 90;

                dataGridViewExpedicao.Columns[2].HeaderText = "Cliente.";
                dataGridViewExpedicao.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewExpedicao.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridViewExpedicao.Columns["expedicao_cliente"].DisplayIndex = 1;
                //dataGridViewExpedicao.Columns["expedicao_volume"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataGridViewColumn coluna2 = dataGridViewExpedicao.Columns[2];
                coluna2.Width = 220;

                dataGridViewExpedicao.Columns[3].HeaderText = "Entrada.";
                dataGridViewExpedicao.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewExpedicao.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridViewExpedicao.Columns["expedicao_dataEntrada"].DisplayIndex = 2;
                dataGridViewExpedicao.Columns["expedicao_dataEntrada"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataGridViewColumn coluna3 = dataGridViewExpedicao.Columns[3];
                coluna3.Width = 89;

                dataGridViewExpedicao.Columns[4].HeaderText = "Entrega.";
                dataGridViewExpedicao.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewExpedicao.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridViewExpedicao.Columns["expedicao_dataEntrega"].DisplayIndex = 3;
                dataGridViewExpedicao.Columns["expedicao_dataEntrega"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataGridViewColumn coluna4 = dataGridViewExpedicao.Columns[4];
                coluna4.Width = 90;

                dataGridViewExpedicao.Columns[5].HeaderText = "Volume.";
                dataGridViewExpedicao.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewExpedicao.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridViewExpedicao.Columns["expedicao_volume"].DisplayIndex = 4;
                dataGridViewExpedicao.Columns["expedicao_volume"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataGridViewColumn coluna5 = dataGridViewExpedicao.Columns[5];
                coluna5.Width = 60;

                dataGridViewExpedicao.Columns[8].HeaderText = "Situação.";
                dataGridViewExpedicao.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewExpedicao.Columns[8].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridViewExpedicao.Columns["expedicao_status"].DisplayIndex = 2;
                dataGridViewExpedicao.Columns["expedicao_status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataGridViewColumn coluna8 = dataGridViewExpedicao.Columns[8];
                coluna8.Width = 90;

                dataGridViewExpedicao.Columns[0].Visible = false; // expedicao_id           
                dataGridViewExpedicao.Columns[9].Visible = false; // expedicao_entregaDate              
                dataGridViewExpedicao.Columns[7].Visible = false; // expedicao_entregaDate              
                dataGridViewExpedicao.Columns[6].Visible = false; // expedicao_entregaDate              

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao buscar os produtos." + e.Message);
            }
            CorDalinha();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (numeroDaGuia <= 0)
            {
                MessageBox.Show("Selecione um pedido.");
            }
            else
            {
                Form f = new Pedidos(numeroDaGuia, idUsuario);
                f.Show();
            }
        }

        private void CorDalinha()
        {

            foreach (DataGridViewRow row in dataGridViewExpedicao.Rows)
            {

                if (row.Cells[8].Value.ToString().Equals("Em produção"))
                {
                    row.DefaultCellStyle.BackColor = Color.Lavender;
                }
                else if (row.Cells[8].Value.ToString().Equals("Concluído"))
                {
                    row.DefaultCellStyle.BackColor = Color.MediumTurquoise;
                }
                else if (row.Cells[8].Value.ToString().Equals("Entregue"))
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }

                if (row.Cells[8].Value.ToString().Equals("Entregue"))
                {
                }
                else
                {
                    if (DateTime.Parse(DateTime.Now.AddDays(0).ToString("dd/MM/yyyy")) == DateTime.Parse(row.Cells[4].Value.ToString()))
                    {
                        row.DefaultCellStyle.BackColor = Color.LemonChiffon;
                    }
                    else if (DateTime.Parse(DateTime.Now.AddDays(0).ToString("dd/MM/yyyy")) > DateTime.Parse(row.Cells[4].Value.ToString()))
                    {
                        row.DefaultCellStyle.BackColor = Color.Tomato;
                    }
                }


            }
        }

        private void dataGridViewExpedicao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                numeroDaGuia = int.Parse(dataGridViewExpedicao.CurrentRow.Cells[1].Value.ToString());
            }
            catch
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CorDalinha();
        }

        private void dataGridViewExpedicao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonProducao_Click(object sender, EventArgs e)
        {
            carrgarExpedicao("Em produção", DateTime.Parse(DateTime.Now.AddDays(0).ToString("dd/MM/yyyy")));
        }

        private void button4_Click(object sender, EventArgs e)
        {


            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
            if (quemPode.Equals(setor) || setor.Equals("Desenvolvimento") || setor.Equals("Recepção"))
            {
                if (numeroDaGuia <= 0)
                {
                    MessageBox.Show("Selecione um pedido para mnarcar como entregue.");
                }
                else
                {

                    if (dataGridViewExpedicao.CurrentRow.Cells[8].Value.ToString().Equals("Entregue"))
                    {
                        MessageBox.Show("Este pedido já foi entregue");
                    }
                    else if (dataGridViewExpedicao.CurrentRow.Cells[8].Value.ToString().Equals("Em produção"))
                    {
                        MessageBox.Show("Este pedido está em produção");
                    }
                    else
                    {
                        ModelExpedicao modelExpedicao = new ModelExpedicao();
                        ControllerExpedicao controllerExpedicao = new ControllerExpedicao();
                        modelExpedicao = controllerExpedicao.recuperarExpedicaoPeloId(numeroDaGuia);
                        modelExpedicao.Expedicao_status = "Entregue";

                        // Initializes the variables to pass to the MessageBox.Show method.
                        string message = "Deseja marcar como entregue, impossível reverter.";
                        string caption = "Marcar como entregue";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result;

                        // Displays the MessageBox.
                        result = MessageBox.Show(message, caption, buttons);
                        if (result == DialogResult.Yes)
                        {
                            if (controllerExpedicao.atualizarClientesController(modelExpedicao))
                            {
                                carrgarExpedicao("Todos", DateTime.Parse(DateTime.Now.AddDays(0).ToString("dd/MM/yyyy")));
                                MessageBox.Show("Item macado como entregue");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de " + quemPode);
            }


        }

        private void buttonArazado_Click(object sender, EventArgs e)
        {
            carrgarExpedicao("Atrazada", DateTime.Parse(DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy")));
        }

        private void buttonIConcluido_Click(object sender, EventArgs e)
        {
            carrgarExpedicao("Concluído", DateTime.Parse(DateTime.Now.AddDays(0).ToString("dd/MM/yyyy")));
        }

        private void buttonEntreguaHoje_Click(object sender, EventArgs e)
        {
            carrgarExpedicao("Hoje", DateTime.Parse(DateTime.Now.AddDays(0).ToString("dd/MM/yyyy")));
        }

        private void buttonEntregue_Click(object sender, EventArgs e)
        {
            carrgarExpedicao("Entregue", DateTime.Parse(DateTime.Now.AddDays(0).ToString("dd/MM/yyyy")));
        }

        private void Expedição_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (numeroDaGuia <= 0)
            {
                MessageBox.Show("Selecione um pedido abaixo");
            }
            else
            {
                Form f = new FormPedidoComIdGuia(numeroDaGuia);
                f.Show();
            }
        }
    }
}
