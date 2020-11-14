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
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revtec_Bioquimica.View {
    public partial class Pedidos : Form {

        ControllerPedido controllerPedido = new ControllerPedido();
        ModelPedido atualizar2;
        int quantidadePorCaixaSelected = 0;
        Conexao cnn = new Conexao();
        DAOProduto daoProduto = new DAOProduto();
        DAOPedidoLista dAOPedidoLista = new DAOPedidoLista();
        DAOPedido dAOPedido = new DAOPedido();
        DAOCaixas daoCaixas = new DAOCaixas();
        DAOTampa daoTampa = new DAOTampa();
        DAOClientes daoCliente = new DAOClientes();
        DAOEmbalagens daoEmbalagens = new DAOEmbalagens();
        List<ModelPedido> listaModel = new List<ModelPedido>();
        List<ModelPedido> lista = new List<ModelPedido>();
        //ModelPedido modelPedido = new ModelPedido();
        ModelPedidoLista modelPedidoLista = new ModelPedidoLista();
        ModelPedido mp = new ModelPedido();
        ModelClientes cliente;
        int codigoDoItem = 0;
        int ultimoIdSalvo = 0;
        ModelPedido verificarPedido = new ModelPedido();
        ModelCaixas modelCaixas = new ModelCaixas();
        ModelClientes verificarCliente = new ModelClientes();
        int idItemExcluir = 0;
        int idPedidoApagar = 0;
        int idPedidoLista = -1;
        int idUsuario = -1;
        String quemPode = "Produção";

        public Pedidos(int idPedido, int id) {
            InitializeComponent();
            idPedidoLista = idPedido;
            idUsuario = id;            
            carregarClientes();
            carregarLitragem();
            carregarProdutos();
            carregarFrasco();
            capturarDataAtual();
            carrgarGridPedidos();
            carregarCaixa();
            carregarTampa();
            btnStatusLancado.BackColor = Color.FloralWhite;
            buttonLoteSolicitado.BackColor = Color.LemonChiffon;
            buttonIRotuloSolicitado.BackColor = Color.LightSkyBlue;
            buttonItemConcluido.BackColor = Color.LightGreen;
            CarregarItem();
            habilitarCampoDeCima(true);
        }

        private void button5_Click(object sender, EventArgs e) {
            Close();
        }

        private void comboBoxLitragem_SelectedValueChanged(object sender, EventArgs e) {
            if (comboBoxLitragem.Text.Equals("300 Ml")) {
                textBoxQtdadePorCaixa.Text = "24";
            } else if (comboBoxLitragem.Text.Equals("500 Gr")) {
                textBoxQtdadePorCaixa.Text = "12";
            } else if (comboBoxLitragem.Text.Equals("500 Ml")) {
                textBoxQtdadePorCaixa.Text = "12";
            } else if (comboBoxLitragem.Text.Equals("1 Litro")) {
                textBoxQtdadePorCaixa.Text = "12";
            } else if (comboBoxLitragem.Text.Equals("2 Litros")) {
                textBoxQtdadePorCaixa.Text = "6";
            } else if (comboBoxLitragem.Text.Equals("5 Litros")) {
                textBoxQtdadePorCaixa.Text = "4";
            } else if (comboBoxLitragem.Text.Equals("20 Litros")) {
                textBoxQtdadePorCaixa.Text = "1";
            } else if (comboBoxLitragem.Text.Equals("50 Litros")) {
                textBoxQtdadePorCaixa.Text = "1";
            } else if (comboBoxLitragem.Text.Equals("200 Litros")) {
                textBoxQtdadePorCaixa.Text = "1";
            } else if (comboBoxLitragem.Text.Equals("1000 Litros")) {
                textBoxQtdadePorCaixa.Text = "1";
            }
        }

        private void buttonCancelarItem_Click(object sender, EventArgs e) {

            if (dataGridViewPedidosAdd.CurrentRow.Cells[22].Value.ToString().Equals("Lançado") || dataGridViewPedidosAdd.CurrentRow.Cells[22].Value.ToString().Equals("Lote Solicitado") || dataGridViewPedidosAdd.CurrentRow.Cells[22].Value.ToString().Equals("Rótulo Solicitado")) {
                MessageBox.Show("Para cancelar um produto que ainda não foi concluído utilize excluir item");
            } else {
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "Deseja cancelar este item? \nO item será adicionado ao estoque.";
                string caption = "Cancelar Item do pedido";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.Yes) {

                    int idPedido = int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[0].Value.ToString());
                    ModelPedido itensDoPedido = new ModelPedido();
                    ControllerPedido controllerPedido = new ControllerPedido();
                    itensDoPedido = controllerPedido.recuperarDadosDoItemPeloId(int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[0].Value.ToString()));

                    ModelExpedicao modelExpedicao = new ModelExpedicao();
                    ModelProdutoAcabado dadosProdutoAcabado = new ModelProdutoAcabado();
                    ControllerProdutoAcabado controllerPedidoLista = new ControllerProdutoAcabado();
                    ControllerExpedicao controllerExpedicao = new ControllerExpedicao();
                    ControllerPedidoLista controllerListaPedidos = new ControllerPedidoLista();
                    ModelPedidoLista listaDePedidos = new ModelPedidoLista();
                    listaDePedidos = controllerListaPedidos.dadosDoPedidoLista(int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[6].Value.ToString()));

                    dadosProdutoAcabado = controllerPedidoLista.recuperarDadosProdutoAcabado(dataGridViewPedidosAdd.CurrentRow.Cells[13].Value.ToString() + " - " + dataGridViewPedidosAdd.CurrentRow.Cells[10].Value.ToString());
                    dadosProdutoAcabado.Pro_estoque += int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[12].Value.ToString());

                    modelExpedicao = controllerExpedicao.recuperarDadosDaExpedicaoPeloId(int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[6].Value.ToString()));
                    modelExpedicao.Expedicao_volume -= int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[18].Value.ToString().Replace(" ", "").Replace("caixas", "").Replace("caixa", "").Replace("bombonas", "").Replace("bombona", "").Replace("tambores", "").Replace("tambor", "").Replace("containners", "").Replace("containner", ""));
                    controllerExpedicao.atualizarClientesController(modelExpedicao);

                    if (controllerPedidoLista.atualizarProdutoController(dadosProdutoAcabado)) {
                        if (controllerPedido.deletarPedidoController(int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[0].Value.ToString()))) {
                            carrgarGridPedidos();
                            if (int.Parse(dataGridViewPedidosAdd.Rows.Count.ToString()) < 1) {
                                if (controllerListaPedidos.deletarPedidoListaController(listaDePedidos.Guia_id)) {
                                    if (modelPedidoLista.deletarPedidoListaPelaGuiaController(idPedido)) {
                                        if (controllerExpedicao.deletarExpedicaoController(idItemExcluir)) {
                                            //panelAddItens.Enabled = false;
                                            dataGridViewPedidosAdd.Enabled = false;
                                            //panelDadosPedido.Enabled = true;
                                            textBoxGuia.Text = "0000";
                                            textBoxGuia.Focus();
                                            capturarDataAtual();
                                            btnCancelar.Enabled = false;
                                            btnExcluir.Enabled = false;
                                            button3.Enabled = false;
                                            button4.Enabled = false;
                                            ultimoIdSalvo = 0;
                                            idItemExcluir = 0;
                                            MessageBox.Show("Pedido excluído\nEste era o último item do pedido\nO item foi adicionado ao estoque");
                                        }

                                    }
                                }
                            } else {
                                MessageBox.Show("Produto cancelado com sucesso, o item foi adicionado ao estoque");
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
            String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
            if (quemPode.Equals(setor) || setor.Equals("Desenvolvimento")) {
                try {
                    if (DateTime.Parse(textBoxPrevisaoDeEntrega.Text) > DateTime.Parse(textBoxDataAtual.Text)) {
                        try {
                            if (int.Parse(textBoxGuia.Text) > 0) {

                                ModelPedidoLista listaDePedido = new ModelPedidoLista();
                                ControllerPedidoLista controllerPedidoLista = new ControllerPedidoLista();
                                listaDePedido = controllerPedidoLista.verificaIdExistente(int.Parse(textBoxGuia.Text));

                                if (listaDePedido.Guia_id > 0) {

                                    if (listaDePedido.Situacao_pedido.Equals("Cancelado")) {
                                        MessageBox.Show("Este pedido foi cancelado dia " + listaDePedido.Pedido_dataEntrega + "\n\nMotivo: " + listaDePedido.Observacao);
                                    } else {
                                        idPedidoLista = int.Parse(textBoxGuia.Text);
                                        cliente = verificarCliente.recuperarClientePeloId(listaDePedido.Cliente_id);
                                        ultimoIdSalvo = modelPedidoLista.verificarPedidoEmAberto(int.Parse(textBoxGuia.Text));

                                        idPedidoLista = listaDePedido.Guia_id;
                                        comboBoxCliente.Text = cliente.Clientes_nome;
                                        textBoxPrevisaoDeEntrega.Text = listaDePedido.Pedido_dataEntrega;
                                        textBoxDataAtual.Text = listaDePedido.Pedido_dataCad;
                                        textBoxGuia.Text = listaDePedido.Guia_id.ToString();
                                        textBoxObservacao.Text = listaDePedido.Observacao;

                                        carrgarGridPedidos();
                                        habilitarCampoDeCima(false);
                                        btnCancelar.Enabled = true;
                                        btnExcluir.Enabled = true;
                                        button3.Enabled = true;
                                        button4.Enabled = true;
                                        buttonCancelarItem.Enabled = true;

                                        dataGridViewPedidosAdd.Enabled = true;
                                    }


                                } else {
                                    idPedidoLista = int.Parse(textBoxGuia.Text);
                                    carrgarGridPedidos();
                                    habilitarCampoDeCima(false);
                                    btnCancelar.Enabled = true;
                                    btnExcluir.Enabled = true;
                                    button3.Enabled = true;
                                    button4.Enabled = true;
                                    buttonCancelarItem.Enabled = true;
                                    dataGridViewPedidosAdd.Enabled = true;
                                }

                            } else {
                                MessageBox.Show("Informe o número do pedido");
                                textBoxGuia.Focus();
                            }
                        } catch (Exception) {
                            MessageBox.Show("Número do pedido inválido");
                            textBoxGuia.Focus();
                        }
                    } else {
                        MessageBox.Show("A data de entrega não pode ser anterior a data de cadastro.");
                    }
                } catch (Exception) {
                    MessageBox.Show("Data de entrega inválida, revise os dados");
                    textBoxPrevisaoDeEntrega.Focus();
                }
            } else {
                MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de " + quemPode);
            }


        }

        private void habilitarCampoDeCima(bool valor)
        {
            comboBoxCliente.Enabled = valor;
            textBoxDataAtual.Enabled = valor;
            textBoxPrevisaoDeEntrega.Enabled = valor;
            textBoxGuia.Enabled = valor;
            textBoxObservacao.Enabled = valor;
            button1.Enabled = valor;

            comboBoxProduto.Enabled = !valor;
            comboBoxLitragem.Enabled = !valor;
            textBoxQuantidade.Enabled = !valor;
            textBoxQtdadePorCaixa.Enabled = !valor;
            comboBoxEmbalagens.Enabled = !valor;
            comboBoxCaixa.Enabled = !valor;
            comboBoxTampa.Enabled = !valor;
            button2.Enabled = !valor;



        }

        private void carregarClientes() {
            DAOClientes dAOClientes = new DAOClientes();
            comboBoxCliente.DisplayMember = "clientes_nome";
            comboBoxCliente.DataSource = dAOClientes.recuperarClientes();

        }

        private void btnStatusLancado_Click(object sender, EventArgs e) {

        }

        private void carregarLitragem() {
            DAOClientes dAOClientes = new DAOClientes();
            comboBoxLitragem.DisplayMember = "litragem";
            comboBoxLitragem.DataSource = dAOClientes.recuperarLitragem();

        }

        private void labelStatus_Click(object sender, EventArgs e) {

        }

        private void carregarFrasco() {

            comboBoxEmbalagens.DisplayMember = "embalagens_nome";
            comboBoxEmbalagens.DataSource = daoEmbalagens.recuperarEmbalagem();

        }

        private void carregarCaixa() {

            comboBoxCaixa.DisplayMember = "caixas_nome";
            comboBoxCaixa.DataSource = daoCaixas.recuperarCaixa();

        }

        private void carregarTampa() {

            comboBoxTampa.DisplayMember = "tampa_nome";
            comboBoxTampa.DataSource = daoTampa.recuperarTampa();

        }

        private void carregarProdutos() {
            DAOProduto dAOClientes = new DAOProduto();
            comboBoxProduto.DisplayMember = "pro_nome";
            comboBoxProduto.DataSource = dAOClientes.recuperarProdutos();

        }

        private void capturarDataAtual() {
            DateTime DataAtual = System.DateTime.Now;
            textBoxDataAtual.Text = System.DateTime.Now.AddDays(0).ToString("dd/MM/yyyy");
            textBoxPrevisaoDeEntrega.Text = System.DateTime.Now.AddDays(5).ToString("dd/MM/yyyy");
        }

        private void popularLista(string qtdadeCaixa, int qtdadeMultiplicar) {

            double litragem = 0;

            if (comboBoxLitragem.Text.Equals("300 Ml")) {
                litragem = 0.3;
            } else if (comboBoxLitragem.Text.Equals("500 Gr")) {
                litragem = 0.5;
            } else if (comboBoxLitragem.Text.Equals("500 Ml")) {
                litragem = 0.5;
            } else if (comboBoxLitragem.Text.Equals("1 Litro")) {
                litragem = 1;
            } else if (comboBoxLitragem.Text.Equals("2 Litros")) {
                litragem = 2;
            } else if (comboBoxLitragem.Text.Equals("5 Litros")) {
                litragem = 5;
            } else if (comboBoxLitragem.Text.Equals("20 Litros")) {
                litragem = 20;
            } else if (comboBoxLitragem.Text.Equals("50 Litros")) {
                litragem = 50;
            } else if (comboBoxLitragem.Text.Equals("200 Litros")) {
                litragem = 200;
            } else if (comboBoxLitragem.Text.Equals("1000 Litros")) {
                litragem = 1000;
            }

            int idDoCliente = daoCliente.idCliPeloNome(comboBoxCliente.Text);
            int idDaCaixa = daoCliente.idCaixaPeloNome(comboBoxCaixa.Text);
            int idDoFrasco = daoCliente.idFrascoPeloNome(comboBoxEmbalagens.Text);
            int idDoProduto = daoProduto.idProdutoPeloNome(comboBoxProduto.Text);
            int idDaTampa = daoCliente.idTampaPeloNome(comboBoxTampa.Text);
            String nomeDoClienteExpedicao = dAOPedidoLista.nomeClientePeloId(idDoCliente);

            double pesoProduto = 0;
            double pesoDaTampa = 0;
            double pesoEmbalagem = 0;
            double pesoDaCaixa = 0;
            double pesoDaUnidade = 0;
            int quantidadePedida = 0;
            int quantidadePorCaixa = 0;
            double litragemTotal = 0;
            double larguraCaixa = 0;
            double alturaCaixa = 0;
            double comprimentoCaixa = 0;
            double cubagemUnitaria = 0;
            double pesoDaCaixaFechada = 0;
            double pesoTotal = 0;
            String nomeDoCliente = "";

            ModelProduto dadosProduto = new ModelProduto();
            ControllerProduto controllerProduto = new ControllerProduto();
            dadosProduto = controllerProduto.retornarProdutoPeloId(idDoProduto);

            ModelTampa dadosTampa = new ModelTampa();
            ControllerTampa controllerTampa = new ControllerTampa();
            dadosTampa = controllerTampa.recuperarDadosDaTampa(idDaTampa);

            ModelCaixas dadosCaixa = new ModelCaixas();
            ControllerCaixas controllerCaixas = new ControllerCaixas();
            dadosCaixa = controllerCaixas.recuperarCaixaPeloId(idDaCaixa);

            alturaCaixa = dadosCaixa.Caixas_altura;
            larguraCaixa = dadosCaixa.Caixas_largura;
            comprimentoCaixa = dadosCaixa.Caixas_comprimento;
            cubagemUnitaria = double.Parse((alturaCaixa * larguraCaixa * comprimentoCaixa).ToString("F5"));

            ModelPedido modelPedido = new ModelPedido();
            modelPedido.Cubagem_unidade = cubagemUnitaria;
            modelPedido.Cubagem_total = double.Parse((cubagemUnitaria * int.Parse(qtdadeCaixa.ToString().Replace(" ", "").Replace("caixas", "").Replace("caixa", "").Replace("bombonas", "").Replace("bombona", "").Replace("tambores", "").Replace("tambor", "").Replace("containners", "").Replace("containner", ""))).ToString("F5"));

            ModelEmbalagens dadosFrascos = new ModelEmbalagens();
            ControllerEmbalagens controllerEmbalagens = new ControllerEmbalagens();
            dadosFrascos = controllerEmbalagens.recuperarDadosEmbalagensPeloId(idDoFrasco);

            ModelLote dadosDoLote = new ModelLote();
            ControllerLote controllerLote = new ControllerLote();
            dadosDoLote = controllerLote.recuperarDadosDaNomeDoProduto(comboBoxProduto.Text);

            ModelProdutoAcabado dadosProdutoAcabado = new ModelProdutoAcabado();
            ModelProdutoAcabado dadosProdutoAcabadoV = new ModelProdutoAcabado();
            ControllerProdutoAcabado controllerProdutoAcabado = new ControllerProdutoAcabado();
            dadosProdutoAcabado = controllerProdutoAcabado.dadosDoProdutoAcabadoPeloId(comboBoxProduto.Text);
            dadosProdutoAcabadoV = controllerProdutoAcabado.dadosDoProdutoAcabadoPeloId(comboBoxProduto.Text + " - " + comboBoxLitragem.Text);

            ControllerExpedicao controllerExpedicaoVerifica = new ControllerExpedicao();

            if (controllerProdutoAcabado.checaEstoque(comboBoxProduto.Text + " - " + comboBoxLitragem.Text) > 0) {

                ModelProdutoAcabado dadosDoProdutoEmEstoque = new ModelProdutoAcabado();
                dadosDoProdutoEmEstoque = controllerProdutoAcabado.recuperarDadosProdutoAcabado(comboBoxProduto.Text + " - " + comboBoxLitragem.Text);

                // Initializes the variables to pass to the MessageBox.Show method.
                string mensagem = "O produto " + dadosDoProdutoEmEstoque.Pro_nome + " consta em estoque deseja utilizar ?\n\n" +
                    "Quantidade em estoque: " + int.Parse(dadosDoProdutoEmEstoque.Pro_estoque.ToString("F0")).ToString();
                string captionn = "Produto consta em estoque";
                MessageBoxButtons buttonss = MessageBoxButtons.YesNo;
                DialogResult resultt;

                // Displays the MessageBox.
                resultt = MessageBox.Show(mensagem, captionn, buttonss);
                if (resultt == DialogResult.Yes) {
                    if (int.Parse(textBoxQuantidade.Text) > int.Parse(dadosDoProdutoEmEstoque.Pro_estoque.ToString("F0"))) {
                        dadosDoProdutoEmEstoque.Pro_estoque = 0;
                        if (controllerProdutoAcabado.atualizarProdutoController(dadosDoProdutoEmEstoque)) {

                            pesoProduto = double.Parse(dadosProduto.Pro_peso.ToString("F3"));
                            pesoDaTampa = double.Parse(dadosTampa.Tampa_peso.ToString("F3"));
                            pesoEmbalagem = double.Parse(dadosFrascos.Embalagens_peso.ToString("F3"));
                            pesoDaCaixa = double.Parse(dadosCaixa.Caixas_peso.ToString("F3"));
                            pesoDaUnidade = double.Parse(((dadosProduto.Pro_peso * litragem) + pesoDaTampa + pesoEmbalagem).ToString("F3"));
                            quantidadePedida = int.Parse(textBoxQuantidade.Text);
                            quantidadePorCaixa = quantidadePorCaixaSelected;
                            litragemTotal = litragem * quantidadePedida;
                            larguraCaixa = dadosCaixa.Caixas_largura;
                            alturaCaixa = dadosCaixa.Caixas_altura;
                            comprimentoCaixa = dadosCaixa.Caixas_comprimento;
                            
                            pesoDaCaixaFechada = double.Parse(((pesoDaUnidade * quantidadePorCaixa) + pesoDaCaixa).ToString("F3"));
                            pesoTotal = double.Parse((pesoDaCaixaFechada * qtdadeMultiplicar).ToString("F3"));
                            nomeDoCliente = dAOPedidoLista.nomeClientePeloId(idDoCliente);

                            modelPedido.Cliente_id = idDoCliente;
                            modelPedido.Frasco_id = idDoFrasco;
                            modelPedido.Caixa_id = idDaCaixa;
                            modelPedido.Tampa_id = idDaTampa;
                            modelPedido.Produto_id = idDoProduto;
                            modelPedido.Guia_id = int.Parse(textBoxGuia.Text);
                            modelPedido.Pedido_dataCad = textBoxDataAtual.Text;
                            modelPedido.Pedido_dataEntrega = textBoxPrevisaoDeEntrega.Text;
                            modelPedido.Pedido_observacao = textBoxObservacao.Text;
                            modelPedido.Litragem_escrita = comboBoxLitragem.Text;
                            modelPedido.Pedido_litragem = double.Parse(litragem.ToString("F3"));
                            modelPedido.Pedido_quantidade = int.Parse(textBoxQuantidade.Text);
                            modelPedido.Nome_item = comboBoxProduto.Text;
                            modelPedido.Caixa_peso = double.Parse(Math.Round(pesoDaCaixa, 3).ToString("F3"));
                            modelPedido.Tampa_peso = Math.Round(pesoDaTampa, 3);
                            modelPedido.Frasco_peso = Math.Round(pesoEmbalagem, 3);
                            modelPedido.Produto_peso = double.Parse(Math.Round(pesoProduto, 3).ToString("F3"));
                            modelPedido.Peso_unidade = Math.Round(pesoDaUnidade, 3);
                            modelPedido.Peso_caixa = Math.Round(pesoDaCaixaFechada, 3);
                            modelPedido.Peso_total = Math.Round(pesoTotal, 3);

                            if (comboBoxLitragem.Text.Equals("20 Litros") | comboBoxLitragem.Text.Equals("50 Litros") | comboBoxLitragem.Text.Equals("100 Litros") | comboBoxLitragem.Text.Equals("1000 Litros"))
                            {
                                modelPedido.Quantidade_int = int.Parse(textBoxQuantidade.Text);
                                modelPedido.Quantidade_caixa = "0 caixa";

                            }
                            else
                            {
                                if (comboBoxCaixa.Text == "ITEM SEM CAIXA")
                                {
                                    modelPedido.Quantidade_caixa = "0 caixa";
                                    modelPedido.Quantidade_int = 0;
                                }
                                else
                                {
                                    modelPedido.Quantidade_caixa = qtdadeCaixa;
                                    modelPedido.Quantidade_int = int.Parse(qtdadeCaixa.ToString().Replace(" ", "").Replace("caixas", "").Replace("caixa", "").Replace("bombonas", "").Replace("bombona", "").Replace("tambores", "").Replace("tambor", "").Replace("containners", "").Replace("containner", ""));
                                }                                
                            }                            
                            modelPedido.Item_status = "Item concluído";
                            modelPedido.Volume_litros = double.Parse(litragemTotal.ToString("F3"));
                            modelPedido.Pedido_loteUsado = "Aguardando";
                            
                            modelPedido.Cliente_nome = nomeDoCliente.ToUpper();
                            modelPedidoLista.Guia_id = int.Parse(textBoxGuia.Text);
                            modelPedidoLista.Cliente_id = daoCliente.idCliPeloNome(comboBoxCliente.Text);
                            modelPedidoLista.Nome_cliente = nomeDoCliente;
                            modelPedidoLista.Pedido_dataCad = textBoxDataAtual.Text;
                            modelPedidoLista.Pedido_dataEntrega = textBoxPrevisaoDeEntrega.Text;
                            modelPedidoLista.Pedido_status = "Item concluído";
                            modelPedidoLista.Situacao_pedido = "Ativo";
                            modelPedidoLista.Observacao = textBoxObservacao.Text;

                            if (ultimoIdSalvo == 0) {
                                ultimoIdSalvo = modelPedidoLista.salvarPedidoListaController(modelPedidoLista);
                            }

                            if (modelPedido.salvarPedidoController(modelPedido)) {

                                salvarExpdicao(idPedidoLista, modelPedido, nomeDoCliente);

                                idPedidoLista = int.Parse(textBoxGuia.Text);
                                carrgarGridPedidos();
                                MessageBox.Show("A quantidade de " + textBoxQuantidade.Text + " e o estoque foi zerado.");
                                textBoxQuantidade.Text = "1";
                                textBoxQtdadePorCaixa.Text = "1";
                                idPedidoLista = int.Parse(textBoxGuia.Text);
                            } else {
                                MessageBox.Show("Erro ao adicionar o item");
                            }

                        }
                    } else {

                        dadosDoProdutoEmEstoque.Pro_estoque -= int.Parse(textBoxQuantidade.Text);
                        if (controllerProdutoAcabado.atualizarProdutoController(dadosDoProdutoEmEstoque)) {

                            pesoProduto = double.Parse(dadosProduto.Pro_peso.ToString("F3"));
                            pesoDaTampa = double.Parse(dadosTampa.Tampa_peso.ToString("F3"));
                            pesoEmbalagem = double.Parse(dadosFrascos.Embalagens_peso.ToString("F3"));
                            pesoDaCaixa = double.Parse(dadosCaixa.Caixas_peso.ToString("F3"));
                            pesoDaUnidade = double.Parse(((dadosProduto.Pro_peso * litragem) + pesoDaTampa + pesoEmbalagem).ToString("F3"));
                            quantidadePedida = int.Parse(textBoxQuantidade.Text);
                            quantidadePorCaixa = quantidadePorCaixaSelected;
                            litragemTotal = litragem * quantidadePedida;
                            larguraCaixa = dadosCaixa.Caixas_largura;
                            alturaCaixa = dadosCaixa.Caixas_altura;
                            comprimentoCaixa = dadosCaixa.Caixas_comprimento;
                            cubagemUnitaria = double.Parse((alturaCaixa * larguraCaixa * comprimentoCaixa).ToString("F5"));
                            pesoDaCaixaFechada = double.Parse(((pesoDaUnidade * quantidadePorCaixa) + pesoDaCaixa).ToString("F3"));
                            pesoTotal = double.Parse((pesoDaCaixaFechada * qtdadeMultiplicar).ToString("F3"));
                            nomeDoCliente = dAOPedidoLista.nomeClientePeloId(idDoCliente);

                            modelPedido.Cliente_id = idDoCliente;
                            modelPedido.Frasco_id = idDoFrasco;
                            modelPedido.Caixa_id = idDaCaixa;
                            modelPedido.Tampa_id = idDaTampa;
                            modelPedido.Produto_id = idDoProduto;
                            modelPedido.Guia_id = int.Parse(textBoxGuia.Text);
                            modelPedido.Pedido_dataCad = textBoxDataAtual.Text;
                            modelPedido.Pedido_dataEntrega = textBoxPrevisaoDeEntrega.Text;
                            modelPedido.Pedido_observacao = textBoxObservacao.Text;
                            modelPedido.Litragem_escrita = comboBoxLitragem.Text;
                            modelPedido.Pedido_litragem = double.Parse(litragem.ToString("F3"));
                            modelPedido.Pedido_quantidade = int.Parse(textBoxQuantidade.Text);
                            modelPedido.Nome_item = comboBoxProduto.Text;
                            modelPedido.Caixa_peso = double.Parse(Math.Round(pesoDaCaixa, 3).ToString("F3"));
                            modelPedido.Tampa_peso = Math.Round(pesoDaTampa, 3);
                            modelPedido.Frasco_peso = Math.Round(pesoEmbalagem, 3);
                            modelPedido.Produto_peso = double.Parse(Math.Round(pesoProduto, 3).ToString("F3"));
                            modelPedido.Peso_unidade = Math.Round(pesoDaUnidade, 3);
                            modelPedido.Peso_caixa = Math.Round(pesoDaCaixaFechada, 3);
                            modelPedido.Peso_total = Math.Round(pesoTotal, 3);
                            if (comboBoxLitragem.Text.Equals("20 Litros") | comboBoxLitragem.Text.Equals("50 Litros") | comboBoxLitragem.Text.Equals("100 Litros") | comboBoxLitragem.Text.Equals("1000 Litros"))
                            {
                                modelPedido.Quantidade_int = int.Parse(textBoxQuantidade.Text);
                                modelPedido.Quantidade_caixa = "0 caixa";

                            }
                            else
                            {
                                if (comboBoxCaixa.Text == "ITEM SEM CAIXA")
                                {
                                    modelPedido.Quantidade_caixa = "0 caixa";
                                    modelPedido.Quantidade_int = 0;
                                }
                                else
                                {
                                    modelPedido.Quantidade_caixa = qtdadeCaixa;
                                    modelPedido.Quantidade_int = int.Parse(qtdadeCaixa.ToString().Replace(" ", "").Replace("caixas", "").Replace("caixa", "").Replace("bombonas", "").Replace("bombona", "").Replace("tambores", "").Replace("tambor", "").Replace("containners", "").Replace("containner", ""));
                                }
                            }
                            modelPedido.Item_status = "Item concluído";
                            modelPedido.Pedido_loteUsado = "Aguardando";
                            modelPedido.Volume_litros = double.Parse(litragemTotal.ToString("F3"));
                            modelPedido.Cliente_nome = nomeDoCliente.ToUpper(); 

                            modelPedidoLista.Guia_id = int.Parse(textBoxGuia.Text);
                            modelPedidoLista.Cliente_id = daoCliente.idCliPeloNome(comboBoxCliente.Text);
                            modelPedidoLista.Nome_cliente = nomeDoCliente;
                            modelPedidoLista.Pedido_dataCad = textBoxDataAtual.Text;
                            modelPedidoLista.Pedido_dataEntrega = textBoxPrevisaoDeEntrega.Text;
                            modelPedidoLista.Pedido_status = "Item concluído";
                            modelPedidoLista.Situacao_pedido = "Ativo";
                            modelPedidoLista.Observacao = textBoxObservacao.Text;

                            if (ultimoIdSalvo == 0) {
                                ultimoIdSalvo = modelPedidoLista.salvarPedidoListaController(modelPedidoLista);
                            }

                            if (modelPedido.salvarPedidoController(modelPedido)) {

                                salvarExpdicao(idPedidoLista, modelPedido, nomeDoCliente);

                                idPedidoLista = int.Parse(textBoxGuia.Text);
                                carrgarGridPedidos();
                                MessageBox.Show("Estoque atualizado\n\nQuantidade retirada do estoque: " + textBoxQuantidade.Text + "\n" +
                                "Nova quantidade em estoque: " + dadosDoProdutoEmEstoque.Pro_estoque.ToString());
                                textBoxQuantidade.Text = "1";
                                textBoxQtdadePorCaixa.Text = "1";
                                idPedidoLista = int.Parse(textBoxGuia.Text);
                            } else {
                                MessageBox.Show("Erro ao adicionar o item");
                            }
                        }
                    }
                } else {
                    pesoProduto = double.Parse(dadosProduto.Pro_peso.ToString("F3"));
                    pesoDaTampa = double.Parse(dadosTampa.Tampa_peso.ToString("F3"));
                    pesoEmbalagem = double.Parse(dadosFrascos.Embalagens_peso.ToString("F3"));
                    pesoDaCaixa = double.Parse(dadosCaixa.Caixas_peso.ToString("F3"));
                    pesoDaUnidade = double.Parse(((dadosProduto.Pro_peso * litragem) + pesoDaTampa + pesoEmbalagem).ToString("F3"));
                    quantidadePedida = int.Parse(textBoxQuantidade.Text);
                    quantidadePorCaixa = quantidadePorCaixaSelected;
                    litragemTotal = litragem * quantidadePedida;
                    larguraCaixa = dadosCaixa.Caixas_largura;
                    alturaCaixa = dadosCaixa.Caixas_altura;
                    comprimentoCaixa = dadosCaixa.Caixas_comprimento;
                    cubagemUnitaria = double.Parse((alturaCaixa * larguraCaixa * comprimentoCaixa).ToString("F5"));
                    pesoDaCaixaFechada = double.Parse(((pesoDaUnidade * quantidadePorCaixa) + pesoDaCaixa).ToString("F3"));
                    pesoTotal = double.Parse((pesoDaCaixaFechada * qtdadeMultiplicar).ToString("F3"));
                    nomeDoCliente = dAOPedidoLista.nomeClientePeloId(idDoCliente);

                    modelPedido.Cliente_id = idDoCliente;
                    modelPedido.Frasco_id = idDoFrasco;
                    modelPedido.Caixa_id = idDaCaixa;
                    modelPedido.Tampa_id = idDaTampa;
                    modelPedido.Produto_id = idDoProduto;
                    modelPedido.Guia_id = int.Parse(textBoxGuia.Text);
                    modelPedido.Pedido_dataCad = textBoxDataAtual.Text;
                    modelPedido.Pedido_dataEntrega = textBoxPrevisaoDeEntrega.Text;
                    modelPedido.Pedido_observacao = textBoxObservacao.Text;
                    modelPedido.Litragem_escrita = comboBoxLitragem.Text;
                    modelPedido.Pedido_litragem = litragem;
                    modelPedido.Pedido_quantidade = int.Parse(textBoxQuantidade.Text);
                    modelPedido.Nome_item = comboBoxProduto.Text;
                    modelPedido.Caixa_peso = double.Parse(Math.Round(pesoDaCaixa, 3).ToString("F3"));
                    modelPedido.Tampa_peso = Math.Round(pesoDaTampa, 3);
                    modelPedido.Frasco_peso = Math.Round(pesoEmbalagem, 3);
                    modelPedido.Produto_peso = double.Parse(Math.Round(pesoProduto, 3).ToString("F3"));
                    modelPedido.Peso_unidade = Math.Round(pesoDaUnidade, 3);
                    modelPedido.Peso_caixa = Math.Round(pesoDaCaixaFechada, 3);
                    modelPedido.Peso_total = Math.Round(pesoTotal, 3);
                    if (comboBoxLitragem.Text.Equals("20 Litros") | comboBoxLitragem.Text.Equals("50 Litros") | comboBoxLitragem.Text.Equals("100 Litros") | comboBoxLitragem.Text.Equals("1000 Litros"))
                    {
                        modelPedido.Quantidade_int = int.Parse(textBoxQuantidade.Text);
                        modelPedido.Quantidade_caixa = "0 caixa";

                    }
                    else
                    {
                        if (comboBoxCaixa.Text == "ITEM SEM CAIXA")
                        {
                            modelPedido.Quantidade_caixa = "0 caixa";
                            modelPedido.Quantidade_int = 0;
                        }
                        else
                        {
                            modelPedido.Quantidade_caixa = qtdadeCaixa;
                            modelPedido.Quantidade_int = int.Parse(qtdadeCaixa.ToString().Replace(" ", "").Replace("caixas", "").Replace("caixa", "").Replace("bombonas", "").Replace("bombona", "").Replace("tambores", "").Replace("tambor", "").Replace("containners", "").Replace("containner", ""));
                        }
                    }
                    modelPedido.Item_status = "Lançado";
                    modelPedido.Pedido_loteUsado = "Aguardando";
                    modelPedido.Volume_litros = double.Parse(litragemTotal.ToString("F3"));
                    modelPedido.Cliente_nome = nomeDoCliente.ToUpper();

                    modelPedidoLista.Guia_id = int.Parse(textBoxGuia.Text);
                    modelPedidoLista.Cliente_id = daoCliente.idCliPeloNome(comboBoxCliente.Text);
                    modelPedidoLista.Nome_cliente = nomeDoCliente;
                    modelPedidoLista.Pedido_dataCad = textBoxDataAtual.Text;
                    modelPedidoLista.Pedido_dataEntrega = textBoxPrevisaoDeEntrega.Text;
                    modelPedidoLista.Pedido_status = "Lançado";
                    modelPedidoLista.Situacao_pedido = "Ativo";
                    modelPedidoLista.Observacao = textBoxObservacao.Text;

                    // Initializes the variables to pass to the MessageBox.Show method.
                    string message = "Produto: " + comboBoxProduto.Text + "\n" +
                                     "Litragem: " + comboBoxLitragem.Text + "\n" +
                                     "Quantidade: " + textBoxQuantidade.Text + "\n" +
                                     "Caixa: " + comboBoxCaixa.Text + "\n" +
                                     "Recipiente: " + comboBoxEmbalagens.Text + "\n" +
                                     "Tampa: " + comboBoxTampa.Text + "\n\nEstá correto ?";
                    string caption = "Atenção revise os dados";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    // Displays the MessageBox.
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == DialogResult.Yes) {

                        if (dadosProdutoAcabadoV.Pro_id < 1) {
                            dadosProdutoAcabadoV.Pro_nome = comboBoxProduto.Text + " - " + comboBoxLitragem.Text;
                            dadosProdutoAcabadoV.Pro_estoque = 0;
                            dadosProdutoAcabadoV.Pro_observacao = "";
                            dadosProdutoAcabadoV.Pro_peso = Math.Round(pesoProduto, 3);
                            controllerProdutoAcabado.salvarProdutoController(dadosProdutoAcabadoV);
                        }

                        if (ultimoIdSalvo == 0) {
                            ultimoIdSalvo = modelPedidoLista.salvarPedidoListaController(modelPedidoLista);
                        }

                        if (modelPedido.salvarPedidoController(modelPedido)) {

                            salvarExpdicao(idPedidoLista, modelPedido, nomeDoCliente);

                            idPedidoLista = int.Parse(textBoxGuia.Text);
                            carrgarGridPedidos();
                            textBoxQuantidade.Text = "1";
                            textBoxQtdadePorCaixa.Text = "1";
                            idPedidoLista = int.Parse(textBoxGuia.Text);
                        } else {
                            MessageBox.Show("Erro ao adicionar o item");
                        }
                    }
                }
            } else {
                pesoProduto = double.Parse(dadosProduto.Pro_peso.ToString("F3"));
                pesoDaTampa = double.Parse(dadosTampa.Tampa_peso.ToString("F3"));
                pesoEmbalagem = double.Parse(dadosFrascos.Embalagens_peso.ToString("F3"));
                pesoDaCaixa = double.Parse(dadosCaixa.Caixas_peso.ToString("F3"));
                pesoDaUnidade = double.Parse(((dadosProduto.Pro_peso * litragem) + pesoDaTampa + pesoEmbalagem).ToString("F3"));
                quantidadePedida = int.Parse(textBoxQuantidade.Text);
                quantidadePorCaixa = quantidadePorCaixaSelected;
                litragemTotal = litragem * quantidadePedida;
                larguraCaixa = dadosCaixa.Caixas_largura;
                alturaCaixa = dadosCaixa.Caixas_altura;
                comprimentoCaixa = dadosCaixa.Caixas_comprimento;
                cubagemUnitaria = double.Parse((alturaCaixa * larguraCaixa * comprimentoCaixa).ToString("F5"));
                pesoDaCaixaFechada = double.Parse(((pesoDaUnidade * quantidadePorCaixa) + pesoDaCaixa).ToString("F3"));
                pesoTotal = double.Parse((pesoDaCaixaFechada * qtdadeMultiplicar).ToString("F3"));
                nomeDoCliente = dAOPedidoLista.nomeClientePeloId(idDoCliente);

                modelPedido.Cliente_id = idDoCliente;
                modelPedido.Frasco_id = idDoFrasco;
                modelPedido.Caixa_id = idDaCaixa;
                modelPedido.Tampa_id = idDaTampa;
                modelPedido.Produto_id = idDoProduto;
                modelPedido.Guia_id = int.Parse(textBoxGuia.Text);
                modelPedido.Pedido_dataCad = textBoxDataAtual.Text;
                modelPedido.Pedido_dataEntrega = textBoxPrevisaoDeEntrega.Text;
                modelPedido.Pedido_observacao = textBoxObservacao.Text;
                modelPedido.Litragem_escrita = comboBoxLitragem.Text;
                modelPedido.Pedido_litragem = litragem;
                modelPedido.Pedido_quantidade = int.Parse(textBoxQuantidade.Text);
                modelPedido.Nome_item = comboBoxProduto.Text;
                modelPedido.Caixa_peso = double.Parse(Math.Round(pesoDaCaixa, 3).ToString("F3"));
                modelPedido.Tampa_peso = Math.Round(pesoDaTampa, 3);
                modelPedido.Frasco_peso = Math.Round(pesoEmbalagem, 3);
                modelPedido.Produto_peso = double.Parse(Math.Round(pesoProduto, 3).ToString("F3"));
                modelPedido.Peso_unidade = Math.Round(pesoDaUnidade, 3);
                modelPedido.Peso_caixa = Math.Round(pesoDaCaixaFechada, 3);
                modelPedido.Peso_total = Math.Round(pesoTotal, 3);
                if (comboBoxLitragem.Text.Equals("20 Litros") | comboBoxLitragem.Text.Equals("50 Litros") | comboBoxLitragem.Text.Equals("100 Litros") | comboBoxLitragem.Text.Equals("1000 Litros"))
                {
                    modelPedido.Quantidade_int = int.Parse(textBoxQuantidade.Text);
                    modelPedido.Quantidade_caixa = "0 caixa";

                }
                else
                {
                    if (comboBoxCaixa.Text == "ITEM SEM CAIXA")
                    {
                        modelPedido.Quantidade_caixa = "0 caixa";
                        modelPedido.Quantidade_int = 0;
                    }
                    else
                    {
                        modelPedido.Quantidade_caixa = qtdadeCaixa;
                        modelPedido.Quantidade_int = int.Parse(qtdadeCaixa.ToString().Replace(" ", "").Replace("caixas", "").Replace("caixa", "").Replace("bombonas", "").Replace("bombona", "").Replace("tambores", "").Replace("tambor", "").Replace("containners", "").Replace("containner", ""));
                    }
                }
                modelPedido.Item_status = "Lançado";
                modelPedido.Pedido_loteUsado = "Aguardando";
                modelPedido.Volume_litros = double.Parse(litragemTotal.ToString("F3"));
                modelPedido.Cliente_nome = nomeDoCliente.ToUpper();

                modelPedidoLista.Guia_id = int.Parse(textBoxGuia.Text);
                modelPedidoLista.Cliente_id = daoCliente.idCliPeloNome(comboBoxCliente.Text);
                modelPedidoLista.Nome_cliente = nomeDoCliente;
                modelPedidoLista.Pedido_dataCad = textBoxDataAtual.Text;
                modelPedidoLista.Pedido_dataEntrega = textBoxPrevisaoDeEntrega.Text;
                modelPedidoLista.Pedido_status = "Lançado";
                modelPedidoLista.Situacao_pedido = "Ativo";
                modelPedidoLista.Observacao = textBoxObservacao.Text;

                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "Produto: " + comboBoxProduto.Text + "\n" +
                                 "Litragem: " + comboBoxLitragem.Text + "\n" +
                                 "Quantidade: " + textBoxQuantidade.Text + "\n" +
                                 "Caixa: " + comboBoxCaixa.Text + "\n" +
                                 "Recipiente: " + comboBoxEmbalagens.Text + "\n" +
                                 "Tampa: " + comboBoxTampa.Text + "\n\nEstá correto ?";
                string caption = "Atenção revise os dados";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.Yes) {

                    if (dadosProdutoAcabadoV.Pro_id < 1) {
                        dadosProdutoAcabadoV.Pro_nome = comboBoxProduto.Text + " - " + comboBoxLitragem.Text;
                        dadosProdutoAcabadoV.Pro_estoque = 0;
                        dadosProdutoAcabadoV.Pro_observacao = "";
                        dadosProdutoAcabadoV.Pro_peso = Math.Round(pesoProduto, 3);
                        controllerProdutoAcabado.salvarProdutoController(dadosProdutoAcabadoV);
                    }

                    if (ultimoIdSalvo == 0) {
                        ultimoIdSalvo = modelPedidoLista.salvarPedidoListaController(modelPedidoLista);
                    }

                    if (modelPedido.salvarPedidoController(modelPedido)) {

                        salvarExpdicao(idPedidoLista, modelPedido, nomeDoCliente);

                        idPedidoLista = int.Parse(textBoxGuia.Text);
                        carrgarGridPedidos();
                        textBoxQuantidade.Text = "1";
                        textBoxQtdadePorCaixa.Text = "1";
                        idPedidoLista = int.Parse(textBoxGuia.Text);
                    } else {
                        MessageBox.Show("Erro ao adicionar o item");
                    }
                }
            }
            if (controllerExpedicaoVerifica.checarItemParaConcluirExpedicao(idPedidoLista)) {
                //MessageBox.Show("Pedido em aberto");
                ControllerExpedicao controllerExpedicao = new ControllerExpedicao();
                ModelExpedicao modelExpedicao = new ModelExpedicao();
                modelExpedicao = controllerExpedicao.recuperarDadosDaExpedicaoPeloId(idPedidoLista);
                modelExpedicao.Expedicao_status = "Em produção";
                if (controllerExpedicao.atualizarClientesController(modelExpedicao)) {
                    //MessageBox.Show("Item em aberto");
                }
            } else {
                //MessageBox.Show("Pedido em aberto");
                ControllerExpedicao controllerExpedicao = new ControllerExpedicao();
                ModelExpedicao modelExpedicao = new ModelExpedicao();
                modelExpedicao = controllerExpedicao.recuperarDadosDaExpedicaoPeloId(idPedidoLista);
                modelExpedicao.Expedicao_status = "Concluído";
                if (controllerExpedicao.atualizarClientesController(modelExpedicao)) {
                    MessageBox.Show("Todos os itens foram concluídos.\nEncaminhe o pedido para expedição.");
                }
            }
        }

        private void salvarExpdicao(int idEmma, ModelPedido pedido, String nome) {

            ModelExpedicao modelExpedicao = new ModelExpedicao();
            ControllerExpedicao controllerExpedicao = new ControllerExpedicao();
            modelExpedicao = controllerExpedicao.recuperarDadosDaExpedicaoPeloId(idEmma);

            int paraExpedicao;

            int volumeDeCaixas = int.Parse(pedido.Quantidade_caixa.Replace(" ", "").Replace("caixas", "").Replace("caixa", "").Replace("bombonas", "").Replace("bombona", "").Replace("tambores", "").Replace("tambor", "").Replace("containners", "").Replace("containner", ""));

            if (comboBoxLitragem.Text == "20 Litros" || comboBoxLitragem.Text == "50 Litros" || comboBoxLitragem.Text == "200 Litros" || comboBoxLitragem.Text == "1000 Litros")
            {
                paraExpedicao = int.Parse(textBoxQuantidade.Text);
            } else
            {
                if (pedido.Quantidade_caixa == "ITEM SEM CAIXA")
                {
                    paraExpedicao = 0;
                } else
                {
                    paraExpedicao = volumeDeCaixas;
                }                
            }

            if (modelExpedicao.Expedicao_guia == idEmma) {
                modelExpedicao.Expedicao_guia = idEmma;
                modelExpedicao.Expedicao_volume += paraExpedicao;
                modelExpedicao.Expedicao_peso += pedido.Peso_total;
                modelExpedicao.Expedicao_cubagem += pedido.Cubagem_total;

                if (controllerExpedicao.atualizarExpedicaoDAO(modelExpedicao)) {
                    //MessageBox.Show("Expedição atualizada");
                }

            } else {

                modelExpedicao.Expedicao_guia = idEmma;
                modelExpedicao.Expedicao_cliente = nome;
                modelExpedicao.Expedicao_dataEntrada = pedido.Pedido_dataCad;
                modelExpedicao.Expedicao_dataEntrega = pedido.Pedido_dataEntrega;
                modelExpedicao.Expedicao_volume = paraExpedicao;
                modelExpedicao.Expedicao_peso = pedido.Peso_total;
                modelExpedicao.Expedicao_cubagem = pedido.Cubagem_total;
                modelExpedicao.Expedicao_status = "Em produção";
                modelExpedicao.Expedicao_entregaDate = DateTime.Parse(pedido.Pedido_dataEntrega);

                if (controllerExpedicao.salvarExpedicaoDAO(modelExpedicao)) {
                    //MessageBox.Show("Expedição salva");
                }
            }
        }

        private void cancelarPedido() {

            String motivoCancelamento = Interaction.InputBox("Informe o motivo do cancelamento", "Cancelar pedido", string.Empty, -1, -1);
            ControllerExpedicao controllerExpedicao = new ControllerExpedicao();

            if (motivoCancelamento.Length < 5) {
                MessageBox.Show("Informe corretamente o motivo do cancelamento.");
            } else {
                foreach (DataGridViewRow linha in dataGridViewPedidosAdd.Rows) {

                    int idPedido = int.Parse(linha.Cells[0].Value.ToString());
                    ModelPedido itensDoPedido = new ModelPedido();
                    ControllerPedido controllerPedido = new ControllerPedido();
                    itensDoPedido = controllerPedido.recuperarDadosDoItemPeloId(int.Parse(linha.Cells[0].Value.ToString()));
                    ControllerProdutoAcabado controllerProdutoAcabado = new ControllerProdutoAcabado();
                    ModelPedidoLista dadosPedidoLista = new ModelPedidoLista();
                    ModelPedido dadosPedido = new ModelPedido();
                    ModelProdutoAcabado dadosProdutoAcabado = new ModelProdutoAcabado();
                    ControllerProdutoAcabado controllerPedidoLista = new ControllerProdutoAcabado();

                    ControllerPedidoLista controllerListaPedidos = new ControllerPedidoLista();
                    ModelPedidoLista listaDePedidos = new ModelPedidoLista();
                    listaDePedidos = controllerListaPedidos.dadosDoPedidoLista(int.Parse(linha.Cells[6].Value.ToString()));
                    idPedidoApagar = int.Parse(linha.Cells[6].Value.ToString());
                    dadosProdutoAcabado = controllerPedidoLista.recuperarDadosProdutoAcabado(linha.Cells[13].Value.ToString() + " - " + linha.Cells[10].Value.ToString());

                    if (linha.Cells[22].Value.ToString().Equals("Item concluído")) {
                        dadosProdutoAcabado.Pro_estoque += int.Parse(linha.Cells[12].Value.ToString());
                    }

                    if (linha.Cells[22].Value.ToString().Equals("Lote Solicitado") || linha.Cells[22].Value.ToString().Equals("Rótulo Solicitado")) {
                        ModelLote dadosDoLote = new ModelLote();
                        ControllerLote controllerLote = new ControllerLote();
                        dadosDoLote = controllerLote.estornarLote(linha.Cells[26].Value.ToString());
                        dadosDoLote.Lote_litragem += double.Parse(linha.Cells[23].Value.ToString());
                        dadosDoLote.Lote_status = "Concluído";
                        MessageBox.Show("O item " + linha.Cells[13].Value.ToString() + " havia solicitado baixa no lote Nº "+ linha.Cells[26].Value.ToString() + " de "+ linha.Cells[23].Value.ToString() + " litros, como o item ainda não havia sido concluído a litragem solicitada voltou a constar em estoque de produto para envase.");

                        if (controllerLote.atualizarLoteController(dadosDoLote)) {
                            
                        }
                    }

                    dadosPedidoLista.Situacao_pedido = "Cancelado";
                    dadosPedidoLista.Observacao = motivoCancelamento;
                    dadosPedidoLista.Pedido_dataEntrega = DateTime.Now.AddDays(0).ToString("dd/MM/yyyy");
                    dadosPedido.Item_status = "Cancelado";

                    controllerListaPedidos.atualizarPedidoListaController(dadosPedidoLista);

                    if (controllerPedidoLista.atualizarProdutoController(dadosProdutoAcabado)) {
                        if (controllerPedido.deletarPedidoController(int.Parse(linha.Cells[0].Value.ToString()))) {
                            if (controllerListaPedidos.atualizarPedidoListaController(dadosPedidoLista)) {
                                if (int.Parse(dataGridViewPedidosAdd.Rows.Count.ToString()) < 1) {
                                    if (controllerListaPedidos.deletarPedidoListaController(listaDePedidos.Guia_id)) {
                                        if (modelPedidoLista.deletarPedidoListaPelaGuiaController(idPedido)) {
                                            if (controllerExpedicao.deletarExpedicaoController(idPedido)) {
                                                //panelAddItens.Enabled = false;
                                                dataGridViewPedidosAdd.Enabled = false;
                                                //panelDadosPedido.Enabled = true;
                                                textBoxGuia.Text = "0000";
                                                textBoxGuia.Focus();
                                                capturarDataAtual();
                                                btnCancelar.Enabled = false;
                                                btnExcluir.Enabled = false;
                                                button3.Enabled = false;
                                                button4.Enabled = false;
                                                ultimoIdSalvo = 0;
                                                idItemExcluir = 0;
                                                MessageBox.Show("Pedido excluído\nEste era o último item do pedido\nO item foi adicionado ao estoque");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    if (linha.Cells[22].Value.ToString().Equals("Item concluído")) {
                        MessageBox.Show("O item acabado " + dadosProdutoAcabado.Pro_nome.ToUpper() + " foi adicionado ao estoque.");
                    }

                }
                if (controllerExpedicao.deletarExpedicaoController(idPedidoApagar)) {
                    idPedidoLista = -1;
                    ultimoIdSalvo = 0;
                    //panelAddItens.Enabled = false;
                    dataGridViewPedidosAdd.Enabled = false;
                    //panelDadosPedido.Enabled = true;
                    textBoxGuia.Text = "0000";
                    textBoxGuia.Focus();
                    capturarDataAtual();
                    carrgarGridPedidos();
                    MessageBox.Show("Pedido cancelado com sucesso");
                }
            }
        }

        private void somarPeso() {

            double peso = 0;
            int qtdItens = 0;
            int quantidadeItensProntos = 0;
            double porcentagem = 100;
            double porcentagemPronta = 0;
            double porcentagemPorItem = 0;

            foreach (DataGridViewRow linha in dataGridViewPedidosAdd.Rows) {
                peso += double.Parse(linha.Cells[21].Value.ToString());
                qtdItens++;
                if (linha.Cells[22].Value.ToString().Equals("Item concluído")) {
                    quantidadeItensProntos++;
                }
            }


            porcentagemPorItem = porcentagem / qtdItens;
            porcentagemPronta = porcentagemPorItem * quantidadeItensProntos;

            if (qtdItens == 0) {
                labelPeso.Text = "|    Peso: " + "0,00" + " Kg";
                labelStatus.Text = "|    Status: " + "0,00" + "% pronto";
            } else {
                labelPeso.Text = "|  Peso: " + peso.ToString() + " Kg";
                labelStatus.Text = "|  Status: " + porcentagemPronta.ToString("F2") + "% pronto";
            }


        }

        private void corDalinha() {

            foreach (DataGridViewRow row in dataGridViewPedidosAdd.Rows)

                if (row.Cells[22].Value.ToString().Equals("Lançado"))
                {
                    row.DefaultCellStyle.BackColor = Color.FloralWhite;
                }
                else if (row.Cells[22].Value.ToString().Equals("Lote Solicitado"))
                {
                    row.DefaultCellStyle.BackColor = Color.LemonChiffon;
                }
                else if (row.Cells[22].Value.ToString().Equals("Rótulo Solicitado"))
                {
                    row.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                }
                else if (row.Cells[22].Value.ToString().Equals("Item concluído"))
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
        }

        private void button2_Click(object sender, EventArgs e) {
            String tipoVolume = "";

            if (textBoxQtdadePorCaixa.Text == "0")
            {
                quantidadePorCaixaSelected = int.Parse(textBoxQuantidade.Text);
            }else
            {
                quantidadePorCaixaSelected = int.Parse(textBoxQtdadePorCaixa.Text);
            }

            try {
                if (int.Parse(textBoxQuantidade.Text) > 0) {
                    try {
                        if (quantidadePorCaixaSelected > 0) {

                            if (int.Parse(textBoxQuantidade.Text) % quantidadePorCaixaSelected == 0) {

                                if (comboBoxLitragem.Text.Equals("300 Ml") && int.Parse(textBoxQuantidade.Text) / quantidadePorCaixaSelected > 1) {
                                    tipoVolume = "caixas";
                                } else if (comboBoxLitragem.Text.Equals("300 Ml") && int.Parse(textBoxQuantidade.Text) / quantidadePorCaixaSelected <= 1) {
                                    tipoVolume = "caixa";
                                } else if (comboBoxLitragem.Text.Equals("500 Gr") && int.Parse(textBoxQuantidade.Text) / quantidadePorCaixaSelected > 0) {
                                    tipoVolume = "caixas";
                                } else if (comboBoxLitragem.Text.Equals("500 Gr") && int.Parse(textBoxQuantidade.Text) / quantidadePorCaixaSelected <= 1) {
                                    tipoVolume = "caixa";
                                } else if (comboBoxLitragem.Text.Equals("500 Ml") && int.Parse(textBoxQuantidade.Text) / quantidadePorCaixaSelected > 1) {
                                    tipoVolume = "caixas";
                                } else if (comboBoxLitragem.Text.Equals("500 Ml") && int.Parse(textBoxQuantidade.Text) / quantidadePorCaixaSelected <= 1) {
                                    tipoVolume = "caixa";
                                } else if (comboBoxLitragem.Text.Equals("1 Litro") && int.Parse(textBoxQuantidade.Text) / quantidadePorCaixaSelected > 1) {
                                    tipoVolume = "caixas";
                                } else if (comboBoxLitragem.Text.Equals("1 Litro") && int.Parse(textBoxQuantidade.Text) / quantidadePorCaixaSelected <= 1) {
                                    tipoVolume = "caixa";
                                } else if (comboBoxLitragem.Text.Equals("2 Litros") && int.Parse(textBoxQuantidade.Text) / quantidadePorCaixaSelected > 1) {
                                    tipoVolume = "caixas";
                                } else if (comboBoxLitragem.Text.Equals("2 Litros") && int.Parse(textBoxQuantidade.Text) / quantidadePorCaixaSelected <= 1) {
                                    tipoVolume = "caixa";
                                } else if (comboBoxLitragem.Text.Equals("5 Litros") && int.Parse(textBoxQuantidade.Text) / quantidadePorCaixaSelected > 1) {
                                    tipoVolume = "caixas";
                                } else if (comboBoxLitragem.Text.Equals("5 Litros") && int.Parse(textBoxQuantidade.Text) / quantidadePorCaixaSelected <= 1) {
                                    tipoVolume = "caixa";
                                } else if (comboBoxLitragem.Text.Equals("20 Litros") && int.Parse(textBoxQuantidade.Text) / quantidadePorCaixaSelected > 1) {
                                    tipoVolume = "bombonas";
                                } else if (comboBoxLitragem.Text.Equals("20 Litros") && int.Parse(textBoxQuantidade.Text) / quantidadePorCaixaSelected <= 1) {
                                    tipoVolume = "bombona";
                                } else if (comboBoxLitragem.Text.Equals("50 Litros") && int.Parse(textBoxQuantidade.Text) / quantidadePorCaixaSelected > 1) {
                                    tipoVolume = "bombonas";
                                } else if (comboBoxLitragem.Text.Equals("50 Litros") && int.Parse(textBoxQuantidade.Text) / quantidadePorCaixaSelected <= 1) {
                                    tipoVolume = "bombona";
                                } else if (comboBoxLitragem.Text.Equals("200 Litros") && int.Parse(textBoxQuantidade.Text) / quantidadePorCaixaSelected > 1) {
                                    tipoVolume = "tambores";
                                } else if (comboBoxLitragem.Text.Equals("300 Litros") && int.Parse(textBoxQuantidade.Text) / quantidadePorCaixaSelected <= 1) {
                                    tipoVolume = "tambor";
                                } else if (comboBoxLitragem.Text.Equals("200 Litros") && int.Parse(textBoxQuantidade.Text) / quantidadePorCaixaSelected > 1) {
                                    tipoVolume = "containners";
                                } else if (comboBoxLitragem.Text.Equals("300 Litros") && int.Parse(textBoxQuantidade.Text) / quantidadePorCaixaSelected <= 1) {
                                    tipoVolume = "containner";
                                }

                                popularLista((int.Parse(textBoxQuantidade.Text) / quantidadePorCaixaSelected).ToString() + " " + tipoVolume, int.Parse(textBoxQuantidade.Text) / quantidadePorCaixaSelected);

                            } else {
                                if (int.Parse(textBoxQuantidade.Text) % quantidadePorCaixaSelected > 1) {
                                    MessageBox.Show("Você informou " + textBoxQuantidade.Text + " itens, porém na caixa você informou que cabem " + quantidadePorCaixaSelected + ", ou seja, sobram " + (int.Parse(textBoxQuantidade.Text) % quantidadePorCaixaSelected).ToString() + " itens. Lance os " +
                                    (int.Parse(textBoxQuantidade.Text) - int.Parse(textBoxQuantidade.Text) % quantidadePorCaixaSelected).ToString() + " itens na caixa informada e depois os " + (int.Parse(textBoxQuantidade.Text) % quantidadePorCaixaSelected).ToString() + " que restam informando outra caixa.");
                                } else {
                                    MessageBox.Show("Você informou " + textBoxQuantidade.Text + " itens, porém na caixa você informou que cabem " + textBoxQtdadePorCaixa.Text + ", ou seja, sobra " + (int.Parse(textBoxQuantidade.Text) % quantidadePorCaixaSelected).ToString() + " item. Lance os " +
                                    (int.Parse(textBoxQuantidade.Text) - int.Parse(textBoxQuantidade.Text) % quantidadePorCaixaSelected).ToString() + " itens na caixa informada e depois mais " + (int.Parse(textBoxQuantidade.Text) % quantidadePorCaixaSelected).ToString() + " que resta informando outra caixa.");
                                }
                            }

                        } else {
                            MessageBox.Show("Quantidade por caixa informada inválida");
                            textBoxQtdadePorCaixa.Text = "1";
                            textBoxQtdadePorCaixa.Focus();
                        }
                    } catch (Exception w) {
                        MessageBox.Show("Quantidade por caixa informada inválida" + w.Message);
                        textBoxQtdadePorCaixa.Text = "1";
                        textBoxQtdadePorCaixa.Focus();
                    }
                } else {
                    MessageBox.Show("Quantidade informada inválida");
                    textBoxQuantidade.Text = "1";
                    textBoxQuantidade.Focus();
                }
            } catch (Exception) {
                MessageBox.Show("Quantidade informada inválida");
                textBoxQuantidade.Text = "0";
                textBoxQuantidade.Focus();
            }
        }

        public void carrgarGridPedidos() {

            try {
                ModelPedido modelPedido = new ModelPedido();
                dataGridViewPedidosAdd.DataSource = modelPedido.exibirTabelaPedidos(idPedidoLista);

                dataGridViewPedidosAdd.Columns[13].HeaderText = "Produto.";
                dataGridViewPedidosAdd.Columns["nome_item"].DisplayIndex = 0;
                DataGridViewColumn coluna1 = dataGridViewPedidosAdd.Columns[13];
                coluna1.Width = 345;

                dataGridViewPedidosAdd.Columns[10].HeaderText = "Litragem.";
                dataGridViewPedidosAdd.Columns["litragem_escrita"].DisplayIndex = 1;
                DataGridViewColumn coluna2 = dataGridViewPedidosAdd.Columns[10];
                coluna2.Width = 100;

                dataGridViewPedidosAdd.Columns[12].HeaderText = "Quantidade.";
                dataGridViewPedidosAdd.Columns["pedido_quantidade"].DisplayIndex = 2;
                DataGridViewColumn coluna3 = dataGridViewPedidosAdd.Columns[12];
                coluna3.Width = 100;

                dataGridViewPedidosAdd.Columns[19].HeaderText = "Peso por Un.";
                dataGridViewPedidosAdd.Columns["peso_unidade"].DisplayIndex = 3;
                DataGridViewColumn coluna4 = dataGridViewPedidosAdd.Columns[19];
                coluna4.Width = 100;

                dataGridViewPedidosAdd.Columns[18].HeaderText = "Qtdade de caixas/item.";
                dataGridViewPedidosAdd.Columns["quantidade_caixa"].DisplayIndex = 4;
                DataGridViewColumn coluna5 = dataGridViewPedidosAdd.Columns[18];
                coluna5.Width = 150;

                dataGridViewPedidosAdd.Columns[20].HeaderText = "Peso da Caixa.";
                dataGridViewPedidosAdd.Columns["peso_caixa"].DisplayIndex = 5;
                DataGridViewColumn coluna6 = dataGridViewPedidosAdd.Columns[20];
                coluna6.Width = 120;

                dataGridViewPedidosAdd.Columns[21].HeaderText = "Peso Total.";
                dataGridViewPedidosAdd.Columns["peso_total"].DisplayIndex = 6;
                DataGridViewColumn coluna7 = dataGridViewPedidosAdd.Columns[21];
                coluna7.Width = 100;

                dataGridViewPedidosAdd.Columns[23].HeaderText = "Litragem/KG Total";
                dataGridViewPedidosAdd.Columns["volume_litros"].DisplayIndex = 7;
                DataGridViewColumn coluna8 = dataGridViewPedidosAdd.Columns[23];
                coluna8.Width = 130;

                dataGridViewPedidosAdd.Columns[24].HeaderText = "Cubagem m³";
                dataGridViewPedidosAdd.Columns["cubagem_unidade"].DisplayIndex = 8;
                DataGridViewColumn coluna9 = dataGridViewPedidosAdd.Columns[24];
                coluna9.Width = 150;

                dataGridViewPedidosAdd.Columns[25].HeaderText = "Cubagem Total m³";
                dataGridViewPedidosAdd.Columns["cubagem_total"].DisplayIndex = 9;
                DataGridViewColumn coluna10 = dataGridViewPedidosAdd.Columns[25];
                coluna10.Width = 150;

                dataGridViewPedidosAdd.Columns[22].HeaderText = "Status Item";
                dataGridViewPedidosAdd.Columns["item_status"].DisplayIndex = 10;
                DataGridViewColumn coluna11 = dataGridViewPedidosAdd.Columns[22];
                coluna11.Width = 100;

                dataGridViewPedidosAdd.Columns[0].Visible = false; // pedido_id
                dataGridViewPedidosAdd.Columns[1].Visible = false; // cliente_id
                dataGridViewPedidosAdd.Columns[2].Visible = false; // frasco_id
                dataGridViewPedidosAdd.Columns[3].Visible = false; // caixa_id
                dataGridViewPedidosAdd.Columns[4].Visible = false; // tampa_id
                dataGridViewPedidosAdd.Columns[5].Visible = false; // produto_id
                dataGridViewPedidosAdd.Columns[6].Visible = false; // guia_id
                dataGridViewPedidosAdd.Columns[7].Visible = false; // pedido_dataCad
                dataGridViewPedidosAdd.Columns[8].Visible = false; // pedido_dataEntrega
                dataGridViewPedidosAdd.Columns[9].Visible = false; // pedido_observacao
                //dataGridViewPedidosAdd.Columns[10].Visible = false; // litragem_escrita
                dataGridViewPedidosAdd.Columns[11].Visible = false; // pedido_litragem
                //dataGridViewPedidosAdd.Columns[12].Visible = false; // pedido_quantidade
                //dataGridViewPedidosAdd.Columns[13].Visible = false; // nome_item
                dataGridViewPedidosAdd.Columns[14].Visible = false; // caixa_peso
                dataGridViewPedidosAdd.Columns[15].Visible = false; // tampa_peso
                dataGridViewPedidosAdd.Columns[16].Visible = false; // frasco_peso
                dataGridViewPedidosAdd.Columns[17].Visible = false; // produto_peso
                //dataGridViewPedidosAdd.Columns[18].Visible = false; // quantidade_caixa              
                //dataGridViewPedidosAdd.Columns[19].Visible = false; // peso_unidade              
                //dataGridViewPedidosAdd.Columns[20].Visible = false; // peso_caixa                
                //dataGridViewPedidosAdd.Columns[21].Visible = false; // peso_total                
                //dataGridViewPedidosAdd.Columns[22].Visible = false; // item_status                
                //dataGridViewPedidosAdd.Columns[23].Visible = false; // volume_litros
                //dataGridViewPedidosAdd.Columns[24].Visible = false; // cubagem_unidade
                //dataGridViewPedidosAdd.Columns[25].Visible = false; // cubagem_total
                dataGridViewPedidosAdd.Columns[26].Visible = false; // cubagem_total
                dataGridViewPedidosAdd.Columns[27].Visible = false; // cubagem_total
                dataGridViewPedidosAdd.Columns[28].Visible = false; // cubagem_total

                atualizar2 = new ModelPedido();
                atualizar2.Item_status = "escolha";
                textBoxQuantidade.Focus();

                corDalinha();
                somarPeso();

            } catch (Exception e) {
                MessageBox.Show("Erro ao buscar os produtos." + e.Message);
            }
        }

        private void CarregarItem() {
            if (idPedidoLista > 0) {

                //panelAddItens.Enabled = false;
                //panelDadosPedido.Enabled = false;

                btnCancelar.Enabled = false;
                btnExcluir.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;
                buttonCancelarItem.Enabled = false;

                dataGridViewPedidosAdd.Enabled = true;

            }
        }

        private void entradaEstoque(int idProduto, int idFrasco, int idCaixa, int idTampa, int idProdutoAcabado) {

            ModelProduto dadosProduto = new ModelProduto();
            ControllerProduto controllerProduto = new ControllerProduto();
            dadosProduto = controllerProduto.retornarProdutoPeloId(idProduto);

            ModelPedidoLista dadosDoPedidoNaLista = new ModelPedidoLista();
            ControllerPedidoLista controllerPedidoLista = new ControllerPedidoLista();
            dadosDoPedidoNaLista = controllerPedidoLista.dadosDoPedidoLista(int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[6].Value.ToString()));

            ModelPedido itensDoPedido = new ModelPedido();
            ControllerPedido controllerPedido = new ControllerPedido();
            itensDoPedido = controllerPedido.recuperarDadosDoItemPeloId(int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[0].Value.ToString()));

            ModelTampa dadosTampa = new ModelTampa();
            ControllerTampa controllerTampa = new ControllerTampa();
            dadosTampa = controllerTampa.recuperarDadosDaTampa(idTampa);

            ModelCaixas dadosCaixa = new ModelCaixas();
            ControllerCaixas controllerCaixas = new ControllerCaixas();
            dadosCaixa = controllerCaixas.recuperarCaixaPeloId(idCaixa);

            ModelEmbalagens dadosFrascos = new ModelEmbalagens();
            ControllerEmbalagens controllerEmbalagens = new ControllerEmbalagens();
            dadosFrascos = controllerEmbalagens.recuperarDadosEmbalagensPeloId(idFrasco);

            ModelLote dadosDoLote = new ModelLote();
            ControllerLote controllerLote = new ControllerLote();
            dadosDoLote = controllerLote.recuperarDadosDoLoteComProduto(dataGridViewPedidosAdd.CurrentRow.Cells[13].Value.ToString(), "Aguardando");

            ModelProdutoAcabado dadosProdutoAcabado = new ModelProdutoAcabado();
            ModelProdutoAcabado dadosProdutoAcabadoV = new ModelProdutoAcabado();
            ControllerProdutoAcabado controllerProdutoAcabado = new ControllerProdutoAcabado();
            dadosProdutoAcabado = controllerProdutoAcabado.dadosDoProdutoAcabadoPeloId(dataGridViewPedidosAdd.CurrentRow.Cells[13].Value.ToString() + " - " + dataGridViewPedidosAdd.CurrentRow.Cells[10].Value.ToString());
            dadosProdutoAcabadoV = controllerProdutoAcabado.dadosDoProdutoAcabadoPeloId(dataGridViewPedidosAdd.CurrentRow.Cells[13].Value.ToString());

            double quantidadeDouble = double.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[23].Value.ToString());
            int quantidadeInt = int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[12].Value.ToString());
            int quantidadeIntCaixa = int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[18].Value.ToString().Replace(" ", "").Replace("caixas", "").Replace("caixa", "").Replace("bombonas", "").Replace("bombona", "").Replace("tambores", "").Replace("tambor", "").Replace("containners", "").Replace("containner", ""));

            // Inicio Envia o produto para produção e atualiza a litragem do lote
            if (dataGridViewPedidosAdd.CurrentRow.Cells[22].Value.ToString().Equals("Lançado")) {
                itensDoPedido.Item_status = "Em produção";
                dadosDoLote.Lote_litragem -= double.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[23].Value.ToString());
                if (controllerLote.atualizarLoteController(dadosDoLote)) {
                    if (controllerPedido.atualizarPedidoController(itensDoPedido)) {
                        if (controllerProdutoAcabado.atualizarProdutoController(dadosProdutoAcabadoV)) {
                            dadosDoPedidoNaLista.Pedido_status = "Em produção";
                            if (controllerPedidoLista.atualizarPedidoListaController(dadosDoPedidoNaLista)) {
                                carrgarGridPedidos();
                                MessageBox.Show("Item enviado para produção.");
                            }
                        } else {
                            MessageBox.Show("Erro ao processar o produto acabado.");
                        }
                    } else {
                        MessageBox.Show("Erro ao atualizar os produtos do grid");
                    }
                }
                // Fim Envia o produto para produção e atualiza a litragem do lote

                // Inicio Verifica se o produto ja esta em produção e retorna uma mensagem
            } else if (dataGridViewPedidosAdd.CurrentRow.Cells[22].Value.ToString().Equals("Em produção")) {
                MessageBox.Show("Este item já esta em produção.");
                // Inicio Verifica se o produto ja esta em produção e retorna uma mensagem

                // Inicio Coloca novamente o produto em produção e recoloca os itens usados no estoque novamente
            } else {
                try {
                    double pesoProduto = double.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[19].Value.ToString());
                    try {
                        dadosProdutoAcabadoV.Pro_estoque = double.Parse((dadosProdutoAcabadoV.Pro_estoque + double.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[23].Value.ToString())).ToString("F3"));
                        if (controllerProdutoAcabado.atualizarProdutoController(dadosProdutoAcabadoV)) {
                        } else {
                            MessageBox.Show("Erro ao processar o produto acabado.");
                        }

                    } catch (Exception) {

                    }

                    try {
                        if (dadosProduto.Pro_id > 0) {
                            dadosProduto.Pro_estoque = dadosProduto.Pro_estoque + quantidadeDouble;
                            dadosProduto.Pro_peso = double.Parse(((pesoProduto - dadosTampa.Tampa_peso - dadosFrascos.Embalagens_peso) / itensDoPedido.Pedido_litragem).ToString("F3"));
                            if (controllerProduto.atualizarProdutoController(dadosProduto)) {
                            } else {
                                MessageBox.Show("Erro ao dar baixa no estoque de produtos");
                            }
                        }
                    } catch (Exception) {
                        MessageBox.Show("Produto não encontrado.");
                    }

                    try {
                        if (itensDoPedido.Pedido_id > 0) {
                            itensDoPedido.Produto_peso = (pesoProduto - dadosTampa.Tampa_peso - dadosFrascos.Embalagens_peso) / itensDoPedido.Volume_litros;
                            itensDoPedido.Peso_unidade = pesoProduto;
                            itensDoPedido.Peso_caixa = (pesoProduto * (itensDoPedido.Pedido_quantidade / int.Parse(itensDoPedido.Quantidade_caixa.Replace(" ", "").Replace("caixas", "").Replace("caixa", "").Replace("bombonas", "").Replace("bombona", "").Replace("tambores", "").Replace("tambor", "").Replace("containners", "").Replace("containner", "")))) + dadosCaixa.Caixas_peso;

                            if (controllerPedido.atualizarPedidoController(itensDoPedido)) {
                            } else {
                                MessageBox.Show("Erro ao atualizar os produtos do grid");
                            }
                        }
                    } catch (Exception) {
                        MessageBox.Show("Produto não encontrado.");
                    }

                    try {
                        if (dadosTampa.Tampa_id > 0) {
                            dadosTampa.Tampa_estoque = dadosTampa.Tampa_estoque + quantidadeInt;
                            if (controllerTampa.atualizarTampaController(dadosTampa)) {
                            } else {
                                MessageBox.Show("Erro ao dar baixa no estoque de tampas");
                            }
                        }
                    } catch (Exception) {
                        MessageBox.Show("Caixa não encontrada.");
                    }

                    try {
                        if (dadosCaixa.Caixas_id > 0) {
                            dadosCaixa.Caixas_estoque = dadosCaixa.Caixas_estoque + quantidadeIntCaixa;

                            if (controllerCaixas.atualizarCaixasController(dadosCaixa)) {
                            } else {
                                MessageBox.Show("Erro ao dar baixa no estoque de caixas");
                            }
                        }
                    } catch (Exception) {
                        MessageBox.Show("Caixa não encontrada.");
                    }

                    try {
                        if (dadosFrascos.Embalagens_id > 0) {
                            dadosFrascos.Embalagens_estoque = dadosFrascos.Embalagens_estoque + quantidadeInt;

                            if (controllerEmbalagens.atualizarEmbalagensController(dadosFrascos)) {
                            } else {
                                MessageBox.Show("Erro ao dar baixa no estoque de frascos");
                            }
                        }
                    } catch (Exception) {
                        MessageBox.Show("Embalagem não encontrada.");
                    }

                    try {
                        //aqui
                        if (dadosProdutoAcabado.Pro_id > 0) {
                            dadosProdutoAcabado.Pro_estoque = dadosProdutoAcabado.Pro_estoque;

                            if (controllerProdutoAcabado.atualizarProdutoController(dadosProdutoAcabado)) {
                            } else {
                                MessageBox.Show("Erro ao processar o produto acabado.");
                            }

                        }

                    } catch (Exception) {

                    }

                    atualizar2.Item_status = "Em produção";

                    if (controllerPedido.atualizarPedidoController(atualizar2)) {
                        carrgarGridPedidos();
                        MessageBox.Show("O Item voltou para produção.\nO volume em litros voltou ao estoque.");
                    }

                } catch (Exception) {
                    MessageBox.Show("Peso unitário informado inválildo, revise os dados");
                }

            }
            // Fim Coloca novamente o produto em produção e recoloca os itens usados no estoque novamente
        }

        private void solicitarLote(ModelLote dadosDoLote, ControllerLote controllerLote) {

            ModelPedido itensDoPedido = new ModelPedido();
            ControllerPedido controllerPedido = new ControllerPedido();
            itensDoPedido = controllerPedido.recuperarDadosDoItemPeloId(int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[0].Value.ToString()));

            ModelPedidoLista dadosDoPedidoNaLista = new ModelPedidoLista();
            ControllerPedidoLista controllerPedidoLista = new ControllerPedidoLista();
            dadosDoPedidoNaLista = controllerPedidoLista.dadosDoPedidoLista(int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[6].Value.ToString()));

            //INICIO ATUALIZAR ORDEM DE PRODUCAO
            ModelOrdemDeProducao ordemDeProducao = new ModelOrdemDeProducao();
            ordemDeProducao = controllerLote.dadosOP(dadosDoLote.Lote_numero);

            if (dadosDoLote.Lote_id > 0)
            {
                ordemDeProducao.OrdemQuantidade += double.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[23].Value.ToString());
                controllerLote.atualizarOP(ordemDeProducao);
            }
            else
            {
                ModelOrdemDeProducao salvarNovaOrdem = new ModelOrdemDeProducao();
                salvarNovaOrdem.OrdemProduto = dataGridViewPedidosAdd.CurrentRow.Cells[13].Value.ToString();
                salvarNovaOrdem.OrdemQuantidade = double.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[23].Value.ToString());
                salvarNovaOrdem.OrdemDataSaida = textBoxPrevisaoDeEntrega.Text;
                salvarNovaOrdem.OrdemLoteNumero = dadosDoLote.Lote_numero;
                salvarNovaOrdem.OrdemDataSolicitacao = DateTime.Now.AddDays(0).ToString("dd/MM/yyyy");
                controllerLote.salvarOrdemParaProducao(salvarNovaOrdem);
            }
            //FIM ATUALIZAR ORDEM DE PRODUÇÃO

            dadosDoLote.Lote_litragem -= itensDoPedido.Volume_litros;
            if (controllerLote.atualizarLoteController(dadosDoLote)) {
                itensDoPedido.Item_status = "Lote Solicitado";
                if (controllerPedido.atualizarPedidoController(itensDoPedido)) {
                    dadosDoPedidoNaLista.Pedido_status = "Em produção";
                    if (controllerPedidoLista.atualizarPedidoListaController(dadosDoPedidoNaLista)) {
                        carrgarGridPedidos();
                        MessageBox.Show("Item aguardando lote.");
                    }
                }

            }
        }

        private void solicitaRotulo(ModelLote dadosDoLote, ControllerLote controllerLote) {

            ModelPedido itensDoPedido = new ModelPedido();
            ControllerPedido controllerPedido = new ControllerPedido();
            itensDoPedido = controllerPedido.recuperarDadosDoItemPeloId(int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[0].Value.ToString()));

            ModelRotulos dadosRotulo = new ModelRotulos();
            ControllerRotulos controllerRotulos = new ControllerRotulos();

            ModelClientes dadosCliente = new ModelClientes();
            ControllerClientes controllerClientes = new ControllerClientes();
            dadosCliente = controllerClientes.recuperarClientePeloId(int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[1].Value.ToString()));

            ModelPedidoLista dadosDoPedidoNaLista = new ModelPedidoLista();
            ControllerPedidoLista controllerPedidoLista = new ControllerPedidoLista();
            dadosDoPedidoNaLista = controllerPedidoLista.dadosDoPedidoLista(int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[6].Value.ToString()));

            dadosDoLote.Lote_litragem -= itensDoPedido.Volume_litros;
            if (controllerLote.atualizarLoteController(dadosDoLote)) {

                itensDoPedido.Item_status = "Rótulo Solicitado";
                itensDoPedido.Pedido_loteUsado = dadosDoLote.Lote_numero;
                if (controllerPedido.atualizarPedidoController(itensDoPedido)) {

                    dadosDoPedidoNaLista.Pedido_status = "Em produção";
                    if (controllerPedidoLista.atualizarPedidoListaController(dadosDoPedidoNaLista)) {

                        dadosRotulo.Rotulo_produto = dataGridViewPedidosAdd.CurrentRow.Cells[13].Value.ToString();
                        dadosRotulo.Rotulo_guia = int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[6].Value.ToString());
                        dadosRotulo.Rotulo_idProduto = int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[0].Value.ToString());
                        dadosRotulo.Rotulo_cliente = dadosCliente.Clientes_nome;
                        dadosRotulo.Rotulo_lote = dadosDoLote.Lote_numero;
                        dadosRotulo.Rotulo_fabricacao = dadosDoLote.Lote_fabricacao;
                        dadosRotulo.Rotulo_validade = dadosDoLote.Lote_validade;
                        dadosRotulo.Rotulo_quantidade = itensDoPedido.Pedido_quantidade;
                        dadosRotulo.Rotulo_litragem = itensDoPedido.Litragem_escrita;
                        dadosRotulo.Rotulo_status = "Em produção";
                        dadosRotulo.Rotulo_observacao = "Rótulo solicitado dia " + DateTime.Now.AddDays(0).ToString("dd/MM/yyyy");
                        if (controllerRotulos.salvarRotuloController(dadosRotulo) > 0) {
                            carrgarGridPedidos();
                            MessageBox.Show("Item pronto para rotular,  comunique ao setor de produção dos rótulos, o prazo de entrega é até "+ itensDoPedido.Pedido_dataEntrega);
                        }
                    }
                }

            }
        }

        private void baixarEstoqueTransformarEmProduto(int idProduto, int idFrasco, int idCaixa, int idTampa, int idProdutoAcabado, String lote) {


            try {

                double pesoProduto = 0;

                ModelProduto dadosProduto = new ModelProduto();
                ControllerProduto controllerProduto = new ControllerProduto();
                dadosProduto = controllerProduto.retornarProdutoPeloId(idProduto);

                ModelPedido itensDoPedido = new ModelPedido();
                ControllerPedido controllerPedido = new ControllerPedido();
                itensDoPedido = controllerPedido.recuperarDadosDoItemPeloId(int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[0].Value.ToString()));

                ModelTampa dadosTampa = new ModelTampa();
                ControllerTampa controllerTampa = new ControllerTampa();
                dadosTampa = controllerTampa.recuperarDadosDaTampa(idTampa);

                ModelCaixas dadosCaixa = new ModelCaixas();
                ControllerCaixas controllerCaixas = new ControllerCaixas();
                dadosCaixa = controllerCaixas.recuperarCaixaPeloId(idCaixa);

                ModelEmbalagens dadosFrascos = new ModelEmbalagens();
                ControllerEmbalagens controllerEmbalagens = new ControllerEmbalagens();
                dadosFrascos = controllerEmbalagens.recuperarDadosEmbalagensPeloId(idFrasco);

                ControllerLote controllerLote = new ControllerLote();
                ModelLote dadosLote = new ModelLote();
                //dadosLote = controllerLote.recuperarDadosDoLoteComLote(dataGridViewPedidosAdd.CurrentRow.Cells[13].Value.ToString(), lote);

                ModelProdutoAcabado dadosProdutoAcabadoV = new ModelProdutoAcabado();
                ModelProdutoAcabado dadosProdutoAcabado = new ModelProdutoAcabado();
                ControllerProdutoAcabado controllerProdutoAcabado = new ControllerProdutoAcabado();

                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "O peso do item POR UNIDADE está correto " + itensDoPedido.Peso_unidade + " Kg/Gr ?";
                string caption = "Confirmação de peso";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.Yes) {
                    pesoProduto = itensDoPedido.Peso_unidade;
                } else if (result == DialogResult.No) {
                    pesoProduto = double.Parse(Interaction.InputBox("Peso unitário do produto", "Informe o peso", string.Empty, -1, -1).Replace(".", ","));
                    
                }

                double quantidadeDouble = double.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[23].Value.ToString());
                int quantidadeInt = int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[12].Value.ToString());
                int quantidadeIntCaixa = int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[18].Value.ToString().Replace(" ", "").Replace("caixas", "").Replace("caixa", "").Replace("bombonas", "").Replace("bombona", "").Replace("tambores", "").Replace("tambor", "").Replace("containners", "").Replace("containner", ""));

                

                if (dadosProduto.Pro_id > 0) {
                    dadosProduto.Pro_estoque = dadosProduto.Pro_estoque - quantidadeDouble;
                    dadosProduto.Pro_peso = double.Parse(((pesoProduto - dadosTampa.Tampa_peso - dadosFrascos.Embalagens_peso) / itensDoPedido.Pedido_litragem).ToString("F3"));
                    if (controllerProduto.atualizarProdutoController(dadosProduto)) {                        
                        if (itensDoPedido.Pedido_id > 0) {
                            itensDoPedido.Produto_peso = (pesoProduto - dadosTampa.Tampa_peso - dadosFrascos.Embalagens_peso) / itensDoPedido.Volume_litros;
                            itensDoPedido.Peso_unidade = pesoProduto; 
                            itensDoPedido.Peso_total = (pesoProduto * quantidadeInt) + (dadosCaixa.Caixas_peso * quantidadeIntCaixa);
                            itensDoPedido.Item_status = "Item concluído";

                            if (dataGridViewPedidosAdd.CurrentRow.Cells[18].Value.ToString().Equals("0 caixa"))
                            {
                                itensDoPedido.Peso_caixa = 0;
                            } else
                            {
                                itensDoPedido.Peso_caixa = (pesoProduto * (itensDoPedido.Pedido_quantidade / int.Parse(itensDoPedido.Quantidade_caixa.Replace(" ", "").Replace("caixas", "").Replace("caixa", "").Replace("bombonas", "").Replace("bombona", "").Replace("tambores", "").Replace("tambor", "").Replace("containners", "").Replace("containner", "")))) + dadosCaixa.Caixas_peso;
                            }
                            
                            if (controllerPedido.atualizarPedidoController(itensDoPedido)) {
                                if (dadosTampa.Tampa_id > 0) {
                                    dadosTampa.Tampa_estoque = dadosTampa.Tampa_estoque - quantidadeInt;
                                    if (controllerTampa.atualizarTampaController(dadosTampa)) {
                                        if (dadosCaixa.Caixas_id > 0) {
                                            dadosCaixa.Caixas_estoque = dadosCaixa.Caixas_estoque - quantidadeIntCaixa;
                                            if (controllerCaixas.atualizarCaixasController(dadosCaixa)) {
                                                if (dadosFrascos.Embalagens_id > 0) {
                                                    dadosFrascos.Embalagens_estoque = dadosFrascos.Embalagens_estoque - quantidadeInt;
                                                    if (controllerEmbalagens.atualizarEmbalagensController(dadosFrascos)) {
                                                        dadosProdutoAcabado = controllerProdutoAcabado.dadosDoProdutoAcabadoPeloId(dataGridViewPedidosAdd.CurrentRow.Cells[13].Value.ToString() + " - " + dataGridViewPedidosAdd.CurrentRow.Cells[10].Value.ToString());
                                                        if (dadosProdutoAcabado.Pro_id > 0) {
                                                            if (controllerProdutoAcabado.atualizarProdutoController(dadosProdutoAcabado)) {
                                                                //dadosLote.Lote_litragem -= double.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[23].Value.ToString());
                                                                if (controllerLote.atualizarLoteController(dadosLote)) {
                                                                    carrgarGridPedidos();
                                                                    MessageBox.Show("Item concluído com sucecsso.");
                                                                }
                                                            } else {
                                                                MessageBox.Show("Erro ao processar o produto acabado.");
                                                            }
                                                        } else {
                                                            dadosProdutoAcabado.Pro_nome = dataGridViewPedidosAdd.CurrentRow.Cells[13].Value.ToString() + " - " + dataGridViewPedidosAdd.CurrentRow.Cells[10].Value.ToString();
                                                            dadosProdutoAcabado.Pro_estoque = 0.0;
                                                            dadosProdutoAcabado.Pro_observacao = "";
                                                            dadosProdutoAcabado.Pro_peso = double.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[17].Value.ToString());
                                                            if (controllerProdutoAcabado.salvarProdutoController(dadosProdutoAcabado)) {
                                                                carrgarGridPedidos();
                                                                MessageBox.Show("Produto acabado não encontrado, o item foi cadastrado automaticamente.");
                                                            }
                                                        }
                                                    } else {
                                                        MessageBox.Show("Erro ao dar baixa no estoque de frascos");
                                                    }
                                                }
                                            } else {
                                                MessageBox.Show("Erro ao dar baixa no estoque de caixas");
                                            }
                                        }
                                    } else {
                                        MessageBox.Show("Erro ao dar baixa no estoque de tampas");
                                    }
                                }
                            } else {
                                MessageBox.Show("Erro ao atualizar os produtos do grid");
                            }
                        }
                    } else {
                        MessageBox.Show("Erro ao dar baixa no estoque de produtos");
                    }
                }
            } catch (Exception) {
                MessageBox.Show("Peso unitário informado inválildo, revise os dados");
            }
        }

        private void cancelarTodosItensEPedidos(int idProduto, int idFrasco, int idCaixa, int idTampa, int idProdutoAcabado) {


            try {
                double pesoProduto = double.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[19].Value.ToString());

                ModelProduto dadosProduto = new ModelProduto();
                ControllerProduto controllerProduto = new ControllerProduto();
                dadosProduto = controllerProduto.retornarProdutoPeloId(idProduto);

                ModelPedido itensDoPedido = new ModelPedido();
                ControllerPedido controllerPedido = new ControllerPedido();
                itensDoPedido = controllerPedido.recuperarDadosDoItemPeloId(int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[0].Value.ToString()));

                ModelTampa dadosTampa = new ModelTampa();
                ControllerTampa controllerTampa = new ControllerTampa();
                dadosTampa = controllerTampa.recuperarDadosDaTampa(idTampa);

                ModelCaixas dadosCaixa = new ModelCaixas();
                ControllerCaixas controllerCaixas = new ControllerCaixas();
                dadosCaixa = controllerCaixas.recuperarCaixaPeloId(idCaixa);

                ModelEmbalagens dadosFrascos = new ModelEmbalagens();
                ControllerEmbalagens controllerEmbalagens = new ControllerEmbalagens();
                dadosFrascos = controllerEmbalagens.recuperarDadosEmbalagensPeloId(idFrasco);

                ModelProdutoAcabado dadosProdutoAcabado = new ModelProdutoAcabado();
                ControllerProdutoAcabado controllerProdutoAcabado = new ControllerProdutoAcabado();

                double quantidadeDouble = double.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[23].Value.ToString());
                int quantidadeInt = int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[12].Value.ToString());
                int quantidadeIntCaixa = int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[18].Value.ToString().Replace(" ", "").Replace("caixas", "").Replace("caixa", "").Replace("bombonas", "").Replace("bombona", "").Replace("tambores", "").Replace("tambor", "").Replace("containners", "").Replace("containner", ""));

                try {
                    if (dadosProduto.Pro_id > 0) {
                        dadosProduto.Pro_estoque = dadosProduto.Pro_estoque - quantidadeDouble;
                        dadosProduto.Pro_peso = double.Parse(((pesoProduto - dadosTampa.Tampa_peso - dadosFrascos.Embalagens_peso) / itensDoPedido.Pedido_litragem).ToString("F3"));
                        if (controllerProduto.atualizarProdutoController(dadosProduto)) {
                        } else {
                            MessageBox.Show("Erro ao dar baixa no estoque de produtos");
                        }
                    }
                } catch (Exception) {
                    MessageBox.Show("Produto não encontrado.");
                }

                try {
                    if (itensDoPedido.Pedido_id > 0) {
                        itensDoPedido.Produto_peso = (pesoProduto - dadosTampa.Tampa_peso - dadosFrascos.Embalagens_peso) / itensDoPedido.Volume_litros;
                        itensDoPedido.Peso_unidade = pesoProduto;
                        itensDoPedido.Peso_caixa = (pesoProduto * (itensDoPedido.Pedido_quantidade / int.Parse(itensDoPedido.Quantidade_caixa.Replace(" ", "").Replace("caixas", "").Replace("caixa", "").Replace("bombonas", "").Replace("bombona", "").Replace("tambores", "").Replace("tambor", "").Replace("containners", "").Replace("containner", "")))) + dadosCaixa.Caixas_peso;

                        if (controllerPedido.atualizarPedidoController(itensDoPedido)) {
                        } else {
                            MessageBox.Show("Erro ao atualizar os produtos do grid");
                        }
                    }
                } catch (Exception) {
                    MessageBox.Show("Produto não encontrado.");
                }


                try {
                    if (dadosTampa.Tampa_id > 0) {
                        dadosTampa.Tampa_estoque = dadosTampa.Tampa_estoque - quantidadeInt;
                        if (controllerTampa.atualizarTampaController(dadosTampa)) {
                        } else {
                            MessageBox.Show("Erro ao dar baixa no estoque de tampas");
                        }
                    }
                } catch (Exception) {
                    MessageBox.Show("Caixa não encontrada.");
                }

                try {
                    if (dadosCaixa.Caixas_id > 0) {
                        dadosCaixa.Caixas_estoque = dadosCaixa.Caixas_estoque - quantidadeIntCaixa;

                        if (controllerCaixas.atualizarCaixasController(dadosCaixa)) {
                        } else {
                            MessageBox.Show("Erro ao dar baixa no estoque de caixas");
                        }
                    }
                } catch (Exception) {
                    MessageBox.Show("Caixa não encontrada.");
                }

                try {
                    if (dadosFrascos.Embalagens_id > 0) {
                        dadosFrascos.Embalagens_estoque = dadosFrascos.Embalagens_estoque - quantidadeInt;

                        if (controllerEmbalagens.atualizarEmbalagensController(dadosFrascos)) {
                        } else {
                            MessageBox.Show("Erro ao dar baixa no estoque de frascos");
                        }
                    }
                } catch (Exception) {
                    MessageBox.Show("Embalagem não encontrada.");
                }

                try {
                    dadosProdutoAcabado = controllerProdutoAcabado.dadosDoProdutoAcabadoPeloId(dataGridViewPedidosAdd.CurrentRow.Cells[13].Value.ToString() + " - " + dataGridViewPedidosAdd.CurrentRow.Cells[10].Value.ToString());
                    if (dadosProdutoAcabado.Pro_id > 0) {
                        dadosProdutoAcabado.Pro_estoque = dadosProdutoAcabado.Pro_estoque + quantidadeDouble;

                        if (controllerProdutoAcabado.atualizarProdutoController(dadosProdutoAcabado)) {
                        } else {
                            MessageBox.Show("Erro ao processar o produto acabado.");
                        }
                    } else {
                        dadosProdutoAcabado.Pro_nome = dataGridViewPedidosAdd.CurrentRow.Cells[13].Value.ToString() + " - " + dataGridViewPedidosAdd.CurrentRow.Cells[10].Value.ToString();
                        dadosProdutoAcabado.Pro_estoque = 0.0;
                        dadosProdutoAcabado.Pro_observacao = "";
                        dadosProdutoAcabado.Pro_peso = double.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[17].Value.ToString());
                        if (controllerProdutoAcabado.salvarProdutoController(dadosProdutoAcabado)) {
                            MessageBox.Show("Produto acabado não encontrado, o item foi cadastrado automaticamente.");
                        }
                    }
                } catch (Exception) {

                }

                atualizar2.Item_status = "Concluído";
                if (controllerPedido.atualizarPedidoController(atualizar2)) {

                }

            } catch (Exception) {
                MessageBox.Show("Peso unitário informado inválildo, revise os dados");
            }

        }

        private void checarUltimoItem(int guia) {

            if (int.Parse(dataGridViewPedidosAdd.Rows.Count.ToString()) < 1) {
                if (modelPedidoLista.deletarPedidoListaPelaGuiaController(guia)) {
                    //panelAddItens.Enabled = false;
                    dataGridViewPedidosAdd.Enabled = false;
                    //panelDadosPedido.Enabled = true;
                    textBoxGuia.Text = "0000";
                    textBoxGuia.Focus();
                    capturarDataAtual();
                    btnCancelar.Enabled = false;
                    btnExcluir.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    ultimoIdSalvo = 0;
                    MessageBox.Show("Pedido excluído, todos os itens foram removidos");
                }
            } else {
                carrgarGridPedidos();
                MessageBox.Show("Item excluido com sucesso.");
            }


        }

        private void btnExcluir_Click(object sender, EventArgs e) {

            if (atualizar2.Item_status.Equals("escolha")) {
                MessageBox.Show("Selecione um item no grid");
            } else {

                if (dataGridViewPedidosAdd.CurrentRow.Cells[22].Value.ToString().Equals("Item concluído")) {
                    MessageBox.Show("Você não pode excluir um produto concluído, utilize cancelar item.");

                } else if (dataGridViewPedidosAdd.CurrentRow.Cells[22].Value.ToString().Equals("Lote Solicitado") || dataGridViewPedidosAdd.CurrentRow.Cells[22].Value.ToString().Equals("Lançado")) {
                    // Initializes the variables to pass to the MessageBox.Show method.
                    string message = "Deseja excluir este item? Impossível reverter";
                    string caption = "Excluir Item do pedido";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    // Displays the MessageBox.
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == DialogResult.Yes) {

                        int idPedido = int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[0].Value.ToString());

                        ModelExpedicao modelExpedicao = new ModelExpedicao();
                        ControllerPedidoLista controllerListaPedidos = new ControllerPedidoLista();
                        ModelPedidoLista listaDePedidos = new ModelPedidoLista();
                        listaDePedidos = controllerListaPedidos.dadosDoPedidoLista(int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[6].Value.ToString()));
                        ControllerExpedicao controllerExpedicao = new ControllerExpedicao();
                        ModelProdutoAcabado dadosProdutoAcabado = new ModelProdutoAcabado();
                        ControllerProdutoAcabado controllerProdutoAcabado = new ControllerProdutoAcabado();
                        dadosProdutoAcabado = controllerProdutoAcabado.dadosDoProdutoAcabadoPeloId(dataGridViewPedidosAdd.CurrentRow.Cells[13].Value.ToString() + " - " + dataGridViewPedidosAdd.CurrentRow.Cells[10].Value.ToString());

                        modelExpedicao = controllerExpedicao.recuperarDadosDaExpedicaoPeloId(int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[6].Value.ToString()));
                        modelExpedicao.Expedicao_volume -= int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[18].Value.ToString().Replace(" ", "").Replace("caixas", "").Replace("caixa", "").Replace("bombonas", "").Replace("bombona", "").Replace("tambores", "").Replace("tambor", "").Replace("containners", "").Replace("containner", ""));
                        controllerExpedicao.atualizarClientesController(modelExpedicao);

                        if (dataGridViewPedidosAdd.CurrentRow.Cells[22].Value.ToString().Equals("Lote Solicitado") || dataGridViewPedidosAdd.CurrentRow.Cells[22].Value.ToString().Equals("Rótulo Solicitado")) {

                                              
                            ModelLote dadosDoLote = new ModelLote();
                            ControllerLote controllerLote = new ControllerLote();
                            dadosDoLote = controllerLote.recuperarLote(dataGridViewPedidosAdd.CurrentRow.Cells[26].Value.ToString());
                            dadosDoLote.Lote_litragem += double.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[23].Value.ToString());
                            dadosDoLote.Lote_status = "Concluído";
                            MessageBox.Show("O item " + dataGridViewPedidosAdd.CurrentRow.Cells[13].Value.ToString() + " havia solicitado baixa no lote Nº " + dataGridViewPedidosAdd.CurrentRow.Cells[26].Value.ToString() + ", como o item ainda não havia sido concluído a litragem solicitada voltou a constar em estoque de produto para envase.");

                            if (controllerLote.atualizarLoteController(dadosDoLote)) {
                                ControllerRotulos controllerRotulos = new ControllerRotulos();
                                controllerRotulos.apagarRotulosolicitado(dataGridViewPedidosAdd.CurrentRow.Cells[1].Value.ToString(), dataGridViewPedidosAdd.CurrentRow.Cells[9].Value.ToString(), "Em produção");
                            }
                        }

                        if (controllerPedido.deletarPedidoController(int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[0].Value.ToString()))) {
                            carrgarGridPedidos();
                            if (int.Parse(dataGridViewPedidosAdd.Rows.Count.ToString()) < 1) {
                                if (controllerListaPedidos.deletarPedidoListaController(listaDePedidos.Guia_id)) {
                                    if (modelPedidoLista.deletarPedidoListaPelaGuiaController(idPedido)) {
                                        if (controllerExpedicao.deletarExpedicaoController(idItemExcluir)) {
                                            //panelAddItens.Enabled = false;
                                            dataGridViewPedidosAdd.Enabled = false;
                                            //panelDadosPedido.Enabled = true;
                                            textBoxGuia.Text = "0000";
                                            textBoxGuia.Focus();
                                            capturarDataAtual();
                                            btnCancelar.Enabled = false;
                                            btnExcluir.Enabled = false;
                                            button3.Enabled = false;
                                            button4.Enabled = false;
                                            ultimoIdSalvo = 0;
                                            idItemExcluir = 0;
                                            MessageBox.Show("Pedido excluído\nEste era o último item do pedido, as solicitações de rótulos em aberto foram canceladas.");
                                        }
                                    }
                                }
                            } else {
                                MessageBox.Show("Produto removido com sucesso, a solicitação de rótulo para este item foi cancelada.");
                            }
                        }
                    }

                } else if (dataGridViewPedidosAdd.CurrentRow.Cells[22].Value.ToString().Equals("Rótulo Solicitado")) {
                    // Initializes the variables to pass to the MessageBox.Show method.
                    string message = "Deseja excluir este item? Impossível reverter";
                    string caption = "Excluir Item do pedido";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    // Displays the MessageBox.
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == DialogResult.Yes) {

                        int idPedido = int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[0].Value.ToString());

                        ControllerRotulos controllerRotulos = new ControllerRotulos();

                        ControllerPedidoLista controllerListaPedidos = new ControllerPedidoLista();
                        ModelPedidoLista listaDePedidos = new ModelPedidoLista();
                        listaDePedidos = controllerListaPedidos.dadosDoPedidoLista(int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[6].Value.ToString()));

                        ModelProdutoAcabado dadosProdutoAcabado = new ModelProdutoAcabado();
                        ControllerProdutoAcabado controllerProdutoAcabado = new ControllerProdutoAcabado();
                        dadosProdutoAcabado = controllerProdutoAcabado.dadosDoProdutoAcabadoPeloId(dataGridViewPedidosAdd.CurrentRow.Cells[13].Value.ToString() + " - " + dataGridViewPedidosAdd.CurrentRow.Cells[10].Value.ToString());

                        if (dataGridViewPedidosAdd.CurrentRow.Cells[22].Value.ToString().Equals("Lote Solicitado") || dataGridViewPedidosAdd.CurrentRow.Cells[22].Value.ToString().Equals("Rótulo Solicitado")) {
                                                       
                            ModelLote dadosDoLote = new ModelLote();
                            ControllerLote controllerLote = new ControllerLote();
                            dadosDoLote = controllerLote.estornarLote(dataGridViewPedidosAdd.CurrentRow.Cells[26].Value.ToString());
                            dadosDoLote.Lote_litragem += double.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[23].Value.ToString());
                            dadosDoLote.Lote_status = "Concluído";
                            MessageBox.Show("O item " + dataGridViewPedidosAdd.CurrentRow.Cells[13].Value.ToString() + " havia solicitado "+ dataGridViewPedidosAdd.CurrentRow.Cells[23].Value.ToString() + " litros no lote Nº " + dataGridViewPedidosAdd.CurrentRow.Cells[26].Value.ToString() + ", a litragem solicitada foi cancelada.");

                            if (controllerLote.atualizarLoteController(dadosDoLote)) {
                                controllerRotulos.apagarRotulosolicitado(dataGridViewPedidosAdd.CurrentRow.Cells[1].Value.ToString(), dataGridViewPedidosAdd.CurrentRow.Cells[9].Value.ToString(), "Em produção");
                            }
                        }

                        if (controllerPedido.deletarPedidoController(int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[0].Value.ToString()))) {
                            if (controllerRotulos.deletarRotuloPeloIdDoItem(int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[0].Value.ToString()))) {
                                carrgarGridPedidos();
                                if (int.Parse(dataGridViewPedidosAdd.Rows.Count.ToString()) < 1) {
                                    if (controllerListaPedidos.deletarPedidoListaController(listaDePedidos.Guia_id)) {
                                        if (modelPedidoLista.deletarPedidoListaPelaGuiaController(idPedido)) {
                                            //panelAddItens.Enabled = false;
                                            dataGridViewPedidosAdd.Enabled = false;
                                            //panelDadosPedido.Enabled = true;
                                            textBoxGuia.Text = "0000";
                                            textBoxGuia.Focus();
                                            capturarDataAtual();
                                            btnCancelar.Enabled = false;
                                            btnExcluir.Enabled = false;
                                            button3.Enabled = false;
                                            button4.Enabled = false;
                                            ultimoIdSalvo = 0;
                                            MessageBox.Show("Pedido excluído\nEste era o último item do pedido, as solicitações de rótulos em aberto foram canceladas.");
                                        }
                                    }
                                } else {
                                    MessageBox.Show("Produto removido com sucesso, a solicitação de rótulo para este item foi cancelda.");
                                }
                            }
                        }
                    }

                }

            }
        }

        private void dataGridViewPedidosAdd_CellClick(object sender, DataGridViewCellEventArgs e) {
            atualizar2 = new ModelPedido();
            atualizar2 = controllerPedido.recuperarDadosDoItemPeloId(int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[0].Value.ToString()));
            idItemExcluir = int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[6].Value.ToString());

            btnExcluir.Enabled = true;


        }

        private void dataGridViewPedidosAdd_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void btnCancelar_Click(object sender, EventArgs e) {

            // Initializes the variables to pass to the MessageBox.Show method.
            string message = "Deseja cancelar este pedido? Impossível reverter";
            string caption = "Cancelar pedido?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes) {
                cancelarPedido();
            }

        }

        private void button3_Click(object sender, EventArgs e) {


            if (atualizar2.Item_status.Equals("escolha")) {
                MessageBox.Show("Selecione um item no grid");
            } else {
                try {
                    if (atualizar2.Item_status.Equals("Concluído")) {
                        MessageBox.Show("Este item já foi concluído.");

                    } else if (atualizar2.Item_status.Equals("Lançado")) {
                        MessageBox.Show("Você não pode concluir um item que não foi para a produção.");

                    } else if (atualizar2.Item_status.Equals("Rótulo Solicitado")) {

                        ModelLote dadosDoLote = new ModelLote();
                        ControllerLote controllerLote = new ControllerLote();

                        ModelRotulos dadosRotulo = new ModelRotulos();
                        ControllerRotulos controllerRotulos = new ControllerRotulos();
                        dadosRotulo = controllerRotulos.dadosDoRotuloPeloIdDoProduto(int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[0].Value.ToString()));

                        if (dadosRotulo.Rotulo_status.Equals("Concluído")) {

                            // Initializes the variables to pass to the MessageBox.Show method.
                            string message = "Marcar o item selecionado como concluído ?";
                            string caption = "Confirmação de conclusão";
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            DialogResult result;

                            // Displays the MessageBox.
                            result = MessageBox.Show(message, caption, buttons);
                            if (result == DialogResult.Yes) {
                                try {
                                    baixarEstoqueTransformarEmProduto(
                                    int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[5].Value.ToString()),
                                    int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[2].Value.ToString()),
                                    int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[3].Value.ToString()),
                                    int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[4].Value.ToString()),
                                    int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[5].Value.ToString()),
                                    dadosDoLote.Lote_numero
                                    );

                                } catch (Exception ee) {
                                    MessageBox.Show("Erro ao processar o estoque. Erro: " + ee.Message);
                                }
                            }
                        } else {
                            MessageBox.Show("Os rótulos estão em produção\n\nVerifique com o departamento responsável.");
                        }
                    } else {
                        MessageBox.Show("Aguardando liberação do lote.");
                    }
                } catch (NullReferenceException) {
                    MessageBox.Show("Selecione um item no grid");
                }
            }

            ControllerExpedicao controllerExpedicao1 = new ControllerExpedicao();

            if (controllerExpedicao1.checarItemParaConcluirExpedicao(idPedidoLista)) {
                //MessageBox.Show("Pedido em aberto");
                ControllerExpedicao controllerExpedicao = new ControllerExpedicao();
                ModelExpedicao modelExpedicao = new ModelExpedicao();
                modelExpedicao = controllerExpedicao.recuperarDadosDaExpedicaoPeloId(idPedidoLista);
                modelExpedicao.Expedicao_status = "Em produção";
                if (controllerExpedicao.atualizarClientesController(modelExpedicao)) {
                }
            } else {
                //MessageBox.Show("Pedido em aberto");
                ControllerExpedicao controllerExpedicao = new ControllerExpedicao();
                ModelExpedicao modelExpedicao = new ModelExpedicao();
                modelExpedicao = controllerExpedicao.recuperarDadosDaExpedicaoPeloId(idPedidoLista);
                modelExpedicao.Expedicao_status = "Concluído";
                if (controllerExpedicao.atualizarClientesController(modelExpedicao)) {
                    MessageBox.Show("Pedido concluído para envio, encaminhe o pedido para a expedição.");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) {

            ControllerLote controllerLote = new ControllerLote();
            ModelLote dadosDoLote = new ModelLote();

            if (atualizar2.Item_status.Equals("escolha")) {
                MessageBox.Show("Selecione um item no grid");
            } else {

                String finalMENOS1 = "-" + (int.Parse(DateTime.Now.AddDays(0).ToString("dd/MM/yyyy").Substring(8)) - 1);
                String final = "-" + (int.Parse(DateTime.Now.AddDays(0).ToString("dd/MM/yyyy").Substring(8)));
                String finalMAIS1 = "-" + (int.Parse(DateTime.Now.AddDays(0).ToString("dd/MM/yyyy").Substring(8)) + 1);
                String ultimoLote = controllerLote.retornarUltimoLote();
                int ultimoLoteValido = int.Parse(ultimoLote.Replace(finalMENOS1, "").Replace(final, "").Replace(finalMAIS1, ""));

                String novoLote = (ultimoLoteValido + 1).ToString() + final;

                if (dataGridViewPedidosAdd.CurrentRow.Cells[22].Value.ToString().Equals("Lançado")) {
                    dadosDoLote = controllerLote.verificarLoteSeAtendeADemanda(dataGridViewPedidosAdd.CurrentRow.Cells[13].Value.ToString(), "Concluído", "Aguardando", double.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[23].Value.ToString()));

                    if (dadosDoLote.Lote_id == 0) {
                        
                        // Initializes the variables to pass to the MessageBox.Show method.
                        string message = "Deseja utilizar o próximo lote "+ novoLote+ " gerado pelo sitema?";
                        string caption = "Próximo lote: "+ novoLote;
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result;

                        // Displays the MessageBox.
                        result = MessageBox.Show(message, caption, buttons);
                        if (result == DialogResult.No) {
                            novoLote = Interaction.InputBox("Informe o lote a ser produzido", "Informe o lote.", string.Empty, -1, -1).Replace(".", ",");
                        }

                        if (novoLote.Length < 1)
                        {
                            MessageBox.Show("Você não informou o lote");
                        } else
                        {
                            int tamanho = novoLote.Length-3;
                            String finalDoLote = novoLote.Substring(tamanho);

                            if (finalDoLote == finalMENOS1 || finalDoLote == final)
                            {

                                if (controllerLote.recuperarIdDoLote(novoLote)>0)
                                {
                                    MessageBox.Show("Este lote já existe, utilize a opção corrigir saldo em LOTES.");
                                }
                                else
                                {

                                    dadosDoLote.Lote_numero = novoLote;
                                    dadosDoLote.Lote_produto = dataGridViewPedidosAdd.CurrentRow.Cells[13].Value.ToString();
                                    dadosDoLote.Lote_fabricacao = DateTime.Now.AddDays(0).ToString("dd/MM/yyyy");
                                    dadosDoLote.Lote_validade = DateTime.Now.AddMonths(24).ToString("dd/MM/yyyy");
                                    dadosDoLote.Lote_litragem = -double.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[23].Value.ToString());
                                    dadosDoLote.Lote_litragemFeita = -double.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[23].Value.ToString());
                                    dadosDoLote.Lote_idAmostra = int.Parse(novoLote.Replace("-", "")) + 5 + 5 + 95 + 16 + 10 + 84;
                                    dadosDoLote.Lote_observacao = "Lote gerado pelo sistema";
                                    dadosDoLote.Lote_status = "Aguardando";
                                    controllerLote.salvarLoteController(dadosDoLote);
                                    solicitarLote(dadosDoLote, controllerLote);
                                }

                            } else
                            {
                                MessageBox.Show("Lote inválido, o lote deve ter o final como "+ finalMENOS1+" ou "+ final+". Ex: 0000"+ final);
                            }                            
                        }
                        
                    } else if (dadosDoLote.Lote_litragem >= double.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[23].Value.ToString())) {
                        solicitaRotulo(dadosDoLote, controllerLote);
                    } else if (dadosDoLote.Lote_id > 0) {
                        solicitarLote(dadosDoLote, controllerLote);
                    }

                } else if (dataGridViewPedidosAdd.CurrentRow.Cells[22].Value.ToString().Equals("Lote Solicitado")) {

                    dadosDoLote = controllerLote.verificarSeLoteLiberou(dataGridViewPedidosAdd.CurrentRow.Cells[13].Value.ToString(), "Concluído", "Aguardando", double.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[23].Value.ToString()));

                    if (dadosDoLote.Lote_id > 0) {
                        solicitaRotulo(dadosDoLote, controllerLote);
                    } else {
                        MessageBox.Show("Lote ainda não liberado.");
                    }

                } else if (dataGridViewPedidosAdd.CurrentRow.Cells[22].Value.ToString().Equals("Rótulo Solicitado")) {

                    MessageBox.Show("Ops!!! solicitação de rótulo já realizada.");

                } else if (dataGridViewPedidosAdd.CurrentRow.Cells[22].Value.ToString().Equals("Item concluído")) {

                    MessageBox.Show("Ops!!! este item já foi concluído");

                }
            }
            controllerLote.concluirLoteZerado();
        }

        private void textBoxObservacao_TextChanged(object sender, EventArgs e) {

        }

        private void textBoxGuia_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                ControllerUsuarios controllerUsuarios = new ControllerUsuarios();
                String setor = controllerUsuarios.recuperarSetorDoUsuario(idUsuario);
                if (quemPode.Equals(setor) || setor.Equals("Desenvolvimento")) {
                    try {
                        if (DateTime.Parse(textBoxPrevisaoDeEntrega.Text) > DateTime.Parse(textBoxDataAtual.Text)) {
                            try {
                                if (int.Parse(textBoxGuia.Text) > 0) {

                                    ModelPedidoLista listaDePedido = new ModelPedidoLista();
                                    ControllerPedidoLista controllerPedidoLista = new ControllerPedidoLista();
                                    listaDePedido = controllerPedidoLista.verificaIdExistente(int.Parse(textBoxGuia.Text));

                                    if (listaDePedido.Guia_id > 0) {

                                        if (listaDePedido.Situacao_pedido.Equals("Cancelado")) {
                                            MessageBox.Show("Este pedido foi cancelado dia " + listaDePedido.Pedido_dataEntrega + "\n\nMotivo: " + listaDePedido.Observacao);
                                        } else {
                                            idPedidoLista = int.Parse(textBoxGuia.Text);
                                            cliente = verificarCliente.recuperarClientePeloId(listaDePedido.Cliente_id);
                                            ultimoIdSalvo = modelPedidoLista.verificarPedidoEmAberto(int.Parse(textBoxGuia.Text));

                                            idPedidoLista = listaDePedido.Guia_id;
                                            comboBoxCliente.Text = cliente.Clientes_nome;
                                            textBoxPrevisaoDeEntrega.Text = listaDePedido.Pedido_dataEntrega;
                                            textBoxDataAtual.Text = listaDePedido.Pedido_dataCad;
                                            textBoxGuia.Text = listaDePedido.Guia_id.ToString();
                                            textBoxObservacao.Text = listaDePedido.Observacao;

                                            carrgarGridPedidos();
                                            //panelAddItens.Enabled = true;
                                            //panelDadosPedido.Enabled = false;

                                            btnCancelar.Enabled = true;
                                            btnExcluir.Enabled = true;
                                            button3.Enabled = true;
                                            button4.Enabled = true;
                                            buttonCancelarItem.Enabled = true;

                                            dataGridViewPedidosAdd.Enabled = true;
                                        }


                                    } else {
                                        idPedidoLista = int.Parse(textBoxGuia.Text);
                                        carrgarGridPedidos();
                                        //panelAddItens.Enabled = true;
                                        //panelDadosPedido.Enabled = false;
                                        btnCancelar.Enabled = true;
                                        btnExcluir.Enabled = true;
                                        button3.Enabled = true;
                                        button4.Enabled = true;
                                        buttonCancelarItem.Enabled = true;
                                        dataGridViewPedidosAdd.Enabled = true;
                                    }

                                } else {
                                    MessageBox.Show("Informe o número do pedido");
                                    textBoxGuia.Focus();
                                }
                            } catch (Exception) {
                                MessageBox.Show("Número do pedido inválido");
                                textBoxGuia.Focus();
                            }
                        } else {
                            MessageBox.Show("A data de entrega não pode ser anterior a data de cadastro.");
                        }
                    } catch (Exception) {
                        MessageBox.Show("Data de entrega inválida, revise os dados");
                        textBoxPrevisaoDeEntrega.Focus();
                    }
                } else {
                    MessageBox.Show("Você não tem permissão para executar esta função.\nContate o responsável pelo setor de " + quemPode);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e) {

            if (idPedidoLista < 1)
            {
                try
                {
                    Form f = new FormPedidoComIdGuia(int.Parse(Interaction.InputBox("Informe o númro do pedido", "Informe o pedido", string.Empty, -1, -1).Replace(".", ",")));
                    f.Show();
                }
                catch (Exception)
                {

                }
            }
            else
            {
                Form f = new FormPedidoComIdGuia(idPedidoLista);
                f.Show();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            if (atualizar2.Item_status.Equals("escolha"))
            {
                MessageBox.Show("Selecione um item no grid");
            }
            else
            {

                if (dataGridViewPedidosAdd.CurrentRow.Cells[22].Value.ToString().Equals("Item concluído"))
                {
                    MessageBox.Show("Este item já foi concluído.");
                }
                else
                {
                    ControllerLoteLaboratorio controllerLoteLaboratorio = new ControllerLoteLaboratorio();
                    ModelLoteLaboratorio modelLoteLaboratorio = new ModelLoteLaboratorio();
                    modelLoteLaboratorio = controllerLoteLaboratorio.recuperarUltimoLote();

                    ModelPedido itensDoPedido = new ModelPedido();
                    ControllerPedido controllerPedido = new ControllerPedido();
                    itensDoPedido = controllerPedido.recuperarDadosDoItemPeloId(int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[0].Value.ToString()));

                    String finalMENOS1 = "-" + (int.Parse(DateTime.Now.AddDays(0).ToString("dd/MM/yyyy").Substring(8)) - 1);
                    String final = "-" + (int.Parse(DateTime.Now.AddDays(0).ToString("dd/MM/yyyy").Substring(8)));
                    String finalMAIS1 = "-" + (int.Parse(DateTime.Now.AddDays(0).ToString("dd/MM/yyyy").Substring(8)) - 1);

                    String ultimoLote = modelLoteLaboratorio.Numero_lote.Replace("L", "");
                    int ultimoLoteValido = int.Parse(ultimoLote.Replace(finalMENOS1, "").Replace(final, "").Replace(finalMAIS1, ""));
                    String novoLote = "L" + (ultimoLoteValido + 1).ToString() + final;

                    itensDoPedido.Item_status = "Item concluído";
                    itensDoPedido.Pedido_loteUsado = novoLote;

                    modelLoteLaboratorio.Numero_lote = novoLote;
                    modelLoteLaboratorio.Data_lote = itensDoPedido.Pedido_dataCad;
                    modelLoteLaboratorio.Produto_lote = itensDoPedido.Nome_item;
                    modelLoteLaboratorio.Litragem_lote = itensDoPedido.Volume_litros;
                    modelLoteLaboratorio.Cliente_lote = itensDoPedido.Cliente_nome;

                    // Initializes the variables to pass to the MessageBox.Show method.
                    string message = "Finalizar item como lote de laboratório ?";
                    string caption = "Lote de laboratório Número " + novoLote;
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    // Displays the MessageBox.
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == DialogResult.Yes)
                    {
                        if (controllerLoteLaboratorio.salvarLoteDeLaboratorio(modelLoteLaboratorio))
                        {
                            if (controllerPedido.atualizarPedidoController(itensDoPedido))
                            {
                                baixarEstoqueTransformarEmProduto(
                                                int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[5].Value.ToString()),
                                                int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[2].Value.ToString()),
                                                int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[3].Value.ToString()),
                                                int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[4].Value.ToString()),
                                                int.Parse(dataGridViewPedidosAdd.CurrentRow.Cells[5].Value.ToString()),
                                                ""
                                                );
                            }
                            else
                            {
                                MessageBox.Show("Erro ao concluir este item, contate o suporte.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Erro ao concluir este item, contate o suporte.");
                        }
                    }
                }
            }
        }

        private void buttonItemConcluido_Click(object sender, EventArgs e)
        {

        }

        private void textBoxQtdadePorCaixa_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxQtdadePorCaixa.Text == "0")
            {
                quantidadePorCaixaSelected = int.Parse(textBoxQuantidade.Text);
                comboBoxCaixa.Text = "ITEM SEM CAIXA";
            }
        }
    }
}
