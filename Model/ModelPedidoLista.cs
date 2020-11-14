using Revtec_Bioquimica.Controller;
using System;

namespace Revtec_Bioquimica.Model
{
    class ModelPedidoLista : ControllerPedidoLista
    {
        private int pedido_id;
        private int guia_id;
        private int cliente_id;
        private String nome_cliente;
        private String pedido_dataCad;
        private String pedido_dataEntrega; 
        private String pedido_status;
        private String situacao_pedido;
        private String observacao;

        public int Pedido_id
        {
            get { return pedido_id; }
            set { pedido_id = value; }
        }

        public int Guia_id {
            get { return guia_id; }
            set { guia_id = value; }
        }

        public int Cliente_id {
            get { return cliente_id; }
            set { cliente_id = value; }
        }

        public String Nome_cliente {
            get { return nome_cliente; }
            set { nome_cliente = value; }
        }
        public String Pedido_dataCad {
            get { return pedido_dataCad; }
            set { pedido_dataCad = value; }
        }
        public String Pedido_dataEntrega {
            get { return pedido_dataEntrega; }
            set { pedido_dataEntrega = value; }
        }
        public String Pedido_status {
            get { return pedido_status; }
            set { pedido_status = value; }
        }        
        
        public String Situacao_pedido {
            get { return situacao_pedido; }
            set { situacao_pedido = value; }
        }        
        
        public String Observacao {
            get { return observacao; }
            set { observacao = value; }
        }

    }
}
