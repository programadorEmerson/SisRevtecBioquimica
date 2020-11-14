using Revtec_Bioquimica.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revtec_Bioquimica.Relatorio
{
    public partial class FormSelecaoDeRelatorio : Form
    {
        int idUsuario;
        public FormSelecaoDeRelatorio(int id)
        {
            InitializeComponent();
            idUsuario = id;
            carregarClientes();
            carregarProdutos();
            carregarLitragem();
            comboBox1.Text = "Em Falta";
            comboBox2.Text = "Em Falta";
            comboBox3.Text = "Em Falta";
            comboBox4.Text = "Em Falta";
            comboBox5.Text = "Em Falta";
            comboBox6.Text = "Em Falta";
        }

        private void carregarLitragem()
        {
            DAOClientes dAOClientes = new DAOClientes();
            comboBox9.DisplayMember = "litragem";
            comboBox9.DataSource = dAOClientes.recuperarLitragem();

        }

        private void carregarProdutos()
        {
            DAOProduto dAOClientes = new DAOProduto();
            comboBox8.DisplayMember = "pro_nome";
            comboBox8.DataSource = dAOClientes.recuperarProdutos();

            comboBox11.DisplayMember = "pro_nome";
            comboBox11.DataSource = dAOClientes.recuperarProdutos();

        }

        private void carregarClientes()
        {
            DAOClientes dAOClientes = new DAOClientes();
            comboBox7.DisplayMember = "clientes_nome";
            comboBox7.DataSource = dAOClientes.recuperarClientes();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int numeroPedido = int.Parse(textBox9.Text);

                if (numeroPedido > 0)
                {
                    Form f = new FormPedidoComIdGuia(numeroPedido);
                    f.Show();
                }
                else
                {
                    textBox9.Focus();
                    MessageBox.Show("Digite um pedido com o número maior que 0");
                    textBox9.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Você digitou um pedido inválido");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dataInicial, dataFinal;

            try
            {

                dataInicial = DateTime.Parse(textBox1.Text);

                try
                {
                    dataFinal = DateTime.Parse(textBox2.Text);

                    if (dataInicial > dataFinal)
                    {
                        MessageBox.Show("A data inicial não pode ser maior que a final");
                        textBox2.Focus();
                        textBox2.Text = "";
                    }
                    else
                    {
                        Form f = new FormRelatorioExpedicaoDataInicialDataFinal(dataInicial, dataFinal);
                        f.Show();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Data final informada inválida");
                    textBox2.Focus();
                    textBox2.Text = "";
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Data inicial informada inválida");
                textBox1.Focus();
                textBox1.Text = "";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DateTime dataInicial, dataFinal;
            String cliente = comboBox7.Text;

            try
            {

                dataInicial = DateTime.Parse(textBox8.Text);

                try
                {
                    dataFinal = DateTime.Parse(textBox7.Text);

                    if (dataInicial > dataFinal)
                    {
                        MessageBox.Show("A data inicial não pode ser maior que a final");
                        textBox7.Focus();
                        textBox7.Text = "";
                    }
                    else
                    {
                        Form f = new FormRelatorioVendasPorClienteComData(cliente, dataInicial, dataFinal);
                        f.Show();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Data final informada inválida");
                    textBox7.Focus();
                    textBox7.Text = "";
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Data inicial informada inválida");
                textBox8.Focus();
                textBox8.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            String produto = comboBox8.Text, litragem = comboBox9.Text;
            DateTime inicial, final;

            try
            {

                inicial = DateTime.Parse(textBox4.Text);

                try
                {
                    final = DateTime.Parse(textBox3.Text);

                    if (inicial > final)
                    {
                        MessageBox.Show("A data inicial não pode ser maior que a final");
                        textBox7.Focus();
                        textBox7.Text = "";
                    }
                    else
                    {
                        Form f = new FormVendaPorProduto(produto, litragem, textBox4.Text, textBox3.Text);
                        f.Show();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Data final informada inválida");
                    textBox3.Focus();
                    textBox3.Text = "";
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Data inicial informada inválida");
                textBox4.Focus();
                textBox4.Text = "";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text.Equals("Exibir Todos"))
            {
                Form f = new FormRelatorioProdutoAcabado();
                f.Show();
            }
            else if (comboBox2.Text.Equals("Com Saldo"))
            {
                Form f = new FormRelatorioProdutoAcabadoPositivo();
                f.Show();
            }
            else if (comboBox2.Text.Equals("Em Falta"))
            {
                Form f = new FormProdutoAcabadoEmFalta();
                f.Show();
            } else
            {
                MessageBox.Show("Voce não selecionou nenhuma opção.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text.Equals("Exibir Todos"))
            {
                //Form f = new FormRelatoriosDeLotes("Todos");
                //f.Show();
            }
            else if (comboBox3.Text.Equals("Com Saldo"))
            {
                Form f = new FormRelatorioLotePositivo();
                f.Show();
            }
            else if (comboBox3.Text.Equals("Em Falta"))
            {
                Form f = new FormLoteEmFalta();
                f.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Exibir Todos"))
            {
                Form f = new FormMateriaPrimaTodas();
                f.Show();
            }
            else if (comboBox1.Text.Equals("Com Saldo"))
            {
                Form f = new FormMateriaPrimaEmEstoque();
                f.Show();
            }
            else if (comboBox1.Text.Equals("Em Falta"))
            {
                Form f = new FormMateriaPrimaEmFalta();
                f.Show();
            }
            else
            {
                MessageBox.Show("Voce não selecionou nenhuma opção.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text.Equals("Exibir Todos"))
            {
                Form f = new FormEmbalagemTodas();
                f.Show();
            }
            else if (comboBox4.Text.Equals("Com Saldo"))
            {
                Form f = new FormEmbalagemPositiva();
                f.Show();
            }
            else if (comboBox4.Text.Equals("Em Falta"))
            {
                Form f = new FormEmbalagemNegativa();
                f.Show();
            }
            else
            {
                MessageBox.Show("Voce não selecionou nenhuma opção.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox5.Text.Equals("Exibir Todos"))
            {
                Form f = new FormCaixasTodas();
                f.Show();
            }
            else if (comboBox5.Text.Equals("Com Saldo"))
            {
                Form f = new FormCaixasPositiva();
                f.Show();
            }
            else if (comboBox5.Text.Equals("Em Falta"))
            {
                Form f = new FormCaixasNegativas();
                f.Show();
            }
            else
            {
                MessageBox.Show("Voce não selecionou nenhuma opção.");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (comboBox6.Text.Equals("Exibir Todos"))
            {
                Form f = new FormTampaTodas();
                f.Show();
            }
            else if (comboBox6.Text.Equals("Com Saldo"))
            {
                Form f = new FormTampaPositiva();
                f.Show();
            }
            else if (comboBox6.Text.Equals("Em Falta"))
            {
                Form f = new FormTampaNegativa();
                f.Show();
            }
            else
            {
                MessageBox.Show("Voce não selecionou nenhuma opção.");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime verifica = DateTime.Parse(textBox6.Text);

                if (textBox6.Text.Equals(""))
                {
                    MessageBox.Show("Informe a data.");
                }
                else
                {
                    Form f = new FormOrdemDeProducao(textBox6.Text);
                    f.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Data inválida.");
            }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form f = new FormProdutosEmAberto(comboBox11.Text);
            f.Show();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                DateTime dataInicial, dataFinal;

                try
                {

                    dataInicial = DateTime.Parse(textBox1.Text);

                    try
                    {
                        dataFinal = DateTime.Parse(textBox2.Text);

                        if (dataInicial > dataFinal)
                        {
                            MessageBox.Show("A data inicial não pode ser maior que a final");
                            textBox2.Focus();
                            textBox2.Text = "";
                        }
                        else
                        {
                            Form f = new FormRelatorioExpedicaoDataInicialDataFinal(dataInicial, dataFinal);
                            f.Show();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Data final informada inválida");
                        textBox2.Focus();
                        textBox2.Text = "";
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Data inicial informada inválida");
                    textBox1.Focus();
                    textBox1.Text = "";
                }
            }
            }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                DateTime dataInicial, dataFinal;
                String cliente = comboBox7.Text;

                try
                {

                    dataInicial = DateTime.Parse(textBox8.Text);

                    try
                    {
                        dataFinal = DateTime.Parse(textBox7.Text);

                        if (dataInicial > dataFinal)
                        {
                            MessageBox.Show("A data inicial não pode ser maior que a final");
                            textBox7.Focus();
                            textBox7.Text = "";
                        }
                        else
                        {
                            Form f = new FormRelatorioVendasPorClienteComData(cliente, dataInicial, dataFinal);
                            f.Show();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Data final informada inválida");
                        textBox7.Focus();
                        textBox7.Text = "";
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Data inicial informada inválida");
                    textBox8.Focus();
                    textBox8.Text = "";
                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                String produto = comboBox8.Text, litragem = comboBox9.Text;
                DateTime inicial, final;

                try
                {

                    inicial = DateTime.Parse(textBox4.Text);

                    try
                    {
                        final = DateTime.Parse(textBox3.Text);

                        if (inicial > final)
                        {
                            MessageBox.Show("A data inicial não pode ser maior que a final");
                            textBox7.Focus();
                            textBox7.Text = "";
                        }
                        else
                        {
                            Form f = new FormVendaPorProduto(produto, litragem, textBox4.Text, textBox3.Text);
                            f.Show();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Data final informada inválida");
                        textBox3.Focus();
                        textBox3.Text = "";
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Data inicial informada inválida");
                    textBox4.Focus();
                    textBox4.Text = "";
                }

            }
        }

        private void textBox9_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    int numeroPedido = int.Parse(textBox9.Text);

                    if (numeroPedido > 0)
                    {
                        Form f = new FormPedidoComIdGuia(numeroPedido);
                        f.Show();
                    }
                    else
                    {
                        textBox9.Focus();
                        MessageBox.Show("Digite um pedido com o número maior que 0");
                        textBox9.Text = "";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Você digitou um pedido inválido");
                }
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    DateTime verifica = DateTime.Parse(textBox6.Text);

                    if (textBox6.Text.Equals(""))
                    {
                        MessageBox.Show("Informe a data.");
                    }
                    else
                    {
                        Form f = new FormOrdemDeProducao(textBox6.Text);
                        f.Show();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Data inválida.");
                }
            }
        }
    }
}
