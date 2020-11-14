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
    class ModelClientes : ControllerClientes
    {
        private int clientes_id;
        private String clientes_nome;
        private String clientes_cidade;
        private String clientes_observacao;


        public int Clientes_id
        {
            get { return clientes_id; }
            set { clientes_id = value; }
        }

        public String Clientes_nome
        {
            get { return clientes_nome; }
            set { clientes_nome = value; }
        }

        public String Clientes_cidade
        {
            get { return clientes_cidade; }
            set { clientes_cidade = value; }
        }

        public String Clientes_observacao
        {
            get { return clientes_observacao; }
            set { clientes_observacao = value; }
        }
    }
}
