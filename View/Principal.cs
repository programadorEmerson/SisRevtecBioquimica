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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revtec_Bioquimica.View
{
    public partial class Principal : Form
    {
        int idUsuario;
        String empresa;
        ControllerLote controllerLote = new ControllerLote();         
        ControllerExpedicao controllerExpedicao = new ControllerExpedicao();         
        public Principal(String nomeUsuario, String nivel, int id, String setor, String usuarioEmpresa)
        {
            InitializeComponent();
            idUsuario = id;
            int atrsos = controllerExpedicao.verificarAtrsos();
            empresa = usuarioEmpresa;
            controllerLote.concluirLoteZerado();
            labelUsuarioLogado.Text = "Usuário Logado: "+nomeUsuario;
            labelTipoUsuário.Text = "Tipo de Usuário: " + setor;
            labelNivelDeAcesso.Text = "Nível de acesso: " + nivel;
            verificarRegistro();
            panel3.BackColor = Color.FromArgb(0, Color.Black);
            labelNivelDeAcesso.BackColor = Color.FromArgb(0, Color.Black);
            labelTipoUsuário.BackColor = Color.FromArgb(0, Color.Black);
            labelUsuarioLogado.BackColor = Color.FromArgb(0, Color.Black);

            if (atrsos > 0)
            {
                panelAtrasos.Visible = true;

                if (atrsos == 1)
                {
                    labelAtrasos.Text = "0"+atrsos.ToString() + " ATRASO";
                }else if (atrsos > 1 && atrsos < 10)
                {
                    labelAtrasos.Text = "0"+atrsos.ToString() + " ATRASOS";
                }else
                {
                    labelAtrasos.Text = atrsos.ToString() + " ATRASOS";
                }


            } else
            {
                panelAtrasos.Visible = false;
            }


        }

        private ChecarKey verificar(String usuario)
        {
            ChecarKey chaveUsuario = new ChecarKey();
            ControllerChecarKey controllerChecarKey = new ControllerChecarKey();
            try
            {
                chaveUsuario = controllerChecarKey.recuperarChave("Revtec Bioquímica");
            }
            catch (Exception)
            {
                
            }

            return chaveUsuario;
        }

        private void verificarRegistro()
        {
            Registro registro = new Registro();
            ControllerRegistro controllerRegistro = new ControllerRegistro();
            registro = controllerRegistro.verificarChaveDeRegistro();

            if (DateTime.Parse(DateTime.Now.AddDays(5).ToString().Substring(0, 10)).Equals(registro.Registro_dataExpira))
            {
                textBoxChave.Text = registro.Registro_serial;
                textBoxChave.Enabled = false;
                MessageBox.Show("Atenção, sua licença de uso se encerra em 5 dias.");
            }
            else if (DateTime.Parse(DateTime.Now.AddDays(4).ToString().Substring(0, 10)).Equals(registro.Registro_dataExpira))
            {
                textBoxChave.Text = registro.Registro_serial;
                textBoxChave.Enabled = false;
                MessageBox.Show("Atenção, sua licença de uso se encerra em 4 dias.");
            }
            else if (DateTime.Parse(DateTime.Now.AddDays(3).ToString().Substring(0, 10)).Equals(registro.Registro_dataExpira))
            {
                textBoxChave.Text = registro.Registro_serial;
                textBoxChave.Enabled = false;
                MessageBox.Show("Atenção, sua licença de uso se encerra em 3 dias.");
            }
            else if (DateTime.Parse(DateTime.Now.AddDays(2).ToString().Substring(0, 10)).Equals(registro.Registro_dataExpira))
            {
                textBoxChave.Text = registro.Registro_serial;
                textBoxChave.Enabled = false;
                MessageBox.Show("Atenção, sua licença de uso se encerra em 2 dias.");
            }
            else if (DateTime.Parse(DateTime.Now.AddDays(1).ToString().Substring(0, 10)).Equals(registro.Registro_dataExpira))
            {
                textBoxChave.Text = registro.Registro_serial;
                textBoxChave.Enabled = false;
                MessageBox.Show("Atenção, sua licença de uso se encerra em 1 dia.");
            }
            else if (DateTime.Parse(DateTime.Now.AddDays(0).ToString().Substring(0, 10)).Equals(registro.Registro_dataExpira))
            {
                textBoxChave.Text = registro.Registro_serial;
                textBoxChave.Enabled = false;
                MessageBox.Show("Atenção, sua licença de uso se encerra hoje.");
            }
            else if (DateTime.Parse(DateTime.Now.ToString().Substring(0, 10)) > registro.Registro_dataExpira)
            {
                ControllerChecarKey controllerChecarKey = new ControllerChecarKey();
                ChecarKey checarKey = new ChecarKey();
                checarKey = controllerChecarKey.recuperarChave(empresa);

                if (DateTime.Parse(DateTime.Now.ToString().Substring(0, 10)) > checarKey.Cliente_dataExpira)
                {
                    btnUsuario.Enabled = false;
                    btnCliente.Enabled = false;
                    btnFornecedor.Enabled = false;
                    btnProduto.Enabled = false;
                    btnLote.Enabled = false;
                    btnPedido.Enabled = false;
                    btnEstoque.Enabled = false;
                    btnRotulos.Enabled = false;
                    btnExpedicao.Enabled = false;
                    btnRelatorios.Enabled = false;
                    textBoxChave.Text = registro.Registro_serial;
                    textBoxChave.Enabled = true;
                    MessageBox.Show("Sua licença de uso venceu, contate o suporte. (19) 9.8230-2626");
                } else
                {
                    registro.Registro_id = checarKey.Cliente_id;
                    registro.Registro_serial = checarKey.Cliente_serial;
                    registro.Registro_dataRegistro = checarKey.Cliente_dataCadastro;
                    registro.Registro_dataExpira = checarKey.Cliente_dataExpira;
                    controllerRegistro.atualizarChave(registro);

                    textBoxChave.Text = checarKey.Cliente_serial;
                    textBoxChave.Enabled = false;

                    MessageBox.Show("Sua chave foi atualizada automaticamente on-line, obrigado.");
                }


                
            }
            else
            {
                textBoxChave.Text = registro.Registro_serial;
                textBoxChave.Enabled = false;
            }

        }


        private void button4_Click(object sender, EventArgs e)
        {           
            Form f = new Emerson(idUsuario);
            f.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Form f = new Usuarios(idUsuario);
            f.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Form f = new Clientes(idUsuario);
            f.Show();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            Form f = new Fornecedor(idUsuario);
            f.Show();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            Form f = new Pedidos(-1,idUsuario);
            f.Show();
        }

        private void btnLote_Click(object sender, EventArgs e) {
            Form f = new Lotes(idUsuario);
            f.Show();
        }

        private void btnRotulos_Click(object sender, EventArgs e) {
            Form f = new Rotulos(idUsuario);
            f.Show();
        }

        private void btnEstoque_Click(object sender, EventArgs e) {
            Form f = new Estoque(idUsuario);
            f.Show();
        }

        private void btnExpedicao_Click(object sender, EventArgs e) {
            Form f = new Expedição(idUsuario, "Todos");
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void btnOrdemProducao_Click(object sender, EventArgs e) {

        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e) {

        }

        private void btnRelatorios_Click(object sender, EventArgs e) {
            Form f = new FormSelecaoDeRelatorio(idUsuario);
            f.Show();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
              
        }

        private void criptografiaDeChave (String chave)
        {
            String valor = "";

            String rplc0 = "E";
            String rplc1 = "M";
            String rplc2 = "R";
            String rplc3 = "S";
            String rplc4 = "O";
            String rplc5 = "N";
            String rplc6 = "A";
            String rplc7 = "T";
            String rplc8 = "U";
            String rplc9 = "I";

            if ("".Equals("gerar"))
            {
                String valorChave = DateTime.Now.AddDays(0).ToString().Substring(0, 10);
                String diaEmerson = "16" + valorChave.Substring(0, 2) + "61";
                String mesEmerson = "10" + valorChave.Substring(3, 2) + "01";
                String anoEmerson = "8" + valorChave.Substring(6, 4) + "4";
                String chaveNumerica = diaEmerson + "-" + mesEmerson + "-" + anoEmerson;
                String chaveLetras = chaveNumerica
                    .Replace("0", rplc0)
                    .Replace("1", rplc1)
                    .Replace("2", rplc2)
                    .Replace("3", rplc3)
                    .Replace("4", rplc4)
                    .Replace("5", rplc5)
                    .Replace("6", rplc6)
                    .Replace("7", rplc7)
                    .Replace("8", rplc8)
                    .Replace("9", rplc9);
                valor = chaveLetras;
            } else
            {
                String chaveDataDia = chave.Substring(2, 2);
                String chaveDataMes = chave.Substring(9, 2);
                String chaveDataAno = chave.Substring(15, 4);
                String chaveData = chaveDataDia + "/" + chaveDataMes + "/" + chaveDataAno;
                String chaveQuebrada = chaveData
                    .Replace(rplc0, "0")
                    .Replace(rplc1, "1")
                    .Replace(rplc2, "2")
                    .Replace(rplc3, "3")
                    .Replace(rplc4, "4")
                    .Replace(rplc5, "5")
                    .Replace(rplc6, "6")
                    .Replace(rplc7, "7")
                    .Replace(rplc8, "8")
                    .Replace(rplc9, "9");
                try
                {
                    if (DateTime.Parse(DateTime.Now.AddDays(0).ToString().Substring(0, 10)) > DateTime.Parse(chaveQuebrada))
                    {
                        MessageBox.Show("a chave "+chave+" não é válida");
                    }
                    else
                    {
                        ChecarKey dadosAtivacao = new ChecarKey();
                        dadosAtivacao = verificar(empresa);

                        dadosAtivacao.Cliente_dataExpira = DateTime.Parse(chaveQuebrada);
                        dadosAtivacao.Cliente_serial = chave;

                        ControllerChecarKey controllerChecarKey = new ControllerChecarKey();

                        if (controllerChecarKey.atualizarChaveController(dadosAtivacao))
                        {

                            Registro registro = new Registro();
                            ControllerRegistro controllerRegistro = new ControllerRegistro();

                            registro.Registro_id = dadosAtivacao.Cliente_id;
                            registro.Registro_serial = dadosAtivacao.Cliente_serial;
                            registro.Registro_dataRegistro = dadosAtivacao.Cliente_dataCadastro;
                            registro.Registro_dataExpira = dadosAtivacao.Cliente_dataExpira;
                            controllerRegistro.atualizarChave(registro);

                            verificarRegistro();
                            btnUsuario.Enabled = true;
                            btnCliente.Enabled = true;
                            btnFornecedor.Enabled = true;
                            btnProduto.Enabled = true;
                            btnLote.Enabled = true;
                            btnPedido.Enabled = true;
                            btnEstoque.Enabled = true;
                            btnRotulos.Enabled = true;
                            btnExpedicao.Enabled = true;
                            btnRelatorios.Enabled = true;
                            textBoxChave.Enabled = false;
                            MessageBox.Show("Chave atualzada com sucesso.");
                        } else
                        {
                            MessageBox.Show("Erro ao atualizar a chave, contate o suporte (19) 9.8230-2626");
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Esta chave não é válida.");
                }
            }
        }

        private void textBoxChave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                criptografiaDeChave(textBoxChave.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Acessar suporte via chat pelo WhatsApp?", "WhatsApp suporte (19)9.8457-2020.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {
                System.Diagnostics.Process.Start("https://bityli.com/6S8e6");
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult confirm = MessageBox.Show("Acessar site www.programandosolucoes.com ?", "Deseja Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {
                System.Diagnostics.Process.Start("https://programandosolucoes.com/");
            }

                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new Expedição(idUsuario, "Atrazada");
            f.Show();
        }
    }
}
