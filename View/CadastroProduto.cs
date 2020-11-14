using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Revtec_Bioquimica.Controller;
using Revtec_Bioquimica.Model;



namespace Revtec_Bioquimica
{
    public partial class Emerson : Form
    {
        ModelProduto modelProduto = new ModelProduto();
        ModelEmbalagens modelEmbalagens = new ModelEmbalagens();
        ModelCaixas modelCaixas = new ModelCaixas();
        ModelTampa modelTampa = new ModelTampa();
        ModelMateriaPrima modelMateriaPrima = new ModelMateriaPrima();

        double qtdadeEstoque;
        int qtdadeEstoqueTampa;
        int qtdadeEstoqueEmbalagens;
        int qtdadeEstoqueCaixas;
        int qtdadeEstoqueMateriaPrima;
        int idUsuario;
        double pesoCaixa;
        double alturaCaixa;
        double comprimentoCaixa;
        double larguraCaixa;
        String quemPode = "Produção";
        String quemPode2 = "Química";
        bool trueSalvarfalseAlterar = true;
        bool trueSalvarfalseAlterarEmbalagens = true;
        bool trueSalvarfalseAlterarCaixas = true;
        bool trueSalvarfalseAlterarTampa = true;
        bool trueSalvarfalseAlterarMateriaPrima = true;

        public Emerson(int id)
        {
            InitializeComponent();
            idUsuario = id;
        }

