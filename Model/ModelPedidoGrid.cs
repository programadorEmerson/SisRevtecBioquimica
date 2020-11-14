using MySql.Data.MySqlClient;
using Revtec_Bioquimica.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revtec_Bioquimica.Model
{
    class ModelPedidoGrid //: ControllerPedido
    {

        private int pedido_idPedido;
        private int pedido_idCliente;
        private String pedido_dataCadastro;
        private String pedido_dataEntrega;
        private int pedido_idPedidoEma;
        private String pedido_observacoes;
        private String pedido_status;

        public int Pedido_idPedido {
            get { return pedido_idPedido; }
            set { pedido_idPedido = value; }
        }

        public int Pedido_idCliente {
            get { return pedido_idCliente; }
            set { pedido_idCliente = value; }
        }

        public String Pedido_dataCadastro {
            get { return pedido_dataCadastro; }
            set { pedido_dataCadastro = value; }
        }

        public String Pedido_dataEntrega {
            get { return pedido_dataEntrega; }
            set { pedido_dataEntrega = value; }
        }

        public int Pedido_idPedidoEma {
            get { return pedido_idPedidoEma; }
            set { pedido_idPedidoEma = value; }
        }

        public String Pedido_observacoes {
            get { return pedido_observacoes; }
            set { pedido_observacoes = value; }
        }

        public String Pedido_status {
            get { return pedido_status; }
            set { pedido_status = value; }
        }

    }
}
