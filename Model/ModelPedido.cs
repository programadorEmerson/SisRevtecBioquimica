using MySql.Data.MySqlClient;
using Revtec_Bioquimica.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revtec_Bioquimica.Model {
    class ModelPedido : ControllerPedido {
        private String nome_item;

        private int pedido_id;
        private int cliente_id;
        private int frasco_id;
        private int caixa_id;
        private int tampa_id;
        private int produto_id;

        private int guia_id;
        private String pedido_dataCad;
        private String pedido_dataEntrega;
        private String pedido_observacao;
        private String litragem_escrita;
        private double pedido_litragem;
        private int pedido_quantidade;

        private double caixa_peso;
        private double tampa_peso;
        private double frasco_peso;
        private double produto_peso;
        private String quantidade_caixa;

        private double peso_unidade;
        private double peso_caixa;
        private double peso_total;
        private String item_status;
        private String pedido_loteUsado;
        private double volume_litros;

        private double cubagem_unidade;
        private double cubagem_total;

        private int quantidade_int;
        private String cliente_nome;

        public String Nome_item {
            get { return nome_item; }
            set { nome_item = value; }
        }

        public int Pedido_quantidade {
            get { return pedido_quantidade; }
            set { pedido_quantidade = value; }
        }

        public String Litragem_escrita {
            get { return litragem_escrita; }
            set { litragem_escrita = value; }
        }

        public String Quantidade_caixa {
            get { return quantidade_caixa; }
            set { quantidade_caixa = value; }
        }

        public double Peso_unidade {
            get { return peso_unidade; }
            set { peso_unidade = value; }
        }
        public double Peso_caixa {
            get { return peso_caixa; }
            set { peso_caixa = value; }

        }
        public double Peso_total {
            get { return peso_total; }
            set { peso_total = value; }
        }
        public String Item_status {
            get { return item_status; }
            set { item_status = value; }
        }

        public double Pedido_litragem {
            get { return pedido_litragem; }
            set { pedido_litragem = value; }
        }


        public int Produto_id {
            get { return produto_id; }
            set { produto_id = value; }
        }

        public double Caixa_peso {
            get { return caixa_peso; }
            set { caixa_peso = value; }
        }

        public double Tampa_peso {
            get { return tampa_peso; }
            set { tampa_peso = value; }
        }

        public double Frasco_peso {
            get { return frasco_peso; }
            set { frasco_peso = value; }
        }

        public double Produto_peso {
            get { return produto_peso; }
            set { produto_peso = value; }
        }
        public double Volume_litros {
            get { return volume_litros; }
            set { volume_litros = value; }
        }

        public double Cubagem_unidade {
            get { return cubagem_unidade; }
            set { cubagem_unidade = value; }
        }

        public double Cubagem_total {
            get { return cubagem_total; }
            set { cubagem_total = value; }
        }

        public int Pedido_id {
            get { return pedido_id; }
            set { pedido_id = value; }
        }

        public int Caixa_id {
            get { return caixa_id; }
            set { caixa_id = value; }
        }

        public int Tampa_id {
            get { return tampa_id; }
            set { tampa_id = value; }
        }

        public int Frasco_id {
            get { return frasco_id; }
            set { frasco_id = value; }
        }

        public String Pedido_observacao {
            get { return pedido_observacao; }
            set { pedido_observacao = value; }
        }

        public String Pedido_dataEntrega {
            get { return pedido_dataEntrega; }
            set { pedido_dataEntrega = value; }
        }

        public int Guia_id {
            get { return guia_id; }
            set { guia_id = value; }
        }

        public String Pedido_dataCad {
            get { return pedido_dataCad; }
            set { pedido_dataCad = value; }
        }

        public String Pedido_loteUsado {
            get { return pedido_loteUsado; }
            set { pedido_loteUsado = value; }
        }

        public int Cliente_id {
            get { return cliente_id; }
            set { cliente_id = value; }
        }

        public int Quantidade_int {
            get { return quantidade_int; }
            set { quantidade_int = value; }
        }

        public String Cliente_nome {
            get { return cliente_nome; }
            set { cliente_nome = value; }
        }




    }
}