        private void Emerson_Load(object sender, EventArgs e)
        {
            carrgarProdutos();
            carrgarEmbalagens();
            carrgarCaixas();
            carrgarTampa();
            carrgarMateriaPrima();

            habilitarBotoes(true, false, false, false, false);
            habilitarBotoesEmbalagens(true, false, false, false, false);
            habilitarBotoesCaixas(true, false, false, false, false);
            habilitarBotoesTampa(true, false, false, false, false);
            habilitarBotoesMateriaPrima(true, false, false, false, false);

            limparCampos(false, false);          
            limparCamposEmabalagens(false, false);
            limparCamposCaixas(false, false);
            limparCamposTampa(false, false);
            limparCamposMateriaPrima(false, false);          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!txtNome.Text.Trim().Equals("") || txtNome.Text.Trim().Length > 4)
            {
                if (!txtPesoProduto.Text.Trim().Equals(""))
                {
                    if (!txtObservacoes.Text.Trim().Equals(""))
                    {
                        gravarDados(trueSalvarfalseAlterar, txtObservacoes.Text);
                    }
                    else
                    {
                        gravarDados(trueSalvarfalseAlterar, "Produto sem informação adicional");
                    }
                }
                else
                {
                    MessageBox.Show("O peso inserido é inválido");
                    txtPesoProduto.Focus();
                }
            }
            else
            {
                MessageBox.Show("O nome inserido é inválido");
                txtNome.Focus();
            }          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
            if (quemPode.Equals(setor) || setor.Equals("Desenvolvimento")) {
            // Initializes the variables to pass to the MessageBox.Show method.
            string message = "Deseja excluir o produto ("+ dataGridViewProdutos.CurrentRow.Cells[1].Value.ToString()+")\n\nImpossível reverter";
            string caption = "EXCLUIR PRODUTO";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (modelProduto.deletarProdutoController(txtCodPro.Text = dataGridViewProdutos.CurrentRow.Cells[0].Value.ToString()))
                {
                    carrgarProdutos();
                    trueSalvarfalseAlterar = true;
                    habilitarBotoes(true, false, false, false, false);
                    limparCampos(false, false);
                    MessageBox.Show("Produto deletado com sucesso!");
                    txtNome.Text = "";
                    txtObservacoes.Text = "";
                    txtCodPro.Text = "";
                    qtdadeEstoque = 0;
                    txtNome.Focus();
                }
                else
                {
                    MessageBox.Show("Erro ao deletar o produto.");
                }
            }
            } else {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de " + quemPode);
            }
        }


        public void habilitarBotoes(bool novo, bool alterar, bool cancelar, bool excluir, bool salvar)
        {
            btnNovoRegistroProduto.Enabled = novo;
            btnAlterarProduto.Enabled = alterar;
            btnCancelarProduto.Enabled = cancelar;
            btnExcluirProduto.Enabled = excluir;
            btnSalvarProduto.Enabled = salvar;
        }

        public void habilitarBotoesEmbalagens(bool novo, bool alterar, bool cancelar, bool excluir, bool salvar)
        {
            btnNovoRegistroEmbalagens.Enabled = novo;
            btnAlterarEmbalagens.Enabled = alterar;
            btnCancelarEmbalagens.Enabled = cancelar;
            btnExcluirEmbalagens.Enabled = excluir;
            btnSalvarEmbalagens.Enabled = salvar;
        }
        public void habilitarBotoesCaixas(bool novo, bool alterar, bool cancelar, bool excluir, bool salvar)
        {
            btnNovoRegistroCaixas.Enabled = novo;
            btnAlterarCaixas.Enabled = alterar;
            btnCancelarCaixas.Enabled = cancelar;
            btnExcluirCaixas.Enabled = excluir;
            btnSalvarCaixas.Enabled = salvar;
        }
        public void habilitarBotoesTampa(bool novo, bool alterar, bool cancelar, bool excluir, bool salvar)
        {
            btnNovaTampa.Enabled = novo;
            btnAlterarTampa.Enabled = alterar;
            btnCancelarTampa.Enabled = cancelar;
            btnExcluirTampa.Enabled = excluir;
            btnSalvarTampa.Enabled = salvar;
        }
        
        public void habilitarBotoesMateriaPrima(bool novo, bool alterar, bool cancelar, bool excluir, bool salvar)
        {
            btnNovoRegistroMateriaPrima.Enabled = novo;
            btnAlterarMateriaPrima.Enabled = alterar;
            btnCancelarMateriaPrima.Enabled = cancelar;
            btnExcluirMateriaPrima.Enabled = excluir;
            btnSalvarMateriaPrima.Enabled = salvar;
        }

        public void limparCampos(bool nome, bool observacao)
        {
            txtNome.Text = "";
            txtNome.Enabled = nome;
            
            txtPesoProduto.Text = "";
            txtPesoProduto.Enabled = nome;

            txtObservacoes.Text = "";
            txtObservacoes.Enabled = observacao;

            txtCodPro.Text = "";

            qtdadeEstoque = 0;
        }
        public void limparCamposCaixas(bool nome, bool observacao)
        {
            txtNomeCaixas.Text = "";
            txtNomeCaixas.Enabled = nome;

            txtPesoCaixas.Text = "";
            txtPesoCaixas.Enabled = nome;

            textBoxAltura.Text = "";
            textBoxAltura.Enabled = nome;

            textBoxLargura.Text = "";
            textBoxLargura.Enabled = nome;

            textBoxComprimento.Text = "";
            textBoxComprimento.Enabled = nome;

            txtObservacoesCaixas.Text = "";
            txtObservacoesCaixas.Enabled = observacao;

            txtCodigoCaixas.Text = "";

            qtdadeEstoqueCaixas = 0;
        }
        
        public void limparCamposTampa(bool nome, bool observacao)
        {
            txtNomeTampa.Text = "";
            txtNomeTampa.Enabled = nome;

            txtPesoTampa.Text = "";
            txtPesoTampa.Enabled = nome;

            txtObservacaoTampa.Text = "";
            txtObservacaoTampa.Enabled = observacao;

            txtCodigoTampa.Text = "";

            qtdadeEstoqueTampa = 0;
        }
        
        public void limparCamposMateriaPrima(bool nome, bool observacao)
        {
            txtNomeMateriaPrima.Text = "";
            txtNomeMateriaPrima.Enabled = nome;

            txtObservacoesMateriaPrima.Text = "";
            txtObservacoesMateriaPrima.Enabled = observacao;

            txtCodigoMateriaPrima.Text = "";

            qtdadeEstoqueMateriaPrima = 0;
        }

        public void limparCamposEmabalagens(bool nome, bool observacao)
        {
            txtNomeEmbalagens.Text = "";
            txtNomeEmbalagens.Enabled = nome;

            txtPesoFrasco.Text = "";
            txtPesoFrasco.Enabled = nome;

            txtObservacoesEmbalagens.Text = "";
            txtObservacoesEmbalagens.Enabled = observacao;

            txtCodigoEmbalagens.Text = "";

            qtdadeEstoqueEmbalagens = 0;
        }


        public void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtObservacoes.Enabled = true;
            txtPesoProduto.Enabled = true;
        }
        public void habilitarCamposCaixas()
        {
            txtNomeCaixas.Enabled = true;
            txtObservacoesCaixas.Enabled = true;
            txtPesoCaixas.Enabled = true;

            textBoxAltura.Enabled = true;
            textBoxLargura.Enabled = true;
            textBoxComprimento.Enabled = true;
        }
        
        public void habilitarCamposTampa()
        {
            txtNomeTampa.Enabled = true;
            txtObservacaoTampa.Enabled = true;
            txtPesoTampa.Enabled = true;
        }
        public void habilitarCamposMateriaPrima()
        {
            txtNomeMateriaPrima.Enabled = true;
            txtObservacoesMateriaPrima.Enabled = true;
        }

        public void habilitarCamposEmbalagens()
        {
            txtNomeEmbalagens.Enabled = true;
            txtObservacoesEmbalagens.Enabled = true;
            txtPesoFrasco.Enabled = true;
        }

        public void carrgarProdutos()
        {

            try
            {
                dataGridViewProdutos.DataSource = modelProduto.exibirTabelaProdutos();

                dataGridViewProdutos.Columns[0].HeaderText = "ID";
                DataGridViewColumn coluna1 = dataGridViewProdutos.Columns[0];
                coluna1.Width = 50;

                dataGridViewProdutos.Columns[1].HeaderText = "PRODUTO";
                DataGridViewColumn coluna2 = dataGridViewProdutos.Columns[1];
                coluna2.Width = 300;

                dataGridViewProdutos.Columns[2].Visible = false; // pedido_observacao

                dataGridViewProdutos.Columns[3].HeaderText = "OBSERVAÇÃO";
                DataGridViewColumn coluna4 = dataGridViewProdutos.Columns[3];
                coluna4.Width = 189;

                dataGridViewProdutos.Columns[4].HeaderText = "PESO";
                DataGridViewColumn coluna5 = dataGridViewProdutos.Columns[4];
                coluna5.Width = 100;
            }
            catch
            {
                MessageBox.Show("Erro ao buscar os produtos.");
            }
        }
        
        public void carrgarCaixas()
        {

            try
            {
                dataGridViewCaixas.DataSource = modelCaixas.exibirTabelaCaixas();

                dataGridViewCaixas.Columns[0].HeaderText = "ID";
                DataGridViewColumn coluna1 = dataGridViewCaixas.Columns[0];
                coluna1.Width = 50;

                dataGridViewCaixas.Columns[1].HeaderText = "ITEM";
                DataGridViewColumn coluna2 = dataGridViewCaixas.Columns[1];
                coluna2.Width = 340;

                dataGridViewCaixas.Columns[2].Visible = false; // caixas_estoque

                dataGridViewCaixas.Columns[3].HeaderText = "OBSERVAÇÃO";
                DataGridViewColumn coluna4 = dataGridViewCaixas.Columns[3];
                coluna4.Width = 149;

                dataGridViewCaixas.Columns[4].HeaderText = "PESO";
                DataGridViewColumn coluna5 = dataGridViewCaixas.Columns[4];
                coluna5.Width = 100;

                dataGridViewCaixas.Columns[5].Visible = false; // altura
                dataGridViewCaixas.Columns[6].Visible = false; // largura
                dataGridViewCaixas.Columns[7].Visible = false; // comprimento
            }
            catch
            {
                MessageBox.Show("Erro ao buscar os produtos.");
            }
        }
        
        public void carrgarTampa()
        {

            try
            {
                dataGridViewTampa.DataSource = modelTampa.exibirTabelaTampa();

                dataGridViewTampa.Columns[0].HeaderText = "ID";
                DataGridViewColumn coluna1 = dataGridViewTampa.Columns[0];
                coluna1.Width = 50;

                dataGridViewTampa.Columns[1].HeaderText = "ITEM";
                DataGridViewColumn coluna2 = dataGridViewTampa.Columns[1];
                coluna2.Width = 300;

                dataGridViewTampa.Columns[2].Visible = false; // tampa_estoque

                dataGridViewTampa.Columns[3].HeaderText = "OBSERVAÇÃO";
                DataGridViewColumn coluna4 = dataGridViewTampa.Columns[3];
                coluna4.Width = 189;

                dataGridViewTampa.Columns[4].HeaderText = "PESO";
                DataGridViewColumn coluna5 = dataGridViewTampa.Columns[4];
                coluna5.Width = 100;
            }
            catch
            {
                MessageBox.Show("Erro ao buscar os produtos.");
            }
        }
        
        public void carrgarMateriaPrima()
        {

            try
            {
                dataGridViewMateriaPrima.DataSource = modelMateriaPrima.exibirTabelaMateriaPrima();

                dataGridViewMateriaPrima.Columns[0].HeaderText = "ID";
                DataGridViewColumn coluna1 = dataGridViewMateriaPrima.Columns[0];
                coluna1.Width = 50;

                dataGridViewMateriaPrima.Columns[1].HeaderText = "ITEM";
                DataGridViewColumn coluna2 = dataGridViewMateriaPrima.Columns[1];
                coluna2.Width = 340;

                dataGridViewMateriaPrima.Columns[2].Visible = false; // materiaprima_estoque

                dataGridViewMateriaPrima.Columns[3].HeaderText = "OBSERVAÇÃO";
                DataGridViewColumn coluna4 = dataGridViewMateriaPrima.Columns[3];
                coluna4.Width = 249;
            }
            catch
            {
                MessageBox.Show("Erro ao buscar os produtos.");
            }
        }
        public void carrgarEmbalagens()
        {

            try
            {
                dataGridViewEmbalagens.DataSource = modelEmbalagens.exibirTabelaEmbalagens();

                dataGridViewEmbalagens.Columns[0].HeaderText = "ID";
                DataGridViewColumn coluna1 = dataGridViewEmbalagens.Columns[0];
                coluna1.Width = 50;

                dataGridViewEmbalagens.Columns[1].HeaderText = "ITEM";
                DataGridViewColumn coluna2 = dataGridViewEmbalagens.Columns[1];
                coluna2.Width = 340;

                dataGridViewEmbalagens.Columns[2].Visible = false; // embalagens_estoque

                dataGridViewEmbalagens.Columns[3].HeaderText = "OBSERVAÇÃO";
                DataGridViewColumn coluna4 = dataGridViewEmbalagens.Columns[3];
                coluna4.Width = 149;

                dataGridViewEmbalagens.Columns[4].HeaderText = "PESO";
                DataGridViewColumn coluna5 = dataGridViewEmbalagens.Columns[4];
                coluna5.Width = 100;
            }
            catch
            {
                MessageBox.Show("Erro ao buscar os intens.");
            }
        }

        public void pesquisarProdutos(String pesquisa)
        {

            try
            {
                dataGridViewProdutos.DataSource = modelProduto.pesquisarTabelaProdutos(pesquisa);

                dataGridViewProdutos.Columns[0].HeaderText = "ID";
                DataGridViewColumn coluna1 = dataGridViewProdutos.Columns[0];
                coluna1.Width = 50;

                dataGridViewProdutos.Columns[1].HeaderText = "PRODUTO";
                DataGridViewColumn coluna2 = dataGridViewProdutos.Columns[1];
                coluna2.Width = 300;

                dataGridViewProdutos.Columns[2].HeaderText = "ESTOQUE";
                DataGridViewColumn coluna3 = dataGridViewProdutos.Columns[2];
                coluna3.Width = 80;

                dataGridViewProdutos.Columns[3].HeaderText = "OBSERVAÇÃO";
                DataGridViewColumn coluna4 = dataGridViewProdutos.Columns[3];
                coluna4.Width = 209;
            }
            catch
            {
                MessageBox.Show("Erro ao buscar os produtos.");
            }
        }
        public void pesquisarCaixas(String pesquisa)
        {

            try
            {
                dataGridViewCaixas.DataSource = modelCaixas.pesquisarTabelaCaixas(pesquisa);

                dataGridViewCaixas.Columns[0].HeaderText = "ID";
                DataGridViewColumn coluna1 = dataGridViewCaixas.Columns[0];
                coluna1.Width = 50;

                dataGridViewCaixas.Columns[1].HeaderText = "ITEM";
                DataGridViewColumn coluna2 = dataGridViewCaixas.Columns[1];
                coluna2.Width = 300;

                dataGridViewCaixas.Columns[2].HeaderText = "ESTOQUE";
                DataGridViewColumn coluna3 = dataGridViewCaixas.Columns[2];
                coluna3.Width = 80;

                dataGridViewCaixas.Columns[3].HeaderText = "OBSERVAÇÃO";
                DataGridViewColumn coluna4 = dataGridViewCaixas.Columns[3];
                coluna4.Width = 209;
            }
            catch
            {
                MessageBox.Show("Erro ao buscar os itens.");
            }
        }
        
        public void pesquisarTampa(String pesquisa)
        {

            try
            {
                dataGridViewTampa.DataSource = modelTampa.pesquisarTabelaTampa(pesquisa);

                dataGridViewTampa.Columns[0].HeaderText = "ID";
                DataGridViewColumn coluna1 = dataGridViewTampa.Columns[0];
                coluna1.Width = 50;

                dataGridViewTampa.Columns[1].HeaderText = "ITEM";
                DataGridViewColumn coluna2 = dataGridViewTampa.Columns[1];
                coluna2.Width = 300;

                dataGridViewTampa.Columns[2].HeaderText = "ESTOQUE";
                DataGridViewColumn coluna3 = dataGridViewTampa.Columns[2];
                coluna3.Width = 80;

                dataGridViewTampa.Columns[3].HeaderText = "OBSERVAÇÃO";
                DataGridViewColumn coluna4 = dataGridViewTampa.Columns[3];
                coluna4.Width = 209;
            }
            catch
            {
                MessageBox.Show("Erro ao buscar os itens.");
            }
        }
        public void pesquisarMateriaPrima(String pesquisa)
        {

            try
            {
                dataGridViewMateriaPrima.DataSource = modelMateriaPrima.pesquisarTabelaMateriaPrima(pesquisa);

                dataGridViewMateriaPrima.Columns[0].HeaderText = "ID";
                DataGridViewColumn coluna1 = dataGridViewMateriaPrima.Columns[0];
                coluna1.Width = 50;

                dataGridViewMateriaPrima.Columns[1].HeaderText = "ITEM";
                DataGridViewColumn coluna2 = dataGridViewMateriaPrima.Columns[1];
                coluna2.Width = 300;

                dataGridViewMateriaPrima.Columns[2].HeaderText = "ESTOQUE";
                DataGridViewColumn coluna3 = dataGridViewMateriaPrima.Columns[2];
                coluna3.Width = 80;

                dataGridViewMateriaPrima.Columns[3].HeaderText = "OBSERVAÇÃO";
                DataGridViewColumn coluna4 = dataGridViewMateriaPrima.Columns[3];
                coluna4.Width = 209;
            }
            catch
            {
                MessageBox.Show("Erro ao buscar os itens.");
            }
        }
        public void pesquisarEmbalagens(String pesquisa)
        {

            try
            {
                dataGridViewEmbalagens.DataSource = modelEmbalagens.pesquisarTabelaEmbalagens(pesquisa);

                dataGridViewEmbalagens.Columns[0].HeaderText = "ID";
                DataGridViewColumn coluna1 = dataGridViewEmbalagens.Columns[0];
                coluna1.Width = 50;

                dataGridViewEmbalagens.Columns[1].HeaderText = "ITEM";
                DataGridViewColumn coluna2 = dataGridViewEmbalagens.Columns[1];
                coluna2.Width = 300;

                dataGridViewEmbalagens.Columns[2].HeaderText = "ESTOQUE";
                DataGridViewColumn coluna3 = dataGridViewEmbalagens.Columns[2];
                coluna3.Width = 80;

                dataGridViewEmbalagens.Columns[3].HeaderText = "OBSERVAÇÃO";
                DataGridViewColumn coluna4 = dataGridViewEmbalagens.Columns[3];
                coluna4.Width = 209;
            }
            catch
            {
                MessageBox.Show("Erro ao buscar os itens.");
            }
        }

        private void dataGridViewProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            habilitarBotoes(false, true, false, true, false);
            carregarGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);

            if (quemPode.Equals(setor) || setor.Equals("Desenvolvimento")) {
            habilitarBotoes(false, false, true, false, true);
            habilitarCampos();
            trueSalvarfalseAlterar = false; 
            } else {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de " + quemPode);
            }
           
        }

        public void carregarGrid()
        {
            txtCodPro.Text = dataGridViewProdutos.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dataGridViewProdutos.CurrentRow.Cells[1].Value.ToString();
            //MessageBox.Show(dataGridViewProdutos.CurrentRow.Cells[2].Value.ToString());
            qtdadeEstoque = double.Parse(dataGridViewProdutos.CurrentRow.Cells[2].Value.ToString());
            txtObservacoes.Text = dataGridViewProdutos.CurrentRow.Cells[3].Value.ToString();
            txtPesoProduto.Text = dataGridViewProdutos.CurrentRow.Cells[4].Value.ToString();
            txtNome.Enabled = false;
            txtObservacoes.Enabled = false;
            habilitarBotoes(false, true, false, true, false);

        }
        public void carregarGridCaixas()
        {
            txtCodigoCaixas.Text = dataGridViewCaixas.CurrentRow.Cells[0].Value.ToString();
            txtNomeCaixas.Text = dataGridViewCaixas.CurrentRow.Cells[1].Value.ToString();
            qtdadeEstoqueCaixas = int.Parse(dataGridViewCaixas.CurrentRow.Cells[2].Value.ToString());
            txtObservacoesCaixas.Text = dataGridViewCaixas.CurrentRow.Cells[3].Value.ToString();
            txtPesoCaixas.Text = double.Parse(dataGridViewCaixas.CurrentRow.Cells[4].Value.ToString()).ToString("F3");
            textBoxAltura.Text = (double.Parse(dataGridViewCaixas.CurrentRow.Cells[5].Value.ToString())*100).ToString("F2").Replace(".",",");
            textBoxLargura.Text = (double.Parse(dataGridViewCaixas.CurrentRow.Cells[6].Value.ToString()) * 100).ToString("F2").Replace(".", ",");
            textBoxComprimento.Text = (double.Parse(dataGridViewCaixas.CurrentRow.Cells[7].Value.ToString()) * 100).ToString("F2").Replace(".", ",");
            txtNomeCaixas.Enabled = false;
            txtObservacoesCaixas.Enabled = false;
            habilitarBotoesCaixas(false, true, false, true, false);

        }
        
        public void carregarGridTampa()
        {
            txtCodigoTampa.Text = dataGridViewTampa.CurrentRow.Cells[0].Value.ToString();
            txtNomeTampa.Text = dataGridViewTampa.CurrentRow.Cells[1].Value.ToString();
            qtdadeEstoqueTampa = int.Parse(dataGridViewTampa.CurrentRow.Cells[2].Value.ToString());
            txtObservacaoTampa.Text = dataGridViewTampa.CurrentRow.Cells[3].Value.ToString();
            txtPesoTampa.Text = dataGridViewTampa.CurrentRow.Cells[4].Value.ToString();
            txtNomeTampa.Enabled = false;
            txtObservacaoTampa.Enabled = false;
            habilitarBotoesTampa(false, true, false, true, false);

        }

        public void carregarGridEmbalagens()
        {
            txtCodigoEmbalagens.Text = dataGridViewEmbalagens.CurrentRow.Cells[0].Value.ToString();
            txtNomeEmbalagens.Text = dataGridViewEmbalagens.CurrentRow.Cells[1].Value.ToString();
            qtdadeEstoqueEmbalagens = int.Parse(dataGridViewEmbalagens.CurrentRow.Cells[2].Value.ToString());
            txtObservacoesEmbalagens.Text = dataGridViewEmbalagens.CurrentRow.Cells[3].Value.ToString();
            txtPesoFrasco.Text = dataGridViewEmbalagens.CurrentRow.Cells[4].Value.ToString();
            txtNomeEmbalagens.Enabled = false;
            txtObservacoesEmbalagens.Enabled = false;
            habilitarBotoesEmbalagens(false, true, false, true, false);

        }
        public void carregarGridMateriaPrima()
        {
            txtCodigoMateriaPrima.Text = dataGridViewMateriaPrima.CurrentRow.Cells[0].Value.ToString();
            txtNomeMateriaPrima.Text = dataGridViewMateriaPrima.CurrentRow.Cells[1].Value.ToString();
            qtdadeEstoqueMateriaPrima = int.Parse(dataGridViewMateriaPrima.CurrentRow.Cells[2].Value.ToString());
            txtObservacoesMateriaPrima.Text = dataGridViewMateriaPrima.CurrentRow.Cells[3].Value.ToString();
            txtNomeMateriaPrima.Enabled = false;
            txtObservacoesMateriaPrima.Enabled = false;
            habilitarBotoesMateriaPrima(false, true, false, true, false);

        }

        public void gravarDados(bool acao, String observacao)
        {
            if (acao)
            {
                modelProduto.Pro_nome = txtNome.Text.ToUpper();
                modelProduto.Pro_estoque = double.Parse("0");
                modelProduto.Pro_peso = double.Parse(txtPesoProduto.Text.Replace(".", ","));
                modelProduto.Pro_observacao = observacao.ToUpper();

                if (modelProduto.salvarProdutoController(modelProduto))
                {
                    carrgarProdutos();
                    trueSalvarfalseAlterar = true;
                    habilitarBotoes(true, false, false, false, false);
                    MessageBox.Show("Dados inseridos com sucesso!");
                    limparCampos(false, false);
                }
                else
                {
                    trueSalvarfalseAlterar = true;
                    habilitarBotoes(true, false, false, false, false);
                    MessageBox.Show("Erro ao salvar os dados");
                }
            }
            else
            {
                ControllerProduto controllerProduto = new ControllerProduto();
                modelProduto = controllerProduto.retornarProdutoPeloId(int.Parse(txtCodPro.Text));
                modelProduto.Pro_nome = txtNome.Text.ToUpper();
                modelProduto.Pro_peso = double.Parse(txtPesoProduto.Text.Replace(".", ","));
                modelProduto.Pro_observacao = observacao.ToUpper();

                if (modelProduto.atualizarProdutoController(modelProduto))
                {
                    trueSalvarfalseAlterar = true;
                    habilitarBotoes(true, false, false, false, false);
                    limparCampos(false, false);
                    carrgarProdutos();
                    MessageBox.Show("Dados atualizados com sucesso!");
                    txtNome.Focus();
                }
                else
                {
                    trueSalvarfalseAlterar = true;
                    habilitarBotoes(true, false, false, false, false);
                    MessageBox.Show("Erro ao atualizar os dados");
                }
            }
        }
        public void gravarDadosEmbalagens(bool acao, String observacao)
        {
            if (acao)
            {
                modelEmbalagens.Embalagens_nome = txtNomeEmbalagens.Text.ToUpper();
                modelEmbalagens.Embalagens_estoque = int.Parse("0");
                modelEmbalagens.Embalagens_peso = double.Parse(txtPesoFrasco.Text.Replace(".", ","));
                modelEmbalagens.Embalagens_observacao = observacao.ToUpper();

                if (modelEmbalagens.salvarEmbalagensController(modelEmbalagens))
                {
                    carrgarEmbalagens();
                    trueSalvarfalseAlterarEmbalagens = true;
                    habilitarBotoesEmbalagens(true, false, false, false, false);
                    MessageBox.Show("Dados inseridos com sucesso!");
                    limparCamposEmabalagens(false, false);
                }
                else
                {
                    trueSalvarfalseAlterarEmbalagens = true;
                    habilitarBotoesEmbalagens(true, false, false, false, false);
                    MessageBox.Show("Erro ao salvar os dados");
                }
            }
            else
            {
                ControllerEmbalagens controllerEmbalagens = new ControllerEmbalagens();
                modelEmbalagens = controllerEmbalagens.recuperarDadosEmbalagensPeloId(int.Parse(txtCodigoEmbalagens.Text));                
                modelEmbalagens.Embalagens_nome = txtNomeEmbalagens.Text.ToUpper();
                modelEmbalagens.Embalagens_peso = double.Parse(txtPesoFrasco.Text.Replace(".", ","));
                modelEmbalagens.Embalagens_observacao = observacao.ToUpper();

                if (modelEmbalagens.atualizarEmbalagensController(modelEmbalagens))
                {
                    trueSalvarfalseAlterarEmbalagens = true;
                    habilitarBotoesEmbalagens(true, false, false, false, false);
                    limparCamposEmabalagens(false, false);
                    carrgarEmbalagens();
                    MessageBox.Show("Dados atualizados com sucesso!");
                    txtNomeEmbalagens.Focus();
                }
                else
                {
                    trueSalvarfalseAlterarEmbalagens = true;
                    habilitarBotoesEmbalagens(true, false, false, false, false);
                    MessageBox.Show("Erro ao atualizar os dados");
                }
            }
        }
        
        public void gravarDadosCaixas(bool acao, String observacao)
        {
            if (acao)
            {
                modelCaixas.Caixas_nome = txtNomeCaixas.Text.ToUpper();
                modelCaixas.Caixas_estoque = int.Parse("0");
                modelCaixas.Caixas_peso = pesoCaixa;
                modelCaixas.Caixas_altura = alturaCaixa/100;
                modelCaixas.Caixas_largura = larguraCaixa / 100;
                modelCaixas.Caixas_comprimento = comprimentoCaixa / 100;
                modelCaixas.Caixas_observacao = observacao.ToUpper();

                if (modelCaixas.salvarCaixasController(modelCaixas))
                {
                    carrgarCaixas();
                    trueSalvarfalseAlterarCaixas = true;
                    habilitarBotoesCaixas(true, false, false, false, false);
                    MessageBox.Show("Dados inseridos com sucesso!");
                    limparCamposCaixas(false, false);
                }
                else
                {
                    trueSalvarfalseAlterarCaixas = true;
                    habilitarBotoesCaixas(true, false, false, false, false);
                    MessageBox.Show("Erro ao salvar os dados");
                }
            }
            else
            {
                ControllerCaixas controllerCaixas = new ControllerCaixas();
                modelCaixas = controllerCaixas.recuperarCaixaPeloId(int.Parse(txtCodigoCaixas.Text));

                modelCaixas.Caixas_nome = txtNomeCaixas.Text.ToUpper();
                modelCaixas.Caixas_peso = double.Parse(txtPesoCaixas.Text.Replace(".", ","));
                modelCaixas.Caixas_observacao = observacao.ToUpper();
                modelCaixas.Caixas_altura = alturaCaixa / 100;
                modelCaixas.Caixas_largura = larguraCaixa / 100;
                modelCaixas.Caixas_comprimento = comprimentoCaixa / 100;

                if (modelCaixas.atualizarCaixasController(modelCaixas))
                {
                    trueSalvarfalseAlterarCaixas = true;
                    habilitarBotoesCaixas(true, false, false, false, false);
                    limparCamposCaixas(false, false);
                    carrgarCaixas();
                    MessageBox.Show("Dados atualizados com sucesso!");
                    txtNomeCaixas.Focus();
                }
                else
                {
                    trueSalvarfalseAlterarCaixas = true;
                    habilitarBotoesCaixas(true, false, false, false, false);
                    MessageBox.Show("Erro ao atualizar os dados");
                }
            }
        }
        
        public void gravarDadosTampa(bool acao, String observacao)
        {
            if (acao)
            {
                modelTampa.Tampa_nome = txtNomeTampa.Text.ToUpper();
                modelTampa.Tampa_estoque = int.Parse("0");
                modelTampa.Tampa_peso = double.Parse(txtPesoTampa.Text.Replace(".", ","));
                modelTampa.Tampa_observacao = observacao.ToUpper();

                if (modelTampa.salvarTampaController(modelTampa))
                {
                    carrgarTampa();
                    trueSalvarfalseAlterarTampa = true;
                    habilitarBotoesTampa(true, false, false, false, false);
                    MessageBox.Show("Dados inseridos com sucesso!");
                    limparCamposTampa(false, false);
                }
                else
                {
                    trueSalvarfalseAlterarTampa = true;
                    habilitarBotoesTampa(true, false, false, false, false);
                    MessageBox.Show("Erro ao salvar os dados");
                }
            }
            else
            {
                ControllerTampa controllerTampa = new ControllerTampa();

                modelTampa = controllerTampa.recuperarDadosDaTampa(int.Parse(txtCodigoTampa.Text));
                modelTampa.Tampa_nome = txtNomeTampa.Text.ToUpper();
                modelTampa.Tampa_peso = double.Parse(txtPesoTampa.Text.Replace(".", ","));
                modelTampa.Tampa_observacao = observacao.ToUpper();

                if (modelTampa.atualizarTampaController(modelTampa))
                {
                    trueSalvarfalseAlterarTampa = true;
                    habilitarBotoesTampa(true, false, false, false, false);
                    limparCamposTampa(false, false);
                    carrgarTampa();
                    MessageBox.Show("Dados atualizados com sucesso!");
                    txtNomeTampa.Focus();
                }
                else
                {
                    trueSalvarfalseAlterarTampa = true;
                    habilitarBotoesTampa(true, false, false, false, false);
                    MessageBox.Show("Erro ao atualizar os dados");
                }
            }
        }
        
        public void gravarDadosMateriaPrima(bool acao, String observacao)
        {
            if (acao)
            {
                modelMateriaPrima.MateriaPrima_nome = txtNomeMateriaPrima.Text.ToUpper();
                modelMateriaPrima.MateriaPrima_estoque = double.Parse("0");
                modelMateriaPrima.MateriaPrima_observacao = observacao.ToUpper();

                if (modelMateriaPrima.salvarMateriaPrimaController(modelMateriaPrima))
                {
                    carrgarMateriaPrima();
                    trueSalvarfalseAlterarMateriaPrima = true;
                    habilitarBotoesMateriaPrima(true, false, false, false, false);
                    MessageBox.Show("Dados inseridos com sucesso!");
                    limparCamposMateriaPrima(false, false);
                }
                else
                {
                    trueSalvarfalseAlterarMateriaPrima = true;
                    habilitarBotoesMateriaPrima(true, false, false, false, false);
                    MessageBox.Show("Erro ao salvar os dados");
                }
            }
            else
            {
                ControllerMateriaPrima controllerMateriaPrima = new ControllerMateriaPrima();

                modelMateriaPrima = controllerMateriaPrima.recuperarMateriaPrima(int.Parse(txtCodigoMateriaPrima.Text));
                modelMateriaPrima.MateriaPrima_id = int.Parse(txtCodigoMateriaPrima.Text);
                modelMateriaPrima.MateriaPrima_nome = txtNomeMateriaPrima.Text.ToUpper();
                modelMateriaPrima.MateriaPrima_observacao = observacao.ToUpper();

                if (modelMateriaPrima.atualizarMateriaPrimaController(modelMateriaPrima))
                {
                    trueSalvarfalseAlterarMateriaPrima = true;
                    habilitarBotoesMateriaPrima(true, false, false, false, false);
                    limparCamposMateriaPrima(false, false);
                    carrgarMateriaPrima();
                    MessageBox.Show("Dados atualizados com sucesso!");
                    txtNomeMateriaPrima.Focus();
                }
                else
                {
                    trueSalvarfalseAlterarMateriaPrima = true;
                    habilitarBotoesMateriaPrima(true, false, false, false, false);
                    MessageBox.Show("Erro ao atualizar os dados");
                }
            }
        }

        private void btnNovoRegistroProduto_Click(object sender, EventArgs e)
        {
            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
            if (quemPode.Equals(setor) || setor.Equals("Desenvolvimento")) {
            trueSalvarfalseAlterar = true;
            limparCampos(true, true);
            txtNome.Focus();
            habilitarBotoes(false, false, true, false, true);
            } else {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de " + quemPode);
            }

        }

        private void btnCancelarProduto_Click(object sender, EventArgs e)
        {
            trueSalvarfalseAlterar = true;
            limparCampos(false, false);
            habilitarBotoes(true, false, false, false, false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPesquisa.Text.Equals(""))
            {
                carrgarProdutos();
                limparCampos(false, false);
            }
            else
            {
                pesquisarProdutos(txtPesquisa.Text);
                limparCampos(false, false);
            }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnNovoRegistroEmbalagens_Click(object sender, EventArgs e)
        {
            trueSalvarfalseAlterarEmbalagens = true;
            limparCamposEmabalagens(true, true);
            txtNomeEmbalagens.Focus();
            habilitarBotoesEmbalagens(false, false, true, false, true);
        }

        private void btnAlterarEmbalagens_Click(object sender, EventArgs e)
        {
            habilitarBotoesEmbalagens(false, false, true, false, true);
            habilitarCamposEmbalagens();
            trueSalvarfalseAlterarEmbalagens = false;
        }

        private void btnCancelarEmbalagens_Click(object sender, EventArgs e)
        {
            trueSalvarfalseAlterarEmbalagens = true;
            limparCamposEmabalagens(false, false);
            habilitarBotoesEmbalagens(true, false, false, false, false);
        }

        private void btnExcluirEmbalagens_Click(object sender, EventArgs e)
        {
            // Initializes the variables to pass to the MessageBox.Show method.
            string message = "Deseja excluir o item (" + dataGridViewEmbalagens.CurrentRow.Cells[1].Value.ToString() + ")\n\nImpossível reverter";
            string caption = "EXCLUIR ITEM";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (modelEmbalagens.deletarEmbalagensController(txtCodPro.Text = dataGridViewEmbalagens.CurrentRow.Cells[0].Value.ToString()))
                {
                    carrgarEmbalagens();
                    trueSalvarfalseAlterarEmbalagens = true;
                    habilitarBotoesEmbalagens(true, false, false, false, false);
                    limparCamposEmabalagens(false, false);
                    MessageBox.Show("Item deletado com sucesso!");
                    txtNomeEmbalagens.Text = "";
                    txtObservacoesEmbalagens.Text = "";
                    txtCodigoEmbalagens.Text = "";
                    qtdadeEstoqueEmbalagens = 0;
                    txtNomeEmbalagens.Focus();
                }
                else
                {
                    MessageBox.Show("Erro ao deletar o produto.");
                }
            }
        }

        private void btnSalvarEmbalagens_Click(object sender, EventArgs e)
        {
            if (!txtNomeEmbalagens.Text.Trim().Equals("") || txtNomeEmbalagens.Text.Trim().Length > 4)
            {
                if (!txtObservacoesEmbalagens.Text.Trim().Equals(""))
                {
                    gravarDadosEmbalagens(trueSalvarfalseAlterarEmbalagens, txtObservacoesEmbalagens.Text);
                }
                else
                {
                    gravarDadosEmbalagens(trueSalvarfalseAlterarEmbalagens, "Item sem informação adicional");
                }
            }
            else
            {
                MessageBox.Show("O nome inserido é inválido");
                txtNome.Focus();
            }
        }

        private void dataGridViewEmbalagens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            habilitarBotoesEmbalagens(false, true, false, true, false);
            carregarGridEmbalagens();
        }

        private void dataGridViewEmbalagens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            habilitarBotoesEmbalagens(false, true, false, true, false);
            carregarGridEmbalagens();
        }

        private void btnNovoRegistroEmbalagens_Click_1(object sender, EventArgs e)
        {
            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
            if (quemPode.Equals(setor) || setor.Equals("Desenvolvimento")) { 
            trueSalvarfalseAlterarEmbalagens = true;
            limparCamposEmabalagens(true, true);
            txtNomeEmbalagens.Focus();
            habilitarBotoesEmbalagens(false, false, true, false, true);
            } else {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de " + quemPode);
            }
        }

        private void btnAlterarEmbalagens_Click_1(object sender, EventArgs e)
        {
            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
            if (quemPode.Equals(setor) || setor.Equals("Desenvolvimento")) {
            habilitarBotoesEmbalagens(false, false, true, false, true);
            habilitarCamposEmbalagens();
            trueSalvarfalseAlterarEmbalagens = false;
            } else {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de " + quemPode);
            }

        }

        private void btnCancelarEmbalagens_Click_1(object sender, EventArgs e)
        {
            trueSalvarfalseAlterarEmbalagens = true;
            limparCamposEmabalagens(false, false);
            habilitarBotoesEmbalagens(true, false, false, false, false);
        }

        private void btnExcluirEmbalagens_Click_1(object sender, EventArgs e)
        {
            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
            if (quemPode.Equals(setor) || setor.Equals("Desenvolvimento")) {
            // Initializes the variables to pass to the MessageBox.Show method.
            string message = "Deseja excluir o item (" + dataGridViewEmbalagens.CurrentRow.Cells[1].Value.ToString() + ")\n\nImpossível reverter";
            string caption = "EXCLUIR ITEM";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (modelEmbalagens.deletarEmbalagensController(txtCodigoEmbalagens.Text = dataGridViewEmbalagens.CurrentRow.Cells[0].Value.ToString()))
                {
                    carrgarEmbalagens();
                    trueSalvarfalseAlterarEmbalagens = true;
                    habilitarBotoesEmbalagens(true, false, false, false, false);
                    limparCamposEmabalagens(false, false);
                    MessageBox.Show("Item deletado com sucesso!");
                    txtNomeEmbalagens.Text = "";
                    txtObservacoesEmbalagens.Text = "";
                    txtCodigoEmbalagens.Text = "";
                    qtdadeEstoqueEmbalagens = 0;
                    txtNomeEmbalagens.Focus();
                }
                else
                {
                    MessageBox.Show("Erro ao deletar o item.");
                }
            }
            } else {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de " + quemPode);
            }
            
        }

        private void btnSalvarEmbalagens_Click_1(object sender, EventArgs e)
        {
            if (!txtNomeEmbalagens.Text.Trim().Equals("") || txtNomeEmbalagens.Text.Trim().Length > 4)
            {
                if (!txtPesoFrasco.Text.Trim().Equals(""))
                {
                    if (!txtObservacoesEmbalagens.Text.Trim().Equals(""))
                    {
                        gravarDadosEmbalagens(trueSalvarfalseAlterarEmbalagens, txtObservacoesEmbalagens.Text);
                    }
                    else
                    {
                        gravarDadosEmbalagens(trueSalvarfalseAlterarEmbalagens, "Item sem informação adicional");
                    }
                }
                else
                {
                    MessageBox.Show("O peso inserido é inválido");
                    txtPesoFrasco.Focus();
                }
            }
            else
            {
                MessageBox.Show("O nome inserido é inválido");
                txtNomeEmbalagens.Focus();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txtPesquisaEmbalagens.Text.Equals(""))
            {
                carrgarEmbalagens();
                limparCamposEmabalagens(false, false);
            }
            else
            {
                pesquisarEmbalagens(txtPesquisaEmbalagens.Text);
                limparCamposEmabalagens(false, false);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
            if (quemPode.Equals(setor) || setor.Equals("Desenvolvimento")) {
            trueSalvarfalseAlterarCaixas = true;
            limparCamposCaixas(true, true);
            txtNomeCaixas.Focus();
            habilitarBotoesCaixas(false, false, true, false, true);
            } else {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de " + quemPode);
            }

        }

        private void btnAlterarCaixas_Click(object sender, EventArgs e)
        {
            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
            if (quemPode.Equals(setor) || setor.Equals("Desenvolvimento")) {
            habilitarBotoesCaixas(false, false, true, false, true);
            habilitarCamposCaixas();
            trueSalvarfalseAlterarCaixas = false;
            } else {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de " + quemPode);
            }

        }

        private void btnCancelarCaixas_Click(object sender, EventArgs e)
        {
            trueSalvarfalseAlterarCaixas = true;
            limparCamposCaixas(false, false);
            habilitarBotoesCaixas(true, false, false, false, false);
        }

        private void btnExcluirCaixas_Click(object sender, EventArgs e)
        {
            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
            if (quemPode.Equals(setor) || setor.Equals("Desenvolvimento")) {
            // Initializes the variables to pass to the MessageBox.Show method.
            string message = "Deseja excluir o item (" + dataGridViewCaixas.CurrentRow.Cells[1].Value.ToString() + ")\n\nImpossível reverter";
            string caption = "EXCLUIR ITEM";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (modelCaixas.deletarCaixasController(txtCodigoCaixas.Text = dataGridViewCaixas.CurrentRow.Cells[0].Value.ToString()))
                {
                    carrgarCaixas();
                    trueSalvarfalseAlterarCaixas = true;
                    habilitarBotoesCaixas(true, false, false, false, false);
                    limparCamposCaixas(false, false);
                    MessageBox.Show("Item deletado com sucesso!");
                    txtNomeCaixas.Text = "";
                    txtObservacoesCaixas.Text = "";
                    txtCodigoCaixas.Text = "";
                    qtdadeEstoqueCaixas = 0;
                    txtNomeCaixas.Focus();
                }
                else
                {
                    MessageBox.Show("Erro ao deletar o item.");
                }
            }
            } else {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de " + quemPode);
            }
            
        }

        private void btnSalvarCaixas_Click(object sender, EventArgs e)
        {

            try {

                if (!txtNomeCaixas.Text.Trim().Equals("") || txtNomeCaixas.Text.Trim().Length > 4) {

                    try {

                        if (!txtPesoCaixas.Text.Trim().Equals("")) {
                            pesoCaixa = double.Parse(txtPesoCaixas.Text.Replace(".", ","));

                            try {

                                if (!textBoxAltura.Text.Trim().Equals("")) {
                                    alturaCaixa = double.Parse(textBoxAltura.Text.Replace(".", ","));

                                    try {

                                        if (!textBoxLargura.Text.Trim().Equals("")) {
                                            larguraCaixa = double.Parse(textBoxLargura.Text.Replace(".", ","));

                                            try {

                                                if (!textBoxComprimento.Text.Trim().Equals("")) {
                                                    comprimentoCaixa = double.Parse(textBoxComprimento.Text.Replace(".", ","));

                                                    try {

                                                        if (!txtObservacoesCaixas.Text.Trim().Equals("")) {
                                                            gravarDadosCaixas(trueSalvarfalseAlterarCaixas, txtObservacoesCaixas.Text);
                                                        } else {
                                                            gravarDadosCaixas(trueSalvarfalseAlterarCaixas, "Item sem informação adicional");
                                                        }

                                                    } catch (Exception) {
                                                        MessageBox.Show("Observação inválida");
                                                        txtObservacoesCaixas.Focus();
                                                    }

                                                } else {
                                                    MessageBox.Show("O comprimento da caixa é obrigatório");
                                                    textBoxComprimento.Focus();
                                                }

                                            } catch (Exception) {
                                                MessageBox.Show("Formato inválido do comprimento da caixa, revise.");
                                                textBoxComprimento.Focus();
                                            }

                                        } else {
                                            MessageBox.Show("A altura da caixa é obrigatório");
                                            textBoxLargura.Focus();
                                        }

                                    } catch (Exception) {

                                        MessageBox.Show("Formato inválido da largura da caixa, revise.");
                                        textBoxLargura.Focus();
                                    }

                                } else {
                                    MessageBox.Show("A altura da caixa é obrigatório");
                                    textBoxAltura.Focus();
                                }

                            } catch (Exception) {

                                MessageBox.Show("Formato inválido da altura da caixa, revise.");
                                textBoxAltura.Focus();
                            }

                        } else {
                            MessageBox.Show("O peso da caixa é obrigatório");
                            txtPesoCaixas.Focus();
                        }

                    } catch (Exception) {

                        MessageBox.Show("Formato inválido do peso da caixa, revise.");
                        txtPesoCaixas.Focus();
                    }

                } else {
                    MessageBox.Show("O nome inserido é inválido");
                    txtNomeCaixas.Focus();
                }

            } catch (Exception) {
                MessageBox.Show("O nome inserido é inválido");
                txtNomeCaixas.Focus();
            }
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtPesquisarCaixas.Text.Equals(""))
            {
                carrgarCaixas();
                limparCamposCaixas(false, false);
            }
            else
            {
                pesquisarCaixas(txtPesquisaEmbalagens.Text);
                limparCamposCaixas(false, false);
            }
        }

        private void dataGridViewEmbalagens_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            habilitarBotoesEmbalagens(false, true, false, true, false);
            carregarGridEmbalagens();
        }

        private void dataGridViewEmbalagens_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            habilitarBotoesEmbalagens(false, true, false, true, false);
            carregarGridEmbalagens();
        }

        private void dataGridViewCaixas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            habilitarBotoesCaixas(false, true, false, true, false);
            carregarGridCaixas();
        }

        private void dataGridViewCaixas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNovoRegistroMateriaPrima_Click(object sender, EventArgs e)
        {
            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
            if (quemPode2.Equals(setor) || setor.Equals("Desenvolvimento")) {
            trueSalvarfalseAlterarMateriaPrima = true;
            limparCamposMateriaPrima(true, true);
            txtNomeMateriaPrima.Focus();
            habilitarBotoesMateriaPrima(false, false, true, false, true);
            } else {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de " + quemPode);
            }

        }

        private void btnAlterarMateriaPrima_Click(object sender, EventArgs e)
        {
            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
            if (quemPode2.Equals(setor) || setor.Equals("Desenvolvimento")) {
            habilitarBotoesMateriaPrima(false, false, true, false, true);
            habilitarCamposMateriaPrima();
            trueSalvarfalseAlterarMateriaPrima = false;
            } else {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de " + quemPode);
            }

        }

        private void btnCancelarMateriaPrima_Click(object sender, EventArgs e)
        {
            trueSalvarfalseAlterarMateriaPrima = true;
            limparCamposMateriaPrima(false, false);
            habilitarBotoesMateriaPrima(true, false, false, false, false);
        }

        private void btnExcluirMateriaPrima_Click(object sender, EventArgs e)
        {
            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
            if (quemPode2.Equals(setor) || setor.Equals("Desenvolvimento")) {
            // Initializes the variables to pass to the MessageBox.Show method.
            string message = "Deseja excluir o item (" + dataGridViewMateriaPrima.CurrentRow.Cells[1].Value.ToString() + ")\n\nImpossível reverter";
            string caption = "EXCLUIR ITEM";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (modelMateriaPrima.deletarMateriaPrimaController(txtCodigoMateriaPrima.Text = dataGridViewMateriaPrima.CurrentRow.Cells[0].Value.ToString()))
                {
                    carrgarMateriaPrima();
                    trueSalvarfalseAlterarMateriaPrima = true;
                    habilitarBotoesMateriaPrima(true, false, false, false, false);
                    limparCamposMateriaPrima(false, false);
                    MessageBox.Show("Item deletado com sucesso!");
                    txtNomeMateriaPrima.Text = "";
                    txtObservacoesMateriaPrima.Text = "";
                    txtCodigoMateriaPrima.Text = "";
                    qtdadeEstoqueMateriaPrima = 0;
                    txtNomeMateriaPrima.Focus();
                }
                else
                {
                    MessageBox.Show("Erro ao deletar o item.");
                }
            }
            } else {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de " + quemPode);
            }
            
        }

        private void dataGridViewMateriaPrima_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            habilitarBotoesMateriaPrima(false, true, false, true, false);
            carregarGridMateriaPrima();
        }

        private void dataGridViewMateriaPrima_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            habilitarBotoesMateriaPrima(false, true, false, true, false);
            carregarGridMateriaPrima();
        }

        private void btnSalvarMateriaPrima_Click(object sender, EventArgs e)
        {
            if (!txtNomeMateriaPrima.Text.Trim().Equals("") || txtNomeMateriaPrima.Text.Trim().Length > 4)
            {
                if (!txtObservacoesMateriaPrima.Text.Trim().Equals(""))
                {
                    gravarDadosMateriaPrima(trueSalvarfalseAlterarMateriaPrima, txtObservacoesMateriaPrima.Text);
                }
                else
                {
                    gravarDadosMateriaPrima(trueSalvarfalseAlterarMateriaPrima, "Item sem informação adicional");
                }
            }
            else
            {
                MessageBox.Show("O nome inserido é inválido");
                txtNomeMateriaPrima.Focus();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtPesquisarMateriaPrima.Text.Equals(""))
            {
                carrgarMateriaPrima();
                limparCamposMateriaPrima(false, false);
            }
            else
            {
                pesquisarMateriaPrima(txtPesquisarMateriaPrima.Text);
                limparCamposMateriaPrima(false, false);
            }
    }

        private void btnNovaTampa_Click(object sender, EventArgs e) {
            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
            if (quemPode.Equals(setor) || setor.Equals("Desenvolvimento")) {
            trueSalvarfalseAlterarTampa = true;
            limparCamposTampa(true, true);
            txtNomeTampa.Focus();
            habilitarBotoesTampa(false, false, true, false, true);
            } else {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de " + quemPode);
            }
            
        }

        private void btnAlterarTampa_Click(object sender, EventArgs e) {
            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
            if (quemPode.Equals(setor) || setor.Equals("Desenvolvimento")) {
            habilitarBotoesTampa(false, false, true, false, true);
            habilitarCamposTampa();
            trueSalvarfalseAlterarTampa = false;
            } else {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de " + quemPode);
            }

        }

        private void btnCancelarTampa_Click(object sender, EventArgs e) {
            trueSalvarfalseAlterarTampa = true;
            limparCamposTampa(false, false);
            habilitarBotoesTampa(true, false, false, false, false);
        }

        private void btnExcluirTampa_Click(object sender, EventArgs e) {
            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
            if (quemPode.Equals(setor) || setor.Equals("Desenvolvimento")) {
            // Initializes the variables to pass to the MessageBox.Show method.
            string message = "Deseja excluir o item (" + dataGridViewTampa.CurrentRow.Cells[1].Value.ToString() + ")\n\nImpossível reverter";
            string caption = "EXCLUIR ITEM";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes) {
                if (modelTampa.deletarTampaController(txtCodigoTampa.Text = dataGridViewTampa.CurrentRow.Cells[0].Value.ToString())) {
                    carrgarTampa();
                    trueSalvarfalseAlterarTampa = true;
                    habilitarBotoesTampa(true, false, false, false, false);
                    limparCamposTampa(false, false);
                    MessageBox.Show("Item deletado com sucesso!");
                    txtNomeTampa.Text = "";
                    txtObservacaoTampa.Text = "";
                    txtCodigoTampa.Text = "";
                    qtdadeEstoqueTampa = 0;
                    txtNomeTampa.Focus();
                } else {
                    MessageBox.Show("Erro ao deletar o item.");
                }
            }
            } else {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de " + quemPode);
            }
            
        }

        private void btnSalvarTampa_Click(object sender, EventArgs e) {
            if (!txtNomeTampa.Text.Trim().Equals("") || txtNomeTampa.Text.Trim().Length > 4) {
                if (!txtPesoTampa.Text.Trim().Equals("")) {
                    if (!txtObservacaoTampa.Text.Trim().Equals("")) {
                        gravarDadosTampa(trueSalvarfalseAlterarTampa, txtObservacaoTampa.Text);
                    } else {
                        gravarDadosTampa(trueSalvarfalseAlterarTampa, "Item sem informação adicional");
                    }
                } else {
                    MessageBox.Show("O peso inserido é inválido");
                    txtNomeTampa.Focus();
                }
            } else {
                MessageBox.Show("O nome inserido é inválido");
                txtNomeTampa.Focus();
            }
        }

        private void dataGridViewTampa_CellClick(object sender, DataGridViewCellEventArgs e) {
            habilitarBotoesTampa(false, true, false, true, false);
            carregarGridTampa();
        }

        private void btnPesquisarTampa_Click(object sender, EventArgs e) {
            if (txtPesquisarTampa.Text.Equals("")) {
                carrgarTampa();
                limparCamposTampa(false, false);
            } else {
                pesquisarTampa(txtPesquisarTampa.Text);
                limparCamposTampa(false, false);
            }
        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }
    }
}
